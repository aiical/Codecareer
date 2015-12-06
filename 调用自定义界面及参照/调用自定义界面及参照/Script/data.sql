--开始导出ZH-CN_UAP_VoucherLayout:
DELETE FROM [UAP_VoucherLayout] WHERE  LayoutID=N'SaleVouche_0012_L01' AND  localid=N'ZH-CN' 
INSERT INTO [UAP_VoucherLayout] (CardNumber,LayoutID,LayoutName,localid )  Values (N'SaleVouche_0012',N'SaleVouche_0012_L01',N'默认布局',N'ZH-CN' ) 
GO
--ZH-CN_UAP_VoucherLayout导出结束。

--开始导出ZH-CN_AA_BusObject_base:
IF NOT EXISTS (SELECT 1 FROM AA_BusObject_base WHERE cBusObId=N'SaleVouche_0012' AND iAuthType='1' AND langid=N'ZH-CN' )
INSERT INTO AA_BusObject_base (cBusObId,cBusObName,iAuthType,bAuthControl,cSub_Id,cMark,iFuncType,langid,iOrder,bLocked,cLockedBy,bNoAuth) Values (N'SaleVouche_0012',N'版辊档案示例列表','1','0',N'SA',NULL,'2',N'ZH-CN',NULL,NULL,NULL,'0')
ELSE
UPDATE AA_BusObject_base SET cBusObId=N'SaleVouche_0012',cBusObName=N'版辊档案示例列表',iAuthType='1',cSub_Id=N'SA',cMark=NULL,iFuncType='2',langid=N'ZH-CN',iOrder=NULL,bLocked=NULL,cLockedBy=NULL,bNoAuth=0 WHERE  cBusObId=N'SaleVouche_0012' AND iAuthType='1' AND langid=N'ZH-CN' 
GO
IF NOT EXISTS (SELECT 1 FROM AA_BusObject_base WHERE cBusObId=N'SaleVouche_0012{##}Form' AND iAuthType='1' AND langid=N'ZH-CN' )
INSERT INTO AA_BusObject_base (cBusObId,cBusObName,iAuthType,bAuthControl,cSub_Id,cMark,iFuncType,langid,iOrder,bLocked,cLockedBy,bNoAuth) Values (N'SaleVouche_0012{##}Form',N'版辊档案示例','1','0',N'SA',NULL,'2',N'ZH-CN',NULL,NULL,NULL,'0')
ELSE
UPDATE AA_BusObject_base SET cBusObId=N'SaleVouche_0012{##}Form',cBusObName=N'版辊档案示例',iAuthType='1',cSub_Id=N'SA',cMark=NULL,iFuncType='2',langid=N'ZH-CN',iOrder=NULL,bLocked=NULL,cLockedBy=NULL,bNoAuth=0 WHERE  cBusObId=N'SaleVouche_0012{##}Form' AND iAuthType='1' AND langid=N'ZH-CN' 
GO
--ZH-CN_AA_BusObject_base导出结束。

--开始导出ZH-CN_vouchers_lang:
DELETE FROM [vouchers_lang] WHERE  cardnumber='SaleVouche_0012' AND  Localeid=N'ZH-CN' 
INSERT INTO [vouchers_lang] (cardnumber,localeid,ccardname,appname )  Values ('SaleVouche_0012',N'ZH-CN',N'版辊档案示例',N'销售管理' ) 
GO
--ZH-CN_vouchers_lang导出结束。

--开始导出ZH-CN_AA_Enum:
DELETE FROM [AA_Enum] WHERE  EnumType=N'30490524-1187-45d6-93ac-8c50765cc16d' AND  LocaleId=N'ZH-CN' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'30490524-1187-45d6-93ac-8c50765cc16d',N'A001',N'ZH-CN',N'销售类型－普通','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'30490524-1187-45d6-93ac-8c50765cc16d' AND  LocaleId=N'ZH-CN' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'30490524-1187-45d6-93ac-8c50765cc16d',N'A002',N'ZH-CN',N'销售类型－分销','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'62d375aa-e328-4e4a-bccd-2b0eb43a5757' AND  LocaleId=N'ZH-CN' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'62d375aa-e328-4e4a-bccd-2b0eb43a5757',N'0',N'ZH-CN',N'停用','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'62d375aa-e328-4e4a-bccd-2b0eb43a5757' AND  LocaleId=N'ZH-CN' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'62d375aa-e328-4e4a-bccd-2b0eb43a5757',N'1',N'ZH-CN',N'启用','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'62d375aa-e328-4e4a-bccd-2b0eb43a5757' AND  LocaleId=N'ZH-CN' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'62d375aa-e328-4e4a-bccd-2b0eb43a5757','',N'ZH-CN','','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'ZH-CN' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'0',N'ZH-CN',N'受订','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'ZH-CN' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'1',N'ZH-CN',N'审核','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'ZH-CN' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'2',N'ZH-CN',N'出货','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'ZH-CN' AND  EnumIndex='3' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'3',N'ZH-CN',N'关闭','3',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'ZH-CN' AND  EnumIndex='4' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'4',N'ZH-CN',N'锁定','4',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-CN' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2007',N'ZH-CN',N'2007','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-CN' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2008',N'ZH-CN',N'2008','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-CN' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2009',N'ZH-CN',N'2009','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-CN' AND  EnumIndex='3' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2010',N'ZH-CN',N'2010','3',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-CN' AND  EnumIndex='4' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2011',N'ZH-CN',N'2011','4',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-CN' AND  EnumIndex='5' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2012',N'ZH-CN',N'2012','5',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'1',N'ZH-CN',N'1','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'2',N'ZH-CN',N'2','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'3',N'ZH-CN',N'3','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='3' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'4',N'ZH-CN',N'4','3',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='4' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'5',N'ZH-CN',N'5','4',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='5' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'6',N'ZH-CN',N'6','5',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='6' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'7',N'ZH-CN',N'7','6',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='7' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'8',N'ZH-CN',N'8','7',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='8' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'9',N'ZH-CN',N'9','8',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='9' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'10',N'ZH-CN',N'10','9',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='10' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'11',N'ZH-CN',N'11','10',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-CN' AND  EnumIndex='11' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'12',N'ZH-CN',N'12','11',N'SaleVouche' ) 
GO
--ZH-CN_AA_Enum导出结束。

