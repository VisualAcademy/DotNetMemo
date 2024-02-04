using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace 메시지박스생성기{
	/// <summary>
	/// MessageBoxCreater에 대한 요약 설명입니다.
	/// </summary>
	public class MessageBoxCreater : System.Windows.Forms.Form{
		#region 필드
		private System.Windows.Forms.Label promptLabel;
		private System.Windows.Forms.Label displayLabel;
		private System.Windows.Forms.Button displayButton;
		private System.Windows.Forms.GroupBox iconTypeGroupBox;
		private System.Windows.Forms.RadioButton questionButton;
		private System.Windows.Forms.RadioButton informationButton;
		private System.Windows.Forms.RadioButton exclamationButton;
		private System.Windows.Forms.RadioButton errorButton;
		private System.Windows.Forms.GroupBox buttonTypeGroupBox;
		private System.Windows.Forms.RadioButton retryCancelButton;
		private System.Windows.Forms.RadioButton yesNoButton;
		private System.Windows.Forms.RadioButton yesNoCancelButton;
		private System.Windows.Forms.RadioButton abortRetryIgnoreButton;
		private System.Windows.Forms.RadioButton okCancelButton;
		private System.Windows.Forms.RadioButton okButton;  

		private MessageBoxIcon iconType = MessageBoxIcon.Error;
		private MessageBoxButtons buttonType = MessageBoxButtons.OK;

		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion
		public MessageBoxCreater()
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
			this.promptLabel = new System.Windows.Forms.Label();
			this.displayLabel = new System.Windows.Forms.Label();
			this.displayButton = new System.Windows.Forms.Button();
			this.iconTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.questionButton = new System.Windows.Forms.RadioButton();
			this.informationButton = new System.Windows.Forms.RadioButton();
			this.exclamationButton = new System.Windows.Forms.RadioButton();
			this.errorButton = new System.Windows.Forms.RadioButton();
			this.buttonTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.retryCancelButton = new System.Windows.Forms.RadioButton();
			this.yesNoButton = new System.Windows.Forms.RadioButton();
			this.yesNoCancelButton = new System.Windows.Forms.RadioButton();
			this.abortRetryIgnoreButton = new System.Windows.Forms.RadioButton();
			this.okCancelButton = new System.Windows.Forms.RadioButton();
			this.okButton = new System.Windows.Forms.RadioButton();
			this.iconTypeGroupBox.SuspendLayout();
			this.buttonTypeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// promptLabel
			// 
			this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.promptLabel.Location = new System.Drawing.Point(42, 58);
			this.promptLabel.Name = "promptLabel";
			this.promptLabel.Size = new System.Drawing.Size(412, 26);
			this.promptLabel.TabIndex = 10;
			this.promptLabel.Text = "표시할 메시지박스 옵션을 선택하세요.";
			// 
			// displayLabel
			// 
			this.displayLabel.Location = new System.Drawing.Point(272, 368);
			this.displayLabel.Name = "displayLabel";
			this.displayLabel.Size = new System.Drawing.Size(163, 26);
			this.displayLabel.TabIndex = 9;
			// 
			// displayButton
			// 
			this.displayButton.Location = new System.Drawing.Point(272, 299);
			this.displayButton.Name = "displayButton";
			this.displayButton.Size = new System.Drawing.Size(163, 52);
			this.displayButton.TabIndex = 8;
			this.displayButton.Text = "표시하기";
			this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
			// 
			// iconTypeGroupBox
			// 
			this.iconTypeGroupBox.Controls.Add(this.questionButton);
			this.iconTypeGroupBox.Controls.Add(this.informationButton);
			this.iconTypeGroupBox.Controls.Add(this.exclamationButton);
			this.iconTypeGroupBox.Controls.Add(this.errorButton);
			this.iconTypeGroupBox.Location = new System.Drawing.Point(272, 101);
			this.iconTypeGroupBox.Name = "iconTypeGroupBox";
			this.iconTypeGroupBox.Size = new System.Drawing.Size(163, 190);
			this.iconTypeGroupBox.TabIndex = 7;
			this.iconTypeGroupBox.TabStop = false;
			this.iconTypeGroupBox.Text = "Icon";
			// 
			// questionButton
			// 
			this.questionButton.Location = new System.Drawing.Point(19, 155);
			this.questionButton.Name = "questionButton";
			this.questionButton.Size = new System.Drawing.Size(120, 25);
			this.questionButton.TabIndex = 0;
			this.questionButton.Text = "Question";
			this.questionButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
			// 
			// informationButton
			// 
			this.informationButton.Location = new System.Drawing.Point(19, 112);
			this.informationButton.Name = "informationButton";
			this.informationButton.Size = new System.Drawing.Size(120, 25);
			this.informationButton.TabIndex = 4;
			this.informationButton.Text = "Information";
			this.informationButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
			// 
			// exclamationButton
			// 
			this.exclamationButton.Location = new System.Drawing.Point(19, 69);
			this.exclamationButton.Name = "exclamationButton";
			this.exclamationButton.Size = new System.Drawing.Size(125, 25);
			this.exclamationButton.TabIndex = 2;
			this.exclamationButton.Text = "Exclamation";
			this.exclamationButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
			// 
			// errorButton
			// 
			this.errorButton.Location = new System.Drawing.Point(19, 26);
			this.errorButton.Name = "errorButton";
			this.errorButton.Size = new System.Drawing.Size(120, 25);
			this.errorButton.TabIndex = 1;
			this.errorButton.Text = "Error";
			this.errorButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
			// 
			// buttonTypeGroupBox
			// 
			this.buttonTypeGroupBox.Controls.Add(this.retryCancelButton);
			this.buttonTypeGroupBox.Controls.Add(this.yesNoButton);
			this.buttonTypeGroupBox.Controls.Add(this.yesNoCancelButton);
			this.buttonTypeGroupBox.Controls.Add(this.abortRetryIgnoreButton);
			this.buttonTypeGroupBox.Controls.Add(this.okCancelButton);
			this.buttonTypeGroupBox.Controls.Add(this.okButton);
			this.buttonTypeGroupBox.Location = new System.Drawing.Point(51, 101);
			this.buttonTypeGroupBox.Name = "buttonTypeGroupBox";
			this.buttonTypeGroupBox.Size = new System.Drawing.Size(183, 293);
			this.buttonTypeGroupBox.TabIndex = 6;
			this.buttonTypeGroupBox.TabStop = false;
			this.buttonTypeGroupBox.Text = "Button Type";
			// 
			// retryCancelButton
			// 
			this.retryCancelButton.Location = new System.Drawing.Point(19, 241);
			this.retryCancelButton.Name = "retryCancelButton";
			this.retryCancelButton.Size = new System.Drawing.Size(120, 25);
			this.retryCancelButton.TabIndex = 4;
			this.retryCancelButton.Text = "RetryCancel";
			this.retryCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// yesNoButton
			// 
			this.yesNoButton.Location = new System.Drawing.Point(19, 198);
			this.yesNoButton.Name = "yesNoButton";
			this.yesNoButton.Size = new System.Drawing.Size(120, 25);
			this.yesNoButton.TabIndex = 0;
			this.yesNoButton.Text = "YesNo";
			this.yesNoButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// yesNoCancelButton
			// 
			this.yesNoCancelButton.Location = new System.Drawing.Point(19, 155);
			this.yesNoCancelButton.Name = "yesNoCancelButton";
			this.yesNoCancelButton.Size = new System.Drawing.Size(120, 25);
			this.yesNoCancelButton.TabIndex = 3;
			this.yesNoCancelButton.Text = "YesNoCancel";
			this.yesNoCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// abortRetryIgnoreButton
			// 
			this.abortRetryIgnoreButton.Location = new System.Drawing.Point(19, 112);
			this.abortRetryIgnoreButton.Name = "abortRetryIgnoreButton";
			this.abortRetryIgnoreButton.Size = new System.Drawing.Size(144, 25);
			this.abortRetryIgnoreButton.TabIndex = 2;
			this.abortRetryIgnoreButton.Text = "AbortRetryIgnore";
			this.abortRetryIgnoreButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// okCancelButton
			// 
			this.okCancelButton.Location = new System.Drawing.Point(19, 69);
			this.okCancelButton.Name = "okCancelButton";
			this.okCancelButton.Size = new System.Drawing.Size(120, 25);
			this.okCancelButton.TabIndex = 1;
			this.okCancelButton.Text = "OKCancel";
			this.okCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// okButton
			// 
			this.okButton.Checked = true;
			this.okButton.Location = new System.Drawing.Point(19, 26);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(120, 25);
			this.okButton.TabIndex = 0;
			this.okButton.TabStop = true;
			this.okButton.Text = "OK";
			this.okButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// MessageBoxCreater
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(496, 453);
			this.Controls.Add(this.promptLabel);
			this.Controls.Add(this.displayLabel);
			this.Controls.Add(this.displayButton);
			this.Controls.Add(this.iconTypeGroupBox);
			this.Controls.Add(this.buttonTypeGroupBox);
			this.Name = "MessageBoxCreater";
			this.Text = "MessageBoxCreater";
			this.iconTypeGroupBox.ResumeLayout(false);
			this.buttonTypeGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion      

		private void buttonType_CheckedChanged(
			object sender, System.EventArgs e ){
			if ( sender == okButton )
				buttonType = MessageBoxButtons.OK;
			else if ( sender == okCancelButton )
				buttonType = MessageBoxButtons.OKCancel;
			else if ( sender == abortRetryIgnoreButton )
				buttonType = MessageBoxButtons.AbortRetryIgnore;
			else if ( sender == yesNoCancelButton )
				buttonType = MessageBoxButtons.YesNoCancel;
			else if ( sender == yesNoButton )
				buttonType = MessageBoxButtons.YesNo;
			else
				buttonType = MessageBoxButtons.RetryCancel;
		}                                          
		private void iconType_CheckedChanged(
			object sender, System.EventArgs e ){
			if ( sender == errorButton )
				iconType = MessageBoxIcon.Error;
			else if ( sender == exclamationButton )
				iconType = MessageBoxIcon.Exclamation;
			else if ( sender == informationButton ) 
				iconType = MessageBoxIcon.Information;
			else
				iconType = MessageBoxIcon.Question;
		}   
		private void displayButton_Click(object sender, System.EventArgs e)
		{
			DialogResult result = 
				MessageBox.Show( "당신이 선택한 메시지박스입니다.", 
				"사용자 정의 메시지박스", buttonType, iconType, 0, 0 );

			switch ( result ){
				case DialogResult.OK: 
					displayLabel.Text = "OK 눌림."; 
					break;          
				case DialogResult.Cancel: 
					displayLabel.Text = "Cancel 눌림."; 
					break;          
				case DialogResult.Abort: 
					displayLabel.Text = "Abort 눌림."; 
					break;          
				case DialogResult.Retry: 
					displayLabel.Text = "Retry 눌림."; 
					break;          
				case DialogResult.Ignore: 
					displayLabel.Text = "Ignore 눌림."; 
					break;          
				case DialogResult.Yes: 
					displayLabel.Text = "Yes 눌림."; 
					break;          
				case DialogResult.No: 
					displayLabel.Text = "No 눌림."; 
					break;       
			} // end switch
		}    
	}
}
