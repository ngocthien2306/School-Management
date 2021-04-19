using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace School_Management.Manager.Student
{
    public partial class Manager_General : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Manager_General()
        {
            InitializeComponent();
        }

        private void Fname_lb_Click(object sender, EventArgs e)
        {

        }
        private void Add_bt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add_Students add = new Add_Students();
            Student student = new Student();
            int Id = Convert.ToInt32(ID_student.Text);
            string firstname = this.Firstname.Text;
            string lastname = this.Lastname.Text;
            DateTime birthday = Birthday_picker.DateTime;
            string phone = this.Phone_student.Text;
            string address = this.Address_student.Text;
            string gender = "Female";
            if (Check_male.Checked == true)
            {
                Check_female.Checked = false;
                gender = "Male";
            }

            MemoryStream pic = new MemoryStream();
            //int born_year = Convert.ToInt32(Birthday_picker.ToString());
            //int this_year = DateTime.Now.Year;
            //if (this_year - born_year < 10 || this_year - born_year > 100)
            //{
            //    MessageBox.Show("The student age must be 10 to 100 year", "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (!add.Check())
            {
                Picture_Student.Image.Save(pic, Picture_Student.Image.RawFormat);
                if (student.AddStudent(Id, firstname, lastname, birthday, gender, address, phone, pic))
                {
                    MessageBox.Show("New student added", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Edit_bt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit_Remove edit = new Edit_Remove();
            edit.ID_student.Text = ID_student.Text;
            edit.Firstname.Text = Firstname.Text;
            edit.Lastname.Text = Lastname.Text;
            edit.Birthday_picker.DateTime = Birthday_picker.DateTime;
            edit.Phone_student.Text = Phone_student.Text;
            edit.Address_student.Text = Address_student.Text;
            edit.Check_male.Text = "Male";
            if(edit.Check_male.Checked)
            {
                edit.Check_female.Text = "Female";
            }
            edit.Picture_Student.Image = Picture_Student.Image;
            edit.Edit();
        }

        private void Remove_bt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit_Remove edit = new Edit_Remove();
            edit.ID_student.Text = ID_student.Text;
            edit.Remove();
        }

        private void Manager_General_Load(object sender, EventArgs e)
        {
            this.ShowList();
        }
        protected bool ShowList()
        {
            try
            {
                My_Database dataBase = new My_Database();
                dataBase.Openconnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Add_Student", dataBase.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Add_Student");
                dataBase.Closeconnection();

                DataSource_Student.RowTemplate.Height = 85;
                DataTable table = dataSet.Tables["Add_Student"];
                DataSource_Student.DataSource = table;
                DataSource_Student.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)DataSource_Student.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DataSource_Student.AllowUserToAddRows = false;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }
        private void Reload_Grid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowList();
        }
        public bool OpenEdit()
        {
            try
            {
                ID_student.Text = DataSource_Student.CurrentRow.Cells[0].Value.ToString().Trim();
                Firstname.Text = DataSource_Student.CurrentRow.Cells[1].Value.ToString().Trim();
                Lastname.Text = DataSource_Student.CurrentRow.Cells[2].Value.ToString().Trim();
                Birthday_picker.DateTime = (DateTime)DataSource_Student.CurrentRow.Cells[3].Value;
                if (DataSource_Student.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
                {
                    Check_male.Checked = true;
                }
                else if (DataSource_Student.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
                {
                    Check_female.Checked = true;
                    
                }
                Address_student.Text = DataSource_Student.CurrentRow.Cells[5].Value.ToString().Trim();
                Phone_student.Text = DataSource_Student.CurrentRow.Cells[6].Value.ToString().Trim();
                byte[] byteImage = (byte[])DataSource_Student.CurrentRow.Cells[7].Value;
                MemoryStream stream = new MemoryStream(byteImage);
                Picture_Student.Image = Image.FromStream(stream);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }
        private void DataSource_Student_DoubleClick(object sender, EventArgs e)
        {
            this.OpenEdit();
        }

        private void Load_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Picture_Student.Image = Image.FromFile(open.FileName);
            }
        }

        private void Reset_bt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ID_student.Text = "";
            Firstname.Text = "";
            Lastname.Text = "";
            Phone_student.Text = "";
            Address_student.Text = "";
            Picture_Student.Image = null;
            Birthday_picker.DateTime = DateTime.Now;
            Check_male.Checked = false;
            Check_female.Checked = false;
        }

        private void Find_bt_Click(object sender, EventArgs e)
        {
            if (Find_tb.Text.Trim() == "")
            {
                MessageBox.Show("Wrong! You should enter keyword to search", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                Student student = new Student();
                DataTable table = student.findByHint(Find_tb.Text);
                table = student.StudentsTableNaming(table);
                DataSource_Student.RowTemplate.Height = 80;
                DataSource_Student.DataSource = table;
                DataSource_Student.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)DataSource_Student.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DataSource_Student.AllowUserToAddRows = false;
            }
        }

        private void Check_male_CheckedChanged(object sender, EventArgs e)
        {
            Check_female.Checked = false;
        }

        private void Check_female_CheckedChanged(object sender, EventArgs e)
        {
            Check_male.Checked = false;
        }
    }
}