--开始导出ZH-CN_UFMenu_Business_Lang:
DELETE FROM [UFMenu_Business_Lang] WHERE  MenuId=N'SAEFSaleVouche_0012' AND  localeId=N'ZH-CN' 
INSERT INTO [UFMenu_Business_Lang] (MenuId,Caption,LocaleId )  Values (N'SAEFSaleVouche_0012',N'版辊档案示例',N'ZH-CN' ) 
GO
DELETE FROM [UFMenu_Business_Lang] WHERE  MenuId=N'SAEFSaleVouche_0012List' AND  localeId=N'ZH-CN' 
INSERT INTO [UFMenu_Business_Lang] (MenuId,Caption,LocaleId )  Values (N'SAEFSaleVouche_0012List',N'版辊档案示例列表',N'ZH-CN' ) 
GO
--ZH-CN_UFMenu_Business_Lang导出结束。

--开始导出ZH-TW_UAP_VoucherLayout:
DELETE FROM [UAP_VoucherLayout] WHERE  LayoutID=N'SaleVouche_0012_L01' AND  localid=N'ZH-TW' 
INSERT INTO [UAP_VoucherLayout] (CardNumber,LayoutID,LayoutName,localid )  Values (N'SaleVouche_0012',N'SaleVouche_0012_L01',N'默认布局',N'ZH-TW' ) 
GO
--ZH-TW_UAP_VoucherLayout导出结束。

--开始导出ZH-TW_AA_BusObject_base:
IF NOT EXISTS (SELECT 1 FROM AA_BusObject_base WHERE cBusObId=N'SaleVouche_0012' AND iAuthType='1' AND langid=N'ZH-TW' )
INSERT INTO AA_BusObject_base (cBusObId,cBusObName,iAuthType,bAuthControl,cSub_Id,cMark,iFuncType,langid,iOrder,bLocked,cLockedBy,bNoAuth) Values (N'SaleVouche_0012',N'版辊档案示例列表','1','0',N'SA',NULL,'2',N'ZH-TW',NULL,NULL,NULL,'0')
ELSE
UPDATE AA_BusObject_base SET cBusObId=N'SaleVouche_0012',cBusObName=N'版辊档案示例列表',iAuthType='1',cSub_Id=N'SA',cMark=NULL,iFuncType='2',langid=N'ZH-TW',iOrder=NULL,bLocked=NULL,cLockedBy=NULL,bNoAuth=0 WHERE  cBusObId=N'SaleVouche_0012' AND iAuthType='1' AND langid=N'ZH-TW' 
GO
IF NOT EXISTS (SELECT 1 FROM AA_BusObject_base WHERE cBusObId=N'SaleVouche_0012{##}Form' AND iAuthType='1' AND langid=N'ZH-TW' )
INSERT INTO AA_BusObject_base (cBusObId,cBusObName,iAuthType,bAuthControl,cSub_Id,cMark,iFuncType,langid,iOrder,bLocked,cLockedBy,bNoAuth) Values (N'SaleVouche_0012{##}Form',N'版辊档案示例','1','0',N'SA',NULL,'2',N'ZH-TW',NULL,NULL,NULL,'0')
ELSE
UPDATE AA_BusObject_base SET cBusObId=N'SaleVouche_0012{##}Form',cBusObName=N'版辊档案示例',iAuthType='1',cSub_Id=N'SA',cMark=NULL,iFuncType='2',langid=N'ZH-TW',iOrder=NULL,bLocked=NULL,cLockedBy=NULL,bNoAuth=0 WHERE  cBusObId=N'SaleVouche_0012{##}Form' AND iAuthType='1' AND langid=N'ZH-TW' 
GO
--ZH-TW_AA_BusObject_base导出结束。

--开始导出ZH-TW_vouchers_lang:
DELETE FROM [vouchers_lang] WHERE  cardnumber='SaleVouche_0012' AND  Localeid=N'ZH-TW' 
INSERT INTO [vouchers_lang] (cardnumber,localeid,ccardname,appname )  Values ('SaleVouche_0012',N'ZH-TW',N'版辊档案示例',N'銷售管理' ) 
GO
--ZH-TW_vouchers_lang导出结束。

