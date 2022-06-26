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

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Gunluk_Satis_Raporu == null)
            {
                Gunluk_Satis_Raporu = new pages.Gunluk_Satis_Raporu();
                Gunluk_Satis_Raporu.MdiParent = this;
                Gunluk_Satis_Raporu.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Aylik_Satis_Raporu == null)
            {
                Aylik_Satis_Raporu = new pages.Aylik_Satis_Raporu();
                Aylik_Satis_Raporu.MdiParent = this;
                Aylik_Satis_Raporu.Show();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Raporu_Mail_Gonder == null)
            {
                Raporu_Mail_Gonder = new pages.Raporu_Mail_Gonder();
                Raporu_Mail_Gonder.MdiParent = this;
                Raporu_Mail_Gonder.Show();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Kullanici_Islemleri == null)
            {
                Kullanici_Islemleri = new pages.Kullanici_Islemleri();
                Kullanici_Islemleri.MdiParent = this;
                Kullanici_Islemleri.Show();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Cari == null)
            {
                Cari = new pages.Cari();
                Cari.MdiParent = this;
                Cari.Show();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Cari_Listesi == null)
            {
                Cari_Listesi = new pages.Cari_Listesi();
                Cari_Listesi.MdiParent = this;
                Cari_Listesi.Show();
            }
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Cari_Alacaklandır == null)
            {
                Cari_Alacaklandır = new pages.Cari_Alacaklandır();
                Cari_Alacaklandır.MdiParent = this;
                Cari_Alacaklandır.Show();
            }
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Cari_Borcland == null)
            {
                Cari_Borcland = new pages.Cari_Borclandır();
                Cari_Borcland.MdiParent = this;
                Cari_Borcland.Show();
            }
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Kasa == null)
            {
                Kasa = new pages.Kasa();
                Kasa.MdiParent = this;
                Kasa.Show();
            }
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Kasa_Listesi == null)
            {
                Kasa_Listesi = new pages.Kasa_Listesi();
                Kasa_Listesi.MdiParent = this;
                Kasa_Listesi.Show();
            }
        }
    }
}
