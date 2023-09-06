namespace CRUD_STUDENT_2
{
    partial class FormAdmin
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridViewAdmin = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Permision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Admin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbAdmin = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Student = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbStudent = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Teacher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbTeacher = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbParent = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit11 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl4);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(729, 349);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl4
            // 
            this.gridControl4.Location = new System.Drawing.Point(12, 12);
            this.gridControl4.MainView = this.gridViewAdmin;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit11,
            this.cbAdmin,
            this.repositoryItemCheckedComboBoxEdit1,
            this.cbStudent,
            this.cbTeacher,
            this.cbParent});
            this.gridControl4.Size = new System.Drawing.Size(705, 325);
            this.gridControl4.TabIndex = 0;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAdmin,
            this.gridView1});
            // 
            // gridViewAdmin
            // 
            this.gridViewAdmin.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserName,
            this.Permision,
            this.Admin,
            this.Student,
            this.Teacher,
            this.Parent,
            this.colDel});
            this.gridViewAdmin.GridControl = this.gridControl4;
            this.gridViewAdmin.Name = "gridViewAdmin";
            this.gridViewAdmin.OptionsView.ColumnAutoWidth = false;
            this.gridViewAdmin.OptionsView.ShowGroupPanel = false;
            this.gridViewAdmin.ViewCaption = "Xin chao";
            this.gridViewAdmin.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewAdmin_CellValueChanging);
            // 
            // UserName
            // 
            this.UserName.AppearanceHeader.Options.UseTextOptions = true;
            this.UserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserName.Caption = "User Account";
            this.UserName.FieldName = "U_Name";
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 1;
            this.UserName.Width = 217;
            // 
            // Permision
            // 
            this.Permision.AppearanceHeader.Options.UseTextOptions = true;
            this.Permision.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Permision.Caption = "Permision";
            this.Permision.FieldName = "role";
            this.Permision.Name = "Permision";
            this.Permision.Visible = true;
            this.Permision.VisibleIndex = 6;
            this.Permision.Width = 127;
            // 
            // Admin
            // 
            this.Admin.AppearanceHeader.Options.UseTextOptions = true;
            this.Admin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Admin.Caption = "Admin";
            this.Admin.ColumnEdit = this.cbAdmin;
            this.Admin.FieldName = "admin";
            this.Admin.Name = "Admin";
            this.Admin.Visible = true;
            this.Admin.VisibleIndex = 2;
            // 
            // cbAdmin
            // 
            this.cbAdmin.Appearance.Options.UseTextOptions = true;
            this.cbAdmin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbAdmin.AutoHeight = false;
            this.cbAdmin.Name = "cbAdmin";
            // 
            // Student
            // 
            this.Student.AppearanceHeader.Options.UseTextOptions = true;
            this.Student.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Student.Caption = "Student";
            this.Student.ColumnEdit = this.cbStudent;
            this.Student.FieldName = "student";
            this.Student.Name = "Student";
            this.Student.Visible = true;
            this.Student.VisibleIndex = 3;
            // 
            // cbStudent
            // 
            this.cbStudent.AutoHeight = false;
            this.cbStudent.Name = "cbStudent";
            // 
            // Teacher
            // 
            this.Teacher.AppearanceHeader.Options.UseTextOptions = true;
            this.Teacher.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Teacher.Caption = "Teacher";
            this.Teacher.ColumnEdit = this.cbTeacher;
            this.Teacher.FieldName = "teacher";
            this.Teacher.Name = "Teacher";
            this.Teacher.Visible = true;
            this.Teacher.VisibleIndex = 4;
            // 
            // cbTeacher
            // 
            this.cbTeacher.AutoHeight = false;
            this.cbTeacher.Name = "cbTeacher";
            // 
            // Parent
            // 
            this.Parent.AppearanceHeader.Options.UseTextOptions = true;
            this.Parent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Parent.Caption = "Parent";
            this.Parent.ColumnEdit = this.cbParent;
            this.Parent.FieldName = "parent";
            this.Parent.Name = "Parent";
            this.Parent.Visible = true;
            this.Parent.VisibleIndex = 5;
            this.Parent.Width = 52;
            // 
            // cbParent
            // 
            this.cbParent.AutoHeight = false;
            this.cbParent.Name = "cbParent";
            // 
            // colDel
            // 
            this.colDel.AppearanceCell.Options.UseTextOptions = true;
            this.colDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDel.AppearanceHeader.Options.UseTextOptions = true;
            this.colDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDel.Caption = "Xóa";
            this.colDel.ColumnEdit = this.repositoryItemButtonEdit11;
            this.colDel.FieldName = "btn_Xoa";
            this.colDel.Name = "colDel";
            this.colDel.OptionsColumn.AllowEdit = false;
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 0;
            this.colDel.Width = 54;
            // 
            // repositoryItemButtonEdit11
            // 
            this.repositoryItemButtonEdit11.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            this.repositoryItemButtonEdit11.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit11.Name = "repositoryItemButtonEdit11";
            this.repositoryItemButtonEdit11.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl4;
            this.gridView1.Name = "gridView1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(729, 349);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl4;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(709, 329);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 349);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormAdmin";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn Permision;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit11;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Admin;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit cbAdmin;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Student;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit cbStudent;
        private DevExpress.XtraGrid.Columns.GridColumn Teacher;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit cbTeacher;
        private DevExpress.XtraGrid.Columns.GridColumn Parent;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit cbParent;
    }
}