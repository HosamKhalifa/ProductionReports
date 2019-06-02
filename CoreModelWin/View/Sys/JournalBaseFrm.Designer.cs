namespace CoreModelWin.View.Sys
{
    partial class JournalBaseFrm
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.overviewPage = new DevExpress.XtraTab.XtraTabPage();
            this.journalGC = new CoreLib.Grid.MyGridControl();
            this.journalBS = new System.Windows.Forms.BindingSource(this.components);
            this.journalXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.journalGV = new CoreLib.Grid.MyGridView();
            this.colWorkflowStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequenceWorkflowStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailsPage = new DevExpress.XtraTab.XtraTabPage();
            this.securityRoleJournalXUC1 = new CoreModelWin.View.Sys.SecurityRoleJournalXUC();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.overviewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalGV)).BeginInit();
            this.detailsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.overviewPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(582, 311);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.overviewPage,
            this.detailsPage});
            // 
            // overviewPage
            // 
            this.overviewPage.Controls.Add(this.journalGC);
            this.overviewPage.Name = "overviewPage";
            this.overviewPage.Size = new System.Drawing.Size(576, 283);
            this.overviewPage.Text = "Overview";
            // 
            // journalGC
            // 
            this.journalGC.DataSource = this.journalBS;
            this.journalGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalGC.Location = new System.Drawing.Point(0, 0);
            this.journalGC.MainView = this.journalGV;
            this.journalGC.Name = "journalGC";
            this.journalGC.Size = new System.Drawing.Size(576, 283);
            this.journalGC.TabIndex = 1;
            this.journalGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.journalGV});
            // 
            // journalBS
            // 
            this.journalBS.DataSource = this.journalXPC;
            // 
            // journalXPC
            // 
            this.journalXPC.DisplayableProperties = "WorkflowStatus;LineId;CreatedBy;CreatedAt;ModifiedBy;ModifiedAt;LineShadowLines;J" +
    "ournalCode;JournalName;JournalType;Sequence!Key;SequenceWorkflowStatus";
            this.journalXPC.ObjectType = typeof(CoreModel.JournalBase);
            this.journalXPC.Session = this.unitOfWork1;
            // 
            // journalGV
            // 
            this.journalGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWorkflowStatus,
            this.colLineId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colJournalCode,
            this.colJournalName,
            this.colJournalType,
            this.gridColumn1,
            this.colSequenceWorkflowStatus});
            this.journalGV.EnableAutoFormat = true;
            this.journalGV.EnableAutoSave = true;
            this.journalGV.GridControl = this.journalGC;
            this.journalGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.FormEdit;
            this.journalGV.Name = "journalGV";
            this.journalGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colWorkflowStatus
            // 
            this.colWorkflowStatus.FieldName = "WorkflowStatus";
            this.colWorkflowStatus.Name = "colWorkflowStatus";
            this.colWorkflowStatus.Visible = true;
            this.colWorkflowStatus.VisibleIndex = 0;
            // 
            // colLineId
            // 
            this.colLineId.FieldName = "LineId";
            this.colLineId.Name = "colLineId";
            this.colLineId.Visible = true;
            this.colLineId.VisibleIndex = 1;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 2;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 3;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 4;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 5;
            // 
            // colJournalCode
            // 
            this.colJournalCode.FieldName = "JournalCode";
            this.colJournalCode.Name = "colJournalCode";
            this.colJournalCode.Visible = true;
            this.colJournalCode.VisibleIndex = 6;
            // 
            // colJournalName
            // 
            this.colJournalName.FieldName = "JournalName";
            this.colJournalName.Name = "colJournalName";
            this.colJournalName.Visible = true;
            this.colJournalName.VisibleIndex = 7;
            // 
            // colJournalType
            // 
            this.colJournalType.FieldName = "JournalType";
            this.colJournalType.Name = "colJournalType";
            this.colJournalType.Visible = true;
            this.colJournalType.VisibleIndex = 8;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Sequence!Key";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            // 
            // colSequenceWorkflowStatus
            // 
            this.colSequenceWorkflowStatus.FieldName = "SequenceWorkflowStatus";
            this.colSequenceWorkflowStatus.Name = "colSequenceWorkflowStatus";
            this.colSequenceWorkflowStatus.Visible = true;
            this.colSequenceWorkflowStatus.VisibleIndex = 10;
            // 
            // detailsPage
            // 
            this.detailsPage.Controls.Add(this.securityRoleJournalXUC1);
            this.detailsPage.Name = "detailsPage";
            this.detailsPage.Size = new System.Drawing.Size(576, 283);
            this.detailsPage.Text = "Details";
            // 
            // securityRoleJournalXUC1
            // 
            this.securityRoleJournalXUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.securityRoleJournalXUC1.Location = new System.Drawing.Point(0, 0);
            this.securityRoleJournalXUC1.Name = "securityRoleJournalXUC1";
            this.securityRoleJournalXUC1.Size = new System.Drawing.Size(576, 283);
            this.securityRoleJournalXUC1.TabIndex = 0;
            // 
            // JournalBaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(582, 311);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "JournalBaseFrm";
            this.Text = "Journal names";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.overviewPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.journalGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalGV)).EndInit();
            this.detailsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage detailsPage;
        private DevExpress.XtraTab.XtraTabPage overviewPage;
        private DevExpress.Xpo.XPCollection journalXPC;
        private System.Windows.Forms.BindingSource journalBS;
        private CoreLib.Grid.MyGridControl journalGC;
        private CoreLib.Grid.MyGridView journalGV;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkflowStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalName;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colSequenceWorkflowStatus;
        private SecurityRoleJournalXUC securityRoleJournalXUC1;
    }
}
