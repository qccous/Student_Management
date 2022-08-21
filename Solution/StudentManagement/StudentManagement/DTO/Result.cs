using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DTO
{
    public class Result
    {
        private int student_Code;
        private string subject_Code;
        private int mark;
        public Result(int student_Code, string subject_Code, int mark)
        {
            Student_Code = student_Code;
            Subject_Code = subject_Code;
            Mark = mark;
        }

        public Result(DataRow row)
        {
            Student_Code = (int)row["StudentCode"];
            Subject_Code = row["SubjectCode"].ToString();
            Mark = (int)row["Mark"];
        }

        public int Student_Code { get => student_Code; set => student_Code = value; }
        public string Subject_Code { get => subject_Code; set => subject_Code = value; }
        public int Mark { get => mark; set => mark = value; }
    }
}
