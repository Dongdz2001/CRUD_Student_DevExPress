using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBSQLHelper;

namespace CRUD_STUDENT_2.DTO.Phan_quyen
{
    public class UserPermision
    {
        public string U_ID { get; set; }
        public string U_Name { get; set; }
        public string role { get; set; }

        public bool admin { get; set; } = false;
        public bool student { get; set; } = false;
        public bool teacher { get; set; } = false;
        public bool parent { get; set; } = false;
        public bool allPermision { get; set; } = false;

        public void setValuePermision()
        {
            this.role = this.role.Trim();
            this.admin = role == "Admin";
            this.student = role == "Student";
            this.teacher = role == "Teacher";
            this.parent = role == "Parent";
            this.allPermision = false;
        }

        public void setAllValue(bool value)
        {
            this.allPermision = value;
            this.student = value;
            this.teacher = value;
            this.parent = value;
        }
       

        public void  setOnlyValuePermision(string permisionAccount, UserPermision per )
        {
            this.allPermision = false;
            this.admin = permisionAccount == "Admin";
            this.student = permisionAccount == "Student";
            this.teacher = permisionAccount == "Teacher";
            this.parent = permisionAccount == "Parent";

            string query = @"
                UPDATE tbl_Role_Users
                SET idRole = (SELECT tbl_Role.id FROM tbl_Role WHERE tbl_Role.role = @RoleUser )
                WHERE tbl_Role_Users.idUser = @idUserAccount";
             // Sử dụng tham số trong truy vấn để tránh tình trạng SQL injection
            var parameters = new Dictionary<string, object>
            {
                { "@idUserAccount", per.U_ID },
                { "@RoleUser", permisionAccount }
            };

            var data_row = SQLHelper.ExecQueryDataAsDataTable(query, parameters);

            //string queryCheckUpdated = @"
            //    SELECT * FROM tbl_Role_Uers as RU WHERE RU.idUser = @idUserAccount  
            //    AND RU.idRole = (SELECT tbl_Role.id FROM tbl_Role WHERE tbl_Role.role = @RoleUser )
            //    ";
            
            if (data_row == null )
            {
                XtraMessageBox.Show("Có lỗi xảy ra chưa update được quyền truy cập!");
            }
        }

    }
}
