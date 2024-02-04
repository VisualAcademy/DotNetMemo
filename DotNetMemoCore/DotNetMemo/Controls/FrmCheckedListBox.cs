using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmCheckedListBox 
	/// </summary>
	public class FrmCheckedListBox : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label lblDisplay;
		#endregion

		#region Private Members
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors
		public FrmCheckedListBox()
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

		#region Windows Form Designer Generated Code
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Items.AddRange(new object[] {
																												 "HTML",
																												 "CSS",
																												 "JavaScript",
																												 "Windows Server",
																												 "SQL Server",
																												 "Visual Studio"});
			this.checkedListBox1.Location = new System.Drawing.Point(16, 8);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(128, 196);
			this.checkedListBox1.TabIndex = 0;
			this.checkedListBox1.ThreeDCheckBoxes = true;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(192, 8);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(152, 184);
			this.listBox1.TabIndex = 1;
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 214);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(352, 23);
			this.lblDisplay.TabIndex = 2;
			// 
			// FrmCheckedListBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(352, 237);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.checkedListBox1);
			this.Name = "FrmCheckedListBox";
			this.Text = "FrmCheckedListBox";
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void checkedListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.checkedListBox1.SelectedIndex != -1)
			{
				this.lblDisplay.Text = 
					this.checkedListBox1.SelectedItem.ToString();
			}
		}

		private void checkedListBox1_ItemCheck(
			object sender, 
			ItemCheckEventArgs e)
		{
			string item = 
				this.checkedListBox1.SelectedItem.ToString();
			this.lblDisplay.Text = item;//
			if (e.NewValue == CheckState.Checked)
			{
				this.listBox1.Items.Add(item);
			}
			else
			{
				this.listBox1.Items.Remove(item);
			}
		}
		#endregion
	}
}
