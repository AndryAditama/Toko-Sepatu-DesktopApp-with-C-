namespace percobaan.Forms
{
    partial class FormDataAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.tbNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Tbpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelkiri = new System.Windows.Forms.Panel();
            this.panelkanan = new System.Windows.Forms.Panel();
            this.panelbawah = new System.Windows.Forms.Panel();
            this.paneltabel = new System.Windows.Forms.Panel();
            this.tabelAdmin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelatas = new System.Windows.Forms.Panel();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneltabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTambah
            // 
            this.btnTambah.BorderRadius = 4;
            this.btnTambah.CheckedState.Parent = this.btnTambah;
            this.btnTambah.CustomImages.Parent = this.btnTambah;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.HoverState.Parent = this.btnTambah;
            this.btnTambah.Location = new System.Drawing.Point(435, 39);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.ShadowDecoration.Parent = this.btnTambah;
            this.btnTambah.Size = new System.Drawing.Size(87, 37);
            this.btnTambah.TabIndex = 21;
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
            this.btnEdit.Location = new System.Drawing.Point(435, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(87, 37);
            this.btnEdit.TabIndex = 22;
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
            this.btnReload.Location = new System.Drawing.Point(435, 168);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(87, 37);
            this.btnReload.TabIndex = 24;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
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
            this.tbNama.Location = new System.Drawing.Point(153, 76);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNama.Name = "tbNama";
            this.tbNama.PasswordChar = '\0';
            this.tbNama.PlaceholderText = "";
            this.tbNama.ReadOnly = true;
            this.tbNama.SelectedText = "";
            this.tbNama.ShadowDecoration.Parent = this.tbNama;
            this.tbNama.Size = new System.Drawing.Size(254, 27);
            this.tbNama.TabIndex = 18;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 39);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(78, 21);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "ID Admin";
            // 
            // TbUsername
            // 
            this.TbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbUsername.DefaultText = "";
            this.TbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUsername.DisabledState.Parent = this.TbUsername;
            this.TbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbUsername.FocusedState.Parent = this.TbUsername;
            this.TbUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbUsername.HoverState.Parent = this.TbUsername;
            this.TbUsername.Location = new System.Drawing.Point(153, 113);
            this.TbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.PasswordChar = '\0';
            this.TbUsername.PlaceholderText = "";
            this.TbUsername.ReadOnly = true;
            this.TbUsername.SelectedText = "";
            this.TbUsername.ShadowDecoration.Parent = this.TbUsername;
            this.TbUsername.Size = new System.Drawing.Size(254, 27);
            this.TbUsername.TabIndex = 19;
            // 
            // btnHapus
            // 
            this.btnHapus.BorderRadius = 4;
            this.btnHapus.CheckedState.Parent = this.btnHapus;
            this.btnHapus.CustomImages.Parent = this.btnHapus;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.HoverState.Parent = this.btnHapus;
            this.btnHapus.Location = new System.Drawing.Point(435, 125);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.ShadowDecoration.Parent = this.btnHapus;
            this.btnHapus.Size = new System.Drawing.Size(87, 37);
            this.btnHapus.TabIndex = 23;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
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
            this.tbID.Location = new System.Drawing.Point(153, 39);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.PlaceholderText = "";
            this.tbID.ReadOnly = true;
            this.tbID.SelectedText = "";
            this.tbID.ShadowDecoration.Parent = this.tbID;
            this.tbID.Size = new System.Drawing.Size(157, 27);
            this.tbID.TabIndex = 17;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(57, 76);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(52, 21);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "Nama";
            // 
            // Tbpassword
            // 
            this.Tbpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tbpassword.DefaultText = "";
            this.Tbpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Tbpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Tbpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tbpassword.DisabledState.Parent = this.Tbpassword;
            this.Tbpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tbpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tbpassword.FocusedState.Parent = this.Tbpassword;
            this.Tbpassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tbpassword.HoverState.Parent = this.Tbpassword;
            this.Tbpassword.Location = new System.Drawing.Point(153, 150);
            this.Tbpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tbpassword.Name = "Tbpassword";
            this.Tbpassword.PasswordChar = '\0';
            this.Tbpassword.PlaceholderText = "";
            this.Tbpassword.ReadOnly = true;
            this.Tbpassword.SelectedText = "";
            this.Tbpassword.ShadowDecoration.Parent = this.Tbpassword;
            this.Tbpassword.Size = new System.Drawing.Size(254, 27);
            this.Tbpassword.TabIndex = 20;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(56, 150);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(79, 21);
            this.bunifuCustomLabel4.TabIndex = 16;
            this.bunifuCustomLabel4.Text = "Password";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(57, 113);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(83, 21);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "Username";
            // 
            // panelkiri
            // 
            this.panelkiri.BackColor = System.Drawing.Color.White;
            this.panelkiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelkiri.Location = new System.Drawing.Point(0, 219);
            this.panelkiri.Name = "panelkiri";
            this.panelkiri.Size = new System.Drawing.Size(55, 235);
            this.panelkiri.TabIndex = 27;
            // 
            // panelkanan
            // 
            this.panelkanan.BackColor = System.Drawing.Color.White;
            this.panelkanan.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelkanan.Location = new System.Drawing.Point(912, 219);
            this.panelkanan.Name = "panelkanan";
            this.panelkanan.Size = new System.Drawing.Size(55, 235);
            this.panelkanan.TabIndex = 28;
            // 
            // panelbawah
            // 
            this.panelbawah.BackColor = System.Drawing.Color.White;
            this.panelbawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbawah.Location = new System.Drawing.Point(55, 434);
            this.panelbawah.Name = "panelbawah";
            this.panelbawah.Size = new System.Drawing.Size(857, 20);
            this.panelbawah.TabIndex = 29;
            // 
            // paneltabel
            // 
            this.paneltabel.Controls.Add(this.tabelAdmin);
            this.paneltabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltabel.Location = new System.Drawing.Point(55, 219);
            this.paneltabel.Name = "paneltabel";
            this.paneltabel.Size = new System.Drawing.Size(857, 215);
            this.paneltabel.TabIndex = 30;
            // 
            // tabelAdmin
            // 
            this.tabelAdmin.AllowUserToAddRows = false;
            this.tabelAdmin.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.tabelAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelAdmin.BackgroundColor = System.Drawing.Color.White;
            this.tabelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabelAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_user,
            this.nama,
            this.username,
            this.password});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelAdmin.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelAdmin.EnableHeadersVisualStyles = false;
            this.tabelAdmin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.tabelAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabelAdmin.Name = "tabelAdmin";
            this.tabelAdmin.ReadOnly = true;
            this.tabelAdmin.RowHeadersVisible = false;
            this.tabelAdmin.RowTemplate.Height = 25;
            this.tabelAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelAdmin.Size = new System.Drawing.Size(857, 215);
            this.tabelAdmin.TabIndex = 0;
            this.tabelAdmin.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.tabelAdmin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.tabelAdmin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tabelAdmin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tabelAdmin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tabelAdmin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tabelAdmin.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tabelAdmin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.tabelAdmin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.tabelAdmin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tabelAdmin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabelAdmin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabelAdmin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabelAdmin.ThemeStyle.HeaderStyle.Height = 23;
            this.tabelAdmin.ThemeStyle.ReadOnly = true;
            this.tabelAdmin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.tabelAdmin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabelAdmin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabelAdmin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabelAdmin.ThemeStyle.RowsStyle.Height = 25;
            this.tabelAdmin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.tabelAdmin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabelAdmin.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelAdmin_CellEnter);
            // 
            // panelatas
            // 
            this.panelatas.BackColor = System.Drawing.Color.White;
            this.panelatas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelatas.Location = new System.Drawing.Point(0, 0);
            this.panelatas.Name = "panelatas";
            this.panelatas.Size = new System.Drawing.Size(967, 219);
            this.panelatas.TabIndex = 26;
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "iduser";
            this.id_user.FillWeight = 60.9137F;
            this.id_user.HeaderText = "ID Admin";
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.FillWeight = 113.0288F;
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.FillWeight = 113.0288F;
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.FillWeight = 113.0288F;
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // FormDataAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 454);
            this.Controls.Add(this.paneltabel);
            this.Controls.Add(this.panelbawah);
            this.Controls.Add(this.panelkanan);
            this.Controls.Add(this.panelkiri);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Tbpassword);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.panelatas);
            this.Name = "FormDataAdmin";
            this.Text = "DATA ADMIN";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.paneltabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2TextBox tbNama;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TbUsername;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2TextBox tbID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Guna.UI2.WinForms.Guna2TextBox Tbpassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel panelkiri;
        private System.Windows.Forms.Panel panelkanan;
        private System.Windows.Forms.Panel panelbawah;
        private System.Windows.Forms.Panel paneltabel;
        private Guna.UI2.WinForms.Guna2DataGridView tabelAdmin;
        private System.Windows.Forms.Panel panelatas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}