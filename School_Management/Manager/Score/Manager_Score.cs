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
using School_Management.Manager.Course;
using School_Management.Manager.Student;
using System.Data.SqlClient;
using DevExpress.XtraBars.Docking2010;

namespace School_Management.Manager.Score
{
    public partial class Manager_Score : DevExpress.XtraEditors.XtraForm
    {
        My_Database data = new My_Database();
        Courses course;
        Students student;
        Scores score;
        DataTable table;
        public Manager_Score()
        {
            InitializeComponent();
            course = new Courses();
            student = new Students();
            score = new Scores();
            foreach (WindowsUIButton navButton in windowsUIButtonPanel1.Buttons)
            {
                navButton.Style = ButtonStyle.CheckButton;
                navButton.GroupIndex = 1;
                navButton.UseCaption = true;
                navButton.Checked = false;

            }
        }

        private void Manager_Score_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Student.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.dataSet_Student.Course);
            // TODO: This line of code loads data into the 'dataSet_Student.Score' table. You can move, or remove it, as needed.
            this.scoreTableAdapter.Fill(this.dataSet_Student.Score);
            // TODO: This line of code loads data into the 'dataSet_Student.Add_Student' table. You can move, or remove it, as needed.
            this.add_StudentTableAdapter.Fill(this.dataSet_Student.Add_Student);
            //this.scoreTableAdapter.Fill(this.dataSet_Student.Score);
            //getAllstudent = new SqlCommand()
            //{
            //    CommandText = "SELECT id, firstname, lastname FROM Add_Student"
            //};
            //GridControl.DataSource = student.GetStudents(getAllstudent);

            table = course.GetAll_ID_label();
            foreach (DataRow row in table.Rows)
            {
                ComboBox_Course.Items.Add(row[1].ToString().Trim());
            }
        }
        public void RemoveScore()
        {
            try
            {
                DialogResult data = MessageBox.Show("Are you sure detele this record?", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (data == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(Id_tb.Text);
                    int cid = Convert.ToInt32(table.Rows[ComboBox_Course.SelectedIndex][0].ToString());
                    if (score.Delete_Score(id, cid))
                    {
                        MessageBox.Show("Delete successful!", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed!", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("Error!!! Tip: Check textbox or combobox", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AddScore()
        {
            

            try
            {
                if (Id_tb.Text == ""
                            || ComboBox_Course.SelectedIndex == -1
                            || Rich_desc.Text == ""
                            || Score_tb.Text == "")
                {

                    MessageBox.Show("The textboxs are blank, please enter again!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int id = Convert.ToInt32(Id_tb.Text);
                    float sc = (float)Convert.ToDouble(Score_tb.Text);
                    string des = Rich_desc.Text;
                    int cid = Convert.ToInt32(table.Rows[ComboBox_Course.SelectedIndex][0].ToString());
                    if (score.Add_Score(id, cid, sc, des))
                    {
                        MessageBox.Show("Add score successful!!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void windowsUIButtonPanel1_ButtonChecked(object sender, ButtonEventArgs e)
        {


            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "A1":
                    this.AddScore();
                    break;
                case "A2":
                    this.RemoveScore();
                    break;
                case "A3":
                    this.add_StudentTableAdapter.Fill(this.dataSet_Student.Add_Student);
                    break;
            }
        }

        private void Show_student_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = score.GetStudentScore();
        }

        private void ShowScore_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = score.GetAllScore();
        }
        private void scoreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

    }
}