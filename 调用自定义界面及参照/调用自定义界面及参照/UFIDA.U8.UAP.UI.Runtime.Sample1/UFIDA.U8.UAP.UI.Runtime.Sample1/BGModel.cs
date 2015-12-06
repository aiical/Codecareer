using System;
using System.Collections.Generic;
using System.Text;

namespace UFIDA.U8.UAP.UI.Runtime.Sample1
{
    public class BGModel
    {
        public BGModel()
        { }

        #region
        string _bgbm;
        string _chfl;
        string _chflmc;
        string _lb;
        string _hwh;

        public string Bgbm
        {
            get { return _bgbm; }
            set { _bgbm = value; }
        }

        public string Chfl
        {
            get { return _chfl; }
            set { _chfl = value; }
        }
        public string Chflmc
        {
            get { return _chflmc; }
            set { _chflmc = value; }
        }

        public string Lb
        {
            get { return _lb; }
            set { _lb = value; }
        }
        public string Hwh
        {
            get { return _hwh; }
            set { _hwh = value; }
        }

        #endregion

    }
}
