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

namespace percobaan
{
    public partial class Form_login : Form
    {
        string alamat, query;
        MySqlConnection koneksi;
        MySqlCommand perintah;
        MySqlDataReader reader;

        public Form_login()
        {

            InitializeComponent();
            alamat = string.Format("datasource=localhost;port=3306;username=root;password=;database=dbtoko");
            koneksi = new MySqlConnection(alamat);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text != "" && tbPass.Text != "")
            {
                string user = tbUser.Text;
                string pass = tbPass.Text;
                koneksi.Open();
                query = string.Format("select * from tbuser where username='" + user + "' " + " and password= '" + pass + "'");
                perintah = new MySqlCommand(query, koneksi);
                reader = perintah.ExecuteReader();

                int log = 0;
                while (reader.Read())
                {
                    log = log + 1;
                }
                if (log == 1)
                {
                    koneksi.Close();
                    dashboard opendahsboard = new dashboard(tbUser.Text);
                    opendahsboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username dan Password Salah!");
                    koneksi.Close();
                }
            }
            else
            {
                MessageBox.Show(null,"Isi Username Dan Password!","Info",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

        private void tbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
                
            }
        }
    }
}
