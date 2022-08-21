using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
    public class SchoolYearDAO
    {
        private static SchoolYearDAO instance;
        public static SchoolYearDAO Instance
        {
            get { if (instance == null) instance = new SchoolYearDAO(); return instance; }
            private set { instance = value; }
        }
        private SchoolYearDAO() { }
    }
}
