using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class CRUD_Subjects : Form
    {
        public CRUD_Subjects()
        {
            InitializeComponent();
            dgvSubject.DataSource = new SubjectDAO().GetListSubject();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
