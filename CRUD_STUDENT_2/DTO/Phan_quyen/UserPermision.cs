using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void setValuePermision()
        {
            this.role = this.role.Trim();
            this.admin = role == "Admin";
            this.student = role == "Student";
            this.teacher = role == "Teacher";
            this.parent = role == "Parent";
        }

        public void setAllValue()
        {
            this.student = true;
            this.teacher = true;
            this.parent = true;
        }

        public void setOnlyValuePermision(string permisionAccount )
        {
            this.admin = permisionAccount == "Admin";
            this.student = permisionAccount == "Student";
            this.teacher = permisionAccount == "Teacher";
            this.parent = permisionAccount == "Parent";
        }

    }
}
