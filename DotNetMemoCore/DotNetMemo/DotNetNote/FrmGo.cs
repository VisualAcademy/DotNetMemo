using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DotNetNote
{
    public partial class FrmGo : Form
    {
        #region Private Member Variables
        private int _LineLength;
        private int _CurrentLine; 
        #endregion

        #region Constructors
        public FrmGo()
        {
          InitializeComponent();
        }

        public FrmGo(int intLineLength, int intCurrentLine)
        {
          this._LineLength = intLineLength;
          this._CurrentLine = intCurrentLine;
          InitializeComponent();
        } 
        #endregion

        #region Event Handlers
        private void FrmGo_Load(object sender, EventArgs e)
        {
          this.txtLineNumber.Text = this._CurrentLine.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          try
          {
            int intMaxLine = Convert.ToInt32(txtLineNumber.Text);
            if (intMaxLine > this._LineLength)
            {
              MessageBox.Show("줄 번호가 범위를 벗어납니다.",
                  "메모장",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
              this.DialogResult = DialogResult.Cancel;
              return;
            }
            else if (intMaxLine < 1)
            {
              MessageBox.Show("줄 번호가 범위를 벗어납니다.",
                  "메모장",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
              this.DialogResult = DialogResult.Cancel;
              return;
            }
          }
          catch
          {
            return;
          }
          finally
          {
            this.Close();
          }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          this.Close();
        } 
        #endregion

        #region Public Methods
        public int GetLine()
        {
          return Convert.ToInt32(this.txtLineNumber.Text);
        } 
        #endregion
    }
}