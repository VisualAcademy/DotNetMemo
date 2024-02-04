namespace CSharp_Windows.Applications
{
    /// <summary>
    /// FrmUserDefinedForm�� ���� ��� �����Դϴ�.
    /// </summary>
    public class FrmUserDefinedForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label lblPos;
		private System.Windows.Forms.Label lblMode;
		private System.Windows.Forms.Button btnOK;
		private System.ComponentModel.Container components = null;
		#region Properties
		public string LblPos
		{
			get { return lblPos.Text; }
			set { lblPos.Text = value; }
		}
		public string LblMode
		{
			get { return lblMode.Text; }
			set { lblMode.Text = value; }
		}
		#endregion

		public FrmUserDefinedForm()
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.lblPos = new System.Windows.Forms.Label();
			this.lblMode = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "�� �Ӽ�:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "�� ��ġ:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 88);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "�� ����:";
			// 
			// lblType
			// 
			this.lblType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblType.Location = new System.Drawing.Point(152, 16);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(120, 23);
			this.lblType.TabIndex = 3;
			// 
			// lblPos
			// 
			this.lblPos.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblPos.Location = new System.Drawing.Point(152, 48);
			this.lblPos.Name = "lblPos";
			this.lblPos.Size = new System.Drawing.Size(120, 23);
			this.lblPos.TabIndex = 4;
			this.lblPos.Click += new System.EventHandler(this.label5_Click);
			// 
			// lblMode
			// 
			this.lblMode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblMode.Location = new System.Drawing.Point(152, 80);
			this.lblMode.Name = "lblMode";
			this.lblMode.Size = new System.Drawing.Size(120, 23);
			this.lblMode.TabIndex = 5;
			this.lblMode.Click += new System.EventHandler(this.label6_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(112, 128);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "�ݱ�";
			// 
			// FrmUserDefinedForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 173);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblMode);
			this.Controls.Add(this.lblPos);
			this.Controls.Add(this.lblType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmUserDefinedForm";
			this.Text = "FrmUserDefinedForm : ������ ��";
			this.ResumeLayout(false);

		}
		#endregion

		private void label5_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label6_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
