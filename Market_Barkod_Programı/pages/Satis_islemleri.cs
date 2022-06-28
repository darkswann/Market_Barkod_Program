using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Barkod_Programı.pages
{
    public partial class Satis_islemleri : DevExpress.XtraEditors.XtraForm
    {
        public Satis_islemleri()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            textEdit1.Height = 40;
            textEdit1.Width = 300;
        }
    }
}