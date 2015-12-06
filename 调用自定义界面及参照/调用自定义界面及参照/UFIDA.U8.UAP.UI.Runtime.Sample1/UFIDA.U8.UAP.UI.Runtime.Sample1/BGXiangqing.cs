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
            objinfo.Bgbm = this.textBox5.Text;//�������

            this.Close();
        }
        /// <summary>
        /// ���ս���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            object textValue = null; //����һ������������ؽ���Ĳ���
            if (SelectRef("InventoryClass_AA", this.textBox1.Text, U8Login, out textValue))
                textBox1.Text = textValue as string;
        }

        //�����������

        // D:\U8Soft\Interop\Interop.U8RefService.dll

        // D:\U8Soft\Interop\Adodb.dll



        //������refObjectId,����ID���ɲο�UAP�����еĲ��������

        //      filltext,����ı�������һ����ֵ�����ս����ʱ��ѡ�и����ݶ�Ӧ��¼,һ��ʹ���ϴ�ѡ��Ľ�����ɡ���ֵʱ���ս�����ʾȫ�����ݡ�

        //      u8loginObject:U8��¼����

        private bool SelectRef(string refObjectId, string filltext, object u8loginObject, out object returnValue)
        {
            ADODB.Recordset retRstGrid = null; //�����Microsoft ADO RecordSet����COM��������շ���ķ��ؽ���ᱣ����������ݼ���
            ADODB.Recordset retRstClass = null; //���һ��û���ã������շ���ӿ��ж����ˣ����봫�����
            U8RefService.IServiceClass refservice;
            string errMsg = null;  //��Ϊ���շ�������������������շ���Ĵ�����Ϣ���������Ļ���

            //�������շ������
            refservice = new U8RefService.IServiceClass();

            //����ģʽ�Ͳ���
            refservice.Mode = U8RefService.RefModes.modeRefing;
            refservice.RefID = refObjectId;
            refservice.FillText = filltext;
            //����ѡ��XML�����ı�
            refservice.MetaXML = "<Ref><RefSet bAuth='1'  authFunID='W' iFilterStyle='1' bMultiSel='0'/></Ref>";

            //��ҪΪ���մ��ڶ���һ���������ھ�����������������κδ�Control��������
            //Ŀ���Ǳ�֤���մ��ڲ������������ڵ������û�к��ʵ����д����ȥ����
            refservice.GetPortalHwnd((int)this.Handle); //this.Handle�滻Ϊ�κ���Ч���ڻ�ؼ���Handler����

            if (refservice.ShowRefSecond(ref u8loginObject, ref retRstClass, ref retRstGrid, ref errMsg) == false)
            {
                //����ѡ��ʧ�ܡ�������Ϣ������errMsg��
                MessageBox.Show(errMsg);
                returnValue = null;
                return false;
            }
            else
            {
                //���շ��سɹ�
                //�������ݱ�����retRstGrid������
                if (retRstGrid != null)
                {
                    //ѡ��������
                    retRstGrid.MoveFirst(); //retRstGrid�����α꣬��Ҫ������¼λ�ã�һ������·��صļ�¼ֻ��һ��
                    //�ӵ�ǰ��¼λ���л�ȡ���ؽ����������п��ܰ�������ֶΣ�����Ӧ����Ҫȡ�ᡣ
                    //cPsn_NumΪ��Ա���룬cPsn_NameΪ��Ա����
                    returnValue = retRstGrid.Fields["cInvCName"].Value; //FieldName�滻�ɷ��������е����ƻ�����ֶΡ�
                }
                else
                {
                    //δѡ������
                    MessageBox.Show("ȡ��ѡ��");
                    returnValue = null;
                    return false;
                }
            }

            //�ͷ�COM����
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
            objinfo.Bgbm = this.textBox5.Text;//�������

            this.Close();
        }

        
    }
}