namespace OgrenciDersSecmeSistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOgrenciIsleri = new System.Windows.Forms.TabPage();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtGano = new System.Windows.Forms.TextBox();
            this.txtDersAdı = new System.Windows.Forms.TextBox();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.txtKontenjan = new System.Windows.Forms.TextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.tabPageOgrenci = new System.Windows.Forms.TabPage();
            this.lbSeçilenDersler = new System.Windows.Forms.ListBox();
            this.lbSeçilebilirDersler = new System.Windows.Forms.ListBox();
            this.btnDersEkleOgrenci = new System.Windows.Forms.Button();
            this.btnDersSilOgrenci = new System.Windows.Forms.Button();
            this.lblToplamKredi = new System.Windows.Forms.Label();
            this.btnGönder = new System.Windows.Forms.Button();
            this.tabPageDanisman = new System.Windows.Forms.TabPage();
            this.dgvDanismanOgrenciler = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnGeriGönder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogubsDataSet = new OgrenciDersSecmeSistemi.ogubsDataSet();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencilerTableAdapter = new OgrenciDersSecmeSistemi.ogubsDataSetTableAdapters.OgrencilerTableAdapter();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gANODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogubsDataSet1 = new OgrenciDersSecmeSistemi.ogubsDataSet1();
            this.ogrenciDersleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciDersleriTableAdapter = new OgrenciDersSecmeSistemi.ogubsDataSet1TableAdapters.OgrenciDersleriTableAdapter();
            this.ogrenciIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oNAYDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageOgrenciIsleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.tabPageOgrenci.SuspendLayout();
            this.tabPageDanisman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanismanOgrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogubsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageOgrenciIsleri);
            this.tabControl.Controls.Add(this.tabPageOgrenci);
            this.tabControl.Controls.Add(this.tabPageDanisman);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 600);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageOgrenciIsleri
            // 
            this.tabPageOgrenciIsleri.Controls.Add(this.label6);
            this.tabPageOgrenciIsleri.Controls.Add(this.label5);
            this.tabPageOgrenciIsleri.Controls.Add(this.label4);
            this.tabPageOgrenciIsleri.Controls.Add(this.label3);
            this.tabPageOgrenciIsleri.Controls.Add(this.label2);
            this.tabPageOgrenciIsleri.Controls.Add(this.label1);
            this.tabPageOgrenciIsleri.Controls.Add(this.dgvOgrenciler);
            this.tabPageOgrenciIsleri.Controls.Add(this.txtAd);
            this.tabPageOgrenciIsleri.Controls.Add(this.txtSoyad);
            this.tabPageOgrenciIsleri.Controls.Add(this.txtGano);
            this.tabPageOgrenciIsleri.Controls.Add(this.txtDersAdı);
            this.tabPageOgrenciIsleri.Controls.Add(this.txtKredi);
            this.tabPageOgrenciIsleri.Controls.Add(this.txtKontenjan);
            this.tabPageOgrenciIsleri.Controls.Add(this.btnOgrenciEkle);
            this.tabPageOgrenciIsleri.Controls.Add(this.btnDersEkle);
            this.tabPageOgrenciIsleri.Controls.Add(this.btnGuncelle);
            this.tabPageOgrenciIsleri.Controls.Add(this.btnSil);
            this.tabPageOgrenciIsleri.Location = new System.Drawing.Point(4, 25);
            this.tabPageOgrenciIsleri.Name = "tabPageOgrenciIsleri";
            this.tabPageOgrenciIsleri.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOgrenciIsleri.Size = new System.Drawing.Size(792, 571);
            this.tabPageOgrenciIsleri.TabIndex = 0;
            this.tabPageOgrenciIsleri.Text = "Öğrenci İşleri Memuru";
            this.tabPageOgrenciIsleri.UseVisualStyleBackColor = true;
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.AutoGenerateColumns = false;
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.gANODataGridViewTextBoxColumn,
            this.kayitTarihiDataGridViewTextBoxColumn});
            this.dgvOgrenciler.DataSource = this.ogrencilerBindingSource;
            this.dgvOgrenciler.Location = new System.Drawing.Point(21, 354);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.RowHeadersWidth = 51;
            this.dgvOgrenciler.Size = new System.Drawing.Size(750, 150);
            this.dgvOgrenciler.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(200, 82);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(200, 133);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtGano
            // 
            this.txtGano.Location = new System.Drawing.Point(200, 185);
            this.txtGano.Name = "txtGano";
            this.txtGano.Size = new System.Drawing.Size(200, 22);
            this.txtGano.TabIndex = 3;
            // 
            // txtDersAdı
            // 
            this.txtDersAdı.Location = new System.Drawing.Point(200, 237);
            this.txtDersAdı.Name = "txtDersAdı";
            this.txtDersAdı.Size = new System.Drawing.Size(200, 22);
            this.txtDersAdı.TabIndex = 4;
            // 
            // txtKredi
            // 
            this.txtKredi.Location = new System.Drawing.Point(125, 292);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(100, 22);
            this.txtKredi.TabIndex = 5;
            // 
            // txtKontenjan
            // 
            this.txtKontenjan.Location = new System.Drawing.Point(360, 292);
            this.txtKontenjan.Name = "txtKontenjan";
            this.txtKontenjan.Size = new System.Drawing.Size(100, 22);
            this.txtKontenjan.TabIndex = 6;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(549, 82);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(100, 30);
            this.btnOgrenciEkle.TabIndex = 7;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(549, 133);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(100, 30);
            this.btnDersEkle.TabIndex = 8;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(549, 185);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 30);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(549, 237);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tabPageOgrenci
            // 
            this.tabPageOgrenci.Controls.Add(this.lbSeçilenDersler);
            this.tabPageOgrenci.Controls.Add(this.lbSeçilebilirDersler);
            this.tabPageOgrenci.Controls.Add(this.btnDersEkleOgrenci);
            this.tabPageOgrenci.Controls.Add(this.btnDersSilOgrenci);
            this.tabPageOgrenci.Controls.Add(this.lblToplamKredi);
            this.tabPageOgrenci.Controls.Add(this.btnGönder);
            this.tabPageOgrenci.Location = new System.Drawing.Point(4, 25);
            this.tabPageOgrenci.Name = "tabPageOgrenci";
            this.tabPageOgrenci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOgrenci.Size = new System.Drawing.Size(792, 571);
            this.tabPageOgrenci.TabIndex = 1;
            this.tabPageOgrenci.Text = "Öğrenci Paneli";
            this.tabPageOgrenci.UseVisualStyleBackColor = true;
            // 
            // lbSeçilenDersler
            // 
            this.lbSeçilenDersler.FormattingEnabled = true;
            this.lbSeçilenDersler.ItemHeight = 16;
            this.lbSeçilenDersler.Location = new System.Drawing.Point(300, 30);
            this.lbSeçilenDersler.Name = "lbSeçilenDersler";
            this.lbSeçilenDersler.Size = new System.Drawing.Size(200, 148);
            this.lbSeçilenDersler.TabIndex = 0;
            // 
            // lbSeçilebilirDersler
            // 
            this.lbSeçilebilirDersler.FormattingEnabled = true;
            this.lbSeçilebilirDersler.ItemHeight = 16;
            this.lbSeçilebilirDersler.Location = new System.Drawing.Point(20, 30);
            this.lbSeçilebilirDersler.Name = "lbSeçilebilirDersler";
            this.lbSeçilebilirDersler.Size = new System.Drawing.Size(200, 148);
            this.lbSeçilebilirDersler.TabIndex = 1;
            // 
            // btnDersEkleOgrenci
            // 
            this.btnDersEkleOgrenci.Location = new System.Drawing.Point(240, 30);
            this.btnDersEkleOgrenci.Name = "btnDersEkleOgrenci";
            this.btnDersEkleOgrenci.Size = new System.Drawing.Size(40, 30);
            this.btnDersEkleOgrenci.TabIndex = 2;
            this.btnDersEkleOgrenci.Text = ">";
            this.btnDersEkleOgrenci.UseVisualStyleBackColor = true;
            this.btnDersEkleOgrenci.Click += new System.EventHandler(this.btnDersEkleOgrenci_Click);
            // 
            // btnDersSilOgrenci
            // 
            this.btnDersSilOgrenci.Location = new System.Drawing.Point(240, 77);
            this.btnDersSilOgrenci.Name = "btnDersSilOgrenci";
            this.btnDersSilOgrenci.Size = new System.Drawing.Size(40, 30);
            this.btnDersSilOgrenci.TabIndex = 3;
            this.btnDersSilOgrenci.Text = "<";
            this.btnDersSilOgrenci.UseVisualStyleBackColor = true;
            this.btnDersSilOgrenci.Click += new System.EventHandler(this.btnDersSilOgrenci_Click);
            // 
            // lblToplamKredi
            // 
            this.lblToplamKredi.AutoSize = true;
            this.lblToplamKredi.Location = new System.Drawing.Point(20, 200);
            this.lblToplamKredi.Name = "lblToplamKredi";
            this.lblToplamKredi.Size = new System.Drawing.Size(94, 16);
            this.lblToplamKredi.TabIndex = 4;
            this.lblToplamKredi.Text = "Toplam Kredi: ";
            // 
            // btnGönder
            // 
            this.btnGönder.Location = new System.Drawing.Point(339, 200);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(100, 30);
            this.btnGönder.TabIndex = 5;
            this.btnGönder.Text = "Ders Seç";
            this.btnGönder.UseVisualStyleBackColor = true;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // tabPageDanisman
            // 
            this.tabPageDanisman.Controls.Add(this.dgvDanismanOgrenciler);
            this.tabPageDanisman.Controls.Add(this.btnOnayla);
            this.tabPageDanisman.Controls.Add(this.btnGeriGönder);
            this.tabPageDanisman.Location = new System.Drawing.Point(4, 25);
            this.tabPageDanisman.Name = "tabPageDanisman";
            this.tabPageDanisman.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDanisman.Size = new System.Drawing.Size(792, 571);
            this.tabPageDanisman.TabIndex = 2;
            this.tabPageDanisman.Text = "Danışman Hoca Paneli";
            this.tabPageDanisman.UseVisualStyleBackColor = true;
            // 
            // dgvDanismanOgrenciler
            // 
            this.dgvDanismanOgrenciler.AutoGenerateColumns = false;
            this.dgvDanismanOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanismanOgrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn1,
            this.dersIDDataGridViewTextBoxColumn,
            this.oNAYDataGridViewCheckBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn});
            this.dgvDanismanOgrenciler.DataSource = this.ogrenciDersleriBindingSource;
            this.dgvDanismanOgrenciler.Location = new System.Drawing.Point(20, 50);
            this.dgvDanismanOgrenciler.Name = "dgvDanismanOgrenciler";
            this.dgvDanismanOgrenciler.RowHeadersWidth = 51;
            this.dgvDanismanOgrenciler.Size = new System.Drawing.Size(750, 150);
            this.dgvDanismanOgrenciler.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(250, 220);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(100, 30);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnGeriGönder
            // 
            this.btnGeriGönder.Location = new System.Drawing.Point(360, 220);
            this.btnGeriGönder.Name = "btnGeriGönder";
            this.btnGeriGönder.Size = new System.Drawing.Size(100, 30);
            this.btnGeriGönder.TabIndex = 2;
            this.btnGeriGönder.Text = "Geri Gönder";
            this.btnGeriGönder.UseVisualStyleBackColor = true;
            this.btnGeriGönder.Click += new System.EventHandler(this.btnGeriGönder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "GANO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ders Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kredi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kontenjan :";
            // 
            // ogubsDataSet
            // 
            this.ogubsDataSet.DataSetName = "ogubsDataSet";
            this.ogubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerBindingSource
            // 
            this.ogrencilerBindingSource.DataMember = "Ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.ogubsDataSet;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // gANODataGridViewTextBoxColumn
            // 
            this.gANODataGridViewTextBoxColumn.DataPropertyName = "GANO";
            this.gANODataGridViewTextBoxColumn.HeaderText = "GANO";
            this.gANODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gANODataGridViewTextBoxColumn.Name = "gANODataGridViewTextBoxColumn";
            this.gANODataGridViewTextBoxColumn.Width = 125;
            // 
            // kayitTarihiDataGridViewTextBoxColumn
            // 
            this.kayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.HeaderText = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihiDataGridViewTextBoxColumn.Name = "kayitTarihiDataGridViewTextBoxColumn";
            this.kayitTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogubsDataSet1
            // 
            this.ogubsDataSet1.DataSetName = "ogubsDataSet1";
            this.ogubsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciDersleriBindingSource
            // 
            this.ogrenciDersleriBindingSource.DataMember = "OgrenciDersleri";
            this.ogrenciDersleriBindingSource.DataSource = this.ogubsDataSet1;
            // 
            // ogrenciDersleriTableAdapter
            // 
            this.ogrenciDersleriTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciIDDataGridViewTextBoxColumn1
            // 
            this.ogrenciIDDataGridViewTextBoxColumn1.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn1.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn1.Name = "ogrenciIDDataGridViewTextBoxColumn1";
            this.ogrenciIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // oNAYDataGridViewCheckBoxColumn
            // 
            this.oNAYDataGridViewCheckBoxColumn.DataPropertyName = "ONAY";
            this.oNAYDataGridViewCheckBoxColumn.HeaderText = "ONAY";
            this.oNAYDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.oNAYDataGridViewCheckBoxColumn.Name = "oNAYDataGridViewCheckBoxColumn";
            this.oNAYDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            this.ogrenciAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Öğrenci Ders Seçme Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl.ResumeLayout(false);
            this.tabPageOgrenciIsleri.ResumeLayout(false);
            this.tabPageOgrenciIsleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.tabPageOgrenci.ResumeLayout(false);
            this.tabPageOgrenci.PerformLayout();
            this.tabPageDanisman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanismanOgrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogubsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOgrenciIsleri;
        private System.Windows.Forms.TabPage tabPageOgrenci;
        private System.Windows.Forms.TabPage tabPageDanisman;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtGano;
        private System.Windows.Forms.TextBox txtDersAdı;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.TextBox txtKontenjan;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lbSeçilenDersler;
        private System.Windows.Forms.ListBox lbSeçilebilirDersler;
        private System.Windows.Forms.Button btnDersEkleOgrenci;
        private System.Windows.Forms.Button btnDersSilOgrenci;
        private System.Windows.Forms.Label lblToplamKredi;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.DataGridView dgvDanismanOgrenciler;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnGeriGönder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ogubsDataSet ogubsDataSet;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private ogubsDataSetTableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gANODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
        private ogubsDataSet1 ogubsDataSet1;
        private System.Windows.Forms.BindingSource ogrenciDersleriBindingSource;
        private ogubsDataSet1TableAdapters.OgrenciDersleriTableAdapter ogrenciDersleriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn oNAYDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
    }
}
