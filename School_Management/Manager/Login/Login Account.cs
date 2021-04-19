﻿using DevExpress.XtraEditors;
using School_Management.Manager.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management.Manager.Login
{
    public partial class Login_Account : DevExpress.XtraEditors.XtraForm
    {
        public Login_Account()
        {
            InitializeComponent();
        }
        My_Database connect = new My_Database();

        private void Login_bt_Click(object sender, EventArgs e)
        {
            try
            {
                string user = User_text.Text;
                string pass = Password_text.Text;
                Users users = new Users();
                if (users.Login(user, pass))
                {
                    MessageBox.Show("Login Successful! Please click OK to continue", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Manager_Student manager = new Manager_Student();
                    manager.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed, your name or pass incorrect!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    User_text.Text = "";
                    Password_text.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}