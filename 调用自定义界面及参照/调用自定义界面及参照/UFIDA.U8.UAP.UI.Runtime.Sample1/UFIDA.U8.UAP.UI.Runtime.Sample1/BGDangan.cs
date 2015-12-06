using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using UFIDA.U8.UAP.UI.Runtime.Common;
using UFIDA.U8.UAP.UI.Runtime.Model;
using UFIDA.U8.UAP.UI.Runtime.List.Metas;
using UFIDA.U8.UAP.UI.Runtime.Controller;


namespace UFIDA.U8.UAP.UI.Runtime.Sample1
{
    public class BGDangan : ReceiptPluginBase
    {
        #region IReceipt 成员

        /// <summary>
        /// 值更新之后的接口，对值的后续处理（如对其他Cell值的变更）在这里进行
        /// </summary>
        /// <param name="para">Cell的值变动参数</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        //[IsImplement(true)]
        public override void CellChanged(UFIDA.U8.UAP.UI.Runtime.Common.CellChangeEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {

            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 值更新之前的接口，对值的合法性检查在这里进行
        /// </summary>
        /// <param name="para">Cell的值变动参数</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        /// <return>是否允许更新单元格的值，false--不允许更新，将保持原值</return>
        public override bool CellChanging(UFIDA.U8.UAP.UI.Runtime.Common.CellChangeEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 鼠标左键双击数据单元格的接口
        /// </summary>
        /// <param name="para">鼠标双击信息</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        /// </summary>
        [IsImplement(true)]
        public override void CellDoubleClick(UFIDA.U8.UAP.UI.Runtime.Common.CellDoubleClickEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            Business E002 = voucherObject.Businesses["SaleVouche_0012_E002"] as Business;
            Business E003 = voucherObject.Businesses["SaleVouche_0012_E003"] as Business;
            if (E002.Rows.Count > 0)
            {
                switch (para.ColumnName)
                {
                    case "bgbm":
                        OpenNewVoucher(voucherObject.VBLoginObject, para, E003);
                        break;
                    default:
                        break;
                }
            }


            //throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 设置当前列之后的接口
        /// </summary>
        /// <param name="para">列信息</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        public override void CellSelected(UFIDA.U8.UAP.UI.Runtime.Common.CellSelectEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 表头或表体工具条按钮单击事件的接口
        /// </summary>
        /// <param name="para">被单击的按钮参数</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        /// <returns>true表示实现了相应按钮的方法；false表示没有实现相应按钮的方法。</returns>
        //[IsImplement(true)]

        public override bool ClickToolBarButton(UFIDA.U8.UAP.UI.Runtime.Common.ToolBarActionEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 创建用户自定义控件接口，开发人员可以在这里创建用户自定义控件。运行时会把这个控件加载到布局视图中。（871版本新增）
        /// </summary>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        /// <param name="ID">布局视图中指定的自定义控件“控件ID”</param>
        /// <returns>用户自定义控件对象</returns>
        public override System.Windows.Forms.Control CreateControl(BusinessProxy businessObject, VoucherProxy voucherObject, string ID)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 业务数据合法性检查之后的接口
        /// </summary>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        // [IsImplement(true)]

        public override void DataChecked(BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 业务数据合法性检查之前的接口
        /// </summary>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        /// <returns>检查是否通过，false--不通过</returns>
        public override bool DataChecking(BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 表头或表体填充数据后的接口
        /// </summary>
        /// <param name="view">观察者视图接口(IEditWindow)对象</param>
        /// <param name="fillDataTable">已经填充的数据</param>
        /// <param name="businessObject">表头或表体对象</param>
        /// <param name="voucherObject">单据对象</param>
        public override void EditWindowFilled(UFIDA.U8.UAP.UI.Runtime.Common.IEditWindow view, System.Data.DataTable fillDataTable, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 表头或表体填充数据前的接口
        /// </summary>
        /// <param name="view">观察者视图接口(IEditWindow)对象</param>
        /// <param name="fillDataTable">即将要填充的数据</param>
        /// <param name="businessObject">表头或表体对象</param>
        /// <param name="voucherObject">单据对象</param>
        public override void EditWindowFilling(UFIDA.U8.UAP.UI.Runtime.Common.IEditWindow view, System.Data.DataTable fillDataTable, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 门户按钮处理接口
        /// </summary>
        /// <param name="ButtonArgs">按钮对象</param>
        /// <param name="voucherObject">单据对象</param>
        /// <returns>门户按钮处理实现类</returns>
        //IsImplement(true)]
        public override IButtonEventHandler GetButtonEventHandler(UFIDA.U8.UAP.UI.Runtime.Common.VoucherButtonArgs ButtonArgs, VoucherProxy voucherObject)
        {
            return null;

        }

        /// <summary>
        /// 鼠标左键双击表格的标题的接口
        /// </summary>
        /// <param name="para">鼠标双击信息</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        public override void HeaderDoubleClick(UFIDA.U8.UAP.UI.Runtime.Common.HeaderDoubleClickEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 运行时表单加载之后调用的接口，可以处理表单加载之后的业务要求。
        /// </summary>
        /// <param name="ReceiptObject">所属表单对象</param>
        public override void ReceiptLoaded(VoucherProxy ReceiptObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 运行时表单加载之前调用的接口，可以处理表单加载之前的业务要求。
        /// </summary>
        /// <param name="login">U8登录对象</param>
        /// <param name="Cardnumber">表单编号</param>
        /// <param name="ds">表单数据</param>
        /// <param name="state">表单状态</param>
        /// <param name="voucherParameter">表单数据</param>
        public override void ReceiptLoading(U8Login.clsLogin login, string Cardnumber, System.Data.DataSet ds, UFIDA.U8.UAP.UI.Runtime.Common.VoucherStateEnum state, UFIDA.U8.UAP.UI.Runtime.Common.ReceiptLoadingParas loadingParas)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 参照返回（关闭）后的接口
        /// </summary>
        /// <param name="view">观察者视图接口(IEditWindow)对象</param>
        /// <param name="para">ReferCloseEventArgs参照信息</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        public override void ReferClosed(UFIDA.U8.UAP.UI.Runtime.Common.ReferCloseEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 参照打开前的接口(比如为参照列表设置过滤等)
        /// </summary>
        /// <param name="para">ReferOpenEventArgs参照信息</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        /// <returns>是否允许参照，false--不允许参照，将不弹出参照界面，参照操作终止</returns>
        //[IsImplement(true)]

        public override bool ReferOpening(UFIDA.U8.UAP.UI.Runtime.Common.ReferOpenEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            return false;
        }

        /// <summary>
        /// 增加行之后的接口，对新增行的后续处理在这里进行
        /// </summary>
        /// <param name="para">新增的行参数</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        //[IsImplement(true)]
        public override void RowAdded(UFIDA.U8.UAP.UI.Runtime.Common.RowChangeEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 增加行之前的接口，对行的合法性检查在这里进行
        /// </summary>
        /// <param name="para">新增的行参数</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        /// <returns>是否允许增加新行，false-不允许增加新的行</returns>
        public override bool RowAdding(UFIDA.U8.UAP.UI.Runtime.Common.RowChangeEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 鼠标左键双击数据行的接口
        /// </summary>
        /// <param name="para">鼠标双击信息</param>
        /// <param name="businessObject"></param>
        /// <param name="voucherObject"></param>
        public override void RowDoubleClick(UFIDA.U8.UAP.UI.Runtime.Common.RowDoubleClickEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 设置为当前行之后的接口
        /// </summary>
        /// <param name="para">被选择的行参数</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        public override void RowSelected(UFIDA.U8.UAP.UI.Runtime.Common.RowSelectEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 设置为当前行之前的接口
        /// </summary>
        /// <param name="para">被选择的行参数</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        /// <returns>是否允许选择新行，false--不允许选择新行，当前行不发生改变</returns>
        public override bool RowSelecting(UFIDA.U8.UAP.UI.Runtime.Common.RowSelectEventArgs para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 删除行之后的接口，对删除行的后续处理在这里进行
        /// </summary>
        /// <param name="para">RowChangeEventArgs[]类型，要删除的行参数</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        public override void RowsDeleted(UFIDA.U8.UAP.UI.Runtime.Common.RowChangeEventArgs[] para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 删除行之前的接口，对行的合法性检查在这里进行
        /// </summary>
        /// <param name="para">RowChangeEventArgs[]类型，要删除的行参数</param>
        /// <param name="businessObject">所属业务对象</param>
        /// <param name="voucherObject">所属表单对象</param>
        /// <returns>是否允许删除这些行，false--不允许删除这些行</returns>
        public override bool RowsDeleting(UFIDA.U8.UAP.UI.Runtime.Common.RowChangeEventArgs[] para, BusinessProxy businessObject, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 表单状态更新之后的接口
        /// </summary>
        /// <param name="para">状态的变动参数</param>
        /// <param name="voucherObject">所属表单对象</param>
        //[IsImplement(true)]
        public override void StateChanged(UFIDA.U8.UAP.UI.Runtime.Common.VoucherStateChangeEventArgs para, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// 表单状态更新之前的接口
        /// </summary>
        /// <param name="para">状态的变动参数</param>
        /// <param name="voucherObject">所属表单对象</param>
        /// <returns>是否允许改变状态 false-不允许改变状态，表单仍将处于当前状态</returns>
        public override bool StateChanging(UFIDA.U8.UAP.UI.Runtime.Common.VoucherStateChangeEventArgs para, VoucherProxy voucherObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion


        #region 自定义函数
        private void OpenNewVoucher(U8Login.clsLogin login, UFIDA.U8.UAP.UI.Runtime.Common.CellDoubleClickEventArgs para, Business E003)
        {

            string key = para.RowKey;
            BGXiangqing newform = new BGXiangqing(login);
            // newform.U8Login = login;
            newform.ShowDialog();
            BGModel objinfo = newform.objinfo;
            E003.Rows[key].Cells["bgbm"].Value = objinfo.Bgbm;

            E003.Rows[key].Cells["bgmc"].Value = objinfo.Chflmc;
            E003.Rows[key].Cells["bglb"].Value = objinfo.Chfl;
            E003.Rows[key].Cells["hwh"].Value = objinfo.Hwh;



            //VoucherUserControl newvoucher = new VoucherUserControl();
            //newvoucher.OpenVoucherByDialog(login, "GSEFHS01_0002", "弹出版辊详情录入界面", "<property cardnum=\"HS01_0002\"  type=\"voucher\"/>");
        }
        #endregion
    }
}
