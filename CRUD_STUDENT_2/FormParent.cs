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
using System.Threading.Tasks;
using System.Windows.Forms;
using VBSQLHelper;

namespace CRUD_STUDENT_2
{
    public partial class FormParent : DevExpress.XtraEditors.XtraForm
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void FormParent_Load(object sender, EventArgs e)
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

            var parents = new Parents
            {
                id = Convert.ToInt32(id),
                firstname = firstname,
                lastname = lastname,
                address = address,
                age = age,
                gender = gender
            };

            var affectrown = SQLHelper.Insert(parents);

            if (affectrown > 0)
            {
                XtraMessageBox.Show("Insert Parents Succed!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                XtraMessageBox.Show("Insert Parents Failed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadDataToGirlViews()
        {
            var dataStudents = SQLHelper.ExecQueryData<Parents>("select * from tbl_parents");
            gridControl2.DataSource = dataStudents;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            var idEdit = txtID.Text;
            var firstnameEdit = txtFirstName.Text;
            var lastnameEdit = txtLastName.Text;
            var addressEdit = txtAddress.Text;
            var ageEdit = Convert.ToInt32(spin_age.EditValue);
            var genderEdit = Convert.ToInt32(cbGender.EditValue) == 1 ? true : false;

            var parentsEdit = new Parents
            {
                id = Convert.ToInt32(idEdit),
                firstname = firstnameEdit,
                lastname = lastnameEdit,
                address = addressEdit,
                age = ageEdit,
                gender = genderEdit
            };
            var affectrown = SQLHelper.Update(parentsEdit);
            if (affectrown)
            {
                XtraMessageBox.Show("Update Parents Succefully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDataToGirlViews();
        }

        private void gridViewParents_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var girlview = sender as GridView;
            if (girlview.IsDataRow(e.FocusedRowHandle))
            {
                var parents = girlview.GetFocusedRow() as Parents;
                txtID.EditValue = parents.id;
                txtFirstName.EditValue = parents.firstname;
                txtLastName.EditValue = parents.lastname;
                txtAddress.EditValue = parents.address;
                spin_age.EditValue = parents.age;
                cbGender.EditValue = parents.gender ? 1 : 2;
            }
        }

        private void gridViewParents_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column == colDel)
            {
                var parentDelete = gridViewParents.GetFocusedRow() as Parents;
                var dlg = XtraMessageBox.Show($"Are you sure deleted parents: {parentDelete.firstname.Trim()} {parentDelete.lastname.Trim()}?",
                    "information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    SQLHelper.Delete(parentDelete);
                    gridViewParents.DeleteSelectedRows();
                }
            }
        }

        private void txtSeach_KeyDown(object sender, KeyEventArgs e)
        {
            string searchString = txtSeach.Text;
            string query = $@"
                SELECT * FROM tbl_parents
                WHERE firstname COLLATE SQL_Latin1_General_Cp1251_CS_AS LIKE N'%{searchString}%' 
                OR lastname COLLATE SQL_Latin1_General_Cp1251_CS_AS LIKE N'%{searchString}%'
            ";
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSeach.Text != "")
                {
                    var dataStudents = SQLHelper.ExecQueryData<Parents>(query);
                    gridControl2.DataSource = dataStudents;
                }
                else
                {
                    LoadDataToGirlViews();
                }
            }
        }
    }
}