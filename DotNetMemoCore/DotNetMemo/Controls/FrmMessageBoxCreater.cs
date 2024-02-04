using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmMessageBoxCreater�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmMessageBoxCreater : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.Label promptLabel;
		private System.Windows.Forms.Label displayLabel;
		private System.Windows.Forms.Button displayButton;
		private System.Windows.Forms.GroupBox buttonTypeGroupBox;
		private System.Windows.Forms.GroupBox iconTypeGroupBox;
		private System.Windows.Forms.RadioButton okButton;
		private System.Windows.Forms.RadioButton okCancelButton;
		private System.Windows.Forms.RadioButton yesNoCancelButton;
		private System.Windows.Forms.RadioButton yesNoButton;
		private System.Windows.Forms.RadioButton retryButton;
		private System.Windows.Forms.RadioButton exclamationButton;
		private System.Windows.Forms.RadioButton informationButton;
		private System.Windows.Forms.RadioButton questionButton;
		#endregion
	
		#region Private Fields
		// ������ Ÿ���� �����ϴ� �ʵ�
		private MessageBoxIcon iconType = 
			MessageBoxIcon.Error;
		// ��ư Ÿ���� �����ϴ� �ʵ�
    private MessageBoxButtons buttonType = 
			MessageBoxButtons.OK;
		private System.Windows.Forms.RadioButton abortRetryIgnoreButton;
		private System.Windows.Forms.RadioButton errorButton;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructor
		public FrmMessageBoxCreater()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}

		#endregion

		#region Protected Methods
		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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
		#endregion

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.promptLabel = new System.Windows.Forms.Label();
			this.buttonTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.iconTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.displayButton = new System.Windows.Forms.Button();
			this.displayLabel = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.RadioButton();
			this.okCancelButton = new System.Windows.Forms.RadioButton();
			this.abortRetryIgnoreButton = new System.Windows.Forms.RadioButton();
			this.yesNoCancelButton = new System.Windows.Forms.RadioButton();
			this.yesNoButton = new System.Windows.Forms.RadioButton();
			this.retryButton = new System.Windows.Forms.RadioButton();
			this.errorButton = new System.Windows.Forms.RadioButton();
			this.exclamationButton = new System.Windows.Forms.RadioButton();
			this.informationButton = new System.Windows.Forms.RadioButton();
			this.questionButton = new System.Windows.Forms.RadioButton();
			this.buttonTypeGroupBox.SuspendLayout();
			this.iconTypeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// promptLabel
			// 
			this.promptLabel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.promptLabel.Location = new System.Drawing.Point(32, 16);
			this.promptLabel.Name = "promptLabel";
			this.promptLabel.Size = new System.Drawing.Size(296, 23);
			this.promptLabel.TabIndex = 0;
			this.promptLabel.Text = "ǥ���� �޽��� �ڽ� �ɼ��� �����ϼ���.";
			// 
			// buttonTypeGroupBox
			// 
			this.buttonTypeGroupBox.Controls.Add(this.retryButton);
			this.buttonTypeGroupBox.Controls.Add(this.yesNoButton);
			this.buttonTypeGroupBox.Controls.Add(this.yesNoCancelButton);
			this.buttonTypeGroupBox.Controls.Add(this.abortRetryIgnoreButton);
			this.buttonTypeGroupBox.Controls.Add(this.okCancelButton);
			this.buttonTypeGroupBox.Controls.Add(this.okButton);
			this.buttonTypeGroupBox.Location = new System.Drawing.Point(16, 48);
			this.buttonTypeGroupBox.Name = "buttonTypeGroupBox";
			this.buttonTypeGroupBox.Size = new System.Drawing.Size(160, 216);
			this.buttonTypeGroupBox.TabIndex = 1;
			this.buttonTypeGroupBox.TabStop = false;
			this.buttonTypeGroupBox.Text = "Button Type";
			// 
			// iconTypeGroupBox
			// 
			this.iconTypeGroupBox.Controls.Add(this.questionButton);
			this.iconTypeGroupBox.Controls.Add(this.informationButton);
			this.iconTypeGroupBox.Controls.Add(this.exclamationButton);
			this.iconTypeGroupBox.Controls.Add(this.errorButton);
			this.iconTypeGroupBox.Location = new System.Drawing.Point(192, 48);
			this.iconTypeGroupBox.Name = "iconTypeGroupBox";
			this.iconTypeGroupBox.Size = new System.Drawing.Size(184, 128);
			this.iconTypeGroupBox.TabIndex = 2;
			this.iconTypeGroupBox.TabStop = false;
			this.iconTypeGroupBox.Text = "Icon";
			// 
			// displayButton
			// 
			this.displayButton.Location = new System.Drawing.Point(200, 200);
			this.displayButton.Name = "displayButton";
			this.displayButton.Size = new System.Drawing.Size(176, 23);
			this.displayButton.TabIndex = 3;
			this.displayButton.Text = "ǥ���ϱ�";
			this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
			// 
			// displayLabel
			// 
			this.displayLabel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.displayLabel.Location = new System.Drawing.Point(208, 240);
			this.displayLabel.Name = "displayLabel";
			this.displayLabel.Size = new System.Drawing.Size(160, 23);
			this.displayLabel.TabIndex = 4;
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(24, 16);
			this.okButton.Name = "okButton";
			this.okButton.TabIndex = 0;
			this.okButton.Text = "OK";
			this.okButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// okCancelButton
			// 
			this.okCancelButton.Location = new System.Drawing.Point(24, 48);
			this.okCancelButton.Name = "okCancelButton";
			this.okCancelButton.TabIndex = 1;
			this.okCancelButton.Text = "OKCancel";
			this.okCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// abortRetryIgnoreButton
			// 
			this.abortRetryIgnoreButton.Location = new System.Drawing.Point(24, 80);
			this.abortRetryIgnoreButton.Name = "abortRetryIgnoreButton";
			this.abortRetryIgnoreButton.Size = new System.Drawing.Size(120, 24);
			this.abortRetryIgnoreButton.TabIndex = 2;
			this.abortRetryIgnoreButton.Text = "AbortRetryIgnore";
			this.abortRetryIgnoreButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// yesNoCancelButton
			// 
			this.yesNoCancelButton.Location = new System.Drawing.Point(24, 112);
			this.yesNoCancelButton.Name = "yesNoCancelButton";
			this.yesNoCancelButton.TabIndex = 3;
			this.yesNoCancelButton.Text = "YesNoCancel";
			this.yesNoCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// yesNoButton
			// 
			this.yesNoButton.Location = new System.Drawing.Point(24, 144);
			this.yesNoButton.Name = "yesNoButton";
			this.yesNoButton.TabIndex = 4;
			this.yesNoButton.Text = "YesNo";
			this.yesNoButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// retryButton
			// 
			this.retryButton.Location = new System.Drawing.Point(24, 176);
			this.retryButton.Name = "retryButton";
			this.retryButton.TabIndex = 5;
			this.retryButton.Text = "RetryCancel";
			this.retryButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
			// 
			// errorButton
			// 
			this.errorButton.Location = new System.Drawing.Point(40, 24);
			this.errorButton.Name = "errorButton";
			this.errorButton.TabIndex = 0;
			this.errorButton.Text = "Error";
			this.errorButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
			// 
			// exclamationButton
			// 
			this.exclamationButton.Location = new System.Drawing.Point(40, 48);
			this.exclamationButton.Name = "exclamationButton";
			this.exclamationButton.TabIndex = 1;
			this.exclamationButton.Text = "Exclamation";
			this.exclamationButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
			// 
			// informationButton
			// 
			this.informationButton.Location = new System.Drawing.Point(40, 72);
			this.informationButton.Name = "informationButton";
			this.informationButton.TabIndex = 2;
			this.informationButton.Text = "Information";
			this.informationButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
			// 
			// questionButton
			// 
			this.questionButton.Location = new System.Drawing.Point(40, 96);
			this.questionButton.Name = "questionButton";
			this.questionButton.TabIndex = 3;
			this.questionButton.Text = "Question";
			this.questionButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
			// 
			// FrmMessageBoxCreater
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(400, 277);
			this.Controls.Add(this.displayLabel);
			this.Controls.Add(this.displayButton);
			this.Controls.Add(this.iconTypeGroupBox);
			this.Controls.Add(this.buttonTypeGroupBox);
			this.Controls.Add(this.promptLabel);
			this.Name = "FrmMessageBoxCreater";
			this.Text = "FrmMessageBoxCreater";
			this.Load += new System.EventHandler(this.FrmMessageBoxCreater_Load);
			this.buttonTypeGroupBox.ResumeLayout(false);
			this.iconTypeGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		// ��ư Ŭ��
		private void buttonType_CheckedChanged(
			object sender, System.EventArgs e )
		{
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
			object sender, System.EventArgs e )
		{
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
				MessageBox.Show( "����� ������ �޽����ڽ��Դϴ�.", 
				"����� ���� �޽����ڽ�", buttonType, iconType, 0, 0 );

			switch ( result )
			{
				case DialogResult.OK: 
					displayLabel.Text = "OK ����."; 
					break;          
				case DialogResult.Cancel: 
					displayLabel.Text = "Cancel ����."; 
					break;          
				case DialogResult.Abort: 
					displayLabel.Text = "Abort ����."; 
					break;          
				case DialogResult.Retry: 
					displayLabel.Text = "Retry ����."; 
					break;          
				case DialogResult.Ignore: 
					displayLabel.Text = "Ignore ����."; 
					break;          
				case DialogResult.Yes: 
					displayLabel.Text = "Yes ����."; 
					break;          
				case DialogResult.No: 
					displayLabel.Text = "No ����."; 
					break;       
			} // end switch
		}    
		private void FrmMessageBoxCreater_Load(object sender, System.EventArgs e)
		{
			// �⺻�� ���
			MessageBox.Show(
				"�����ϼ���.",		// �ؽ�Ʈ
				"Ȯ��",					// ĸ��
				buttonType,			// ��ư Ÿ��
				iconType				// ������ ���
			);  
		}
		#endregion
	}
}