--开始导出ZH-TW_AA_Enum:
DELETE FROM [AA_Enum] WHERE  EnumType=N'30490524-1187-45d6-93ac-8c50765cc16d' AND  LocaleId=N'ZH-TW' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'30490524-1187-45d6-93ac-8c50765cc16d',N'A001',N'ZH-TW',N'销售类型－普通','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'30490524-1187-45d6-93ac-8c50765cc16d' AND  LocaleId=N'ZH-TW' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'30490524-1187-45d6-93ac-8c50765cc16d',N'A002',N'ZH-TW',N'销售类型－分销','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'62d375aa-e328-4e4a-bccd-2b0eb43a5757' AND  LocaleId=N'ZH-TW' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'62d375aa-e328-4e4a-bccd-2b0eb43a5757',N'0',N'ZH-TW',N'停用','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'62d375aa-e328-4e4a-bccd-2b0eb43a5757' AND  LocaleId=N'ZH-TW' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'62d375aa-e328-4e4a-bccd-2b0eb43a5757',N'1',N'ZH-TW',N'启用','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'62d375aa-e328-4e4a-bccd-2b0eb43a5757' AND  LocaleId=N'ZH-TW' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'62d375aa-e328-4e4a-bccd-2b0eb43a5757','',N'ZH-TW','','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'ZH-TW' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'0',N'ZH-TW',N'受订','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'ZH-TW' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'1',N'ZH-TW',N'审核','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'ZH-TW' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'2',N'ZH-TW',N'出货','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'ZH-TW' AND  EnumIndex='3' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'3',N'ZH-TW',N'关闭','3',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'ZH-TW' AND  EnumIndex='4' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'4',N'ZH-TW',N'锁定','4',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-TW' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2007',N'ZH-TW',N'2007','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-TW' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2008',N'ZH-TW',N'2008','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-TW' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2009',N'ZH-TW',N'2009','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-TW' AND  EnumIndex='3' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2010',N'ZH-TW',N'2010','3',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-TW' AND  EnumIndex='4' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2011',N'ZH-TW',N'2011','4',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'ZH-TW' AND  EnumIndex='5' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2012',N'ZH-TW',N'2012','5',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'1',N'ZH-TW',N'1','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'2',N'ZH-TW',N'2','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'3',N'ZH-TW',N'3','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='3' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'4',N'ZH-TW',N'4','3',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='4' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'5',N'ZH-TW',N'5','4',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='5' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'6',N'ZH-TW',N'6','5',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='6' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'7',N'ZH-TW',N'7','6',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='7' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'8',N'ZH-TW',N'8','7',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='8' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'9',N'ZH-TW',N'9','8',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='9' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'10',N'ZH-TW',N'10','9',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='10' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'11',N'ZH-TW',N'11','10',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'ZH-TW' AND  EnumIndex='11' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'12',N'ZH-TW',N'12','11',N'SaleVouche' ) 
GO
--ZH-TW_AA_Enum导出结束。

--开始导出ZH-TW_UFMenu_Business_Lang:
DELETE FROM [UFMenu_Business_Lang] WHERE  MenuId=N'SAEFSaleVouche_0012' AND  localeId=N'ZH-TW' 
INSERT INTO [UFMenu_Business_Lang] (MenuId,Caption,LocaleId )  Values (N'SAEFSaleVouche_0012',N'版辊档案示例',N'ZH-TW' ) 
GO
DELETE FROM [UFMenu_Business_Lang] WHERE  MenuId=N'SAEFSaleVouche_0012List' AND  localeId=N'ZH-TW' 
INSERT INTO [UFMenu_Business_Lang] (MenuId,Caption,LocaleId )  Values (N'SAEFSaleVouche_0012List',N'版辊档案示例列表',N'ZH-TW' ) 
GO
--ZH-TW_UFMenu_Business_Lang导出结束。

--开始导出EN-US_UAP_VoucherLayout:
DELETE FROM [UAP_VoucherLayout] WHERE  LayoutID=N'SaleVouche_0012_L01' AND  localid=N'EN-US' 
INSERT INTO [UAP_VoucherLayout] (CardNumber,LayoutID,LayoutName,localid )  Values (N'SaleVouche_0012',N'SaleVouche_0012_L01',N'默认布局',N'EN-US' ) 
GO
--EN-US_UAP_VoucherLayout导出结束。

--开始导出EN-US_AA_BusObject_base:
IF NOT EXISTS (SELECT 1 FROM AA_BusObject_base WHERE cBusObId=N'SaleVouche_0012' AND iAuthType='1' AND langid=N'EN-US' )
INSERT INTO AA_BusObject_base (cBusObId,cBusObName,iAuthType,bAuthControl,cSub_Id,cMark,iFuncType,langid,iOrder,bLocked,cLockedBy,bNoAuth) Values (N'SaleVouche_0012',N'版辊档案示例列表','1','0',N'SA',NULL,'2',N'EN-US',NULL,NULL,NULL,'0')
ELSE
UPDATE AA_BusObject_base SET cBusObId=N'SaleVouche_0012',cBusObName=N'版辊档案示例列表',iAuthType='1',cSub_Id=N'SA',cMark=NULL,iFuncType='2',langid=N'EN-US',iOrder=NULL,bLocked=NULL,cLockedBy=NULL,bNoAuth=0 WHERE  cBusObId=N'SaleVouche_0012' AND iAuthType='1' AND langid=N'EN-US' 
GO
IF NOT EXISTS (SELECT 1 FROM AA_BusObject_base WHERE cBusObId=N'SaleVouche_0012{##}Form' AND iAuthType='1' AND langid=N'EN-US' )
INSERT INTO AA_BusObject_base (cBusObId,cBusObName,iAuthType,bAuthControl,cSub_Id,cMark,iFuncType,langid,iOrder,bLocked,cLockedBy,bNoAuth) Values (N'SaleVouche_0012{##}Form',N'版辊档案示例','1','0',N'SA',NULL,'2',N'EN-US',NULL,NULL,NULL,'0')
ELSE
UPDATE AA_BusObject_base SET cBusObId=N'SaleVouche_0012{##}Form',cBusObName=N'版辊档案示例',iAuthType='1',cSub_Id=N'SA',cMark=NULL,iFuncType='2',langid=N'EN-US',iOrder=NULL,bLocked=NULL,cLockedBy=NULL,bNoAuth=0 WHERE  cBusObId=N'SaleVouche_0012{##}Form' AND iAuthType='1' AND langid=N'EN-US' 
GO
--EN-US_AA_BusObject_base导出结束。

--开始导出EN-US_vouchers_lang:
DELETE FROM [vouchers_lang] WHERE  cardnumber='SaleVouche_0012' AND  Localeid=N'EN-US' 
INSERT INTO [vouchers_lang] (cardnumber,localeid,ccardname,appname )  Values ('SaleVouche_0012',N'EN-US',N'版辊档案示例',N'Sales Management' ) 
GO
--EN-US_vouchers_lang导出结束。

