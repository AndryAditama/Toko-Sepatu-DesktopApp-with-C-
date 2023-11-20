using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percobaan
{
    class Class_Admin
    {
        private string ID_user, nama_user, user, pass;

        public string iduser
        {
            get { return ID_user; }
            set { ID_user = value; }
        }
        public string nama
        {
            get { return nama_user; }
            set { nama_user = value; }
        }
        public string username
        {
            get { return user; }
            set { user = value; }
        }
        public string password
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}
