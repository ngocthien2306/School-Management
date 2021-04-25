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

namespace School_Management.Manager.Course
{
    public partial class ListCourse : DevExpress.XtraEditors.XtraForm
    {
        public ListCourse()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manager_StudentDataSet);

        }

        private void ListCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.manager_StudentDataSet.Course);

        }
    }
}