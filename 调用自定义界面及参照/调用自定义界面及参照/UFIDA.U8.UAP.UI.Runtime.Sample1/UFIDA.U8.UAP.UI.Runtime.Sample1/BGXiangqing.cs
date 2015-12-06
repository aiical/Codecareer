using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Interop.U8LogService;

namespace UFIDA.U8.UAP.UI.Runtime.Sample1
{
    public partial class BGXiangqing : Form
    {
        public BGModel objinfo;

        public U8Login.clsLogin U8Login;

        public BGXiangqing(U8Login.clsLogin loginObject)
        {
            InitializeComponent();
            this.U8Login = loginObject;

        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            objinfo = new BGModel();
            objinfo.Chfl = this.textBox1.Text;
            objinfo.Chflmc = this.textBox2.Text;
            objinfo.Lb = this.textBox3.Text;
            objinfo.Hwh = this.textBox4.Text;
            objinfo.Bgbm = this.textBox5.Text;//版辊编码

            this.Close();
        }
        /// <summary>
        /// 参照界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            object textValue = null; //定义一个用于输出返回结果的参数
            if (SelectRef("InventoryClass_AA", this.textBox1.Text, U8Login, out textValue))
                textBox1.Text = textValue as string;
        }

        //添加以下引用

        // D:\U8Soft\Interop\Interop.U8RefService.dll

        // D:\U8Soft\Interop\Adodb.dll



        //参数：refObjectId,参照ID，可参考UAP工具中的参照设计器

        //      filltext,填充文本，传入一个数值，参照界面打开时会选中该数据对应记录,一般使用上次选择的结果即可。空值时参照界面显示全部数据。

        //      u8loginObject:U8登录对象

        private bool SelectRef(string refObjectId, string filltext, object u8loginObject, out object returnValue)
        {
            ADODB.Recordset retRstGrid = null; //这个是Microsoft ADO RecordSet对象，COM组件，参照服务的返回结果会保存在这个数据集中
            ADODB.Recordset retRstClass = null; //这个一般没有用，但参照服务接口中定义了，必须传入参数
            U8RefService.IServiceClass refservice;
            string errMsg = null;  //作为参照服务的输出参数，保存参照服务的错误信息（如果出错的话）

            //创建参照服务对象
            refservice = new U8RefService.IServiceClass();

            //设置模式和参数
            refservice.Mode = U8RefService.RefModes.modeRefing;
            refservice.RefID = refObjectId;
            refservice.FillText = filltext;
            //参照选项XML配置文本
            refservice.MetaXML = "<Ref><RefSet bAuth='1'  authFunID='W' iFilterStyle='1' bMultiSel='0'/></Ref>";

            //需要为参照窗口定义一个父级窗口句柄，这个句柄可以是任何从Control类派生的
            //目的是保证参照窗口不被其他窗口遮挡。如果没有合适的这行代码可去掉。
            refservice.GetPortalHwnd((int)this.Handle); //this.Handle替换为任何有效窗口或控件的Handler属性

            if (refservice.ShowRefSecond(ref u8loginObject, ref retRstClass, ref retRstGrid, ref errMsg) == false)
            {
                //参照选择失败。错误信息保存在errMsg中
                MessageBox.Show(errMsg);
                returnValue = null;
                return false;
            }
            else
            {
                //参照返回成功
                //返回数据保存在retRstGrid对象中
                if (retRstGrid != null)
                {
                    //选择了数据
                    retRstGrid.MoveFirst(); //retRstGrid类似游标，需要滚动记录位置，一般情况下返回的记录只有一行
                    //从当前记录位置中获取返回结果，结果行中可能包含多个字段，根据应用需要取舍。
                    //cPsn_Num为人员编码，cPsn_Name为人员姓名
                    returnValue = retRstGrid.Fields["cInvCName"].Value; //FieldName替换成返回数据中的名称或编码字段。
                }
                else
                {
                    //未选择数据
                    MessageBox.Show("取消选择");
                    returnValue = null;
                    return false;
                }
            }

            //释放COM对象
            System.Runtime.InteropServices.Marshal.ReleaseComObject(refservice);


            return true;
        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            objinfo = new BGModel();
            objinfo.Chfl = this.textBox1.Text;
            objinfo.Chflmc = this.textBox2.Text;
            objinfo.Lb = this.textBox3.Text;
            objinfo.Hwh = this.textBox4.Text;
            objinfo.Bgbm = this.textBox5.Text;//版辊编码

            this.Close();
        }

        
    }
}