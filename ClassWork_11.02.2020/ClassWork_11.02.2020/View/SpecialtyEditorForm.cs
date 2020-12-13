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
    public partial class SpecialtyEditorForm : Form
    {
        public Specialty ChangedData
        {
            get
            {
                return new Specialty
                {
                    Name = nameTextBox.Text,
                    Code = codeTextBox.Text
                };
            }
        }
        public SpecialtyEditorForm()
        {
            InitializeComponent();
            acceptButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
        }

        public DialogResult ShowDialog(Specialty data) 
        {
            if (data == null)
                data = new Specialty();

            nameTextBox.Text = data.Name;
            codeTextBox.Text = data.Code;

            return ShowDialog();
        }

    }
}
