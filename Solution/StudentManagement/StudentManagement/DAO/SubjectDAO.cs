using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
    public class SubjectDAO
    {
        private static SubjectDAO instance;
        public static SubjectDAO Instance
        {
            get { if (instance == null) instance = new SubjectDAO(); return instance; }
            private set { instance = value; }
        }
        private SubjectDAO() { }
    }
}
