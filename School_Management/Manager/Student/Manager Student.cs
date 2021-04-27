﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management.Manager.Course;
using School_Management.Manager.Score;
namespace School_Management.Manager.Student
{
    public partial class Manager_Student : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Manager_Student()
        {
            InitializeComponent();
        }

        private void M010401_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_Students add = new Add_Students();
            add.Show();
        }

        private void M010103_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to close program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            { 

            }
        }
        private void M010201_ItemClick(object sender, ItemClickEventArgs e)
        {
            Manager_General manager = new Manager_General();
            manager.Show();
        }

        private void Manager_Student_Load(object sender, EventArgs e)
        {
        }

        private void M010202_ItemClick(object sender, ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet.Add_Student' table. You can move, or remove it, as needed.
            this.add_StudentTableAdapter.Fill(this.manager_StudentDataSet.Add_Student);
            List_Student manager = new List_Student();
            manager.Show();
        }

        private void M010403_ItemClick(object sender, ItemClickEventArgs e)
        {
            List list = new List();
            list.ShowDialog();
        }

        private void DataGrid_Student_Click(object sender, EventArgs e)
        { 

        }

        private void M010404_ItemClick(object sender, ItemClickEventArgs e)
        {
            Find_Student find = new Find_Student();
            find.ShowDialog();
        }

        private void M010203_ItemClick(object sender, ItemClickEventArgs e)
        {
            Print_List_Student print = new Print_List_Student();
            print.Show();
        }

        private void M010501_ItemClick(object sender, ItemClickEventArgs e)
        {
            Statics sta = new Statics();
            sta.ShowDialog();
        }
        private void M020201_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_Course add = new Add_Course();
            add.ShowDialog();
        }

        private void M020205_ItemClick(object sender, ItemClickEventArgs e)
        {
            Find_Course find = new Find_Course();
            find.ShowDialog();
        }

        private void M020202_ItemClick(object sender, ItemClickEventArgs e)
        {
            Edit_Course edit = new Edit_Course();
            edit.ShowDialog();
        }

        private void M020203_ItemClick(object sender, ItemClickEventArgs e)
        {
            Edit_Course edit = new Edit_Course();
            edit.ShowDialog();
        }

        private void M020103_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListCourse list = new ListCourse();
            list.ShowDialog();
        }

        private void M020101_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Manager_Course manager = new Manager_Course();
                manager.ShowDialog();
            }
            catch
            {
                MessageBox.Show("The information a new record is blank. Please enter again!", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void M030101_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_Score add = new Add_Score();
            add.ShowDialog();
        }
    }
}