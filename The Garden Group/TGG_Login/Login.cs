using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGG_Model;
using TGG_Service;

namespace TGG_App
{
    public partial class Login : Form
    {
        User_Service user_Service = new User_Service();
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (user_Service.verifyUserCredentials(UnameTxtbox.Text, PasswdTxtbox.Text) == true)
            {
                //testing only
                User oneUser = new User();
                oneUser = user_Service.GetUserByUserName(UnameTxtbox.Text);
                string message ="Username: "+ oneUser.Username+ " and User role: " + oneUser.role + "";
                MessageBox.Show(message);
            }
            else
            {
              MessageBox.Show("Username or Password incorrect");
            }

        }

        private void RemMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ForgorPassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
