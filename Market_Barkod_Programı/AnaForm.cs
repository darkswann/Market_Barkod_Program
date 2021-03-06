using Market_Barkod_Programı.pages;
using System;
using System.Linq;
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


        public class GlobalClass
        {
            public static string hata = string.Empty;
            public static string aktif = string.Empty;
        }
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (satis_İslemleri == null || satis_İslemleri.IsDisposed)
                {
                    satis_İslemleri = new pages.Satis_islemleri();
                    satis_İslemleri.MdiParent = this;
                    satis_İslemleri.Show();
                }
                else
                {
                    satis_İslemleri.Activate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem13 + Log.hatames + ex.ToString());
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (anlik_Satis == null || anlik_Satis.IsDisposed)
                {
                    anlik_Satis = new pages.Anlik_satis();
                    anlik_Satis.MdiParent = this;
                    anlik_Satis.Show();
                }
                else
                {
                    anlik_Satis.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem14 + Log.hatames + ex.ToString());
            }
        }


        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (stok_İslemleri == null || stok_İslemleri.IsDisposed)
                {
                    stok_İslemleri = new pages.Stok_islemleri();
                    stok_İslemleri.MdiParent = this;
                    stok_İslemleri.Show();
                }
                else
                {
                    stok_İslemleri.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem10 + Log.hatames + ex.ToString());
            }

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (Anlik_Stok_Durumu == null || Anlik_Stok_Durumu.IsDisposed)
                {
                    Anlik_Stok_Durumu = new pages.Anlik_Stok_Durumu();
                    Anlik_Stok_Durumu.MdiParent = this;
                    Anlik_Stok_Durumu.Show();
                }
                else
                {
                    Anlik_Stok_Durumu.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem11 + Log.hatames + ex.ToString());
            }


        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (stok_listesi == null || stok_listesi.IsDisposed)
                {
                    stok_listesi = new pages.Stok_listesi();
                    stok_listesi.MdiParent = this;
                    stok_listesi.Show();
                }
                else
                {
                    stok_listesi.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem12 + Log.hatames + ex.ToString());
            }

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (Gunluk_Satis_Raporu == null || Gunluk_Satis_Raporu.IsDisposed)
                {
                    Gunluk_Satis_Raporu = new pages.Gunluk_Satis_Raporu();
                    Gunluk_Satis_Raporu.MdiParent = this;
                    Gunluk_Satis_Raporu.Show();
                }
                else
                {
                    Gunluk_Satis_Raporu.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem8 + Log.hatames + ex.ToString());
            }

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (Aylik_Satis_Raporu == null || Aylik_Satis_Raporu.IsDisposed)
                {
                    Aylik_Satis_Raporu = new pages.Aylik_Satis_Raporu();
                    Aylik_Satis_Raporu.MdiParent = this;
                    Aylik_Satis_Raporu.Show();
                }
                else
                {
                    Aylik_Satis_Raporu.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem15 + Log.hatames + ex.ToString());
            }

        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (Raporu_Mail_Gonder == null || Raporu_Mail_Gonder.IsDisposed)
                {
                    Raporu_Mail_Gonder = new pages.Raporu_Mail_Gonder();
                    Raporu_Mail_Gonder.MdiParent = this;
                    Raporu_Mail_Gonder.Show();
                }
                else
                {
                    Raporu_Mail_Gonder.Activate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem17 + Log.hatames + ex.ToString());
            }

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            try
            {
                if (Kullanici_Islemleri == null || Kullanici_Islemleri.IsDisposed)
                {
                    Kullanici_Islemleri = new pages.Kullanici_Islemleri();
                    Kullanici_Islemleri.MdiParent = this;
                    Kullanici_Islemleri.Show();
                }
                else
                {
                    Kullanici_Islemleri.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem18 + Log.hatames + ex.ToString());
            }

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (Cari == null || Cari.IsDisposed)
                {
                    Cari = new pages.Cari();
                    Cari.MdiParent = this;
                    Cari.Show();
                }
                else
                {
                    Cari.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem19 + Log.hatames + ex.ToString());
            }

        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            try
            {
                if (Cari_Listesi == null || Cari_Listesi.IsDisposed)
                {
                    Cari_Listesi = new pages.Cari_Listesi();
                    Cari_Listesi.MdiParent = this;
                    Cari_Listesi.Show();
                }
                else
                {
                    Cari_Listesi.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem20 + Log.hatames + ex.ToString());
            }

        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (Cari_Alacaklandır == null || Cari_Alacaklandır.IsDisposed)
                {
                    Cari_Alacaklandır = new pages.Cari_Alacaklandır();
                    Cari_Alacaklandır.MdiParent = this;
                    Cari_Alacaklandır.Show();
                }
                else
                {
                    Cari_Alacaklandır.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem21 + Log.hatames + ex.ToString());
            }

        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (Cari_Borcland == null || Cari_Borcland.IsDisposed)
                {
                    Cari_Borcland = new pages.Cari_Borclandır();
                    Cari_Borcland.MdiParent = this;
                    Cari_Borcland.Show();
                }
                else
                {
                    Cari_Borcland.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem22 + Log.hatames + ex.ToString());
            }


        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Kasa == null || Kasa.IsDisposed)
                {
                    Kasa = new pages.Kasa();
                    Kasa.MdiParent = this;
                    Kasa.Show();
                }
                else
                {
                    Kasa.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem23 + Log.hatames + ex.ToString());
            }
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Kasa_Listesi == null || Kasa_Listesi.IsDisposed)
                {
                    Kasa_Listesi = new pages.Kasa_Listesi();
                    Kasa_Listesi.MdiParent = this;
                    Kasa_Listesi.Show();
                }
                else
                {
                    Kasa_Listesi.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(barButtonItem24 + Log.hatames + ex.ToString());
            }
        }
    }
}
