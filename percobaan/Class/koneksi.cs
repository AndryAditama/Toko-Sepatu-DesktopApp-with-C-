using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace percobaan
{
    class koneksi
    {
        
        string konek;
        MySqlConnection conn;

        public koneksi()
        {
            this.konek = "datasource=localhost;port=3306;username=root;password=;database=dbtoko";
        }

        public DataTable ambildata(string query)
        {
            DataTable dt=new DataTable();
            conn = new MySqlConnection(konek);
            conn.Open();
            MySqlCommand cmd=new MySqlCommand(query,conn);
            MySqlDataReader datareader=cmd.ExecuteReader();
            dt.Load(datareader);
            conn.Close();
            return dt;
        }
        public void insertData(Class_Admin insertadmin)
        {
            try
            {
                conn = new MySqlConnection(konek);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into tbuser (nama, username, password) values(@nama,@username,@password)";
                cmd.Parameters.AddWithValue("@id_user", insertadmin.iduser);
                cmd.Parameters.AddWithValue("@nama", insertadmin.nama);
                cmd.Parameters.AddWithValue("@username", insertadmin.username);
                cmd.Parameters.AddWithValue("@password", insertadmin.password);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            { 

            }

        }

        public void updateData(Class_Admin UPadmin)
        {
            try
            {
                conn = new MySqlConnection(konek);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tbuser set nama=@nama, username=@username, password=@password where iduser=@id_user";
                cmd.Parameters.AddWithValue("@id_user", UPadmin.iduser);
                cmd.Parameters.AddWithValue("@nama", UPadmin.nama);
                cmd.Parameters.AddWithValue("@username", UPadmin.username);
                cmd.Parameters.AddWithValue("@password", UPadmin.password);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {

            }

        }

        public void deleteData(Class_Admin del)
        {
            try
            {
                conn = new MySqlConnection(konek);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM tbuser WHERE iduser=@id_user";
                cmd.Parameters.AddWithValue("@id_user", del.iduser);
                
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {

            }

        }
        
    }
}
