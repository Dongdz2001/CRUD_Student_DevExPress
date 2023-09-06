using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBSQLHelper;

namespace CRUD_STUDENT_2
{
    public partial class SchoolDashBoard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private FormStudent formStudent ;
        private FormParent formParent ;
        private FormTeacher formTeacher ;
        private FormAdmin formAdmin;
        private User user;
        private string permission;
        public SchoolDashBoard(DataRow dataRow)
        {
            InitializeComponent();
            formStudent = new FormStudent();
            formParent = new FormParent();
            formTeacher = new FormTeacher();
            formAdmin = new FormAdmin();
            user = new User {
                U_ID = dataRow["U_ID"].ToString(),
                U_Name = dataRow["U_Name"].ToString(),
                U_Pass = dataRow["U_Pass"].ToString(),

            };
            var query = $"SELECT U_ID, role FROM tbl_User_Account " +
                        $"LEFT JOIN tbl_Role_Users ON tbl_User_Account.U_ID = tbl_Role_Users.idUser " +
                        $"LEFT JOIN tbl_Role ON tbl_Role_Users.idRole = tbl_Role.id " +
                        $"WHERE U_ID = '{user.U_ID}';";

            var dataRow_Permission = SQLHelper.ExecQueryDataAsDataTable(query);
            permission = dataRow_Permission.Rows[0]["role"].ToString().Trim();

            // Kiểm tra có phải Admin đăng nhập hay không để hiển thị phần quản lý phân quyền
            rbnManageAccess.Visible = Check_Permission(permission,"Admin");
        }

        // Kiểm tra quyền truy cập của User
        private bool Check_Permission(string userPermision ,string permissionAvailable)
        {
         
            return userPermision.Equals(permissionAvailable) || userPermision.Equals("Admin") ;
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Permission(permission,"Student"))
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập vào Student", "Warning");
                return;
            }
            try
            {
                formStudent.Show();
            }
            catch (Exception ex)
            {
                formStudent = new FormStudent();
                formStudent.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Permission(permission, "Teacher"))
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập vào Teacher", "Warning");
                return;
            }
            try
            {
                formTeacher.Show();
            }
            catch (Exception ex)
            {
                formTeacher = new FormTeacher();
                formTeacher.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Permission(permission, "Parent"))
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập vào Parent", "Warning");
                return;
            }
            try
            {
                formParent.Show();
            }
            catch (Exception ex)
            {
                formParent = new FormParent();
                formParent.Show();
            }
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Permission(permission, "Admin"))
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập vào Admin", "Warning");
                return;
            }
            try
            {
                formAdmin.Show();
            }
            catch (Exception ex)
            {
                formAdmin = new FormAdmin();
                formAdmin.Show();
            }
        }
    }
}