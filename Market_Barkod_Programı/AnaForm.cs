using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Market_Barkod_Programı
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        pages.Satis_islemleri satis_İslemleri;
        pages.Anlik_satis anlik_Satis;

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (satis_İslemleri == null)
            {
                satis_İslemleri = new pages.Satis_islemleri();
                satis_İslemleri.MdiParent = this;
                satis_İslemleri.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anlik_Satis == null)
            {
                anlik_Satis = new pages.Anlik_satis();
                anlik_Satis.MdiParent = this;
                anlik_Satis.Show();
            }
        }
    }
}
