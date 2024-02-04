using System.Drawing;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmTab�� ���� ��� �����Դϴ�.
    /// </summary>
    public class FrmTab : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.RadioButton radRed;
		private System.Windows.Forms.RadioButton radGreen;
		private System.Windows.Forms.RadioButton radBlue;
		private System.Windows.Forms.RadioButton radSize12;
		private System.Windows.Forms.RadioButton radSize16;
		private System.Windows.Forms.RadioButton radSize20;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmTab()
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.radRed = new System.Windows.Forms.RadioButton();
			this.radGreen = new System.Windows.Forms.RadioButton();
			this.radBlue = new System.Windows.Forms.RadioButton();
			this.radSize12 = new System.Windows.Forms.RadioButton();
			this.radSize16 = new System.Windows.Forms.RadioButton();
			this.radSize20 = new System.Windows.Forms.RadioButton();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Location = new System.Drawing.Point(16, 32);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(320, 152);
			this.tabControl1.TabIndex = 0;
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 197);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(352, 40);
			this.lblDisplay.TabIndex = 1;
			this.lblDisplay.Text = "�ؽ�Ʈ�� �Ӽ��� �����غ�����.";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.radBlue);
			this.tabPage1.Controls.Add(this.radGreen);
			this.tabPage1.Controls.Add(this.radRed);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(312, 127);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "����";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.radSize20);
			this.tabPage2.Controls.Add(this.radSize16);
			this.tabPage2.Controls.Add(this.radSize12);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(312, 127);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "ũ��";
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 21);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(312, 127);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "�ؽ�Ʈ";
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 21);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(312, 127);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "��Ÿ��";
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 21);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(312, 127);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "��Ÿ";
			// 
			// radRed
			// 
			this.radRed.Location = new System.Drawing.Point(96, 16);
			this.radRed.Name = "radRed";
			this.radRed.TabIndex = 0;
			this.radRed.Text = "Red";
			this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
			// 
			// radGreen
			// 
			this.radGreen.Location = new System.Drawing.Point(96, 48);
			this.radGreen.Name = "radGreen";
			this.radGreen.TabIndex = 1;
			this.radGreen.Text = "Green";
			this.radGreen.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
			// 
			// radBlue
			// 
			this.radBlue.Location = new System.Drawing.Point(96, 80);
			this.radBlue.Name = "radBlue";
			this.radBlue.TabIndex = 2;
			this.radBlue.Text = "Blue";
			this.radBlue.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
			// 
			// radSize12
			// 
			this.radSize12.Location = new System.Drawing.Point(104, 24);
			this.radSize12.Name = "radSize12";
			this.radSize12.TabIndex = 0;
			this.radSize12.Text = "12����Ʈ";
			this.radSize12.CheckedChanged += new System.EventHandler(this.Point_CheckedChanged);
			// 
			// radSize16
			// 
			this.radSize16.Location = new System.Drawing.Point(104, 56);
			this.radSize16.Name = "radSize16";
			this.radSize16.TabIndex = 1;
			this.radSize16.Text = "16����Ʈ";
			this.radSize16.CheckedChanged += new System.EventHandler(this.Point_CheckedChanged);
			// 
			// radSize20
			// 
			this.radSize20.Location = new System.Drawing.Point(104, 88);
			this.radSize20.Name = "radSize20";
			this.radSize20.TabIndex = 2;
			this.radSize20.Text = "20����Ʈ";
			this.radSize20.CheckedChanged += new System.EventHandler(this.Point_CheckedChanged);
			// 
			// FrmTab
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(352, 237);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.tabControl1);
			this.Name = "FrmTab";
			this.Text = "FrmTab";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void radRed_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lblDisplay.BackColor = Color.Red;
		}

		private void Color_CheckedChanged(object sender, System.EventArgs e)
		{
			if (sender == radGreen)
				lblDisplay.BackColor = Color.Green;
			else
				lblDisplay.BackColor = Color.Blue;
		}

		private void Point_CheckedChanged(object sender, System.EventArgs e)
		{
			// ��Ʈ ������ ���ϱ� : new Font(,)
			if (sender == radSize12)
				lblDisplay.Font = new Font(
					lblDisplay.Font.Name, 12);
			else if (sender == radSize16)
				lblDisplay.Font = new Font(
					lblDisplay.Font.Name, 16);
			else
				lblDisplay.Font = new Font(
					lblDisplay.Font.Name, 20);
		}

	}
}