--开始导出EN-US_AA_Enum:
DELETE FROM [AA_Enum] WHERE  EnumType=N'30490524-1187-45d6-93ac-8c50765cc16d' AND  LocaleId=N'EN-US' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'30490524-1187-45d6-93ac-8c50765cc16d',N'A001',N'EN-US',N'销售类型－普通','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'30490524-1187-45d6-93ac-8c50765cc16d' AND  LocaleId=N'EN-US' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'30490524-1187-45d6-93ac-8c50765cc16d',N'A002',N'EN-US',N'销售类型－分销','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'62d375aa-e328-4e4a-bccd-2b0eb43a5757' AND  LocaleId=N'EN-US' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'62d375aa-e328-4e4a-bccd-2b0eb43a5757',N'0',N'EN-US',N'停用','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'62d375aa-e328-4e4a-bccd-2b0eb43a5757' AND  LocaleId=N'EN-US' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'62d375aa-e328-4e4a-bccd-2b0eb43a5757',N'1',N'EN-US',N'启用','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'62d375aa-e328-4e4a-bccd-2b0eb43a5757' AND  LocaleId=N'EN-US' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'62d375aa-e328-4e4a-bccd-2b0eb43a5757','',N'EN-US','','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'EN-US' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'0',N'EN-US',N'受订','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'EN-US' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'1',N'EN-US',N'审核','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'EN-US' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'2',N'EN-US',N'出货','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'EN-US' AND  EnumIndex='3' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'3',N'EN-US',N'关闭','3',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'669a8aab-cc63-4cec-b44a-aac7a8f06cca' AND  LocaleId=N'EN-US' AND  EnumIndex='4' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'669a8aab-cc63-4cec-b44a-aac7a8f06cca',N'4',N'EN-US',N'锁定','4',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'EN-US' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2007',N'EN-US',N'2007','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'EN-US' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2008',N'EN-US',N'2008','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'EN-US' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2009',N'EN-US',N'2009','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'EN-US' AND  EnumIndex='3' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2010',N'EN-US',N'2010','3',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'EN-US' AND  EnumIndex='4' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2011',N'EN-US',N'2011','4',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'96df1e58-bd82-4cc0-8441-d421edd53b92' AND  LocaleId=N'EN-US' AND  EnumIndex='5' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'96df1e58-bd82-4cc0-8441-d421edd53b92',N'2012',N'EN-US',N'2012','5',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='0' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'1',N'EN-US',N'1','0',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='1' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'2',N'EN-US',N'2','1',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='2' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'3',N'EN-US',N'3','2',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='3' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'4',N'EN-US',N'4','3',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='4' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'5',N'EN-US',N'5','4',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='5' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'6',N'EN-US',N'6','5',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='6' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'7',N'EN-US',N'7','6',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='7' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'8',N'EN-US',N'8','7',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='8' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'9',N'EN-US',N'9','8',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='9' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'10',N'EN-US',N'10','9',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='10' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'11',N'EN-US',N'11','10',N'SaleVouche' ) 
GO
DELETE FROM [AA_Enum] WHERE  EnumType=N'd4ceceee-87dd-405b-b908-94c7ad14f3ea' AND  LocaleId=N'EN-US' AND  EnumIndex='11' 
INSERT INTO [AA_Enum] (EnumType,EnumCode,LocaleId,EnumName,EnumIndex,cProjectNO )  Values (N'd4ceceee-87dd-405b-b908-94c7ad14f3ea',N'12',N'EN-US',N'12','11',N'SaleVouche' ) 
GO
--EN-US_AA_Enum导出结束。

--开始导出EN-US_UFMenu_Business_Lang:
DELETE FROM [UFMenu_Business_Lang] WHERE  MenuId=N'SAEFSaleVouche_0012' AND  localeId=N'EN-US' 
INSERT INTO [UFMenu_Business_Lang] (MenuId,Caption,LocaleId )  Values (N'SAEFSaleVouche_0012',N'版辊档案示例',N'EN-US' ) 
GO
DELETE FROM [UFMenu_Business_Lang] WHERE  MenuId=N'SAEFSaleVouche_0012List' AND  localeId=N'EN-US' 
INSERT INTO [UFMenu_Business_Lang] (MenuId,Caption,LocaleId )  Values (N'SAEFSaleVouche_0012List',N'版辊档案示例列表',N'EN-US' ) 
GO
--EN-US_UFMenu_Business_Lang导出结束。

--开始导出PhysicalTable:
--导出物理表脚本,注意如果物理表中有多个字段一起被设为主键，脚本导出工具导出的物理表结构脚本中把每个字段分别设为主键，请手工修改。
GO
--创建物理表SaleVouche_0012_E001的脚本：
IF NOT EXISTS(SELECT * FROM sysobjects where xtype='U' and name='SaleVouche_0012_E001')
 Create Table [SaleVouche_0012_E001] ( [cNo] [nvarchar](40),[cMaker] [nvarchar](30),[dMakeDateEx] [datetime],[dMakeDate] [datetime],[cMender] [nvarchar](30),[dModifyDateEx] [datetime],[dModifyDate] [datetime],[cAuditor] [nvarchar](30),[dAuditDateEx] [datetime],[dAuditDate] [datetime],[cpcl] [nvarchar](100),[SaleVouche_0012_E001_PK] [int] Primary Key  NOT NULL ,[iswfcontrolled] [int],[iverifystate] [int],[ireturncount] [int],[UAPRuntime_RowNO] [int],[UAP_VoucherTransform_Rowkey] [nvarchar](50))  
