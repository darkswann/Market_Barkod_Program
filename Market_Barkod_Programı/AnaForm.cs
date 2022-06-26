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
        pages.Stok_islemleri stok_İslemleri;
        pages.Stok_listesi stok_listesi;
        pages.Raporu_Mail_Gonder Raporu_Mail_Gonder;
        pages.Kullanici_Islemleri Kullanici_Islemleri;
        pages.Kasa_Listesi Kasa_Listesi;
        pages.Kasa Kasa;
        pages.Gunluk_Satis_Raporu Gunluk_Satis_Raporu;
        pages.Cari_Listesi Cari_Listesi;
        pages.Cari_Borclandır Cari_Borcland;
        pages.Cari_Alacaklandır Cari_Alacaklandır;
        pages.Cari Cari;
        pages.Aylik_Satis_Raporu Aylik_Satis_Raporu;
        pages.Anlik_Stok_Durumu Anlik_Stok_Durumu;
        

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (satis_İslemleri == null)
            {
                satis_İslemleri = new pages.Satis_islemleri();
                satis_İslemleri.MdiParent = this;
                satis_İslemleri.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anlik_Satis == null)
            {
                anlik_Satis = new pages.Anlik_satis();
                anlik_Satis.MdiParent = this;
                anlik_Satis.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stok_İslemleri == null)
            {
                stok_İslemleri = new pages.Stok_islemleri();
                stok_İslemleri.MdiParent = this;
                stok_İslemleri.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Anlik_Stok_Durumu == null)
            {
                Anlik_Stok_Durumu = new pages.Anlik_Stok_Durumu();
                Anlik_Stok_Durumu.MdiParent = this;
                Anlik_Stok_Durumu.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stok_listesi == null)
            {
                stok_listesi = new pages.Stok_listesi();
                stok_listesi.MdiParent = this;
                stok_listesi.Show();
            }
        }
    }
}
