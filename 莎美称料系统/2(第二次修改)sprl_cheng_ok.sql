/****** Object:  StoredProcedure [dbo].[sprl_cheng_ok]    Script Date: 07/30/2012 10:33:28 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sprl_cheng_ok]
(@lcdanhao varchar(20),  -- 领料单号
 @lidxno int,                       -- 该领料单的唯一序号
 @lccode varchar(10),     -- 染料编号
 @lcname varchar(30),    -- 染料名称
 @lnumber decimal(10,6),  --实际称料值，单位：kg
 @lclman varchar(10),   -- 称料人
 @lckname varchar(10)   -- 称料仓库
)AS

set nocount on
declare @strday   char(10),   @strtime char(10)
declare @strriqi varchar(20),@strbanci varchar(10)

select @strday  = CONVERT(CHAR(10),GETDATE(),111)
select @strtime = CONVERT(CHAR(10),GETDATE(),108)
select @strriqi  = @strday +' ' + @strtime      ------ yyyy/mm/dd hh:mm
------------------------------------------------------------------------------------------------
select @strbanci=cnote from dbfemp where cname=@lclman

-----------------------------------------------------------------------------------
insert into 称料表(danhao,idxno,ccode,cname,cnumber,clman,ckname,ctime,banci)
values(@lcdanhao,@lidxno,@lccode,@lcname,@lnumber,@lclman,@lckname,getdate(),@strbanci)
----------------------------------------------------------------------------------------------------------------------------
-- 只有正数才可以保存更新，负数为非法操作的无效数据
----------------------------------------------------------------------------------------------------------------------------
if @lnumber > 0
    begin
        update dbflloutput 
               set ckname = @lckname,okpsw ='Y', banci=@strbanci  
               where danhao = @lcdanhao
        Update dbflloutputmx
               set clpsw = 'Y',okpsw = 'Y',clman = @lclman,cltime = @strriqi,clban = @strbanci,
                   cnumber = cnumber + @lnumber
               Where idxid = @lidxno
--------------------------------------------------------------------------------------------------------
-- 未称完的可以继续称, 0.1kg
-------------------------------------------------------------------------
    Update dbflloutputmx
               set clpsw = 'N',okpsw = 'N'
               Where idxid = @lidxno AND nnumber - 0.1 > cnumber
------------------------------------------------------------------------------------------------------------
-- 更新TFERP 数据
-----------------------------------------------------------------------------
declare @lidxid int
select @lidxid = dhkey from dbflloutputmx where idxid = @lidxno

Update tferp_sm..DyeStuffPrintBillDetail
   set bIsDrawn = 1,
       fWeightCount = fWeightCount + case when strUnit='g' then @lnumber*1000 else @lnumber end,dtWeightTime = getdate(),
       bIsInvalid = 0,strWeighSystemCode=@lckname,strWeighter=@lclman
   Where uiPrintIndex = @lidxid

-- select @lnumber=case when strUnit='g' then fWeightCount/1000 else fWeightCount end from tferp_sm..DyeStuffPrintBillDetail where uiPrintIndex = @lidxid
 
 exec tferp_sm..sp_Weighing_AutoOutput @lcdanhao, @lidxid, @lclman, '', @lckname, @lnumber
------------------------------------------------------------------------------------------
end
set nocount off