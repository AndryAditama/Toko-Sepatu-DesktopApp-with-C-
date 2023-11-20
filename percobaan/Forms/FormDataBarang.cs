using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.Data.SqlClient;

namespace percobaan.Forms
{
    public partial class FormDataBarang : Form
    {
        
        MySqlCommand cmd;
        string imageURL = null;
        public string usr;


        string konek = "datasource=localhost;port=3306;username=root;password=;database=dbtoko";
        MySqlConnection conn;


        
        public FormDataBarang()
        {
            InitializeComponent();
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            tampil();
            btnBrowse.Enabled = false;
            total();
            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", Multiselect = false })
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        namafile = ofd.FileName;
            //        ofd.InitialDirectory="C:\\";
            //        label1.Text = namafile;
            //        PictUpload.Image = Image.FromFile(namafile);
            //        ofd.FilterIndex = 1;
            //        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            //        string correctfilename = System.IO.Path.GetFileName(ofd.FileName);
            //        System.IO.File.Copy(ofd.FileName, paths + "\\Uploads\\" + correctfilename);
            //    }
            //}

            using (OpenFileDialog open = new OpenFileDialog() { Multiselect=false})
                if (open.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = open.FileName;
                    open.Filter= "JPEG|*.jpg|PNG|*.png"; 
                    imageURL = open.FileName;
                    PictUpload.Image = new Bitmap(open.FileName);

                    if (PictUpload.Image != null)
                        PictUpload.BackgroundImage = null;

                }
        }

        void tampil()
        {
            conn = new MySqlConnection(konek);
            conn.Open();
            string select = "SELECT idbarang, nama, ukuran, warna, harga, urlgambar FROM tbbarang";
            MySqlCommand updatedatagridcmd = new MySqlCommand(select, conn);
            MySqlDataAdapter sd = new MySqlDataAdapter(updatedatagridcmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dt.Columns.Add("Gambar", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in dt.Rows)
            {
                drow["Gambar"] = File.ReadAllBytes(drow["urlgambar"].ToString());
            }
            tabelBarang.DataSource = dt;
            conn.Close();
            btnBrowse.Enabled = false;
            
        }

        void total()
        {
            tbJumlah.Text = tabelBarang.Rows.Count.ToString();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                btnTambah.Text = "Simpan";
                btnReload.Text = "Batal";
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
                tabelBarang.Enabled = false;
                tbID.ReadOnly = true;
                btnBrowse.Enabled = true;
                tbNama.ReadOnly = false;
                TbUkuran.ReadOnly = false;
                TbWarna.ReadOnly = false;
                tbHarga.ReadOnly = false;
                btnBrowse.Enabled = true;
                hapustext();
                tbNama.Focus();
            }
            else if(btnTambah.Text=="Simpan")
            {
                conn = new MySqlConnection(konek);
                File.Copy(label1.Text, Path.Combine(@"C:\Users\ASUS\Documents\Visual Studio 2012\Projects\percobaan\percobaan\Uploads\", Path.GetFileName(label1.Text)), true);
                Image img = PictUpload.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                //MemoryStream ms = new MemoryStream();
                //.Image.Save(ms, PictUpload.Image.RawFormat);
                //byte[] img = ms.ToArray();

                conn.Open();

                string query = "INSERT INTO tbbarang(nama,ukuran,warna,harga,gambar,urlgambar)VALUES(@namabrg,@ukuran,@warna,@harga,@gambar,@urlgambar)";
                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@namabrg", tbNama.Text);
                cmd.Parameters.AddWithValue("@ukuran", TbUkuran.Text);
                cmd.Parameters.AddWithValue("@warna", TbWarna.Text);
                cmd.Parameters.AddWithValue("@harga", tbHarga.Text);
                cmd.Parameters.AddWithValue("@gambar", arr);
                cmd.Parameters.AddWithValue("@urlgambar", imageURL);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Berhasil Menambah Data!");
                }

                btnTambah.Text = "Tambah";
                btnEdit.Enabled = true;
                btnHapus.Enabled = true;
                btnReload.Text = "Reload";
                btnBrowse.Enabled = false;
                tabelBarang.Enabled = true;
                tbID.ReadOnly = true;
                tbNama.ReadOnly = true;
                TbUkuran.ReadOnly = true;
                TbWarna.ReadOnly = true;
                tbHarga.ReadOnly = true;
                conn.Close();
                tampil();
                hapustext();
                total();
            }
        }

        void hapustext()
        {
            tbID.Text = "";
            tbNama.Text = "";
            TbUkuran.Text = "";
            TbWarna.Text = "";
            tbHarga.Text = "";
            PictUpload.Image = null;
            label1.Text = "";
            if (PictUpload.Image == null)
                PictUpload.BackgroundImage = Properties.Resources.pic2;
            
        }

        private void tabelBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = tabelBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNama.Text = tabelBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            TbUkuran.Text = tabelBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            TbWarna.Text = tabelBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbHarga.Text = tabelBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
            label1.Text = tabelBarang.Rows[e.RowIndex].Cells[5].Value.ToString();
            byte[] imgData = (byte[])tabelBarang.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(imgData);
            PictUpload.Image = Image.FromStream(ms);
            if (PictUpload.Image != null)
                PictUpload.BackgroundImage = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Update";
                btnReload.Text = "Batal";
                btnTambah.Enabled = false;
                btnHapus.Enabled = false;
                tabelBarang.Enabled = false;
                tbID.ReadOnly = true;
                btnBrowse.Enabled = true;
                tbNama.ReadOnly = false;
                TbUkuran.ReadOnly = false;
                TbWarna.ReadOnly = false;
                tbHarga.ReadOnly = false;
                btnBrowse.Enabled = true;


                tbNama.Focus();
            }
            else if(btnEdit.Text == "Update")
            {
                conn = new MySqlConnection(konek);
                File.Copy(label1.Text, Path.Combine(@"C:\Users\ASUS\Documents\Visual Studio 2012\Projects\percobaan\percobaan\Uploads\", Path.GetFileName(label1.Text)), true);
                Image img = PictUpload.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                //MemoryStream ms = new MemoryStream();
                //.Image.Save(ms, PictUpload.Image.RawFormat);
                //byte[] img = ms.ToArray();

                conn.Open();

                string query = "UPDATE tbbarang SET nama=@namabrg ,ukuran=@ukuran, warna=@warna ,harga=@harga ,gambar=@gambar ,urlgambar=@urlgambar WHERE idbarang=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", tbID.Text);
                cmd.Parameters.AddWithValue("@namabrg", tbNama.Text);
                cmd.Parameters.AddWithValue("@ukuran", TbUkuran.Text);
                cmd.Parameters.AddWithValue("@warna", TbWarna.Text);
                cmd.Parameters.AddWithValue("@harga", tbHarga.Text);
                cmd.Parameters.AddWithValue("@gambar", arr);
                cmd.Parameters.AddWithValue("@urlgambar", label1.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Update Data Berhasil");
                }
                btnBrowse.Enabled = false;
                btnEdit.Text = "Edit";
                btnReload.Text = "Reload";
                btnTambah.Enabled = true;
                btnHapus.Enabled = true;
                tabelBarang.Enabled = true;
                tbID.ReadOnly = true;
                tbNama.ReadOnly = true;
                TbUkuran.ReadOnly = true;
                TbWarna.ReadOnly = true;
                tbHarga.ReadOnly = true;
                tampil();
                conn.Close();
                total();
                
            }
        }

