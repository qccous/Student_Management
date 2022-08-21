using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DTO
{
    public class Student
    {
        private int student_Code;
        private string student_Name;
        private DateTime? student_Date;
        private bool student_Gender;
        private string student_Address;
        private int student_Phone;
        private string sY_Code;

        public Student(int student_Code, string student_Name, DateTime? student_Date, bool student_Gender, string student_Address, int student_Phone, string sY_Code)
        {
            Student_Code = student_Code;
            Student_Name = student_Name;
            Student_Date = student_Date;
            Student_Gender = student_Gender;
            Student_Address = student_Address;
            Student_Phone = student_Phone;
            SY_Code = sY_Code;
        }
        public Student(DataRow row)
        {
            Student_Code = (int)row["StudentCode"];
            Student_Name = row["StudentName"].ToString();
            Student_Date = (DateTime?)row["DOB"];
            Student_Gender = (bool)row["Gender"];
            Student_Address = row["Address"].ToString();
            Student_Phone = (int)row["PhoneNum"];
            SY_Code = row["SY_Code"].ToString();
        }
        public int Student_Code { get => student_Code; set => student_Code = value; }
        public string Student_Name { get => student_Name; set => student_Name = value; }
        public DateTime? Student_Date { get => student_Date; set => student_Date = value; }
        public bool Student_Gender { get => student_Gender; set => student_Gender = value; }
        public string Student_Address { get => student_Address; set => student_Address = value; }
        public int Student_Phone { get => student_Phone; set => student_Phone = value; }
        public string SY_Code { get => sY_Code; set => sY_Code = value; }
    }
}
