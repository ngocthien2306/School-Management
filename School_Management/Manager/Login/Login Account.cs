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

        private void Login_bt_Click_1(object sender, EventArgs e)
        {
            try
            {
                string user = User_tb.Text;
                string pass = Pass_tb.Text;
                Users users = new Users();
                if (users.Login(user, pass))
                {
                    Manager_Student manager = new Manager_Student();
                    Progress progress = new Progress();
                    progress.Show();
                    manager.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed, your name or pass incorrect!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    User_tb.Text = "";
                    Pass_tb.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void User_tb_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Pass_tb_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void Link_account_Click(object sender, EventArgs e)
        {
            Create_Account create = new Create_Account();
            create.ShowDialog();
        }

        private void Exit_bt_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to close program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}