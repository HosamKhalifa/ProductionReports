namespace CoreLib
{
    partial class InputBoxFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBoxFrm));
            this.parmDataSet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.parmVGC = new DevExpress.XtraVerticalGrid.VGridControl();
            this.parmBS = new System.Windows.Forms.BindingSource();
            this.okSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.promptLabelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parmVGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parmBS)).BeginInit();
            this.SuspendLayout();
            // 
            // parmDataSet
            // 
            this.parmDataSet.DataSetName = "NewDataSet";
            this.parmDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "ParmTable";
            // 
            // parmVGC
            // 
            this.parmVGC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parmVGC.DataMember = null;
            this.parmVGC.DataSource = this.parmBS;
            this.parmVGC.Location = new System.Drawing.Point(12, 84);
            this.parmVGC.Name = "parmVGC";
            this.parmVGC.Size = new System.Drawing.Size(315, 88);
            this.parmVGC.TabIndex = 0;
            // 
            // parmBS
            // 
            this.parmBS.DataMember = "ParmTable";
            this.parmBS.DataSource = this.parmDataSet;
            // 
            // okSimpleButton
            // 
            this.okSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("okSimpleButton.Image")));
            this.okSimpleButton.Location = new System.Drawing.Point(356, 12);
            this.okSimpleButton.Name = "okSimpleButton";
            this.okSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.okSimpleButton.TabIndex = 1;
            this.okSimpleButton.Text = "OK";
            // 
            // cancelSimpleButton
            // 
            this.cancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelSimpleButton.Image")));
            this.cancelSimpleButton.Location = new System.Drawing.Point(356, 41);
            this.cancelSimpleButton.Name = "cancelSimpleButton";
            this.cancelSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSimpleButton.TabIndex = 2;
            this.cancelSimpleButton.Text = "Cancel";
            // 
            // promptLabelControl
            // 
            this.promptLabelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promptLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.promptLabelControl.LineVisible = true;
            this.promptLabelControl.Location = new System.Drawing.Point(13, 13);
            this.promptLabelControl.Name = "promptLabelControl";
            this.promptLabelControl.Size = new System.Drawing.Size(314, 51);
            this.promptLabelControl.TabIndex = 3;
            this.promptLabelControl.Text = "Prompt:";
            // 
            // InputBoxFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(443, 184);
            this.Controls.Add(this.promptLabelControl);
            this.Controls.Add(this.cancelSimpleButton);
            this.Controls.Add(this.okSimpleButton);
            this.Controls.Add(this.parmVGC);
            this.Name = "InputBoxFrm";
            this.Text = "Input box";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parmVGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parmBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataTable dataTable1;
        private DevExpress.XtraEditors.SimpleButton okSimpleButton;
        private DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
        public DevExpress.XtraVerticalGrid.VGridControl parmVGC;
        public DevExpress.XtraEditors.LabelControl promptLabelControl;
        public System.Data.DataSet parmDataSet;
        private System.Windows.Forms.BindingSource parmBS;
    }
}
