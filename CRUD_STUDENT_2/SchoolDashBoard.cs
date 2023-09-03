using DevExpress.XtraBars;
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
    public partial class SchoolDashBoard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private FormStudent formStudent ;
        private FormParent formParent ;
        private FormTeacher formTeacher ;
        private User user;
        private string permission;
        public SchoolDashBoard(DataRow dataRow)
        {
            InitializeComponent();
            formStudent = new FormStudent();
            formParent = new FormParent();
            formTeacher = new FormTeacher();
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
            //XtraMessageBox.Show(dataRow_Permission.Rows[0]["role"].ToString());
            permission = dataRow_Permission.Rows[0]["role"].ToString().Trim();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!permission.Equals("Student"))
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
            if (!permission.Equals("Teacher"))
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
            if (!permission.Equals("Parent"))
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
    }
}