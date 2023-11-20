using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace percobaan.Forms
{
    public partial class FormTransaksi : Form
    {
        
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=dbtoko");
        public string ADMIN;

        public FormTransaksi(string admin)
        {
            this.ADMIN = admin;
            InitializeComponent();
        }

        void tampil()
        {
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
            dtpTanggal.Text = DateTime.Now.ToString();
            conn.Close();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            tampil();
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
            tbbayar.Text = "";
            tbkembalian.Text = "";
        }


        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            if (btnTransaksi.Text == "Transaksi")
            {
                btnTransaksi.Text = "Selesai";
                tbbayar.ReadOnly = false;
                tbkembalian.ReadOnly = true;
                btnBatal.Visible = true;
                tabelBarang.Enabled = false;
                
            }else if(btnTransaksi.Text=="Selesai")
            {
                string tgl = dtpTanggal.Text;
                string hsl = "";
                var edt = tgl.Split(' ');
                hsl = edt[1] + " " + edt[2] + " " + edt[3];

                string adminnn = ADMIN;
                string namaadmin = "";
                var ed = adminnn.Split(' ');
                namaadmin = ed[1];

                conn.Open();
                string query = "INSERT INTO tbtransaksi (idbarang, nama, ukuran, warna, harga, tanggal, admin) VALUES (@idbarang, @nama, @ukuran, @warna, @harga, @tanggal, @admin)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idbarang", tbID.Text);
                cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                cmd.Parameters.AddWithValue("@ukuran", TbUkuran.Text);
                cmd.Parameters.AddWithValue("@warna", TbWarna.Text);
                cmd.Parameters.AddWithValue("@harga", tbHarga.Text);
                cmd.Parameters.AddWithValue("@tanggal", hsl);
                cmd.Parameters.AddWithValue("@admin", namaadmin);
                cmd.Prepare();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Transaksi Tersimpan!");
                }

                conn.Close();
                btnTransaksi.Text="Transaksi";
                tbbayar.ReadOnly = true;
                tbkembalian.ReadOnly = true;
                tabelBarang.Enabled = true;

                conn.Open();
                string queryhapus = "Delete from tbbarang where idbarang = @idbarang";
                MySqlCommand cmdhapus = new MySqlCommand(queryhapus, conn);
                cmdhapus.Parameters.AddWithValue("@idbarang", tbID.Text);
                cmdhapus.Prepare();
                cmdhapus.ExecuteNonQuery();
                conn.Close();
                tampil();
                hapus();
                btnBatal.Visible = false;
                
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            tbbayar.Text = "";
            tbHarga.Text = "";
            tbkembalian.Text = "";
            tbID.Text = "";
            tbNama.Text = "";
            TbUkuran.Text = "";
            TbWarna.Text = "";
            PictUpload.Image = null;
            label1.Text = "";
            btnTransaksi.Text = "Transaksi";
            btnBatal.Visible = false;
            tbbayar.ReadOnly = true;
            hapus();
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
                    }
                }
                else if (CBpencarian.Text == "Nama Barang")
                {
                    if (tbPencarian.text == "")
                    {
                        tampil();
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
                    }
                }
            }
            catch (Exception r) {
                tampil();
            }
        }
        void hapus()
        {
            tbID.Text = "";
            tbNama.Text = "";
            tbPencarian.text = "";
            TbUkuran.Text = "";
            TbWarna.Text = "";
            tbHarga.Text = "";
            tbkembalian.Text = "";
            tbbayar.Text = "";
            PictUpload.Image = null;
            PictUpload.BackgroundImage = percobaan.Properties.Resources.pic2;
            tabelBarang.Enabled = true;
        }

        private void tabelBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbbayar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (tbbayar.Text == "")
                {
                    if(tbkembalian.Text=="Uang Kurang!")
                        tbkembalian.Text = "";
                }
                else
                {
                    int harga = int.Parse(tbHarga.Text.ToString());
                    int bayar = int.Parse(tbbayar.Text.ToString());
                    if (harga > bayar)
                    {
                        tbkembalian.Text = "Uang Kurang!";
                    }
                    else if (harga < bayar)
                    {
                        int kembalian = bayar - harga;
                        tbkembalian.Text = kembalian.ToString();
                    }
                    else if (harga == bayar)
                    {
                        tbkembalian.Text = "0";
                    }
                }

            }
            catch
            { }
        }
    }
}
