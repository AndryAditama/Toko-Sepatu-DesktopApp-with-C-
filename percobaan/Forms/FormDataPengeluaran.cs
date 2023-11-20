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

namespace percobaan.Forms
{
    public partial class FormDataPengeluaran : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=dbtoko");
        MySqlCommand cmd;

        public FormDataPengeluaran()
        {
            InitializeComponent();
        }

        private void FormDataPengeluaran_Load(object sender, EventArgs e)
        {
            tampil();
            total();
        }

        void hapustext()
        {

            tbKeperluan.Text = "";
            TbJumlahKeluar.Text = "";
        }

        void reload()
        {
            if (btnReload.Text == "Reload")
            {
                tampil();
                hapustext();
                total();
            }
            else if(btnReload.Text=="Batal")
            {
                tampil();
                hapustext();
                total();

                btnTambah.Text = "Tambah";
                btnReload.Text = "Reload";
                btnEdit.Text = "Edit";
                btnEdit.Enabled = true;
                btnHapus.Enabled = true;
                btnTambah.Enabled = true;
                tabelPengeluaran.Enabled = true;
         
            }
        }

        void tambah()
        {
            if (btnTambah.Text == "Tambah")
            {
                btnTambah.Text = "Simpan";
                btnReload.Text = "Batal";
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
                tabelPengeluaran.Enabled = false;

                tbKeperluan.ReadOnly = false;
                TbJumlahKeluar.ReadOnly = false;
                dtpTanggal.Enabled = true;
                dtpTanggal.Text = DateTime.Now.ToString();
                hapustext();
                tbKeperluan.Focus();
            }
            else if(btnTambah.Text=="Simpan")
            {
                
                
                if (tbKeperluan.Text == "" || TbJumlahKeluar.Text == "" || dtpTanggal.Value == null)
                {
                    MessageBox.Show(null, "Data Tidak Lengkap. Tolong Dilengkapi!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //pesan jika data gagal ditampilkan/data tidak lengkap
                }
                else
                {
                    string a = getTanggal(dtpTanggal.Value.ToString());

                    conn.Open();

                    string query = "Insert into tbpengeluaran (keperluan, jumlah, tanggal) values(@keperluan, @jumlah, @tanggal)";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keperluan", tbKeperluan.Text);
                    cmd.Parameters.AddWithValue("@jumlah", TbJumlahKeluar.Text);
                    cmd.Parameters.AddWithValue("@tanggal", a);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(null, "Berhasil Menambah Data!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //pesan jika data berhasil ditampilkan
                    }
                    conn.Close();
                    btnTambah.Text = "Tambah";
                    btnEdit.Enabled = true;
                    btnHapus.Enabled = true;
                    btnReload.Text = "Reload";
                    hapustext();
                    tabelPengeluaran.Enabled = true;
                    total();
                    tampil();

                }

            }
        }

        void edit()
        {
            if (btnEdit.Text == "Edit")
            {
                btnTambah.Text = "Simpan";
                btnEdit.Text = "Update";
                btnReload.Text = "Batal";
                btnTambah.Enabled = false;
                btnHapus.Enabled = false;
                tabelPengeluaran.Enabled = false;

                tbKeperluan.ReadOnly = false;
                TbJumlahKeluar.ReadOnly = false;
                dtpTanggal.Enabled = true;

                tbKeperluan.Focus();
            }
            else if (btnEdit.Text == "Update")
            {
                
                if (tbKeperluan.Text == "" || TbJumlahKeluar.Text == "" || dtpTanggal.Value == null)
                {
                    MessageBox.Show(null, "Data Tidak Lengkap. Tolong Dilengkapi!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //pesan jika data gagal ditampilkan/data tidak lengkap
                }
                else
                {
                    

                    string a = getTanggal(dtpTanggal.Value.ToString());
                    conn.Open();
                    string idbarang = label1.Text;
                    
                    string query = "update tbpengeluaran set keperluan=@keperluan, jumlah=@jumlah, tanggal=@tanggal where id=@id";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id",idbarang);
                    cmd.Parameters.AddWithValue("@keperluan", tbKeperluan.Text);
                    cmd.Parameters.AddWithValue("@jumlah", TbJumlahKeluar.Text);
                    cmd.Parameters.AddWithValue("@tanggal", a);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(null, "Update Data Berhasil!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //pesan jika data berhasil ditampilkan
                    }
                    conn.Close();
                    reload();
                    hapustext();
                    total();
                    tampil();
                    tabelPengeluaran.Enabled = true;
                }

            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tambah();
        }

        string getTanggal(string tanggal)
        {
            string hasil = "";
            var dt = tanggal.Split(' ');

            var tgl = dt[0].Split('/');

            if (tgl[1] == "01")
            {
                hasil = tgl[0].PadLeft(2, '0') + " Januari " + tgl[2];
            }
            else if (tgl[1] == "02")
            {
                hasil = tgl[0].PadLeft(2, '0') + " Februari " + tgl[2];
            }
            else if (tgl[1] == "03")
            {
                hasil = tgl[0].PadLeft(2, '0') + " Maret " + tgl[2];
            }
            else if (tgl[1] == "04")
            {
                hasil = tgl[0].PadLeft(2, '0') + " April " + tgl[2];
            }
            else if (tgl[1] == "05")
            {
                hasil = tgl[0].PadLeft(2, '0') + " Mei " + tgl[2];
            }
            else if (tgl[1] == "06")
            {
                hasil = tgl[0].PadLeft(2, '0') + " Juni " + tgl[2];
            }
            else if (tgl[1] == "07")
            {
                hasil = tgl[0].PadLeft(2, '0') + " Juli " + tgl[2];
            }
            else if (tgl[1] == "08")
            {
                hasil = tgl[0].PadLeft(2, '0') + " Agustus " + tgl[2];
            }
            else if (tgl[1] == "09")
            {
                hasil = tgl[0].PadLeft(2, '0') + " September " + tgl[2];
            }
            else if (tgl[1] == "10")
            {
                hasil = tgl[0].PadLeft(2, '0') + " Oktober " + tgl[2];
            }
            else if (tgl[1] == "11")
            {
                hasil = tgl[0].PadLeft(2, '0') + " November " + tgl[2];
            }
            else if (tgl[1] == "12")
            {
                hasil = tgl[0].PadLeft(2, '0') + " Desember " + tgl[2];
            }

            //hasil = tgl[2] + '-' + tgl[0].PadLeft(2, '0') + '-' + tgl[1].PadLeft(2, '0');

            return hasil;

        }
        void tampil()
        {
            
            conn.Open();
            string select = "SELECT id, keperluan, jumlah, tanggal FROM tbpengeluaran";
            MySqlCommand updatedatagridcmd = new MySqlCommand(select, conn);
            MySqlDataAdapter sd = new MySqlDataAdapter(updatedatagridcmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            tabelPengeluaran.DataSource = dt;
            conn.Close();
            dtpTanggal.Enabled = false;
            total();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void tabelPengeluaran_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            tbKeperluan.Text = tabelPengeluaran.Rows[e.RowIndex].Cells[1].Value.ToString();
            TbJumlahKeluar.Text = tabelPengeluaran.Rows[e.RowIndex].Cells[2].Value.ToString();
            label1.Text = tabelPengeluaran.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tg = tabelPengeluaran.Rows[e.RowIndex].Cells[3].Value.ToString();
            

            string hsl = "";
            var edt = tg.Split(' ');

            if (edt[1] == "Januari")
            {
                hsl = edt[0]+"/01/"+edt[2];
            }
            else if (edt[1] == "Februari")
            {
                hsl = edt[0] + "/02/" + edt[2];
            }
            else if (edt[1] == "Maret")
            {
                hsl = edt[0] + "/03/" + edt[2];
            }
            else if (edt[1] == "April")
            {
                hsl = edt[0] + "/04/" + edt[2];
            }
            else if (edt[1] == "Mei")
            {
                hsl = edt[0] + "/05/" + edt[2];
            }
            else if (edt[1] == "Juni")
            {
                hsl = edt[0] + "/06/" + edt[2];
            }
            else if (edt[1] == "Juli")
            {
                hsl = edt[0] + "/07/" + edt[2];
            }
            else if (edt[1] == "Agustus")
            {
                hsl = edt[0] + "/08/" + edt[2];
            }
            else if (edt[1] == "September")
            {
                hsl = edt[0] + "/09/" + edt[2];
            }
            else if (edt[1] == "Oktober")
            {
                hsl = edt[0] + "/10/" + edt[2];
            }
            else if (edt[1] == "November")
            {
                hsl = edt[0] + "/11/" + edt[2];
            }
            else if (edt[1] == "Desember")
            {
                hsl = edt[0] + "/12/" + edt[2];
            }

            label2.Text = hsl;
            dtpTanggal.Text = hsl;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null,"Yakin Menghapus Data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM tbpengeluaran WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", label1.Text);
                
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                
                tampil();
                MessageBox.Show("Data Berhasil Dihapus");
                hapustext();
                total();
            }

        }

        private void tbPencarian_OnTextChange(object sender, EventArgs e)
        {
            try
            {
                if (CBpencarian.Text == "Keperluan")
                {
                    if (tbPencarian.text == "")
                    {
                        tampil();
                        total();
                    }
                    else
                    {
                        conn.Open();
                        string select = "SELECT * FROM tbpengeluaran WHERE keperluan LIKE '%" + tbPencarian.text + "%' ";
                        MySqlCommand updatedatagridcmd = new MySqlCommand(select, conn);
                        MySqlDataAdapter sd = new MySqlDataAdapter(updatedatagridcmd);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);

                        tabelPengeluaran.DataSource = dt;
                        dtpTanggal.Text = DateTime.Now.ToString();
                        conn.Close();
                        total();
                    }
                }
                else if (CBpencarian.Text == "Tanggal")
                {
                    if (tbPencarian.text == "")
                    {
                        tampil();
                        total();
                    }
                    else
                    {
                        conn.Open();
                        string select = "SELECT * FROM tbpengeluaran WHERE tanggal LIKE '%" + tbPencarian.text + "%' ";
                        MySqlCommand updatedatagridcmd = new MySqlCommand(select, conn);
                        MySqlDataAdapter sd = new MySqlDataAdapter(updatedatagridcmd);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);

                        tabelPengeluaran.DataSource = dt;
                        dtpTanggal.Text = DateTime.Now.ToString();
                        conn.Close();
                        total();
                    }
                }
            }
            catch (Exception er)
            {
                tampil();
            }
        }

        void total()
        {
            int[] columdata = (from DataGridViewRow row in tabelPengeluaran.Rows
                               where row.Cells[2].FormattedValue.ToString() != string.Empty
                               select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();
            tbTotal.Text = "Rp. " + columdata.Sum().ToString();
        }

        
    }
}
