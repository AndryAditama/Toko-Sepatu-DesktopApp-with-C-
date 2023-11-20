using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace percobaan.Forms
{
    public partial class FormDataAdmin : Form
    {
        koneksi admin = new koneksi();

        public FormDataAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            tampil();
        }

        void hapustext()
        {
            tbID.Text = "";
            tbNama.Text = "";
            TbUsername.Text = "";
            Tbpassword.Text = "";
        }

        void tampil()
        {
            string query = "select * from tbuser"; //perintah untuk membaca data di dalam DB
            DataTable tampil = admin.ambildata(query); //jalankan function datatable
            tabelAdmin.DataSource = tampil; //menampilkan data pada datagridview
            
           // MessageBox.Show(null, "Berhasil Menampilkan Data!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //pesan jika data berhasil ditampilkan

            tbID.ReadOnly = true;
            tbNama.ReadOnly = true;
            TbUsername.ReadOnly = true;
            Tbpassword.ReadOnly = true;
        }
        
        void reload()
        {
            if (btnReload.Text == "Reload")
            {
                tampil();
                hapustext();
            }
            else
            {
                tampil();
                hapustext();

                btnTambah.Text = "Tambah";
                btnReload.Text = "Reload";
                btnEdit.Text = "Edit";
                btnEdit.Enabled = true;
                btnHapus.Enabled = true;
                btnTambah.Enabled = true;
                tabelAdmin.Enabled = true;
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
                tabelAdmin.Enabled = false;
                tbID.ReadOnly = true;
                tbID.Text="ID Diisi Otomatis";
                tbNama.ReadOnly = false;
                TbUsername.ReadOnly = false;
                Tbpassword.ReadOnly = false;
                tbNama.Text = "";
                TbUsername.Text = "";
                Tbpassword.Text = "";
                
                tbNama.Focus();
            }
            else
            {
                Class_Admin adm = new Class_Admin();
                adm.iduser = tbID.Text;
                adm.nama = tbNama.Text;
                adm.username = TbUsername.Text;
                adm.password = Tbpassword.Text;


                if (tbNama.Text == "" || TbUsername.Text == "" || Tbpassword.Text == "")
                {
                    MessageBox.Show(null, "Data Tidak Lengkap. Tolong Dilengkapi!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //pesan jika data gagal ditampilkan/data tidak lengkap
                }
                else
                {
                    admin.insertData(adm);
                    tampil();

                    btnTambah.Text = "Tambah";
                    btnReload.Text = "Reload";
                    btnEdit.Enabled = true;
                    btnHapus.Enabled = true;
                    tabelAdmin.Enabled = true;
                    tbNama.ReadOnly = true;
                    TbUsername.ReadOnly = true;
                    Tbpassword.ReadOnly = true;

                    MessageBox.Show(null, "Berhasil Menambah Data!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //pesan jika data berhasil ditampilkan
                }

            }
        }

        void edit()
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Update";
                btnReload.Text = "Batal";
                btnTambah.Enabled = false;
                btnHapus.Enabled = false;
                tabelAdmin.Enabled = false;
                tbID.ReadOnly = true;
                tbNama.ReadOnly = false;
                TbUsername.ReadOnly = false;
                Tbpassword.ReadOnly = false;

                tbNama.Focus();
            }
            else
            {
                Class_Admin adm = new Class_Admin();
                adm.iduser = tbID.Text;
                adm.nama = tbNama.Text;
                adm.username = TbUsername.Text;
                adm.password = Tbpassword.Text;


                if (tbNama.Text == "" || TbUsername.Text == "" || Tbpassword.Text == "")
                {
                    MessageBox.Show(null, "Data Tidak Lengkap. Tolong Dilengkapi!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //pesan jika data gagal ditampilkan/data tidak lengkap
                }
                else
                {
                    admin.updateData(adm);
                    tampil();

                    btnEdit.Text = "Edit";
                    btnReload.Text = "Reload";
                    btnTambah.Enabled = true;
                    btnEdit.Enabled = true;
                    btnHapus.Enabled = true;
                    tabelAdmin.Enabled = true;
                    tbNama.ReadOnly = true;
                    TbUsername.ReadOnly = true;
                    Tbpassword.ReadOnly = true;

                    MessageBox.Show(null, "Update Data Berhasil!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //pesan jika data berhasil ditampilkan
                }

            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tambah();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void tabelAdmin_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = tabelAdmin.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNama.Text = tabelAdmin.Rows[e.RowIndex].Cells[1].Value.ToString();
            TbUsername.Text = tabelAdmin.Rows[e.RowIndex].Cells[2].Value.ToString();
            Tbpassword.Text = tabelAdmin.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null,"Yakin Menghapus Data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Class_Admin delete = new Class_Admin();
                delete.iduser = tbID.Text;
                delete.nama = tbNama.Text;
                delete.username = TbUsername.Text;
                delete.password = Tbpassword.Text;
                admin.deleteData(delete);
                tampil();
                MessageBox.Show("Data Berhasil Dihapus");
            }

        }

    }
}
