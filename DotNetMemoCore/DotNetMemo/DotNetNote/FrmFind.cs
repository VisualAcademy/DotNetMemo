﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DotNetNote
{
    public partial class FrmFind : Form
    {
        #region Private Members
        private DotNetNote dnn = null; // 메인 폼을 가리키는 객체
        #endregion

        #region Constructors
        public FrmFind()
        {
            InitializeComponent();
        }

        public FrmFind(DotNetNote objDotNetNote)
        {
            dnn = objDotNetNote;
            InitializeComponent();
        }
        #endregion

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            this.btnFind.Enabled = true;
        }

        // 다음 찾기 버튼 기능 구현
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!FindText())
            { 
                MessageBox.Show(
                    this.txtFind.Text + "을(를) 찾을 수 없습니다.",
                    "메모장",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // 찾기 전용 메서드 : 찾지 못하면 false
        private bool FindText()
        {
            int nFind;
            int nLen;
            string strTempText;
            string strTempFind;

            // 대/소문자 구분
            if (chkCase.Checked)
            {
                strTempText = dnn.txtMain.Text; // 찾을 대상
                strTempFind = txtFind.Text; // 찾을 단어
            }
            else 
            {
                strTempText = dnn.txtMain.Text.ToLower(); // 소문자
                strTempFind = txtFind.Text.ToLower(); // 소문자
            }

            nLen = txtFind.Text.Length; // 텍스트 길이

            // 위로 / 아래로 검색
            if (rdoUp.Checked)
            {
                if (dnn.txtMain.SelectionStart - 
                    dnn.txtMain.SelectionLength < 0)
                {
                    nFind = -1;
                }
                else
                {
                    nFind = strTempText.LastIndexOf(
                        strTempFind,
                        dnn.txtMain.SelectionStart -
                        dnn.txtMain.SelectionLength);
                }
            }
            else // 아래로
            {
                nFind = strTempText.IndexOf(
                    strTempFind, 
                    dnn.txtMain.SelectionStart + 
                    dnn.txtMain.SelectionLength);
            }

            // 비교
            if (nFind == -1)
            {
                return false;
            }
            else
            {
                dnn.txtMain.SelectionStart = nFind;
                dnn.txtMain.SelectionLength = nLen;
                dnn.txtMain.Focus();
                return true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}