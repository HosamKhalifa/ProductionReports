namespace CoreModelWin
{
    partial class TestFrm
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
            this.mySearchLookUpEdit1 = new CoreLib.MyEditor.MySearchLookUpEdit();
            this.mySearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.lookupGrd = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.myGridControl1 = new CoreLib.Grid.MyGridControl();
            this.journalBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myGridView1 = new CoreLib.Grid.MyGridView();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mySearchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            this.SuspendLayout();
            // 
            // mySearchLookUpEdit1
            // 
            this.mySearchLookUpEdit1.Location = new System.Drawing.Point(12, 3);
            this.mySearchLookUpEdit1.Name = "mySearchLookUpEdit1";
            this.mySearchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mySearchLookUpEdit1.Properties.View = this.mySearchLookUpEdit1View;
            this.mySearchLookUpEdit1.Size = new System.Drawing.Size(233, 20);
            this.mySearchLookUpEdit1.TabIndex = 0;
            // 
            // mySearchLookUpEdit1View
            // 
            this.mySearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.mySearchLookUpEdit1View.Name = "mySearchLookUpEdit1View";
            this.mySearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.mySearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 201);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Setup";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // persistentRepository1
            // 
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookupGrd});
            // 
            // lookupGrd
            // 
            this.lookupGrd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupGrd.Name = "lookupGrd";
            this.lookupGrd.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // myGridControl1
            // 
            this.myGridControl1.DataSource = this.journalBaseBindingSource;
            this.myGridControl1.Location = new System.Drawing.Point(292, 6);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(491, 384);
            this.myGridControl1.TabIndex = 2;
            this.myGridControl1.UseEmbeddedNavigator = true;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // journalBaseBindingSource
            // 
            this.journalBaseBindingSource.DataSource = typeof(CoreModel.JournalBase);
            // 
            // myGridView1
            // 
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.UnitOfWorkXpo = null;
            // 
            // xpCollection1
            // 
            this.xpCollection1.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(785, 402);
            this.Controls.Add(this.myGridControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.mySearchLookUpEdit1);
            this.Name = "TestFrm";
            ((System.ComponentModel.ISupportInitialize)(this.mySearchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CoreLib.MyEditor.MySearchLookUpEdit mySearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView mySearchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit lookupGrd;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private CoreLib.Grid.MyGridControl myGridControl1;
        private CoreLib.Grid.MyGridView myGridView1;
        private System.Windows.Forms.BindingSource journalBaseBindingSource;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
    }
}
