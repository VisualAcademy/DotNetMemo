using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmProgressBar�� ���� ��� �����Դϴ�.
    /// </summary>
    public class FrmProgressBar : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnCommand;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmProgressBar()
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnCommand = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(48, 32);
			this.progressBar1.Maximum = 1000000;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(216, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// btnCommand
			// 
			this.btnCommand.Location = new System.Drawing.Point(40, 80);
			this.btnCommand.Name = "btnCommand";
			this.btnCommand.Size = new System.Drawing.Size(224, 23);
			this.btnCommand.TabIndex = 1;
			this.btnCommand.Text = "���� �ɸ��� �۾� ����";
			this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 126);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(292, 23);
			this.lblDisplay.TabIndex = 2;
			// 
			// FrmProgressBar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 149);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.btnCommand);
			this.Controls.Add(this.progressBar1);
			this.Name = "FrmProgressBar";
			this.Text = "FrmProgressBar";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCommand_Click(object sender, System.EventArgs e)
		{
			for (int i = 0;i < 10000;i++)
			{
				this.progressBar1.Increment(1);
				this.lblDisplay.Text = 
					this.progressBar1.Value.ToString();
			}
			MessageBox.Show("����Ϸ�");
		}
	}
}