ELSE
BEGIN
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='cNo' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [cNo] [nvarchar](40)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='cMaker' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [cMaker] [nvarchar](30)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='dMakeDateEx' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [dMakeDateEx] [datetime]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='dMakeDate' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [dMakeDate] [datetime]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='cMender' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [cMender] [nvarchar](30)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='dModifyDateEx' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [dModifyDateEx] [datetime]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='dModifyDate' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [dModifyDate] [datetime]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='cAuditor' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [cAuditor] [nvarchar](30)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='dAuditDateEx' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [dAuditDateEx] [datetime]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='dAuditDate' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [dAuditDate] [datetime]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='cpcl' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [cpcl] [nvarchar](100)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='SaleVouche_0012_E001_PK' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [SaleVouche_0012_E001_PK] [int] Primary Key  NOT NULL 
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='iswfcontrolled' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [iswfcontrolled] [int]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='iverifystate' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [iverifystate] [int]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='ireturncount' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [ireturncount] [int]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='UAPRuntime_RowNO' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [UAPRuntime_RowNO] [int]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='UAP_VoucherTransform_Rowkey' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E001' AND type='U'))
ALTER TABLE SaleVouche_0012_E001 ADD [UAP_VoucherTransform_Rowkey] [nvarchar](50)
END
--创建物理表SaleVouche_0012_E002的脚本：
IF NOT EXISTS(SELECT * FROM sysobjects where xtype='U' and name='SaleVouche_0012_E002')
 Create Table [SaleVouche_0012_E002] ( [chdabm] [nvarchar](100),[SaleVouche_0012_E002_PK] [int] Primary Key  NOT NULL ,[SaleVouche_0012_E001_PK] [int],[UAPRuntime_RowNO] [int],[UAP_VoucherTransform_Rowkey] [nvarchar](50),[RefMainID] [nvarchar](50),[RefRowID] [nvarchar](50))  
ELSE
BEGIN
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='chdabm' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E002' AND type='U'))
ALTER TABLE SaleVouche_0012_E002 ADD [chdabm] [nvarchar](100)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='SaleVouche_0012_E002_PK' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E002' AND type='U'))
ALTER TABLE SaleVouche_0012_E002 ADD [SaleVouche_0012_E002_PK] [int] Primary Key  NOT NULL 
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='SaleVouche_0012_E001_PK' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E002' AND type='U'))
ALTER TABLE SaleVouche_0012_E002 ADD [SaleVouche_0012_E001_PK] [int]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='UAPRuntime_RowNO' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E002' AND type='U'))
ALTER TABLE SaleVouche_0012_E002 ADD [UAPRuntime_RowNO] [int]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='UAP_VoucherTransform_Rowkey' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E002' AND type='U'))
ALTER TABLE SaleVouche_0012_E002 ADD [UAP_VoucherTransform_Rowkey] [nvarchar](50)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='RefMainID' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E002' AND type='U'))
ALTER TABLE SaleVouche_0012_E002 ADD [RefMainID] [nvarchar](50)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='RefRowID' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E002' AND type='U'))
ALTER TABLE SaleVouche_0012_E002 ADD [RefRowID] [nvarchar](50)
END
--创建物理表SaleVouche_0012_E003的脚本：
IF NOT EXISTS(SELECT * FROM sysobjects where xtype='U' and name='SaleVouche_0012_E003')
 Create Table [SaleVouche_0012_E003] ( [bgbm] [nvarchar](40),[bgmc] [nvarchar](40),[bglb] [nvarchar](40),[chfl] [nvarchar](40),[hwh] [nvarchar](40),[SaleVouche_0012_E003_PK] [int] Primary Key  NOT NULL ,[SaleVouche_0012_E002_PK] [int],[SaleVouche_0012_E001_PK] [int],[UAPRuntime_RowNO] [int],[UAP_VoucherTransform_Rowkey] [nvarchar](50))  
ELSE
BEGIN
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='bgbm' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E003' AND type='U'))
ALTER TABLE SaleVouche_0012_E003 ADD [bgbm] [nvarchar](40)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='bgmc' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E003' AND type='U'))
ALTER TABLE SaleVouche_0012_E003 ADD [bgmc] [nvarchar](40)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='bglb' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E003' AND type='U'))
ALTER TABLE SaleVouche_0012_E003 ADD [bglb] [nvarchar](40)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='chfl' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E003' AND type='U'))
ALTER TABLE SaleVouche_0012_E003 ADD [chfl] [nvarchar](40)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='hwh' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E003' AND type='U'))
ALTER TABLE SaleVouche_0012_E003 ADD [hwh] [nvarchar](40)
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='SaleVouche_0012_E003_PK' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E003' AND type='U'))
ALTER TABLE SaleVouche_0012_E003 ADD [SaleVouche_0012_E003_PK] [int] Primary Key  NOT NULL 
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='SaleVouche_0012_E002_PK' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E003' AND type='U'))
ALTER TABLE SaleVouche_0012_E003 ADD [SaleVouche_0012_E002_PK] [int]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='SaleVouche_0012_E001_PK' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E003' AND type='U'))
ALTER TABLE SaleVouche_0012_E003 ADD [SaleVouche_0012_E001_PK] [int]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='UAPRuntime_RowNO' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E003' AND type='U'))
ALTER TABLE SaleVouche_0012_E003 ADD [UAPRuntime_RowNO] [int]
IF NOT EXISTS (SELECT * FROM SYSCOLUMNS WHERE name ='UAP_VoucherTransform_Rowkey' and id=(SELECT id FROM SYSOBJECTS WHERE name ='SaleVouche_0012_E003' AND type='U'))
ALTER TABLE SaleVouche_0012_E003 ADD [UAP_VoucherTransform_Rowkey] [nvarchar](50)
END


GO
--物理表脚本导出完毕
GO
--PhysicalTable导出结束。

--开始导出vouchertemplates_base:

