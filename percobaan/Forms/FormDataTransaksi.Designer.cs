namespace percobaan.Forms
{
    partial class FormDataTransaksi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataTransaksi));
            this.panelbawah = new System.Windows.Forms.Panel();
            this.tbTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabelTransaksi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idtransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukuran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TbWarna = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelkiri = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TbUkuran = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelatas = new System.Windows.Forms.Panel();
            this.labelcari = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CBpencarian = new MetroFramework.Controls.MetroComboBox();
            this.panelkanan = new System.Windows.Forms.Panel();
            this.paneltabel = new System.Windows.Forms.Panel();
            this.tbPencarian = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelbawah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelTransaksi)).BeginInit();
            this.panelatas.SuspendLayout();
            this.paneltabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbawah
            // 
            this.panelbawah.BackColor = System.Drawing.Color.White;
            this.panelbawah.Controls.Add(this.tbTotal);
            this.panelbawah.Controls.Add(this.lbTotal);
            this.panelbawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbawah.Location = new System.Drawing.Point(55, 407);
            this.panelbawah.Name = "panelbawah";
            this.panelbawah.Size = new System.Drawing.Size(843, 42);
            this.panelbawah.TabIndex = 58;
            // 
            // tbTotal
            // 
            this.tbTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotal.DefaultText = "";
            this.tbTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotal.DisabledState.Parent = this.tbTotal;
            this.tbTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotal.FocusedState.Parent = this.tbTotal;
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotal.HoverState.Parent = this.tbTotal;
            this.tbTotal.Location = new System.Drawing.Point(139, 8);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.PasswordChar = '\0';
            this.tbTotal.PlaceholderText = "";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.SelectedText = "";
            this.tbTotal.ShadowDecoration.Parent = this.tbTotal;
            this.tbTotal.Size = new System.Drawing.Size(113, 27);
            this.tbTotal.TabIndex = 56;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.White;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(-2, 12);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(134, 21);
            this.lbTotal.TabIndex = 55;
            this.lbTotal.Text = "Total Pendapatan";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(341, 24);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(135, 21);
            this.bunifuCustomLabel9.TabIndex = 49;
            this.bunifuCustomLabel9.Text = "Tanggal Transaksi";
            this.bunifuCustomLabel9.Click += new System.EventHandler(this.bunifuCustomLabel9_Click);
            // 
            // tabelTransaksi
            // 
            this.tabelTransaksi.AllowUserToAddRows = false;
            this.tabelTransaksi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.tabelTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tabelTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.tabelTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelTransaksi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabelTransaksi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tabelTransaksi.ColumnHeadersHeight = 25;
            this.tabelTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtransaksi,
            this.idbarang,
            this.namabarang,
            this.ukuran,
            this.warna,
            this.harga,
            this.tanggal,
            this.admin});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelTransaksi.DefaultCellStyle = dataGridViewCellStyle6;
            this.tabelTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelTransaksi.EnableHeadersVisualStyles = false;
            this.tabelTransaksi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.tabelTransaksi.Location = new System.Drawing.Point(0, 0);
            this.tabelTransaksi.Name = "tabelTransaksi";
            this.tabelTransaksi.ReadOnly = true;
            this.tabelTransaksi.RowHeadersVisible = false;
            this.tabelTransaksi.RowTemplate.Height = 25;
            this.tabelTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelTransaksi.Size = new System.Drawing.Size(843, 177);
            this.tabelTransaksi.TabIndex = 0;
            this.tabelTransaksi.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.tabelTransaksi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.tabelTransaksi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tabelTransaksi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tabelTransaksi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tabelTransaksi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tabelTransaksi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tabelTransaksi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.tabelTransaksi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.tabelTransaksi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tabelTransaksi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabelTransaksi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabelTransaksi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabelTransaksi.ThemeStyle.HeaderStyle.Height = 25;
            this.tabelTransaksi.ThemeStyle.ReadOnly = true;
            this.tabelTransaksi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.tabelTransaksi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabelTransaksi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabelTransaksi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabelTransaksi.ThemeStyle.RowsStyle.Height = 25;
            this.tabelTransaksi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.tabelTransaksi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabelTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelTransaksi_CellClick);
            // 
            // idtransaksi
            // 
            this.idtransaksi.DataPropertyName = "idtransaksi";
            this.idtransaksi.FillWeight = 86.98185F;
            this.idtransaksi.HeaderText = "ID Transaksi";
            this.idtransaksi.Name = "idtransaksi";
            this.idtransaksi.ReadOnly = true;
            // 
            // idbarang
            // 
            this.idbarang.DataPropertyName = "idbarang";
            this.idbarang.FillWeight = 89.30954F;
            this.idbarang.HeaderText = "ID Barang";
            this.idbarang.Name = "idbarang";
            this.idbarang.ReadOnly = true;
            // 
            // namabarang
            // 
            this.namabarang.DataPropertyName = "nama";
            this.namabarang.FillWeight = 226.5999F;
            this.namabarang.HeaderText = "Nama Barang";
            this.namabarang.Name = "namabarang";
            this.namabarang.ReadOnly = true;
            // 
            // ukuran
            // 
            this.ukuran.DataPropertyName = "ukuran";
            this.ukuran.FillWeight = 60.60627F;
            this.ukuran.HeaderText = "Ukuran";
            this.ukuran.Name = "ukuran";
            this.ukuran.ReadOnly = true;
            // 
            // warna
            // 
            this.warna.DataPropertyName = "warna";
            this.warna.FillWeight = 104.6017F;
            this.warna.HeaderText = "Warna";
            this.warna.Name = "warna";
            this.warna.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga";
            this.harga.FillWeight = 86.13338F;
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // tanggal
            // 
            this.tanggal.DataPropertyName = "tanggal";
            this.tanggal.FillWeight = 106.2861F;
            this.tanggal.HeaderText = "Tanggal Transaksi";
            this.tanggal.Name = "tanggal";
            this.tanggal.ReadOnly = true;
            // 
            // admin
            // 
            this.admin.DataPropertyName = "admin";
            this.admin.FillWeight = 63.74282F;
            this.admin.HeaderText = "Admin";
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "";
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Location = new System.Drawing.Point(482, 22);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(230, 29);
            this.dtpTanggal.TabIndex = 50;
            this.dtpTanggal.Value = new System.DateTime(2021, 1, 9, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(-2, 61);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(52, 21);
            this.bunifuCustomLabel2.TabIndex = 26;
            this.bunifuCustomLabel2.Text = "Nama";
            // 
            // TbWarna
            // 
            this.TbWarna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbWarna.DefaultText = "";
            this.TbWarna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbWarna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbWarna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbWarna.DisabledState.Parent = this.TbWarna;
            this.TbWarna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbWarna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbWarna.FocusedState.Parent = this.TbWarna;
            this.TbWarna.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbWarna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbWarna.HoverState.Parent = this.TbWarna;
            this.TbWarna.Location = new System.Drawing.Point(91, 135);
            this.TbWarna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbWarna.Name = "TbWarna";
            this.TbWarna.PasswordChar = '\0';
            this.TbWarna.PlaceholderText = "";
            this.TbWarna.ReadOnly = true;
            this.TbWarna.SelectedText = "";
            this.TbWarna.ShadowDecoration.Parent = this.TbWarna;
            this.TbWarna.Size = new System.Drawing.Size(231, 27);
            this.TbWarna.TabIndex = 32;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(-3, 135);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(55, 21);
            this.bunifuCustomLabel4.TabIndex = 28;
            this.bunifuCustomLabel4.Text = "Warna";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(-2, 98);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(61, 21);
            this.bunifuCustomLabel3.TabIndex = 27;
            this.bunifuCustomLabel3.Text = "Ukuran";
            // 
            // panelkiri
            // 
            this.panelkiri.BackColor = System.Drawing.Color.White;
            this.panelkiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelkiri.Location = new System.Drawing.Point(0, 0);
            this.panelkiri.Name = "panelkiri";
            this.panelkiri.Size = new System.Drawing.Size(55, 449);
            this.panelkiri.TabIndex = 57;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(-2, 176);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(54, 21);
            this.bunifuCustomLabel5.TabIndex = 37;
            this.bunifuCustomLabel5.Text = "Harga";
            // 
            // tbHarga
            // 
            this.tbHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHarga.DefaultText = "";
            this.tbHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHarga.DisabledState.Parent = this.tbHarga;
            this.tbHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHarga.FocusedState.Parent = this.tbHarga;
            this.tbHarga.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHarga.HoverState.Parent = this.tbHarga;
            this.tbHarga.Location = new System.Drawing.Point(91, 172);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.PasswordChar = '\0';
            this.tbHarga.PlaceholderText = "";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.SelectedText = "";
            this.tbHarga.ShadowDecoration.Parent = this.tbHarga;
            this.tbHarga.Size = new System.Drawing.Size(113, 27);
            this.tbHarga.TabIndex = 41;
            // 
            // tbNama
            // 
            this.tbNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNama.DefaultText = "";
            this.tbNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNama.DisabledState.Parent = this.tbNama;
            this.tbNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNama.FocusedState.Parent = this.tbNama;
            this.tbNama.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNama.HoverState.Parent = this.tbNama;
            this.tbNama.Location = new System.Drawing.Point(91, 61);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNama.Name = "tbNama";
            this.tbNama.PasswordChar = '\0';
            this.tbNama.PlaceholderText = "";
            this.tbNama.ReadOnly = true;
            this.tbNama.SelectedText = "";
            this.tbNama.ShadowDecoration.Parent = this.tbNama;
            this.tbNama.Size = new System.Drawing.Size(231, 27);
            this.tbNama.TabIndex = 30;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(-3, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(81, 21);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "ID Barang";
            // 
            // TbUkuran
            // 
            this.TbUkuran.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbUkuran.DefaultText = "";
            this.TbUkuran.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbUkuran.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbUkuran.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUkuran.DisabledState.Parent = this.TbUkuran;
            this.TbUkuran.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUkuran.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbUkuran.FocusedState.Parent = this.TbUkuran;
            this.TbUkuran.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUkuran.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbUkuran.HoverState.Parent = this.TbUkuran;
            this.TbUkuran.Location = new System.Drawing.Point(91, 98);
            this.TbUkuran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbUkuran.Name = "TbUkuran";
            this.TbUkuran.PasswordChar = '\0';
            this.TbUkuran.PlaceholderText = "";
            this.TbUkuran.ReadOnly = true;
            this.TbUkuran.SelectedText = "";
            this.TbUkuran.ShadowDecoration.Parent = this.TbUkuran;
            this.TbUkuran.Size = new System.Drawing.Size(113, 27);
            this.TbUkuran.TabIndex = 31;
            // 
            // tbID
            // 
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.DefaultText = "";
            this.tbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.DisabledState.Parent = this.tbID;
            this.tbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.FocusedState.Parent = this.tbID;
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.HoverState.Parent = this.tbID;
            this.tbID.Location = new System.Drawing.Point(91, 24);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.PlaceholderText = "";
            this.tbID.ReadOnly = true;
            this.tbID.SelectedText = "";
            this.tbID.ShadowDecoration.Parent = this.tbID;
            this.tbID.Size = new System.Drawing.Size(113, 27);
            this.tbID.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 51;
            this.label1.Visible = false;
            // 
            // panelatas
            // 
            this.panelatas.BackColor = System.Drawing.Color.White;
            this.panelatas.Controls.Add(this.labelcari);
            this.panelatas.Controls.Add(this.CBpencarian);
            this.panelatas.Controls.Add(this.tbPencarian);
            this.panelatas.Controls.Add(this.dtpTanggal);
            this.panelatas.Controls.Add(this.bunifuCustomLabel9);
            this.panelatas.Controls.Add(this.bunifuCustomLabel5);
            this.panelatas.Controls.Add(this.tbHarga);
            this.panelatas.Controls.Add(this.tbNama);
            this.panelatas.Controls.Add(this.bunifuCustomLabel1);
            this.panelatas.Controls.Add(this.TbUkuran);
            this.panelatas.Controls.Add(this.tbID);
            this.panelatas.Controls.Add(this.bunifuCustomLabel2);
            this.panelatas.Controls.Add(this.TbWarna);
            this.panelatas.Controls.Add(this.bunifuCustomLabel4);
            this.panelatas.Controls.Add(this.bunifuCustomLabel3);
            this.panelatas.Controls.Add(this.label1);
            this.panelatas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelatas.Location = new System.Drawing.Point(55, 0);
            this.panelatas.Name = "panelatas";
            this.panelatas.Size = new System.Drawing.Size(843, 230);
            this.panelatas.TabIndex = 56;
            // 
            // labelcari
            // 
            this.labelcari.AutoSize = true;
            this.labelcari.BackColor = System.Drawing.Color.White;
            this.labelcari.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcari.Location = new System.Drawing.Point(555, 169);
            this.labelcari.Name = "labelcari";
            this.labelcari.Size = new System.Drawing.Size(114, 17);
            this.labelcari.TabIndex = 54;
            this.labelcari.Text = "Cari Berdasarkan :";
            // 
            // CBpencarian
            // 
            this.CBpencarian.FormattingEnabled = true;
            this.CBpencarian.ItemHeight = 23;
            this.CBpencarian.Items.AddRange(new object[] {
            "ID Transaksi",
            "ID Barang",
            "Tanggal"});
            this.CBpencarian.Location = new System.Drawing.Point(558, 189);
            this.CBpencarian.Name = "CBpencarian";
            this.CBpencarian.Size = new System.Drawing.Size(111, 29);
            this.CBpencarian.TabIndex = 53;
            this.CBpencarian.UseSelectable = true;
            // 
            // panelkanan
            // 
            this.panelkanan.BackColor = System.Drawing.Color.White;
            this.panelkanan.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelkanan.Location = new System.Drawing.Point(898, 0);
            this.panelkanan.Name = "panelkanan";
            this.panelkanan.Size = new System.Drawing.Size(55, 449);
            this.panelkanan.TabIndex = 59;
            // 
            // paneltabel
            // 
            this.paneltabel.BackColor = System.Drawing.Color.White;
            this.paneltabel.Controls.Add(this.tabelTransaksi);
            this.paneltabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltabel.Location = new System.Drawing.Point(55, 230);
            this.paneltabel.Name = "paneltabel";
            this.paneltabel.Size = new System.Drawing.Size(843, 177);
            this.paneltabel.TabIndex = 60;
            // 
            // tbPencarian
            // 
            this.tbPencarian.BackColor = System.Drawing.Color.White;
            this.tbPencarian.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPencarian.BackgroundImage")));
            this.tbPencarian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbPencarian.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbPencarian.Icon = ((System.Drawing.Image)(resources.GetObject("tbPencarian.Icon")));
            this.tbPencarian.Location = new System.Drawing.Point(685, 189);
            this.tbPencarian.Name = "tbPencarian";
            this.tbPencarian.Size = new System.Drawing.Size(157, 30);
            this.tbPencarian.TabIndex = 52;
            this.tbPencarian.text = "";
            this.tbPencarian.OnTextChange += new System.EventHandler(this.tbPencarian_OnTextChange_1);
            // 
            // FormDataTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 449);
            this.Controls.Add(this.paneltabel);
            this.Controls.Add(this.panelatas);
            this.Controls.Add(this.panelbawah);
            this.Controls.Add(this.panelkanan);
            this.Controls.Add(this.panelkiri);
            this.Name = "FormDataTransaksi";
            this.Text = "DATA TRANSAKSI";
            this.Load += new System.EventHandler(this.FormDataTransaksi_Load);
            this.panelbawah.ResumeLayout(false);
            this.panelbawah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelTransaksi)).EndInit();
            this.panelatas.ResumeLayout(false);
            this.panelatas.PerformLayout();
            this.paneltabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbawah;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Guna.UI2.WinForms.Guna2DataGridView tabelTransaksi;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TbWarna;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel panelkiri;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Guna.UI2.WinForms.Guna2TextBox tbHarga;
        private Guna.UI2.WinForms.Guna2TextBox tbNama;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TbUkuran;
        private Guna.UI2.WinForms.Guna2TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelatas;
        private System.Windows.Forms.Panel panelkanan;
        private System.Windows.Forms.Panel paneltabel;
        private Bunifu.Framework.UI.BunifuTextbox tbPencarian;
        private MetroFramework.Controls.MetroComboBox CBpencarian;
        private Bunifu.Framework.UI.BunifuCustomLabel labelcari;
        private Guna.UI2.WinForms.Guna2TextBox tbTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukuran;
        private System.Windows.Forms.DataGridViewTextBoxColumn warna;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin;

    }
}