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
namespace School_Management.Manager.Score
{
    public partial class Add_Score : DevExpress.XtraEditors.XtraForm
    {
        public Add_Score()
        {
            InitializeComponent();
        }
        Students student = new Students();
        Courses course = new Courses();
        Scores score = new Scores();
        private void add_StudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.add_StudentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manager_StudentDataSet);

        }

        private void Add_Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Student.Add_Student' table. You can move, or remove it, as needed.
            this.add_StudentTableAdapter1.Fill(this.dataSet_Student.Add_Student);
            // TODO: This line of code loads data into the 'dataSet_Student.Score' table. You can move, or remove it, as needed.
            this.scoreTableAdapter.Fill(this.dataSet_Student.Score);
            // TODO: This line of code loads data into the 'manager_StudentDataSet.Add_Student' table. You can move, or remove it, as needed.
            this.add_StudentTableAdapter.Fill(this.manager_StudentDataSet.Add_Student);
            //StudentGridControl.DataSource = score.GetStudentScore();
            ComboBox_Course.DataSource = course.GetAllCourses();
            ComboBox_Course.DisplayMember = "lable";
            ComboBox_Course.ValueMember = "id";

        }
        private void Add_bt_Click(object sender, EventArgs e)
        {
            try
            {
                Scores score = new Scores();
                int sid = Convert.ToInt32(Id_tb.Text);
                int cid = Convert.ToInt32(ComboBox_Course.ValueMember);
                float score_stu = (float)Convert.ToDouble(Score_tb.Text);
                string des = Des_tb.Text;
                if (score.Add_Score(sid, cid, score_stu, des))
                {
                    MessageBox.Show("Add score successful!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add score failed !", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("The textbox is blank. Please enter again", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Avg_bt_Click(object sender, EventArgs e)
        {
            Avg_Score avg = new Avg_Score();
            avg.ShowDialog();
        }
    }
}