DELETE FROM [vouchers_base] WHERE  CardNumber='SaleVouche_0012' 
DECLARE @ExcluciveIndexProcess4 nvarchar(40) SET @ExcluciveIndexProcess4='版辊档案示例' if(exists(select * from [vouchers_base] where Name='版辊档案示例'))   BEGIN   declare @newidExcluciveIndexProcess4 varchar(100) set @newidExcluciveIndexProcess4= (select newid()) set @ExcluciveIndexProcess4= substring(@newidExcluciveIndexProcess4,0,20) END 
INSERT INTO [vouchers_base] (CardNumber,Shield,Name,CardType,ItemTblName,itemCol,BTTblName,BTQName,BWTblName,BWQName,VchListQName,HaveBodyGrid,BodyModify,VoucherWidth,VoucherHeight,BodyTop,BodyLeft,BodyWidth,BodyHeight,SelfDef1,SelfDef2,SelfDef3,DEF_ID,DEF_ID_PRN,cSub_Id,Memo,iOrder,cIndustry,bAllowMulTemp,cDefWhere,vchtblPrimarykeyNames,ReceiptNoFieldName,IsPrintLimited,AllowDateTimeFormat,NotAppiesAuth,InventoryFieldName,UpdateTime,cHeadBusObjectId,cBodyBusObjectId,cHeadFuncName,cBodyFuncName,cFieldAuthid,vchBodyPKName,BodyFKName )  Values ('SaleVouche_0012','0',@ExcluciveIndexProcess4,'','','0','SaleVouche_0012_E001','','SaleVouche_0012_E002','','','1','1','0','0','0','0','0','0','','','','31258','31258','SA','','0','','1','','SaleVouche_0012_E001_PK','cNo','1','1',NULL,NULL,NULL,'6fff3d9c-a50e-4317-ad88-bcf2805d17f2','GetSaleVouche_0012_E001','6fff3d9c-a50e-4317-ad88-bcf2805d17f2','GetSaleVouche_0012_E002',NULL,NULL,NULL ) 
GO

DELETE FROM vouchertemplates_base WHERE VT_CardNumber='SaleVouche_0012'
DELETE FROM vouchertemplates_lang WHERE vt_cardNumber='SaleVouche_0012'
DELETE FROM voucheritems_prn_base WHERE cardNum='SaleVouche_0012'
DELETE FROM voucheritems_prn_lang WHERE cardNum='SaleVouche_0012'

