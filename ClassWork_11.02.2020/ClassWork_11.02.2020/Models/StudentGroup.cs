using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_11._02._2020.Models
{
    public class StudentGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Specialty_id { get; set; }
        public int NumberOfStudents { get; set; }
        public Specialty Specialty { get; set; }

    }
}
