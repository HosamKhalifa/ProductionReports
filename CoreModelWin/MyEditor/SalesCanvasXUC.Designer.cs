namespace CoreModelWin.MyEditor
{
    partial class SalesCanvasXUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesCanvasXUC));
            this.sequenceXPC = new CoreLib.Xpo.XPCollectionExt();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMyXUC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceXPC)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollectionMyXUC
            // 
            this.imageCollectionMyXUC.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionMyXUC.ImageStream")));
            // 
            // sequenceXPC
            // 
            this.sequenceXPC.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            // 
            // SalesCanvasXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SalesCanvasXUC";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMyXUC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceXPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CoreLib.Xpo.XPCollectionExt sequenceXPC;
    }
}
