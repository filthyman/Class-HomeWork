using ClassWork_11._02._2020.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork_11._02._2020.View
{
    public partial class StudentGroupForm : Form
    {
        public event Action<StudentGroup> ChangeData;
        public event Action AddData;
        public event Action<StudentGroup> DeleteData;


        public StudentGroupForm()
        {
            InitializeComponent();
            groupView.AutoGenerateColumns = false;

        }
        public void ShowData(List<StudentGroup> groups)
        {
            groupView.DataSource = groups;
        }

        private void groupView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var column = groupView.Columns[e.ColumnIndex];

            if (column.Name != "Specialty")
                return;

            var group = groupView.Rows[e.RowIndex].DataBoundItem as StudentGroup;


            e.Value = group.Specialty.Name;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var row = groupView.SelectedRows[0];
            var group = row.DataBoundItem as StudentGroup;


            ChangeData(group);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var row = groupView.SelectedRows[0];
            var group = row.DataBoundItem as StudentGroup;
            DeleteData(group);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            AddData();
        }
    }
}
