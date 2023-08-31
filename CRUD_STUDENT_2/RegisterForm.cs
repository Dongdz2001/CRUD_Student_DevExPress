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
        
        private void lbLogin_Click(object sender, EventArgs e)
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

        }

        private void BtnRegister_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}