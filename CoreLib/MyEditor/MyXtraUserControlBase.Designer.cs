namespace CoreLib.MyEditor
{
    partial class MyXtraUserControlBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyXtraUserControlBase));
            this.imageCollectionMyXUC = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMyXUC)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollectionMyXUC
            // 
            this.imageCollectionMyXUC.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionMyXUC.ImageStream")));
            // 
            // MyXtraUserControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MyXtraUserControlBase";
            this.Size = new System.Drawing.Size(323, 224);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMyXUC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.Utils.ImageCollection imageCollectionMyXUC;
    }
}
