namespace CoreModelWin.View.Sys
{
    partial class SecurityRoleJournalXUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityRoleJournalXUC));
            this.RoleJournalXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.roleJournalGC = new CoreLib.Grid.MyGridControl();
            this.roleJournalGV = new CoreLib.Grid.MyGridView();
            this.colLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecurityPrivilege = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMyXUC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleJournalXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleJournalGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleJournalGV)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollectionMyXUC
            // 
            this.imageCollectionMyXUC.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionMyXUC.ImageStream")));
            // 
            // RoleJournalXPC
            // 
            this.RoleJournalXPC.DisplayableProperties = "This;LineId;CreatedBy;CreatedAt;ModifiedBy;ModifiedAt;RoleJournal!Key;RoleJournal" +
    ".PrincipalId;PrincipalId!Key;PrincipalId.UserName;SecurityPrivilege";
            this.RoleJournalXPC.LoadingEnabled = false;
            this.RoleJournalXPC.ObjectType = typeof(CoreModel.SecurityPrincipalRoleJournalMembers);
            this.RoleJournalXPC.Session = this.unitOfWork1;
            // 
            // roleJournalGC
            // 
            this.roleJournalGC.DataSource = this.RoleJournalXPC;
            this.roleJournalGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleJournalGC.Location = new System.Drawing.Point(0, 0);
            this.roleJournalGC.MainView = this.roleJournalGV;
            this.roleJournalGC.Name = "roleJournalGC";
            this.roleJournalGC.Size = new System.Drawing.Size(541, 300);
            this.roleJournalGC.TabIndex = 0;
            this.roleJournalGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.roleJournalGV});
            // 
            // roleJournalGV
            // 
            this.roleJournalGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.colSecurityPrivilege});
            this.roleJournalGV.EnableAutoFormat = true;
            this.roleJournalGV.EnableAutoSave = true;
            this.roleJournalGV.GridControl = this.roleJournalGC;
            this.roleJournalGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.FormEdit;
            this.roleJournalGV.Name = "roleJournalGV";
            this.roleJournalGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colLineId
            // 
            this.colLineId.FieldName = "LineId";
            this.colLineId.Name = "colLineId";
            this.colLineId.OptionsColumn.AllowEdit = false;
            this.colLineId.OptionsColumn.ReadOnly = true;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsColumn.AllowEdit = false;
            this.colCreatedBy.OptionsColumn.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.OptionsColumn.AllowEdit = false;
            this.colCreatedAt.OptionsColumn.ReadOnly = true;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.OptionsColumn.AllowEdit = false;
            this.colModifiedBy.OptionsColumn.ReadOnly = true;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.OptionsColumn.AllowEdit = false;
            this.colModifiedAt.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Journal";
            this.gridColumn1.FieldName = "RoleJournal!Key";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Principal Id";
            this.gridColumn3.FieldName = "PrincipalId!Key";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Principal name";
            this.gridColumn4.FieldName = "PrincipalId.UserName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // colSecurityPrivilege
            // 
            this.colSecurityPrivilege.FieldName = "SecurityPrivilege";
            this.colSecurityPrivilege.Name = "colSecurityPrivilege";
            this.colSecurityPrivilege.Visible = true;
            this.colSecurityPrivilege.VisibleIndex = 3;
            // 
            // SecurityRoleJournalXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roleJournalGC);
            this.Name = "SecurityRoleJournalXUC";
            this.Size = new System.Drawing.Size(541, 300);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMyXUC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleJournalXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleJournalGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleJournalGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection RoleJournalXPC;
        private CoreLib.Grid.MyGridControl roleJournalGC;
        private CoreLib.Grid.MyGridView roleJournalGV;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colSecurityPrivilege;
    }
}
