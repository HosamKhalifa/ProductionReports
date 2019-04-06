namespace CoreModelWin.MyEditor
{
    partial class MasterDetailsForm
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.masterGC = new CoreLib.Grid.MyGridControl();
            this.masterGV = new CoreLib.Grid.MyGridView();
            this.detailsGC = new CoreLib.Grid.MyGridControl();
            this.detailsGV = new CoreLib.Grid.MyGridView();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.masterGC);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.detailsGC);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(768, 419);
            this.splitContainerControl1.SplitterPosition = 163;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // masterGC
            // 
            this.masterGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterGC.Location = new System.Drawing.Point(0, 0);
            this.masterGC.MainView = this.masterGV;
            this.masterGC.Name = "masterGC";
            this.masterGC.Size = new System.Drawing.Size(768, 163);
            this.masterGC.TabIndex = 0;
            this.masterGC.UseEmbeddedNavigator = true;
            this.masterGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.masterGV});
            // 
            // masterGV
            // 
            this.masterGV.GridControl = this.masterGC;
            this.masterGV.Name = "masterGV";
            this.masterGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // detailsGC
            // 
            this.detailsGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGC.Location = new System.Drawing.Point(0, 0);
            this.detailsGC.MainView = this.detailsGV;
            this.detailsGC.Name = "detailsGC";
            this.detailsGC.Size = new System.Drawing.Size(768, 250);
            this.detailsGC.TabIndex = 0;
            this.detailsGC.UseEmbeddedNavigator = true;
            this.detailsGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.detailsGV});
            // 
            // detailsGV
            // 
            this.detailsGV.GridControl = this.detailsGC;
            this.detailsGV.Name = "detailsGV";
            this.detailsGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // MasterDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(768, 419);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "MasterDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private CoreLib.Grid.MyGridControl masterGC;
        private CoreLib.Grid.MyGridView masterGV;
        private CoreLib.Grid.MyGridControl detailsGC;
        private CoreLib.Grid.MyGridView detailsGV;
    }
}
