namespace Test
{
    partial class Form2
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
            this.xpCollectionExt1 = new CoreLib.Xpo.XPCollectionExt();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.myGridControl1 = new CoreLib.Grid.MyGridControl();
            this.myGridView1 = new CoreLib.Grid.MyGridView();
            this.colSymbolValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSymbolName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSymbolTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpCollectionExt1
            // 
            this.xpCollectionExt1.ObjectType = typeof(CoreLib.Grid.UserProfile.UIMarkerIcons);
            this.xpCollectionExt1.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // myGridControl1
            // 
            this.myGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myGridControl1.DataSource = this.xpCollectionExt1;
            this.myGridControl1.Location = new System.Drawing.Point(12, 12);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(558, 287);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.UseEmbeddedNavigator = true;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSymbolValue,
            this.colSymbolName,
            this.colSymbolTitle});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colSymbolValue
            // 
            this.colSymbolValue.FieldName = "SymbolValue";
            this.colSymbolValue.Name = "colSymbolValue";
            this.colSymbolValue.Visible = true;
            this.colSymbolValue.VisibleIndex = 0;
            // 
            // colSymbolName
            // 
            this.colSymbolName.FieldName = "SymbolName";
            this.colSymbolName.Name = "colSymbolName";
            this.colSymbolName.Visible = true;
            this.colSymbolName.VisibleIndex = 1;
            // 
            // colSymbolTitle
            // 
            this.colSymbolTitle.FieldName = "SymbolTitle";
            this.colSymbolTitle.Name = "colSymbolTitle";
            this.colSymbolTitle.Visible = true;
            this.colSymbolTitle.VisibleIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(582, 311);
            this.Controls.Add(this.myGridControl1);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CoreLib.Xpo.XPCollectionExt xpCollectionExt1;
       
        private CoreLib.Grid.MyGridControl myGridControl1;
        private CoreLib.Grid.MyGridView myGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSymbolValue;
        private DevExpress.XtraGrid.Columns.GridColumn colSymbolName;
        private DevExpress.XtraGrid.Columns.GridColumn colSymbolTitle;
    }
}
