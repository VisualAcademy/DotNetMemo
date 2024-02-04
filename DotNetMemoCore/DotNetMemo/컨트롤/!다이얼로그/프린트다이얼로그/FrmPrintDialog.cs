using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;//
using System.Drawing.Printing;//

namespace CSharp_Windows.프린트다이얼로그
{
	public class FrmPrintDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button btnPrint;

		private string strFileName = 
			@"C:\CSharp_Windows\프린트다이얼로그\Print.txt";
		private StreamReader objStreamToPrint;//인쇄할 스트림
		private Font objPrintFont;
		private System.Windows.Forms.PrintPreviewControl printPreviewControl1;//폰트

		#region +
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmPrintDialog()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmPrintDialog));
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.btnPrint = new System.Windows.Forms.Button();
			this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
			this.SuspendLayout();
			// 
			// printDialog1
			// 
			this.printDialog1.AllowPrintToFile = false;
			this.printDialog1.Document = this.printDocument1;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(281, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(112, 96);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.TabIndex = 1;
			this.btnPrint.Text = "인쇄";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// printPreviewControl1
			// 
			this.printPreviewControl1.AutoZoom = false;
			this.printPreviewControl1.Location = new System.Drawing.Point(8, 8);
			this.printPreviewControl1.Name = "printPreviewControl1";
			this.printPreviewControl1.Size = new System.Drawing.Size(288, 80);
			this.printPreviewControl1.TabIndex = 2;
			this.printPreviewControl1.Zoom = 0.19674935842600513;
			// 
			// FrmPrintDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(304, 125);
			this.Controls.Add(this.printPreviewControl1);
			this.Controls.Add(this.btnPrint);
			this.Name = "FrmPrintDialog";
			this.Text = "FrmPrintDialog";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		
		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			this.printDocument1.DocumentName = "인쇄 테스트";

			this.printDialog1.AllowPrintToFile = false;
			this.printDialog1.AllowSelection = false;
			this.printDialog1.AllowSomePages = false;
			this.printDialog1.Document = this.printDocument1;

			if(this.printDialog1.ShowDialog() == DialogResult.OK)
			{
				objStreamToPrint = new StreamReader(
					strFileName, System.Text.Encoding.Default);

				objPrintFont = new Font("굴림", 10);

				this.printDocument1.PrinterSettings = this.printDialog1.PrinterSettings;

				//this.printPreviewDialog1.ShowDialog();//인쇄 미리보기
				this.printDocument1.Print();
				
				objStreamToPrint.Close();
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			float dblLinesPerPage = 0;
			float dblVerticalPosition = 0;
			int intLineCount = 0;
			float dblLeftMargin = e.MarginBounds.Left;
			float dblTopMargin = e.MarginBounds.Top;
			string strLine = "";

			dblLinesPerPage = e.MarginBounds.Height / objPrintFont.GetHeight(e.Graphics);

			strLine = objStreamToPrint.ReadLine();
			while((intLineCount < dblLinesPerPage) && (strLine != null))
			{
				dblVerticalPosition = dblTopMargin + (intLineCount * objPrintFont.GetHeight(e.Graphics));

				e.Graphics.DrawString(strLine
					, objPrintFont
					, Brushes.Black
					, dblLeftMargin
					, dblVerticalPosition
					, new StringFormat());

				intLineCount = intLineCount + 1;

				if(intLineCount < dblLinesPerPage)
				{
					strLine = objStreamToPrint.ReadLine();
				}
			}

			if(strLine != null)
			{
				e.HasMorePages = true;
			}
			else
			{
				e.HasMorePages = false;
			}
		}
	}
}
