/****** Object:  StoredProcedure [dbo].[sp_Weighing_AutoOutput]    Script Date: 07/27/2012 13:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--称料时自动出仓
ALTER PROCEDURE [dbo].[sp_Weighing_AutoOutput]
(@lcdanhao varchar(20),  -- 领料单号
 @lidxno int,           -- 该领料单的唯一序号
 @lclman varchar(10),    -- 称料人
 @lcbanci varchar(10),    -- 班次
 @lckname varchar(10),   -- 染料仓库
 @lnumber decimal(18,6)  -- 单位：kg
)
AS
--获取仓库编号
select @lckname=strStorehouseCode from WeightStuffInfo where strWeightStuff=@lckname
--获取班别
SELECT @lcbanci=strShiftName FROM Employee WHERE strName=@lclman
--获取料单类型,部门
DECLARE @drawclass NVARCHAR(50),@organization NVARCHAR(50)
SELECT @drawclass=strPrintBillClass,@organization=strDrawOrganization FROM DyeStuffPrintBill WHERE strDyeStuffPrintBillCode=@lcdanhao

--判断领料单号是否存在
DECLARE @outputbillcode VARCHAR(50)
SELECT @outputbillcode=strDyeStuffOutputBillCode FROM DyeStuffOutputBill WHERE strDyeStuffDrawBillCode=@lcdanhao
IF @outputbillcode IS NULL OR @outputbillcode=''
BEGIN
	DECLARE @bename VARCHAR(50)
	SET @bename='BEDyeStuffOutputBill'
	exec TF_GetNewCode_HasOutput @bename,3,@outputbillcode OUTPUT
	SET @outputbillcode = 'LL' + @outputbillcode
	
	insert into DyeStuffOutputBill(strDyeStuffOutputBillCode, strDyeStuffDrawBillCode, dtOutputDateTime, strClerk,strWeighter, 
      strOutStorehouseCode, strInStorehouseCode, strMemo, strProviderName, strDrawer, 
      strInOutStorehouseClassName, dtDrawDateTime, strDrawOrganization, strRecorder, 
      dtRecordDateTime, strExistStatus,strShiftName,strDrawClass)
    values(@outputbillcode,@lcdanhao,getdate(),'',@lclman,@lckname,@lckname,'称料自动出仓','',@lclman,'领料出库',getdate(),@organization,@lclman,getdate(),'',@lcbanci,@drawclass)
END

--------------------------------------------------------------------------------------------------------------------------------------------
DECLARE @dyestuffcode VARCHAR(50),@dyestuffname VARCHAR(50),@billCount FLOAT
SELECT @dyestuffcode=strDyeStuffCode,@dyestuffname=strDyeStuffName,@billCount= (CASE WHEN strUnit='g' THEN fCount/1000 ELSE fCount ENd)
	FROM DyeStuffPrintBillDetail WHERE strDyeStuffPrintBillCode=@lcdanhao AND uiPrintIndex=@lidxno

--保存出仓单明细
INSERT INTO DyeStuffOutputBillDetail(strDyeStuffOutputBillCode, strDyeStuffCode, strDyeStuffName, fOutputCount, strCountUnit, fFeePrice, 
		strPriceUnit, fSum, strSumUnit,strExistStatus, bIsSettled, strDyeStuffOutputDetailCode, dtOutputDateTime,fBillCount)
    VALUES( @outputbillcode,@dyestuffcode,@dyestuffname,@lnumber,'Kg',0,'',0,'','',0,NEWID(),GETDATE(),@billCount )
    	   	
--更新库存
UPDATE DyeStuffCurrentStocks SET fOutputCount = fOutputCount + @lnumber
    WHERE strStorehouseCode = @lckname and strDyeStuffCode = @dyestuffcode
IF(@@ROWCOUNT = 0)
	INSERT INTO DyeStuffCurrentStocks
  		(strStorehouseCode, strDyeStuffCode, strDyeStuffName, strBatchNumber, 
		fInputCount, fInputSum, fOutputCount, fOutputSum, fBalanceCount, fBalanceSum)
    	VALUES(@lckname, @dyestuffcode, ISNULL(@dyestuffname,''), '', 
	     0, 0, @lnumber, 0, 0, 0)
--------------------------------------------------------------------------------------------------------------------------------------------
     
--此称料单中类别为"其他类别"的助剂自动出仓
WHILE EXISTS(SELECT * FROM DyeStuffPrintBillDetail a 
					INNER JOIN DyeStuff c ON a.strDyeStuffCode=c.strDyeStuffCode
			WHERE a.strDyeStuffPrintBillCode=@lcdanhao AND a.bIsDrawn=0 AND c.strClass='助剂' AND c.strSubClass='其他类别')
BEGIN
	SELECT TOP 1 @dyestuffcode=a.strDyeStuffCode,@dyestuffname=a.strDyeStuffName,@billCount=fCount,@lidxno=a.uiPrintIndex,@lnumber=CASE WHEN a.strUnit='kg' THEN fCount ELSE fCount/1000 END 
		FROM DyeStuffPrintBillDetail a 
			INNER JOIN DyeStuff c ON a.strDyeStuffCode=c.strDyeStuffCode
			WHERE a.strDyeStuffPrintBillCode=@lcdanhao AND a.bIsDrawn=0 AND c.strClass='助剂' AND c.strSubClass='其他类别'
	--保存出仓单明细
	INSERT INTO DyeStuffOutputBillDetail(strDyeStuffOutputBillCode, strDyeStuffCode, strDyeStuffName, fOutputCount, strCountUnit, fFeePrice, 
			strPriceUnit, fSum, strSumUnit,strExistStatus, bIsSettled, strDyeStuffOutputDetailCode, dtOutputDateTime,fBillCount)
	    VALUES( @outputbillcode,@dyestuffcode,@dyestuffname,@lnumber,'Kg',0,'',0,'','',0,NEWID(),GETDATE(),@billCount )
    	   	
	--更新库存
	UPDATE DyeStuffCurrentStocks SET fOutputCount = fOutputCount + @lnumber
	    WHERE strStorehouseCode = @lckname and strDyeStuffCode = @dyestuffcode
	IF(@@ROWCOUNT = 0)
		INSERT INTO DyeStuffCurrentStocks
	  		(strStorehouseCode, strDyeStuffCode, strDyeStuffName, strBatchNumber, 
			fInputCount, fInputSum, fOutputCount, fOutputSum, fBalanceCount, fBalanceSum)
	    	VALUES(@lckname, @dyestuffcode, ISNULL(@dyestuffname,''), '', 
		     0, 0, @lnumber, 0, 0, 0)
	UPDATE DyeStuffPrintBillDetail SET bIsDrawn=1,dtWeightTime=GETDATE(),fWeightCount=fCount WHERE uiPrintIndex=@lidxno
END

--若全部称料完毕,更新主表的称料标记
IF NOT EXISTS(SELECT * FROM DyeStuffPrintBillDetail WHERE strDyeStuffPrintBillCode=@lcdanhao AND bIsDrawn=0)
	UPDATE DyeStuffPrintBill SET bIsDrawn=1 WHERE strDyeStuffPrintBillCode=@lcdanhao

