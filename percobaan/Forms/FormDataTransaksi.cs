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
    public partial class FormDataTransaksi : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=dbtoko");
        public FormDataTransaksi()
        {
            InitializeComponent();
        }

        void tampil()
        {
            conn.Open();
            string select = "SELECT * FROM tbtransaksi";
            MySqlCommand updatedatagridcmd = new MySqlCommand(select, conn);
            MySqlDataAdapter sd = new MySqlDataAdapter(updatedatagridcmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            tabelTransaksi.DataSource = dt;
            dtpTanggal.Text = DateTime.Now.ToString();
            conn.Close();
        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void FormDataTransaksi_Load(object sender, EventArgs e)
        {
            tampil();
            total();
            
        }

        private void tabelTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = tabelTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbNama.Text = tabelTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            TbUkuran.Text = tabelTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            TbWarna.Text = tabelTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbHarga.Text = tabelTransaksi.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpTanggal.Text = tabelTransaksi.Rows[e.RowIndex].Cells[6].Value.ToString();
        }


        private void tbPencarian_OnTextChange_1(object sender, EventArgs e)
        {
            if (CBpencarian.Text == "ID Transaksi")
            {
                if (tbPencarian.text == "")
                {
                    tampil();
                    total();
                }
                else
                {
                    conn.Open();
                    string select = "SELECT * FROM tbtransaksi WHERE idtransaksi LIKE '%" + tbPencarian.text + "%' ";
                    MySqlCommand updatedatagridcmd = new MySqlCommand(select, conn);
                    MySqlDataAdapter sd = new MySqlDataAdapter(updatedatagridcmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    tabelTransaksi.DataSource = dt;
                    dtpTanggal.Text = DateTime.Now.ToString();
                    conn.Close();
                    total();
                }
            }
            else if (CBpencarian.Text == "ID Barang")
            {
                if (tbPencarian.text == "")
                {
                    tampil();
                    total();
                }
                else
                {
                    conn.Open();
                    string select = "SELECT * FROM tbtransaksi WHERE idbarang LIKE '%" + tbPencarian.text + "%' ";
                    MySqlCommand updatedatagridcmd = new MySqlCommand(select, conn);
                    MySqlDataAdapter sd = new MySqlDataAdapter(updatedatagridcmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    tabelTransaksi.DataSource = dt;
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
                    string select = "SELECT * FROM tbtransaksi WHERE tanggal LIKE '%" + tbPencarian.text + "%' ";
                    MySqlCommand updatedatagridcmd = new MySqlCommand(select, conn);
                    MySqlDataAdapter sd = new MySqlDataAdapter(updatedatagridcmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    tabelTransaksi.DataSource = dt;
                    dtpTanggal.Text = DateTime.Now.ToString();
                    conn.Close();
                    total();
                }
            }          
        }

        void total()
        {
            int[] columdata = (from DataGridViewRow row in tabelTransaksi.Rows
                               where row.Cells[5].FormattedValue.ToString() != string.Empty
                               select Convert.ToInt32(row.Cells[5].FormattedValue)).ToArray();
            tbTotal.Text ="Rp. " + columdata.Sum().ToString();
            //tbTotal.Text = tabelTransaksi.Rows.Count.ToString();
        }

    }
}
