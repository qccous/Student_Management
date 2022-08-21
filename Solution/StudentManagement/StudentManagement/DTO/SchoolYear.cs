using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DTO
{
    public class SchoolYear
    {
        private string sY_Code;
        private string sY_Name;

        public SchoolYear(string sY_Code, string sY_Name)
        {
            SY_Code = sY_Code;
            SY_Name = sY_Name;
        }

        public SchoolYear(DataRow row)
        {
            SY_Code = row["SY_Code"].ToString();
            SY_Name = row["SY_Name"].ToString();
        }

        public string SY_Code { get => sY_Code; set => sY_Code = value; }
        public string SY_Name { get => sY_Name; set => sY_Name = value; }
    }
}
