using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmListBox�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmListBox : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstCountry;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnUp;		//����
		private System.Windows.Forms.Button btnDown;	//�Ʒ���
		private System.Windows.Forms.Button btnInput;	//�Է�
		private System.Windows.Forms.Button btnDelete;//���û���
		private System.Windows.Forms.Button btnClear;	//��λ���
		private System.Windows.Forms.Button btnClose;	//�ݱ�
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmListBox()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}

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

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.lstCountry = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnInput = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "���� �̸��� �Է��ϼ���.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lstCountry
			// 
			this.lstCountry.ItemHeight = 12;
			this.lstCountry.Location = new System.Drawing.Point(16, 64);
			this.lstCountry.Name = "lstCountry";
			this.lstCountry.Size = new System.Drawing.Size(120, 88);
			this.lstCountry.TabIndex = 1;
			this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(160, 32);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "���� �̸�:";
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(248, 32);
			this.txtInput.Name = "txtInput";
			this.txtInput.TabIndex = 3;
			this.txtInput.Text = "";
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(144, 72);
			this.btnUp.Name = "btnUp";
			this.btnUp.TabIndex = 4;
			this.btnUp.Text = "����";
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(144, 112);
			this.btnDown.Name = "btnDown";
			this.btnDown.TabIndex = 5;
			this.btnDown.Text = "�Ʒ���";
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnInput
			// 
			this.btnInput.Location = new System.Drawing.Point(256, 64);
			this.btnInput.Name = "btnInput";
			this.btnInput.TabIndex = 6;
			this.btnInput.Text = "�Է�";
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(256, 96);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "���� ����";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(256, 128);
			this.btnClear.Name = "btnClear";
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "��� ����";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(256, 160);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "����";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 206);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(360, 23);
			this.lblDisplay.TabIndex = 10;
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmListBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(360, 229);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnInput);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstCountry);
			this.Controls.Add(this.label1);
			this.Name = "FrmListBox";
			this.Text = "����Ʈ�ڽ� : ���� �׸� �� �ϳ� ����";
			this.ResumeLayout(false);

		}
		#endregion

		// ����Ʈ�ڽ��� �׸� ���ý�
		private void lstCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		// �Է�
		private void btnInput_Click(object sender, System.EventArgs e)
		{
			
		}

		// ���û���
		private void btnDelete_Click(object sender, System.EventArgs e)
		{
		
		}

		// ��λ���
		private void btnClear_Click(object sender, System.EventArgs e)
		{
		
		}
		// �ݱ�
		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		// ����(����)
		private void btnUp_Click(object sender, System.EventArgs e)
		{
		
		}
		// �Ʒ���(����)
		private void btnDown_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
