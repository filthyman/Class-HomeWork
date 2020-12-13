using ClassWork_11._02._2020.Models;
using ClassWork_11._02._2020.Servises;
using ClassWork_11._02._2020.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork_11._02._2020.Controllers
{
    class SpecialtyController
    {
        private StorageContext _context;
        private SpecialtyForm _view;
        public SpecialtyController(StorageContext context, SpecialtyForm form)
        {
            _context = context;
            _view = form;
            _view.Load += LoadHandler;
            _view.UpdateData += ChangeDataHolder;
            _view.AddData += AddDataHandler;
            _view.DeleteData += DeleteDataHolder;
        }

        public void LoadHandler(object o, EventArgs e) 
        {
            RefreshDataHandler();
        }

        public void RefreshDataHandler() 
        {
            
            try
            {
                List<Specialty> group = _context.Specialty.GetAllSpecialties();
                _view.ShowData(group);
            }
            catch 
            {

                System.Windows.Forms.MessageBox.Show("ERROR");
            }
        }

        public void ChangeDataHolder(Specialty data)
        {
            var editor = new SpecialtyEditorForm();
            var spec = _context.Specialty.GetAllSpecialties();

            var result = editor.ShowDialog(data);

            if (result != DialogResult.OK)
            {
                return;
            }

            var chagedStudentData = editor.ChangedData;

            _context.Specialty.Update(data.Id, chagedStudentData);

            RefreshDataHandler();
        }

        public void AddDataHandler()
        {
            var editor = new SpecialtyEditorForm();

            var result = editor.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            _context.Specialty.Add(editor.ChangedData);
            RefreshDataHandler();
        }
        public void DeleteDataHolder(Specialty data)
        {

            _context.Specialty.Delete(data.Id);

            RefreshDataHandler();
        }


    }
}
