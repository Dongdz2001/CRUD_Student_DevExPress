using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_STUDENT_2
{
    public partial class SchoolDashBoard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private FormStudent formStudent ;
        private FormParent formParent ;
        private FormTeacher formTeacher ;
        public SchoolDashBoard()
        {
            InitializeComponent();
            formStudent = new FormStudent();
            formParent = new FormParent();
            formTeacher = new FormTeacher();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                formStudent.Show();
            }
            catch(Exception ex)
            {
                formStudent = new FormStudent();
                formStudent.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
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

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
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

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
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