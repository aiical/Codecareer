VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "mytestclass"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit

Public Function RunCommand(ByVal objLogin As Object, ByVal objForm As Object, ByVal objVoucher As Object, _
                            ByVal sKey As String, ByVal VarentValue As Variant, ByVal other As String)
    
    'Call ShowRef(objLogin)
    MsgBox "my button"
End Function

'初始化
Public Function Init(ByVal objLogin As Object, ByVal objForm As Object, ByVal objVoucher As Object, msbar As Object)
'MsgBox "Init"
End Function

'在执行系统按钮只前调用,Cancel后会不再执行系统方法。
Public Function BeforeRunSysCommand(ByVal objLogin As Object, ByVal objForm As Object, ByVal objVoucher As Object, _
                            ByVal sKey As String, ByVal VarentValue As Variant, ByRef Cancel As Boolean, ByVal other As String)
    MsgBox "Save is Canceled"
    Cancel = True
End Function

'Private Function ShowFilter()
'    Dim bSuccess As Boolean
'    Dim ErrInfo As Variant
'    If LCase(sKey) = LCase("_CustDefbtntest") Then
'        Dim userobject As New U8Test.Class1
'        Dim fltsrv As New UFGeneralFilter.FilterSrv
'        Set fltsrv.BehaviorObject = userobject      '可以不调用
'        bSuccess = fltsrv.OpenFilter(objLogin, "8810213F-3B19-421B-B5FE-B96E38FC1A5E", "", "", ErrInfo)
'        If bSuccess = True Then
'            MsgBox fltsrv.GetSQLWhere
'        End If
'    End If
'End Function
'
'Private Function ShowRef(ByVal objLogin As Object)
'    Dim rs As ADODB.Recordset
'    Dim obj As New U8RefService.IService
'    obj.RefID = "inventory_aa"
'    obj.RefType = RefArchive
'    obj.ShowRef objLogin, Nothing, rs, ""
'    If Not rs Is Nothing Then
'        If Not rs.EOF Then
'            MsgBox rs("cInvCode")
'        End If
'    End If
'End Function