DECLARE @newVTID int
SELECT @newVTID=MAX(VT_ID)+2 FROM vouchertemplates_base
INSERT INTO vouchertemplates_base ( VT_ID,VT_CardNumber,VT_TemplateMode,VT_Width,VT_Height,VT_BodyTop,VT_BodyLeft,VT_BodyWidth,VT_BodyHeight,VT_SelfDef1,VT_SelfDef2,VT_SelfDef3,VT_Memo,VT_Lock,VT_TitleTop,VT_TitleLeft,VT_PageHeader,VT_BodyFixedCols,VT_BodyMaxRows,VT_GridStyle,VT_WorkAreaColor,VT_FiexdColor,VT_TotalColor,VT_ControlStyle,VT_GridPrnRows,VT_GridPrnRowHeight,VT_PrintTemplID,VT_AutoCalc,VT_PageSubTotal,VT_PageTotal,VT_PrintGrid,nAutoCalcWidth,nPrintSeril,nPrintGridLine,varPrintSetting,VT_PRN_DEF_LANDID,vt_saveObject,VT_ReservedInfo,VT_xamlField,VT_RowLayoutEnabled,AuditDisplayFlag )  Values (@newVTID,'SaleVouche_0012','1','11339','7937','2640','120','11099','4867','3800','345',NULL,NULL,'1','120','5208',NULL,'1','0','1','16777215','16769984','16777215','2','0','0','0','0','1','1','1','1','0','1',NULL,NULL,NULL,NULL,NULL,NULL,NULL ) 
INSERT INTO vouchertemplates_lang ( vt_id,localeid,vt_cardnumber,vt_name,vt_titlename,vt_titlefontstate,vt_foot,vt_gridstylehead,vt_gridstylebody,vt_gridstyletotal,vt_footheaderfont,vt_header,vt_RowLayoutXML )  Values (@newVTID,'EN-US','SaleVouche_0012','版辊档案示例','版辊档案示例','Tahoma,15,0,0,1','第 %j 页,共 %J 页',NULL,NULL,NULL,NULL,NULL,NULL ) 
INSERT INTO vouchertemplates_lang ( vt_id,localeid,vt_cardnumber,vt_name,vt_titlename,vt_titlefontstate,vt_foot,vt_gridstylehead,vt_gridstylebody,vt_gridstyletotal,vt_footheaderfont,vt_header,vt_RowLayoutXML )  Values (@newVTID,'ZH-CN','SaleVouche_0012','版辊档案示例','版辊档案示例','Tahoma,15,0,0,1','第 %j 页,共 %J 页',NULL,NULL,NULL,NULL,NULL,NULL ) 
INSERT INTO vouchertemplates_lang ( vt_id,localeid,vt_cardnumber,vt_name,vt_titlename,vt_titlefontstate,vt_foot,vt_gridstylehead,vt_gridstylebody,vt_gridstyletotal,vt_footheaderfont,vt_header,vt_RowLayoutXML )  Values (@newVTID,'ZH-TW','SaleVouche_0012','版辊档案示例','版辊档案示例','Tahoma,15,0,0,1','第 %j 页,共 %J 页',NULL,NULL,NULL,NULL,NULL,NULL ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E002','chdamc','1','0',NULL,'B','1','40','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','0','0','3000','285','0',NULL,'0',NULL,'1','0',NULL,'0','0',NULL,'0','1','0','0','cInvName',NULL,NULL,'0',NULL,'1','0',NULL,'Inventory_PM',NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E002','chdabm','1','0',NULL,'B','1','100','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','0','0','3000','285','0',NULL,'0',NULL,'1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0',NULL,'Inventory_PM',NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','cpflmc','1','0',NULL,'T','1','40','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','6720','1815','3000','285','0',NULL,'0',NULL,'1','0',NULL,'0','0',NULL,'0','1','0','0','cInvName',NULL,NULL,'0',NULL,'1','0',NULL,'ProductRef',NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','cpcl','1','0',NULL,'T','1','100','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','3420','1815','3000','285','0',NULL,'0',NULL,'1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0',NULL,'ProductRef',NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','dAuditDate','5','0',NULL,'T','1','0','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','120','1815','3000','285','0','2010-04-06  15:47:25','0','yyyy-MM-dd  HH:mm:ss','1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0','2010-04-06  15:47:25',NULL,NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','dAuditDateEx','5','0',NULL,'T','1','0','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','6720','1470','3000','285','0','2010-04-06','0','yyyy-MM-dd','1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0','2010-04-06',NULL,NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','cAuditor','1','0',NULL,'T','1','40','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','3420','1470','3000','285','0',NULL,'0',NULL,'1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0',NULL,NULL,NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','dModifyDate','5','0',NULL,'T','1','0','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','120','1470','3000','285','0','2010-04-06  15:47:25','0','yyyy-MM-dd  HH:mm:ss','1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0','2010-04-06  15:47:25',NULL,NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','dModifyDateEx','5','0',NULL,'T','1','0','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','6720','1125','3000','285','0','2010-04-06','0','yyyy-MM-dd','1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0','2010-04-06',NULL,NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','cMender','1','0',NULL,'T','1','40','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','3420','1125','3000','285','0',NULL,'0',NULL,'1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0',NULL,NULL,NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','dMakeDate','5','0',NULL,'T','1','0','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','120','1125','3000','285','0','2010-04-06  15:47:25','0','yyyy-MM-dd  HH:mm:ss','1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0','2010-04-06  15:47:25',NULL,NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','dMakeDateEx','5','0',NULL,'T','1','0','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','6720','780','3000','285','0','2010-04-06','0','yyyy-MM-dd','1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0','2010-04-06',NULL,NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','cMaker','1','0',NULL,'T','1','40','0','0','1','1',NULL,NULL,NULL,'0','0','0','0','0','3420','780','3000','285','0',NULL,'0',NULL,'1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0',NULL,NULL,NULL,'0' ) 
INSERT INTO voucheritems_prn_base ( VT_ID,CardNum,CardItemNum,CanNotSelect,ShowIt,LinkIt,LinkTbl,LinkField,TableName,FieldName,FieldType,ReferType,ReferTable,CardSection,CanModify,MaxLength,MaxShowLen,NumPoint,IsNull,CanDelete,UserCheck,UserPrompt,FormatChar,IsMain,NeedSum,CalcField,AliasNum,isSelfDef,COX,COY,Width,Height,TabIndex,DefaultValue,IsFixedLenght,FormatData,PrintCaption,PrintUpcase,PrintInterval,DataSource,EnterType,DataRule,ValidityCheck,ReserveSegTitlePos,BuildArchives,nBorder,ReferReturnField,cmemo,EnumType,IsEnum,EnumTypeString,bZeroAllowable,iFlags,vValueDefault,refObject,AutoFillRule,Catalog )  Values (@newVTID,'SaleVouche_0012',NULL,'0','1','1',NULL,NULL,'SaleVouche_0012_E001','cNo','1','0',NULL,'T','1','40','0','0','0','1',NULL,NULL,NULL,'0','0','0','0','0','120','780','3000','285','0',NULL,'0',NULL,'1','0',NULL,'0','0',NULL,'0','1','0','0',NULL,NULL,NULL,'0',NULL,'1','0',NULL,NULL,NULL,'0' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('82a8421a-f2ea-4e94-8de8-c','ZH-TW',@newVTID,'dModifyDateEx','T','SaleVouche_0012','修改日期','修改日期',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('7848d8cc-a123-4270-9184-3','ZH-CN',@newVTID,'cNo','T','SaleVouche_0012','表单编号','表单编号',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('53150be9-8c2b-4e09-83a4-c','ZH-CN',@newVTID,'dModifyDateEx','T','SaleVouche_0012','修改日期','修改日期',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('6c39ffb8-fda3-420c-b422-0','ZH-CN',@newVTID,'dModifyDate','T','SaleVouche_0012','修改时间','修改时间',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('9c571729-5b76-4e18-a03d-1','ZH-TW',@newVTID,'dMakeDate','T','SaleVouche_0012','制單時間','制單時間',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('b34b3066-0fb6-4d21-8120-a','ZH-CN',@newVTID,'dAuditDate','T','SaleVouche_0012','审核时间','审核时间',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('f6faa9b8-faf7-4199-b607-7','EN-US',@newVTID,'dAuditDate','T','SaleVouche_0012','dAuditDate','dAuditDate',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('db124822-2fdc-42a7-a7af-a','ZH-TW',@newVTID,'cpcl','T','SaleVouche_0012','产品分类','产品分类',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('d9db7e3b-ccb9-46b4-bca2-d','ZH-TW',@newVTID,'cNo','T','SaleVouche_0012','表單編號','表單編號',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('19884030-64ca-4ab8-b8dc-e','EN-US',@newVTID,'cNo','T','SaleVouche_0012','cNo','cNo',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('2d9feb11-2603-4933-ae48-d','ZH-TW',@newVTID,'cMender','T','SaleVouche_0012','修改人','修改人',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('9768306b-e8a6-4034-a3bc-c','EN-US',@newVTID,'cMaker','T','SaleVouche_0012','cMaker','cMaker',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('fc00514c-fe75-46df-809b-e','ZH-TW',@newVTID,'chdamc','B','SaleVouche_0012','存货档案名称','存货档案名称',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('761dc7f8-30be-4970-9dc5-4','EN-US',@newVTID,'chdabm','B','SaleVouche_0012','存货档案编码','存货档案编码',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('424dfee8-21e3-4887-9b33-7','EN-US',@newVTID,'dModifyDateEx','T','SaleVouche_0012','dModifyDateEx','dModifyDateEx',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('bf8a1d3e-f0a2-4879-9267-5','EN-US',@newVTID,'dModifyDate','T','SaleVouche_0012','dModifyDate','dModifyDate',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('d71ec1c4-9246-4c11-90af-5','ZH-TW',@newVTID,'dMakeDateEx','T','SaleVouche_0012','制單日期','制單日期',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('4e70bb78-26bb-410c-be3b-8','EN-US',@newVTID,'dMakeDate','T','SaleVouche_0012','dMakeDate','dMakeDate',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('4cc38716-4065-4b22-a8f8-3','ZH-TW',@newVTID,'dAuditDateEx','T','SaleVouche_0012','審核日期','審核日期',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('0fc490d5-7f05-492f-a8c6-b','ZH-CN',@newVTID,'dAuditDateEx','T','SaleVouche_0012','审核日期','审核日期',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('9959c4ea-f75c-4a0d-b4be-b','EN-US',@newVTID,'dAuditDateEx','T','SaleVouche_0012','dAuditDateEx','dAuditDateEx',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('3722aabf-6f58-4452-a9dd-c','EN-US',@newVTID,'cpflmc','T','SaleVouche_0012','产品分类名称','产品分类名称',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('c5dda123-d768-42b0-abd1-a','ZH-TW',@newVTID,'cMaker','T','SaleVouche_0012','制單人','制單人',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('df3401b7-7781-4a6a-8963-2','ZH-TW',@newVTID,'chdabm','B','SaleVouche_0012','存货档案编码','存货档案编码',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('030f6a8e-c3d3-4525-ad35-7','ZH-CN',@newVTID,'chdabm','B','SaleVouche_0012','存货档案编码','存货档案编码',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('3465db82-7c70-4f40-ab01-e','ZH-TW',@newVTID,'cAuditor','T','SaleVouche_0012','審核人','審核人',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('36e94be8-c104-4ffb-b692-1','ZH-CN',@newVTID,'cAuditor','T','SaleVouche_0012','审核人','审核人',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('58bbb2d4-4d32-4138-a7d7-f','ZH-TW',@newVTID,'dModifyDate','T','SaleVouche_0012','修改時間','修改時間',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('6444c6e1-645c-433c-ac61-0','ZH-CN',@newVTID,'dMakeDateEx','T','SaleVouche_0012','制单日期','制单日期',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('168fdaf3-1cb6-4613-a7aa-f','ZH-TW',@newVTID,'cpflmc','T','SaleVouche_0012','产品分类名称','产品分类名称',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('606ee59e-6c9e-4952-99e3-7','ZH-CN',@newVTID,'cpflmc','T','SaleVouche_0012','产品分类名称','产品分类名称',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('f4631200-8143-4bb9-a73f-6','ZH-CN',@newVTID,'cpcl','T','SaleVouche_0012','产品分类','产品分类',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('700badb0-2309-4a57-8877-b','EN-US',@newVTID,'cpcl','T','SaleVouche_0012','产品分类','产品分类',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('af73bdf3-2df6-4c7a-88b8-6','EN-US',@newVTID,'cMender','T','SaleVouche_0012','cMender','cMender',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('3eb8c3ad-38f7-4e2e-9fd1-4','ZH-CN',@newVTID,'cMaker','T','SaleVouche_0012','制单人','制单人',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('5deffa20-031e-4eef-b596-2','ZH-CN',@newVTID,'chdamc','B','SaleVouche_0012','存货档案名称','存货档案名称',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('b6c02691-b17d-4986-aff9-f','EN-US',@newVTID,'chdamc','B','SaleVouche_0012','存货档案名称','存货档案名称',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('3f45d44e-d8e3-438d-b05d-9','EN-US',@newVTID,'dMakeDateEx','T','SaleVouche_0012','dMakeDateEx','dMakeDateEx',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('e2e6d2fa-226f-41f5-bd8e-d','ZH-TW',@newVTID,'dAuditDate','T','SaleVouche_0012','審核時間','審核時間',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('061a7bd4-182e-4826-9c19-8','ZH-CN',@newVTID,'cMender','T','SaleVouche_0012','修改人','修改人',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('579d2ad2-86b7-458f-8d54-d','EN-US',@newVTID,'cAuditor','T','SaleVouche_0012','cAuditor','cAuditor',NULL,'宋体,9,0,0,1' ) 
INSERT INTO voucheritems_prn_lang ( guid,localeid,vt_id,fieldname,cardsection,cardnum,carditemname,cardformula1,cardformula2,fontstate )  Values ('451df0d0-a14a-492e-829d-8','ZH-CN',@newVTID,'dMakeDate','T','SaleVouche_0012','制单时间','制单时间',NULL,'宋体,9,0,0,1' ) 

UPDATE vouchers_base SET DEF_ID=@newVTID,DEF_ID_PRN=@newVTID WHERE CardNumber='SaleVouche_0012'

GO
--vouchertemplates_base导出结束。

--开始导出UA_Menu:
DELETE FROM [UA_Menu] WHERE  cMenu_ID=N'SAEFSaleVouche_0012' 
INSERT INTO [UA_Menu] (cMenu_Id,cMenu_Name,cMenu_Eng,cSub_Id,IGrade,cSupMenu_Id,bEndGrade,cAuth_Id,iOrder,iImgIndex,Paramters,Depends,Flag )  Values (N'SAEFSaleVouche_0012',N'版辊档案示例',N'2',N'UA','4',N'SA','1','','100.0000000000','4',N'<property cardnum="SaleVouche_0012"  type="voucher"/>',NULL,NULL ) 
GO
DELETE FROM [UA_Menu] WHERE  cMenu_ID=N'SAEFSaleVouche_0012List' 
INSERT INTO [UA_Menu] (cMenu_Id,cMenu_Name,cMenu_Eng,cSub_Id,IGrade,cSupMenu_Id,bEndGrade,cAuth_Id,iOrder,iImgIndex,Paramters,Depends,Flag )  Values (N'SAEFSaleVouche_0012List',N'版辊档案示例列表',N'3',N'UA','4',N'SA','1','','100.0000000000','4',N'<property type="List" cardnum="SaleVouche_0012">
<UFGeneralList id="1860fdea-bc72-419b-ab4b-1547cfffa2e0">
<filter>
<defaultcondition condition=""/>
</filter>
</UFGeneralList>
</property>',NULL,NULL ) 
GO
--UA_Menu导出结束。

