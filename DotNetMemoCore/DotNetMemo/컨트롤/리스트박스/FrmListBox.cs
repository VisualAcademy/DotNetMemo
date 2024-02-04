namespace CSharp_Windows.리스트박스
{
    /// <summary>
    /// FrmListBox에 대한 요약 설명입니다.
    /// </summary>
    public class FrmListBox : System.Windows.Forms.Form
    {
        #region Controls
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ListBox lstCountry;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lblDisplay;
        #endregion
        /// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmListBox()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.lstCountry = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(328, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "나라 이름을 입력하세요.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lstCountry
			// 
			this.lstCountry.ItemHeight = 12;
			this.lstCountry.Location = new System.Drawing.Point(8, 48);
			this.lstCountry.Name = "lstCountry";
			this.lstCountry.Size = new System.Drawing.Size(120, 208);
			this.lstCountry.TabIndex = 1;
			this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(136, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "나라 이름 : ";
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(208, 32);
			this.txtInput.Name = "txtInput";
			this.txtInput.TabIndex = 3;
			this.txtInput.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(224, 88);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "입력";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(224, 128);
			this.button2.Name = "button2";
			this.button2.TabIndex = 5;
			this.button2.Text = "선택 삭제";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(224, 168);
			this.button3.Name = "button3";
			this.button3.TabIndex = 6;
			this.button3.Text = "모두 삭제";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(224, 208);
			this.button4.Name = "button4";
			this.button4.TabIndex = 7;
			this.button4.Text = "종료";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(136, 120);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(64, 23);
			this.button5.TabIndex = 8;
			this.button5.Text = "위로";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(136, 176);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(64, 23);
			this.button6.TabIndex = 9;
			this.button6.Text = "아래로";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 278);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(328, 23);
			this.lblDisplay.TabIndex = 10;
			// 
			// FrmListBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(328, 301);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.lblDisplay,
																																	this.button6,
																																	this.button5,
																																	this.button4,
																																	this.button3,
																																	this.button2,
																																	this.button1,
																																	this.txtInput,
																																	this.label2,
																																	this.lstCountry,
																																	this.label1});
			this.Name = "FrmListBox";
			this.Text = "리스트 박스 컨트롤";
			this.ResumeLayout(false);

		}
		#endregion

		//닫기
		private void button4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		//입력
		private void button1_Click(object sender, System.EventArgs e)
		{
			if(this.txtInput.Text.Length > 0)
			{
				string strCountry = this.txtInput.Text.Trim();//공백 제거
				this.lstCountry.Items.Add(strCountry);//항목 추가
				//this.txtInput.Text = "";//클리어
				this.txtInput.Clear();//텍스트 박스 비우기
				this.txtInput.Focus();//초점
			}
		}
		//선택 삭제
		private void button2_Click(object sender, System.EventArgs e)
		{
			if(this.lstCountry.SelectedIndex != -1)//선택이 되었다면,
			{
				int intIndex = this.lstCountry.SelectedIndex;//인덱스
				this.lstCountry.Items.RemoveAt(intIndex);//현재 인덱스 삭제
			}
		}
		//모두 삭제
		private void button3_Click(object sender, System.EventArgs e)
		{	
			this.lstCountry.Items.Clear();//전체 클리어
		}
		//위로
		private void button5_Click(object sender, System.EventArgs e)
		{
			//과제
		}
		//아래로
		private void button6_Click(object sender, System.EventArgs e)
		{
			//과제
		}
		//리스트 박스 선택할 때 레이블에 항목 출력
		private void lstCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.lstCountry.SelectedIndex != -1)
			{
				this.lblDisplay.Text = 
					this.lstCountry.SelectedItem.ToString() + " 선택됨";
			}
		}
	}
}
