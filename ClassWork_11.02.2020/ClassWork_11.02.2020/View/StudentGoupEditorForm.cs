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
    public partial class StudentGoupEditorForm : Form
    {
        private int StudentId;
        public StudentGroup ChangeData 
        {

            get 
            {
                var specialty = groupComboBox.SelectedItem as Specialty;

                return new StudentGroup
                {
                    Name = nameTextBox.Text,
                    NumberOfStudents = int.Parse(groupNumeric.Text),
                    Specialty_id = specialty.Id,
                    Id = StudentId,
                    Specialty = specialty

                };
            
            }
        }
        public StudentGoupEditorForm(List<Specialty> specialties)
        {
            
            InitializeComponent();
            acceptButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
            groupComboBox.DataSource = specialties;

        }

        public DialogResult ShowDialog(StudentGroup data) 
        {
            Specialty selectedSpecelty = null;
            foreach (var a in groupComboBox.DataSource as List<Specialty>)
            {
                if (a.Id == data.Specialty.Id)
                {
                    selectedSpecelty = a;
                }
            }
            groupComboBox.SelectedItem = selectedSpecelty;
            if (data == null)
                data = new StudentGroup();
            nameTextBox.Text = data.Name;
            groupNumeric.Value = data.NumberOfStudents;

            return ShowDialog();
        }

        private void groupComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var spec = e.ListItem as Specialty;
            e.Value = spec.Name;
        }
    }
}
