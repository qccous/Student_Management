using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
    public class ResultDAO
    {
        private static ResultDAO instance;
        public static ResultDAO Instance
        {
            get { if (instance == null) instance = new ResultDAO(); return instance; }
            private set { instance = value; }
        }
        private ResultDAO() { }
    }
}
