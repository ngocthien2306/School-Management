using DevExpress.XtraBars;
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
namespace School_Management.Manager.Course
{
    public partial class Add_Course : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Add_Course()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            Courses course = new Courses();
            course.Id = Convert.ToInt32(ID_Course_tb.Text);
            course.Label = NameCourse_tb.Text;
            course.Period = Convert.ToInt32(Period_tb.Text);
            course.Description = Description_tb.Text;
            if (course.AddThisCourse())
            {
                MessageBox.Show("Add a new course successful!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Add failed", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {

        }

        private void Description_tb_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}