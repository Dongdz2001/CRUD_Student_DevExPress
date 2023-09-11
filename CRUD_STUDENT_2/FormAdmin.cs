using CRUD_STUDENT_2.DTO.Phan_quyen;
using CRUD_STUDENT_DEMO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class FormAdmin : DevExpress.XtraEditors.XtraForm
    {
        private List<UserPermision> dataAdmin;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void LoadDataToGridView()
        {
            string query = @"
                SELECT UA.U_ID, UA.U_Name, R.role FROM tbl_User_Account as UA
                LEFT JOIN  tbl_Role_Users  as RU
                ON UA.U_ID = RU.idUser 
                LEFT JOIN tbl_Role as R
                ON RU.idRole = R.id ";
            dataAdmin = (List<UserPermision>)SQLHelper.ExecQueryData<UserPermision>(query);
            // Loại bỏ người dùng có U_Name là "admin"
            dataAdmin.RemoveAll(user => user.U_Name.Trim() == "admin");
            foreach (UserPermision user in dataAdmin)
            {
                user.setValuePermision();
            }

            gridControl4.DataSource = dataAdmin;
        }

        private void gridViewAdmin_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var per = gridViewAdmin.GetRow(e.RowHandle) as UserPermision;

            if (e.Column == Student)
            {
                per.setOnlyValuePermision("Student", per);
            }
            else if (e.Column == Teacher)
            {
                per.setOnlyValuePermision("Teacher", per);
            }
            else if (e.Column == Parent)
            {
                per.setOnlyValuePermision("Parent", per);
            }
            else if (e.Column == Admin)
            {
                var dlg = XtraMessageBox.Show($"Bạn có muốn cho trao quyền Admin cho người này không hãy cân nhắc thật kỹ!",
                "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    per.setOnlyValuePermision("Admin", per);
                }
                else
                {
                    // Đặt lại giá trị của ô checkBox Admin trong lưới (GridView) thành false
                    gridViewAdmin.SetRowCellValue(e.RowHandle, Admin, false);
                }
            }
            else if (e.Column == allPermision)
            {
                per.setAllValue(!per.allPermision);
            }

            // Cập nhật lại dòng trong grid
            gridViewAdmin.RefreshRow(e.RowHandle);
        }

        private void txtSeach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchString = txtSeach.Text.Trim();
                string query = $@"
                SELECT UA.U_ID, UA.U_Name, R.role FROM tbl_User_Account as UA
                LEFT JOIN  tbl_Role_Users  as RU
                ON UA.U_ID = RU.idUser 
                LEFT JOIN tbl_Role as R
                ON RU.idRole = R.id 
                WHERE UA.U_Name LIKE N'%{searchString}%' 
                ";
                dataAdmin = (List<UserPermision>)SQLHelper.ExecQueryData<UserPermision>(query);
                // Loại bỏ người dùng có U_Name là "admin"
                dataAdmin.RemoveAll(user => user.U_Name.Trim() == "admin");
                foreach (UserPermision user in dataAdmin)
                {
                    user.setValuePermision();
                }

                gridControl4.DataSource = dataAdmin;
            }
            else
            {
                LoadDataToGridView();
            }
        }
    }
}