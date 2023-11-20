namespace percobaan.Forms
{
    partial class FormDataPengeluaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataPengeluaran));
            this.paneltabel = new System.Windows.Forms.Panel();
            this.tabelPengeluaran = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keperluan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelbawah = new System.Windows.Forms.Panel();
            this.tbTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelkanan = new System.Windows.Forms.Panel();
            this.panelkiri = new System.Windows.Forms.Panel();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.tbKeperluan = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbJumlahKeluar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelatas = new System.Windows.Forms.Panel();
            this.labelcari = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.CBpencarian = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPencarian = new Bunifu.Framework.UI.BunifuTextbox();
            this.paneltabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelPengeluaran)).BeginInit();
            this.panelbawah.SuspendLayout();
            this.panelatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltabel
            // 
            this.paneltabel.BackColor = System.Drawing.Color.White;
            this.paneltabel.Controls.Add(this.tabelPengeluaran);
            this.paneltabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltabel.Location = new System.Drawing.Point(55, 219);
            this.paneltabel.Name = "paneltabel";
            this.paneltabel.Size = new System.Drawing.Size(833, 156);
            this.paneltabel.TabIndex = 47;
            // 
            // tabelPengeluaran
            // 
            this.tabelPengeluaran.AllowUserToAddRows = false;
            this.tabelPengeluaran.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.tabelPengeluaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tabelPengeluaran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelPengeluaran.BackgroundColor = System.Drawing.Color.White;
            this.tabelPengeluaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelPengeluaran.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabelPengeluaran.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelPengeluaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tabelPengeluaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.keperluan,
            this.jumlah,
            this.tanggal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelPengeluaran.DefaultCellStyle = dataGridViewCellStyle6;
            this.tabelPengeluaran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelPengeluaran.EnableHeadersVisualStyles = false;
            this.tabelPengeluaran.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.tabelPengeluaran.Location = new System.Drawing.Point(0, 0);
            this.tabelPengeluaran.Name = "tabelPengeluaran";
            this.tabelPengeluaran.ReadOnly = true;
            this.tabelPengeluaran.RowHeadersVisible = false;
            this.tabelPengeluaran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelPengeluaran.Size = new System.Drawing.Size(833, 156);
            this.tabelPengeluaran.TabIndex = 0;
            this.tabelPengeluaran.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.tabelPengeluaran.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.tabelPengeluaran.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tabelPengeluaran.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tabelPengeluaran.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tabelPengeluaran.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tabelPengeluaran.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tabelPengeluaran.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.tabelPengeluaran.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.tabelPengeluaran.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tabelPengeluaran.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabelPengeluaran.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabelPengeluaran.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabelPengeluaran.ThemeStyle.HeaderStyle.Height = 23;
            this.tabelPengeluaran.ThemeStyle.ReadOnly = true;
            this.tabelPengeluaran.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.tabelPengeluaran.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabelPengeluaran.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabelPengeluaran.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabelPengeluaran.ThemeStyle.RowsStyle.Height = 22;
            this.tabelPengeluaran.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.tabelPengeluaran.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabelPengeluaran.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelPengeluaran_CellEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.FillWeight = 28.54411F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // keperluan
            // 
            this.keperluan.DataPropertyName = "keperluan";
            this.keperluan.FillWeight = 203.0457F;
            this.keperluan.HeaderText = "Keperluan";
            this.keperluan.Name = "keperluan";
            this.keperluan.ReadOnly = true;
            // 
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah";
            this.jumlah.FillWeight = 84.20514F;
            this.jumlah.HeaderText = "Jumlah Pengeluaran";
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            // 
            // tanggal
            // 
            this.tanggal.DataPropertyName = "tanggal";
            this.tanggal.FillWeight = 84.20514F;
            this.tanggal.HeaderText = "Tanggal ";
            this.tanggal.Name = "tanggal";
            this.tanggal.ReadOnly = true;
            // 
            // panelbawah
            // 
            this.panelbawah.BackColor = System.Drawing.Color.White;
            this.panelbawah.Controls.Add(this.tbTotal);
            this.panelbawah.Controls.Add(this.lbTotal);
            this.panelbawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbawah.Location = new System.Drawing.Point(55, 375);
            this.panelbawah.Name = "panelbawah";
            this.panelbawah.Size = new System.Drawing.Size(833, 42);
            this.panelbawah.TabIndex = 46;
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
            this.tbTotal.Location = new System.Drawing.Point(143, 8);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.PasswordChar = '\0';
            this.tbTotal.PlaceholderText = "";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.SelectedText = "";
            this.tbTotal.ShadowDecoration.Parent = this.tbTotal;
            this.tbTotal.Size = new System.Drawing.Size(113, 27);
            this.tbTotal.TabIndex = 58;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.White;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(-2, 10);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(146, 21);
            this.lbTotal.TabIndex = 57;
            this.lbTotal.Text = "Total Pengeluaran :";
            // 
            // panelkanan
            // 
            this.panelkanan.BackColor = System.Drawing.Color.White;
            this.panelkanan.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelkanan.Location = new System.Drawing.Point(888, 0);
            this.panelkanan.Name = "panelkanan";
            this.panelkanan.Size = new System.Drawing.Size(55, 417);
            this.panelkanan.TabIndex = 45;
            // 
            // panelkiri
            // 
            this.panelkiri.BackColor = System.Drawing.Color.White;
            this.panelkiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelkiri.Location = new System.Drawing.Point(0, 0);
            this.panelkiri.Name = "panelkiri";
            this.panelkiri.Size = new System.Drawing.Size(55, 417);
            this.panelkiri.TabIndex = 44;
            // 
            // btnTambah
            // 
            this.btnTambah.BorderRadius = 4;
            this.btnTambah.CheckedState.Parent = this.btnTambah;
            this.btnTambah.CustomImages.Parent = this.btnTambah;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.HoverState.Parent = this.btnTambah;
            this.btnTambah.Location = new System.Drawing.Point(425, 27);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.ShadowDecoration.Parent = this.btnTambah;
            this.btnTambah.Size = new System.Drawing.Size(87, 37);
            this.btnTambah.TabIndex = 39;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 4;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(425, 70);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(87, 37);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReload
            // 
            this.btnReload.BorderRadius = 4;
            this.btnReload.CheckedState.Parent = this.btnReload;
            this.btnReload.CustomImages.Parent = this.btnReload;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.Parent = this.btnReload;
            this.btnReload.Location = new System.Drawing.Point(425, 156);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(87, 37);
            this.btnReload.TabIndex = 42;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // tbKeperluan
            // 
            this.tbKeperluan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKeperluan.DefaultText = "";
            this.tbKeperluan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbKeperluan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbKeperluan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbKeperluan.DisabledState.Parent = this.tbKeperluan;
            this.tbKeperluan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbKeperluan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbKeperluan.FocusedState.Parent = this.tbKeperluan;
            this.tbKeperluan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeperluan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbKeperluan.HoverState.Parent = this.tbKeperluan;
            this.tbKeperluan.Location = new System.Drawing.Point(159, 33);
            this.tbKeperluan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbKeperluan.Multiline = true;
            this.tbKeperluan.Name = "tbKeperluan";
            this.tbKeperluan.PasswordChar = '\0';
            this.tbKeperluan.PlaceholderText = "";
            this.tbKeperluan.ReadOnly = true;
            this.tbKeperluan.SelectedText = "";
            this.tbKeperluan.ShadowDecoration.Parent = this.tbKeperluan;
            this.tbKeperluan.Size = new System.Drawing.Size(241, 66);
            this.tbKeperluan.TabIndex = 36;
            // 
            // TbJumlahKeluar
            // 
            this.TbJumlahKeluar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbJumlahKeluar.DefaultText = "";
            this.TbJumlahKeluar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbJumlahKeluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbJumlahKeluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbJumlahKeluar.DisabledState.Parent = this.TbJumlahKeluar;
            this.TbJumlahKeluar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbJumlahKeluar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbJumlahKeluar.FocusedState.Parent = this.TbJumlahKeluar;
            this.TbJumlahKeluar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbJumlahKeluar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbJumlahKeluar.HoverState.Parent = this.TbJumlahKeluar;
            this.TbJumlahKeluar.Location = new System.Drawing.Point(159, 109);
            this.TbJumlahKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbJumlahKeluar.Name = "TbJumlahKeluar";
            this.TbJumlahKeluar.PasswordChar = '\0';
            this.TbJumlahKeluar.PlaceholderText = "";
            this.TbJumlahKeluar.ReadOnly = true;
            this.TbJumlahKeluar.SelectedText = "";
            this.TbJumlahKeluar.ShadowDecoration.Parent = this.TbJumlahKeluar;
            this.TbJumlahKeluar.Size = new System.Drawing.Size(241, 27);
            this.TbJumlahKeluar.TabIndex = 37;
            // 
            // btnHapus
            // 
            this.btnHapus.BorderRadius = 4;
            this.btnHapus.CheckedState.Parent = this.btnHapus;
            this.btnHapus.CustomImages.Parent = this.btnHapus;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.HoverState.Parent = this.btnHapus;
            this.btnHapus.Location = new System.Drawing.Point(425, 113);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.ShadowDecoration.Parent = this.btnHapus;
            this.btnHapus.Size = new System.Drawing.Size(87, 37);
            this.btnHapus.TabIndex = 41;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(-4, 33);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(84, 21);
            this.bunifuCustomLabel2.TabIndex = 32;
            this.bunifuCustomLabel2.Text = "Keperluan";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(-5, 146);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(66, 21);
            this.bunifuCustomLabel4.TabIndex = 34;
            this.bunifuCustomLabel4.Text = "Tanggal";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(-4, 109);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(153, 21);
            this.bunifuCustomLabel3.TabIndex = 33;
            this.bunifuCustomLabel3.Text = "Jumlah Pengeluaran";
            // 
            // panelatas
            // 
            this.panelatas.BackColor = System.Drawing.Color.White;
            this.panelatas.Controls.Add(this.labelcari);
            this.panelatas.Controls.Add(this.dtpTanggal);
            this.panelatas.Controls.Add(this.CBpencarian);
            this.panelatas.Controls.Add(this.btnHapus);
            this.panelatas.Controls.Add(this.tbPencarian);
            this.panelatas.Controls.Add(this.TbJumlahKeluar);
            this.panelatas.Controls.Add(this.tbKeperluan);
            this.panelatas.Controls.Add(this.bunifuCustomLabel2);
            this.panelatas.Controls.Add(this.bunifuCustomLabel4);
            this.panelatas.Controls.Add(this.btnTambah);
            this.panelatas.Controls.Add(this.bunifuCustomLabel3);
            this.panelatas.Controls.Add(this.btnReload);
            this.panelatas.Controls.Add(this.btnEdit);
            this.panelatas.Controls.Add(this.label2);
            this.panelatas.Controls.Add(this.label1);
            this.panelatas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelatas.Location = new System.Drawing.Point(55, 0);
            this.panelatas.Name = "panelatas";
            this.panelatas.Size = new System.Drawing.Size(833, 219);
            this.panelatas.TabIndex = 43;
            // 
            // labelcari
            // 
            this.labelcari.AutoSize = true;
            this.labelcari.BackColor = System.Drawing.Color.White;
            this.labelcari.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcari.Location = new System.Drawing.Point(544, 158);
            this.labelcari.Name = "labelcari";
            this.labelcari.Size = new System.Drawing.Size(114, 17);
            this.labelcari.TabIndex = 61;
            this.labelcari.Text = "Cari Berdasarkan :";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "";
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Location = new System.Drawing.Point(159, 147);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(241, 29);
            this.dtpTanggal.TabIndex = 43;
            this.dtpTanggal.Value = new System.DateTime(2021, 1, 9, 0, 0, 0, 0);
            // 
            // CBpencarian
            // 
            this.CBpencarian.FormattingEnabled = true;
            this.CBpencarian.ItemHeight = 23;
            this.CBpencarian.Items.AddRange(new object[] {
            "Keperluan",
            "Tanggal"});
            this.CBpencarian.Location = new System.Drawing.Point(547, 178);
            this.CBpencarian.Name = "CBpencarian";
            this.CBpencarian.Size = new System.Drawing.Size(111, 29);
            this.CBpencarian.TabIndex = 60;
            this.CBpencarian.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 45;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 44;
            this.label1.Visible = false;
            // 
            // tbPencarian
            // 
            this.tbPencarian.BackColor = System.Drawing.Color.White;
            this.tbPencarian.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPencarian.BackgroundImage")));
            this.tbPencarian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbPencarian.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbPencarian.Icon = ((System.Drawing.Image)(resources.GetObject("tbPencarian.Icon")));
            this.tbPencarian.Location = new System.Drawing.Point(674, 178);
            this.tbPencarian.Name = "tbPencarian";
            this.tbPencarian.Size = new System.Drawing.Size(157, 30);
            this.tbPencarian.TabIndex = 59;
            this.tbPencarian.text = "";
            this.tbPencarian.OnTextChange += new System.EventHandler(this.tbPencarian_OnTextChange);
            // 
            // FormDataPengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 417);
            this.Controls.Add(this.paneltabel);
            this.Controls.Add(this.panelbawah);
            this.Controls.Add(this.panelatas);
            this.Controls.Add(this.panelkiri);
            this.Controls.Add(this.panelkanan);
            this.Name = "FormDataPengeluaran";
            this.Text = "DATA PENGELUARAN";
            this.Load += new System.EventHandler(this.FormDataPengeluaran_Load);
            this.paneltabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelPengeluaran)).EndInit();
            this.panelbawah.ResumeLayout(false);
            this.panelbawah.PerformLayout();
            this.panelatas.ResumeLayout(false);
            this.panelatas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltabel;
        private Guna.UI2.WinForms.Guna2DataGridView tabelPengeluaran;
        private System.Windows.Forms.Panel panelbawah;
        private System.Windows.Forms.Panel panelkanan;
        private System.Windows.Forms.Panel panelkiri;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2TextBox tbKeperluan;
        private Guna.UI2.WinForms.Guna2TextBox TbJumlahKeluar;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel panelatas;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn keperluan;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private Guna.UI2.WinForms.Guna2TextBox tbTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel labelcari;
        private MetroFramework.Controls.MetroComboBox CBpencarian;
        private Bunifu.Framework.UI.BunifuTextbox tbPencarian;
    }
}