using CRUD_STUDENT_DEMO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VBSQLHelper;
using DevExpress.XtraExport.Helpers;

namespace CRUD_STUDENT_2
{
    public partial class FormStudent : DevExpress.XtraEditors.XtraForm
    {
        public FormStudent()
        {
            InitializeComponent();

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            var data_gender = SQLHelper.ExecQueryDataAsDataTable("select * from tbl_gender");
            cbGender.Properties.DataSource = data_gender;
            cbGender.Properties.ValueMember = "id";
            cbGender.Properties.DisplayMember = "name";
            this.LoadDataToGirlViews();
        }



        private void btn_Save_Click(object sender, EventArgs e)
        {
            var id = txtID.Text;
            var firstname = txtFirstName.Text;
            var lastname = txtLastName.Text;
            var address = txtAddress.Text;
            var age = Convert.ToInt32(spin_age.EditValue);
            var gender = Convert.ToInt32(cbGender.EditValue) == 1 ? true : false;

            if (string.IsNullOrEmpty(id))
            {
                XtraMessageBox.Show("Enter your id", "Information");
                txtID.Focus();
                return;
            }

            // Check id is existe
            var isExiste = Convert.ToInt32(SQLHelper.ExecQuerySacalar($"select count(*) from tbl_student where id='{id}' ")) > 0;
            if (isExiste)
            {
                XtraMessageBox.Show($"Your id {id} is existed!", "Information");
                txtID.Focus();
                txtID.SelectAll();
                return;
            }


            if (string.IsNullOrEmpty(firstname))
            {
                XtraMessageBox.Show("Enter your firstname", "Information");
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lastname))
            {
                XtraMessageBox.Show("Enter your lastname", "Information");
                txtLastName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(address))
            {
                XtraMessageBox.Show("Enter your address", "Information");
                txtAddress.Focus();
                return;
            }
            if (age <= 0 || age > 100)
            {
                XtraMessageBox.Show("Enter your age", "Information");
                spin_age.Focus();
                return;
            }
            if (cbGender.EditValue == null)
            {
                XtraMessageBox.Show("Select your gender!", "Warning");
                cbGender.ShowPopup();
                return;
            }

            var student = new Student
            {
                id = Convert.ToInt32(id),
                firstname = firstname,
                lastname = lastname,
                address = address,
                age = age,
                gender = gender
            };

            var affectrown = SQLHelper.Insert(student);

            if (affectrown > 0)
            {
                XtraMessageBox.Show("Insert Student Succed!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.LoadDataToGirlViews();
                txtID.Text = String.Empty;
                txtFirstName.Text = String.Empty;
                txtLastName.Text = String.Empty;
                txtAddress.Text = String.Empty;
                spin_age.EditValue = 0;
                cbGender.EditValue = null;
            }
            else
            {
                XtraMessageBox.Show("Insert Student Failed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadDataToGirlViews()
        {
            var dataStudents = SQLHelper.ExecQueryData<Student>("select * from tbl_student");
            gridControl1.DataSource = dataStudents;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            var idEdit = txtID.Text;
            var firstnameEdit = txtFirstName.Text;
            var lastnameEdit = txtLastName.Text;
            var addressEdit = txtAddress.Text;
            var ageEdit = Convert.ToInt32(spin_age.EditValue);
            var genderEdit = Convert.ToInt32(cbGender.EditValue) == 1 ? true : false;

            var studentEdit = new Student
            {
                id = Convert.ToInt32(idEdit),
                firstname = firstnameEdit,
                lastname = lastnameEdit,
                address = addressEdit,
                age = ageEdit,
                gender = genderEdit

            };

            var affectrown = SQLHelper.Update(studentEdit);
            if (affectrown)
            {
                XtraMessageBox.Show("Update Student Succefully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDataToGirlViews();
        }

        private void FormStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Ngăn cửa sổ đóng
                Hide(); // Ẩn cửa sổ thay vì đóng
            }
        }

        private void gridViewStudent_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column == colDel)
            {
                var studentDelete = gridViewStudent.GetFocusedRow() as Student;
                var dlg = XtraMessageBox.Show($"Are you sure deleted student: {studentDelete.firstname} {studentDelete.lastname}?",
                    "information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    SQLHelper.Delete(studentDelete);
                    gridViewStudent.DeleteSelectedRows();
                }
            }
        }

        private void gridViewStudent_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gridViewStudent = sender as GridView;
            if (gridViewStudent.IsDataRow(e.FocusedRowHandle))
            {
                var student = gridViewStudent.GetFocusedRow() as Student;
                txtID.EditValue = student.id;
                txtFirstName.EditValue = student.firstname;
                txtLastName.EditValue = student.lastname;
                txtAddress.EditValue = student.address;
                spin_age.EditValue = student.age;
                cbGender.EditValue = student.gender ? 1 : 2;
            }
        }
    }
}
