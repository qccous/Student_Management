using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DTO
{
    public class Subject
    {
        private string subject_Code;
        private string subject_Name;
        private int numOfSlot;
        public Subject(string subject_Code, string subject_Name, int numOfSlot)
        {
            Subject_Code = subject_Code;
            Subject_Name = subject_Name;
            NumOfSlot = numOfSlot;
        }

        public Subject(DataRow row)
        {
            Subject_Code = row["SubjectCode"].ToString();
            Subject_Name = row["SubjectName"].ToString();
            NumOfSlot = (int)row["NumberOfSlot"];
        }
        public string Subject_Code { get => subject_Code; set => subject_Code = value; }
        public string Subject_Name { get => subject_Name; set => subject_Name = value; }
        public int NumOfSlot { get => numOfSlot; set => numOfSlot = value; }
    }
}
