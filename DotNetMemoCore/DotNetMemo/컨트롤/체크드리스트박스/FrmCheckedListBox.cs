using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.체크드리스트박스
{
	/// <summary>
	/// FrmCheckedListBox : CheckBox + ListBox의 기능
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
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors
		public FrmCheckedListBox()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}
		#endregion

		#region Protected Methods
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
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
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
			this.checkedListBox1.Location = new System.Drawing.Point(40, 16);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(160, 180);
			this.checkedListBox1.TabIndex = 0;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(224, 16);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(152, 184);
			this.listBox1.TabIndex = 1;
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 215);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(416, 23);
			this.lblDisplay.TabIndex = 2;
			// 
			// FrmCheckedListBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(416, 238);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.checkedListBox1);
			this.Name = "FrmCheckedListBox";
			this.Text = "FrmCheckedListBox : 체크드리스트박스 컨트롤";
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void checkedListBox1_SelectedIndexChanged(
			object sender, System.EventArgs e)
		{
			if(this.checkedListBox1.SelectedIndex != -1)
			{
				this.lblDisplay.Text = 
					this.checkedListBox1.SelectedItem.ToString() + " 선택됨";
			}
		}

		private void checkedListBox1_ItemCheck(
			object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			//선택된 값
			string item = this.checkedListBox1.SelectedItem.ToString();
			//최근 데이터의 체크가 선택되었다면,
			this.lblDisplay.Text = e.NewValue.ToString() + "값";
			if(e.NewValue == CheckState.Checked)	//리스트 박스에 등록
			{
				this.listBox1.Items.Add(item);//등록
			}
			else	//리스트박스에서 제거
			{
				this.listBox1.Items.Remove(item);//항목 지우기 : Remove
			}
		}
		#endregion
	}
}
