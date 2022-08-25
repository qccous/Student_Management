﻿using StudentManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class InserMark : Form
    {
        public InserMark()
        {
            InitializeComponent();
            cbScode.DataSource = new StudentDAO().GetAllStudents();
            cbScode.DisplayMember = "StudentCode";
            cbSubjectCode.DataSource = new SubjectDAO().GetListSubject();
            cbSubjectCode.DisplayMember = "SubjectCode";
        }

        private void cbScode_TextChanged(object sender, EventArgs e)
        {
            string id = cbScode.Text;
            if (id == "StudentManagement.Models.Student")
            {
                id = "1";
            }
            txtStudentName.Text = new StudentDAO().GetStudentByID(Convert.ToInt32(id)).StudentName;
        }

        private void cbSubjectCode_TextChanged(object sender, EventArgs e)
        {
            string subjectCode = cbSubjectCode.Text;
            if (subjectCode == "StudentManagement.Models.Subject")
            {
                subjectCode = "PRN211";
            }
            txtSubjectName.Text = new SubjectDAO().GetSubjectNameByCode(subjectCode).SubjectName;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string id = cbScode.Text.Trim();
            #region Validate Input
            string mark = Regex.Replace(txtMark.Text.Trim(), " {2,}", " ");
            bool isNumber = double.TryParse(mark, out double result);
            if (String.IsNullOrEmpty(mark.Trim()))
            {
                MessageBox.Show("Điểm không được để trống");
                return;
            }
            if (!isNumber)
            {
                MessageBox.Show("Điểm phải là số");
                return;
            }
            #endregion
            if (id == "StudentManagement.Models.Student")
            {
                id = "1";
            }
            string subjectCode = cbSubjectCode.Text;
            if (subjectCode == "StudentManagement.Models.Subject")
            {
                subjectCode = "PRN211";
            }
            ResultDAO resultDAO = new ResultDAO();
            var existResult = resultDAO.CheckResultExists(Convert.ToInt32(id.Trim()), subjectCode);
            if (existResult != null)
            {
                if (MessageBox.Show(string.Format("Điểm hiện tại đang là: {0}, bạn có muốn ghi đè?", resultDAO.CheckResultExists(Convert.ToInt32(id), subjectCode).Mark), "Thông Báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    resultDAO.UpdateMark(Convert.ToInt32(id.Trim()), subjectCode, Convert.ToInt32(txtMark.Text));
                }
            }
            else
            {
                if (MessageBox.Show(string.Format("Nhập điểm cho sinh viên: {0}\n Môn: {1}\n Số điểm: {2}", txtStudentName.Text, cbSubjectCode.Text, txtMark.Text), "Thông Báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    resultDAO.InsertMark(Convert.ToInt32(id.Trim()), subjectCode, Convert.ToInt32(txtMark.Text));
                }
            }
        }
    }
}
