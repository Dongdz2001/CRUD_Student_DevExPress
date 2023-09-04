using CRUD_STUDENT_2.DTO.Phan_quyen;
using DevExpress.XtraEditors;
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
    public partial class RegisterForm : DevExpress.XtraEditors.XtraForm
    {
        private LoginForm login = null;
        public RegisterForm()
        {
            InitializeComponent();
            
        }
        // thực hiện hành động login khi người dùng đăng nhập
        
        private void LbLogin_Click(object sender, EventArgs e)
        {
            if (login != null)
            {
                login.Show();
                this.Hide();
            }
            else
            {
                login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string user_name = txtUserName.Text.Trim();
            string password = txtPassword.Text;
            string repassword = txtRePassword.Text;

            if (string.IsNullOrWhiteSpace(user_name))
            {
                XtraMessageBox.Show("Enter your UserName", "Information");
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                XtraMessageBox.Show("Enter your Password", "Information");
                txtPassword.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(repassword))
            {
                XtraMessageBox.Show("Enter your Repassword", "Information");
                txtRePassword.Focus();
                return;
            }

            if (password != repassword)
            {
                XtraMessageBox.Show("Enter again your Repassword not equal password", "Warning");
                txtRePassword.Focus();
                return;
            }

            string id_user = Guid.NewGuid().ToString();
            var newUser = new User
            {
                U_ID = id_user,
                U_Name = user_name,
                U_Pass = Program.CalculateMD5Hash(password),
            };
            var newUserRole = new RoleUser
            {
                id = 0,
                idUser = id_user,
                idRole = cbe_type_account.EditValue.ToString(),
            };
            var isExisteUserAccount = Convert.ToInt32(SQLHelper.ExecQuerySacalar($"select count(*) from tbl_User_Account where U_Name ='{user_name}' ")) > 0;
            if (isExisteUserAccount)
            {
                XtraMessageBox.Show("Exist account please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Text = "";
                txtUserName.Focus();
                return;
            }
            try
            {
                var affectRow = SQLHelper.Insert(newUser);
                var affectRowRoleUser = SQLHelper.Insert(newUserRole);
                var isExiste = Convert.ToInt32(SQLHelper.ExecQuerySacalar($"select count(*) from tbl_User_Account where U_ID ='{id_user}' ")) > 0;

                if (isExiste && affectRowRoleUser > 0  )
                {
                    XtraMessageBox.Show("Create account Succed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var query = $"SELECT * FROM tbl_User_Account WHERE U_ID = '{id_user}'";
                    var dataRow = SQLHelper.ExecQueryDataAsDataTable(query);

                    SchoolDashBoard schoolDashBoard = new SchoolDashBoard(dataRow.Rows[0]);
                    schoolDashBoard.Show();
                }
                else
                {
                    XtraMessageBox.Show("Có lỗi xảy ra chưa thêm được!", "Warning");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error");
            }
        }




        private void BtnRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnRegister.PerformClick();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gconnect_testDataSet1.tbl_Role' table. You can move, or remove it, as needed.
            this.tbl_RoleTableAdapter1.Fill(this.gconnect_testDataSet1.tbl_Role);
            // TODO: This line of code loads data into the 'gconnect_testDataSet.tbl_Role' table. You can move, or remove it, as needed.

        }
    }
}