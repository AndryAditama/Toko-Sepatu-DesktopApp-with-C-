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
    public partial class dashboard : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        koneksi cek = new koneksi();
        public string USER;

        public dashboard(string user)
        {
            this.USER = user;
            random=new Random();
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            lblinfo.Text = "Halo, " + USER;
        }

        private Color SelectTema()
        {
            int index = random.Next(temaWarna.ColorList.Count);
            while (tempIndex == index) {
              index = random.Next(temaWarna.ColorList.Count());
            }
            tempIndex = index;
            string color = temaWarna.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void activateButton(object btnsender)
        {
            if(btnsender!=null)
            {
                if(currentButton!=(Button)btnsender)
                {
                    disableButton();
                    Color color=SelectTema();
                    currentButton=(Button)btnsender;
                    currentButton.BackColor=color;
                    currentButton.ForeColor=Color.White;
                    currentButton.Font=new System.Drawing.Font("Segoe UI",14F, System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(0)));
                    paneltitle.BackColor = color;
                    panellogo.BackColor = temaWarna.ChangeColorBrightness(color,-0.3);
                }
            }
        }
        private void disableButton()
        {
            foreach(Control previousBtn in panelmenu.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor=Color.FromArgb(51,51,76);
                    previousBtn.ForeColor=Color.Gainsboro;
                    previousBtn.Font=new System.Drawing.Font("Segoe UI",12F, System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(0)));
                    
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activateButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltitle.Text = childForm.Text;
        }

        private void btndataAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDataAdmin(), sender);
        }

        private void btndataBarang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDataBarang(), sender);
        }

        private void btndataPengeluaran_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDataPengeluaran(), sender);
        }

        private void btnaTransaksi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTransaksi(lblinfo.Text), sender);
        }

        private void btndataTransaksi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDataTransaksi(), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home(), sender);
        }

        private void labeltitle_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_login openlogin = new Form_login();
            openlogin.Show();
            this.Close();
        }




    }
}
