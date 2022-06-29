namespace Market_Barkod_Programı.pages
{
    partial class Gunluk_Satis_Raporu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kasiyer = new System.Windows.Forms.ComboBox();
            this.cmd_urun_cinsi = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarih
            // 
            this.tarih.EditValue = new System.DateTime(2018, 11, 29, 0, 0, 0, 0);
            this.tarih.Location = new System.Drawing.Point(94, 54);
            this.tarih.Name = "tarih";
            this.tarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.tarih.Properties.Appearance.Options.UseFont = true;
            this.tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tarih.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.tarih.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.tarih.Size = new System.Drawing.Size(160, 30);
            this.tarih.TabIndex = 53;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(570, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 24);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "TOPLAM ADET:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(549, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(170, 24);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "TOPLAM TUTAR :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(495, 49);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(69, 32);
            this.simpleButton2.TabIndex = 47;
            this.simpleButton2.Text = "Ara";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(260, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 28);
            this.simpleButton1.TabIndex = 48;
            this.simpleButton1.Text = "Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(260, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Kasiyer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ürün Cinsi:";
            // 
            // kasiyer
            // 
            this.kasiyer.Font = new System.Drawing.Font("Tahoma", 12F);
            this.kasiyer.FormattingEnabled = true;
            this.kasiyer.Location = new System.Drawing.Point(329, 54);
            this.kasiyer.Name = "kasiyer";
            this.kasiyer.Size = new System.Drawing.Size(160, 27);
            this.kasiyer.TabIndex = 42;
            // 
            // cmd_urun_cinsi
            // 
            this.cmd_urun_cinsi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmd_urun_cinsi.FormattingEnabled = true;
            this.cmd_urun_cinsi.Location = new System.Drawing.Point(94, 8);
            this.cmd_urun_cinsi.Name = "cmd_urun_cinsi";
            this.cmd_urun_cinsi.Size = new System.Drawing.Size(160, 27);
            this.cmd_urun_cinsi.TabIndex = 43;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textBox2);
            this.panelControl1.Controls.Add(this.textBox1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.tarih);
            this.panelControl1.Controls.Add(this.cmd_urun_cinsi);
            this.panelControl1.Controls.Add(this.kasiyer);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Location = new System.Drawing.Point(13, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(928, 90);
            this.panelControl1.TabIndex = 54;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(725, 49);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 28);
            this.textBox2.TabIndex = 55;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(725, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 28);
            this.textBox1.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(928, 474);
            this.dataGridView1.TabIndex = 55;
            // 
            // Gunluk_Satis_Raporu
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Gunluk_Satis_Raporu";
            this.Text = "Gunluk_Satis_Raporu";
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit tarih;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kasiyer;
        private System.Windows.Forms.ComboBox cmd_urun_cinsi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}