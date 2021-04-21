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

namespace School_Management.Manager.Student
{
    public partial class Statics : DevExpress.XtraEditors.XtraForm
    {
        public object SeriesChartType { get; private set; }

        public Statics()
        {
            InitializeComponent();
        }

        private void Statics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet.Add_Student' table. You can move, or remove it, as needed.
            this.Add_StudentTableAdapter.Fill(this.Manager_StudentDataSet.Add_Student);
            this.Static();
        }
        private void Static()
        {
            Student student = new Student();
            double male = Convert.ToDouble(student.TotalMaleStudent());
            double female = Convert.ToDouble(student.TotalFemaleStudent());
            this.DrawPieChart(male, female);
        }
        private void DrawPieChart(double value1, double value2)
        {
            ChartControl.Series.Clear();
            string series ="";
            ChartControl.Series[series].Points.AddPoint("Male", value1);
            ChartControl.Series[series].Points.AddPoint("Female", value2);
        }
    }
}