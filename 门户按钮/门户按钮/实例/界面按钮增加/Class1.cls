VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Class1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit


'当过滤的某项的值发生变化时回调此函数
Public Sub CallBack_ValueChange(sKey As String, flt As UFGeneralFilter.FilterSrv)
    Debug.Print sKey
    If sKey = "aaa" Then
        flt.SetValue "bbb", "001"
    End If
End Sub
'当过滤初始化是回调此函数
Public Function CallBack_FilterInit(flt As UFGeneralFilter.FilterSrv)
    
End Function
'当点过滤时回调此函数
Public Function CallBack_FilterClick(flt As UFGeneralFilter.FilterSrv, Cancel As Boolean)
        
End Function



