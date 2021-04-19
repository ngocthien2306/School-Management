using DevExpress.XtraBars;
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
        }

        private void DataGrid_Student_Click(object sender, EventArgs e)
        {
            DataGrid_Student.Height = 40;
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
    }
}