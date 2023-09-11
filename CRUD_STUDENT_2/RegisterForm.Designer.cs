namespace CRUD_STUDENT_2
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lbLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRePassword = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.tblroleUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbe_type_account = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gconnect_testDataSet1 = new CRUD_STUDENT_2.Gconnect_testDataSet1();
            this.tbl_RoleTableAdapter1 = new CRUD_STUDENT_2.Gconnect_testDataSet1TableAdapters.tbl_RoleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblroleUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_type_account.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gconnect_testDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(206, 322);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(106, 15);
            this.lbLogin.TabIndex = 24;
            this.lbLogin.Text = "Đăng nhập tài khoản";
            this.lbLogin.Click += new System.EventHandler(this.LbLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(105, 271);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(174, 20);
            this.txtRePassword.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 241);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 20;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(105, 209);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 20);
            this.txtUserName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kiểu account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nhập lại mk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mật khẩu:";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(12, 211);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(86, 14);
            this.labUserName.TabIndex = 15;
            this.labUserName.Text = "Tên account:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Appearance.BackColor = System.Drawing.Color.Black;
            this.BtnRegister.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnRegister.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnRegister.Appearance.Options.UseBackColor = true;
            this.BtnRegister.Appearance.Options.UseBorderColor = true;
            this.BtnRegister.Appearance.Options.UseFont = true;
            this.BtnRegister.Appearance.Options.UseForeColor = true;
            this.BtnRegister.Location = new System.Drawing.Point(120, 350);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(89, 30);
            this.BtnRegister.TabIndex = 13;
            this.BtnRegister.Text = "Đăng ký";
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            this.BtnRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnRegister_KeyDown);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbl_Role";
            // 
            // cbe_type_account
            // 
            this.cbe_type_account.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.cbe_type_account.EditValue = "stu";
            this.cbe_type_account.Location = new System.Drawing.Point(105, 297);
            this.cbe_type_account.Name = "cbe_type_account";
            this.cbe_type_account.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_type_account.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("role", "Role")});
            this.cbe_type_account.Properties.DataSource = this.bindingSource2;
            this.cbe_type_account.Properties.DisplayMember = "role";
            this.cbe_type_account.Properties.ValueMember = "id";
            this.cbe_type_account.Size = new System.Drawing.Size(174, 20);
            this.cbe_type_account.TabIndex = 25;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tbl_Role";
            this.bindingSource2.DataSource = this.gconnect_testDataSet1;
            // 
            // gconnect_testDataSet1
            // 
            this.gconnect_testDataSet1.DataSetName = "Gconnect_testDataSet1";
            this.gconnect_testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_RoleTableAdapter1
            // 
            this.tbl_RoleTableAdapter1.ClearBeforeFill = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 397);
            this.Controls.Add(this.cbe_type_account);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRegister);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("RegisterForm.IconOptions.Image")));
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblroleUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_type_account.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gconnect_testDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtRePassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton BtnRegister;
        private System.Windows.Forms.BindingSource tblroleUserBindingSource;
        private System.Windows.Forms.BindingSource tblRoleBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.LookUpEdit cbe_type_account;
        private Gconnect_testDataSet1 gconnect_testDataSet1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private Gconnect_testDataSet1TableAdapters.tbl_RoleTableAdapter tbl_RoleTableAdapter1;
    }
}