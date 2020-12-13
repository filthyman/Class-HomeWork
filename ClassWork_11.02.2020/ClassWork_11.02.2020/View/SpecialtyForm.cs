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
    public partial class SpecialtyForm : Form
    {
        public event Action<Specialty> UpdateData;
        public event Action AddData;
        public event Action<Specialty> DeleteData;

        public SpecialtyForm()
        {
            InitializeComponent();
            specialtyView.AutoGenerateColumns = false;
        }

        public void ShowData(List<Specialty> data) 
        {
            specialtyView.DataSource = data; 
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var row = specialtyView.SelectedRows[0];
            var group = row.DataBoundItem as Specialty;
            UpdateData(group);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var row = specialtyView.SelectedRows[0];
            var group = row.DataBoundItem as Specialty;
            DeleteData(group);
        }
    }
}
