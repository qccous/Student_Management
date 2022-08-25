using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAO
{
    public class SubjectDAO
    {
        private Student_ManagementContext context = new Student_ManagementContext();
        public List<Subject> GetListSubject()
        {
            return context.Subjects.ToList();
        }
        public Subject GetSubjectNameByCode(string code)
        {
            return context.Subjects.FirstOrDefault(m => m.SubjectCode.Equals(code));
        }
    }
}
