using ClassWork_11._02._2020.Controllers;
using ClassWork_11._02._2020.Servises;
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
    public partial class MainForm : Form
    {
        private StorageContext _context;
        public MainForm(StorageContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void specialtyButton_Click(object sender, EventArgs e)
        {
            var window = new SpecialtyForm();
            var specController = new SpecialtyController(_context, window);
            window.ShowDialog();
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
            var window = new StudentGroupForm();
            var groupController = new StudentGroupController(_context,window);
            window.ShowDialog();
        }   
    }
}
