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
    class StudentGroupController
    {
        private StorageContext _context;
        private StudentGroupForm _view;
        public StudentGroupController(StorageContext context, StudentGroupForm form)
        {
            _context = context;
            _view = form;
            _view.Load += LoadHandler;
            _view.ChangeData += ChangeDataHolder;
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
                List<StudentGroup> group = _context.Group.GetAllWhichGroups();
                _view.ShowData(group);

            }
            catch
            {

                System.Windows.Forms.MessageBox.Show("ERROR");
            }



        }
        public void ChangeDataHolder(StudentGroup data)
        {
            var spec = _context.Specialty.GetAllSpecialties();
            var editor = new StudentGoupEditorForm(spec);

            var result = editor.ShowDialog(data);

            if (result != DialogResult.OK)
                return;
    

            var chagedStudentData = editor.ChangeData;

            _context.Group.Update(data.Id, chagedStudentData);

            RefreshDataHandler();
        }

        
        public void AddDataHandler()
        {
            var spec = _context.Specialty.GetAllSpecialties();
            var editor = new StudentGoupEditorForm(spec);

            var result = editor.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            _context.Group.Add(editor.ChangeData);
            RefreshDataHandler();
        }

        public void DeleteDataHolder(StudentGroup data)
        {

            _context.Group.Delete(data.Id);

            RefreshDataHandler();
        }


    }
}
