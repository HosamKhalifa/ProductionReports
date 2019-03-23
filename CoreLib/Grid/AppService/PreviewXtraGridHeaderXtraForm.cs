using CoreLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreLib.Grid.AppService
{
    public partial class PreviewXtraGridHeaderXtraForm : MyForm
    {
        public PreviewXtraGridHeaderXtraForm()
        {
            InitializeComponent();
          

        }

        #region Members

        List<string> headerTexts;

        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion

        #region EventHandlers

        private void closeSimpleButton_Click(object sender, EventArgs e)
        {
            headerTexts = new List<string>();
            headerTexts.Add(textEdit1.Text);//left
            headerTexts.Add(textEdit2.Text);//middle
            headerTexts.Add(textEdit3.Text);//right
            FormRecord.ObjectParm = headerTexts;

            this.Close();
        }

        #endregion

    }
}