            void reload()
            {
                if(btnReload.Text=="Reload")
                {
                    btnBrowse.Enabled = false;
                    tbID.ReadOnly = true;
                    tbNama.ReadOnly = true;
                    TbUkuran.ReadOnly = true;
                    TbWarna.ReadOnly = true;
                    tbHarga.ReadOnly = true;
                    hapustext();
                    tampil();
                    total();
                }else if(btnReload.Text=="Batal")
                {
                    btnTambah.Text="Tambah";
                    btnEdit.Text="Edit";
                    btnReload.Text = "Reload";
                    btnTambah.Enabled = true;
                    btnEdit.Enabled = true;
                    btnHapus.Enabled = true;
                    btnBrowse.Enabled = false;
                    tbID.ReadOnly=true;
                    tbNama.ReadOnly=true;
                    TbUkuran.ReadOnly=true;
                    TbWarna.ReadOnly=true;
                    tbHarga.ReadOnly=true;
                    PictUpload.Image = null;
                    tabelBarang.Enabled = true;
                    hapustext();
                    total();
                    
                }
            }

            private void btnReload_Click(object sender, EventArgs e)
            {
                reload();
            }

            private void btnHapus_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show(null, "Yakin Menghapus Data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = tbID.Text;
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM tbbarang WHERE idbarang=@id";
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    tampil();
                    hapustext();
                    total();
                    MessageBox.Show("Data Berhasil Dihapus");
                }
            }

            private void tbPencarian_OnTextChange(object sender, EventArgs e)
            {
                try
                {
                    if (CBpencarian.Text == "ID Barang")
                    {
                        if (tbPencarian.text == "")
                        {
                            tampil();
                            total();
                        }
                        else
                        {
                            conn.Open();
                            string select = "SELECT idbarang, nama, ukuran, warna, harga, urlgambar FROM tbbarang WHERE idbarang LIKE '%" + tbPencarian.text + "%' ";
                            MySqlCommand updatedatagridcmd = new MySqlCommand(select, conn);
                            MySqlDataAdapter sd = new MySqlDataAdapter(updatedatagridcmd);
                            DataTable dt = new DataTable();
                            sd.Fill(dt);
                            dt.Columns.Add("Gambar", Type.GetType("System.Byte[]"));
                            foreach (DataRow drow in dt.Rows)
                            {
                                drow["Gambar"] = File.ReadAllBytes(drow["urlgambar"].ToString());
                            }
                            tabelBarang.DataSource = dt;
                            conn.Close();
                            total();
                        }
                    }
                    else if (CBpencarian.Text == "Nama Barang")
                    {
                        if (tbPencarian.text == "")
                        {
                            tampil();
                            total();
                        }
                        else
                        {
                            conn.Open();
                            string select = "SELECT idbarang, nama, ukuran, warna, harga, urlgambar FROM tbbarang WHERE nama LIKE '%" + tbPencarian.text + "%' ";
                            MySqlCommand updatedatagridcmd = new MySqlCommand(select, conn);
                            MySqlDataAdapter sd = new MySqlDataAdapter(updatedatagridcmd);
                            DataTable dt = new DataTable();
                            sd.Fill(dt);
                            dt.Columns.Add("Gambar", Type.GetType("System.Byte[]"));
                            foreach (DataRow drow in dt.Rows)
                            {
                                drow["Gambar"] = File.ReadAllBytes(drow["urlgambar"].ToString());
                            }
                            tabelBarang.DataSource = dt;
                            conn.Close();
                            total();
                        }
                    }
                }
                catch (Exception r)
                {
                    tampil();
                }
            }
        }
    }

