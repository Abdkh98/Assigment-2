using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_11
{
    public partial class frmLogin : Form
    {

        private User user1;
        private User user2;
        private User user3;
        private User user4;
        private User user5;
        private User user6;

        private List<User> users;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            user1 = new User();
            user1.UserId = 1;
            user1.FullName = "Khaled Mohammad";
            user1.Username = "KM";
            user1.Password = "1234";


            user2 = new User();
            user2.UserId = 2;
            user2.FullName = "Suad Ahmad";
            user2.Username = "SA";
            user2.Password = "5678";

            user3 = new User();
            user3.UserId = 3;
            user3.FullName = "HALA MAHMOUD";
            user3.Username = "HM";
            user3.Password = "1111";

            user4 = new User();
            user4.UserId = 4;
            user4.FullName = "SAMI FOUAD";
            user4.Username = "SF";
            user4.Password = "0000";

            user5 = new User();
            user5.UserId = 5;
            user5.FullName = "FAHAD REYAD";
            user5.Username = "FR";
            user5.Password = "1212";

            user6 = new User();
            user6.UserId = 6;
            user6.FullName = "AMRRE AHMAD";
            user6.Username = "AA";
            user6.Password = "1313";



            users = new List<User>(); // We created the actual object for the list of users

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);
            users.Add(user6);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int i = 0;
            for (; i < users.Count; i++)
            {
                if (users[i].Password == txtPassword.Text && users[i].Username == txtUsername.Text)
                    MessageBox.Show("Welcome " + users[i].FullName);

            }


           /* if (users[i].Username != txtUsername.Text)
            {
                MessageBox.Show("User does not exist");
            }
            else
            {
                MessageBox.Show("Wrong password");
            }*/


        }




        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    


