﻿using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBSQLHelper;

namespace CRUD_STUDENT_2
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private RegisterForm formRegister;
        public LoginForm()
        {
            InitializeComponent();
            formRegister = new RegisterForm();
        }

        private void PerformLogin()
        {
            string user_name = txtUserName.Text;
            string password = txtPassword.Text;

            // Sử dụng tham số trong truy vấn để tránh tình trạng SQL injection
            var query = "SELECT * FROM LoginUsers WHERE U_name = @username AND U_Pass = @password";
            var parameters = new Dictionary<string, object>
            {
                { "@username", user_name },
                { "@password", password }
            };

            var data_row = SQLHelper.ExecQueryDataAsDataTable(query, parameters);

            // Kiểm tra nếu có dòng dữ liệu trả về
            if (data_row.Rows.Count == 1)
            {
                var schoolsDashBoard = new SchoolDashBoard();
                schoolsDashBoard.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("User or Passwors is incorrect!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            try
            {
                formRegister.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                formRegister = new RegisterForm();
                formRegister.Show();
                this.Hide();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.PerformLogin();
        }

        private void BtnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.PerformLogin();
            }
        }
    }
}