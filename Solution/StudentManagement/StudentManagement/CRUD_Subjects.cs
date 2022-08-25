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
            dgvSubject.Columns["Results"].Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSubjectCode.Text = dgvSubject.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtSubjectName.Text = dgvSubject.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            nmSlot.Value = Convert.ToInt32(dgvSubject.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
        }


    }
}
