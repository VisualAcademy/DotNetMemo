using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyWinForms.Controls
{
    public partial class FrmCheckedListBoxFavorite : Form
    {
        public FrmCheckedListBoxFavorite()
        {
            InitializeComponent();
        }

        private void FrmCheckedListBox_Load(object sender, EventArgs e)
        {
            string[] fav = {"C#", "ASP.NET", "WPF", "Silverlight" };

            for (int i = 0; i < fav.Length; i++)
            {
                // 짝수만 체크된 상태
                if (i % 2 != 0)
                {
                    lstFavorites.Items.Add(fav[i], true);  
                }
                else
                {
                    lstFavorites.Items.Add(fav[i]); 
                } 
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            // Input
            List<Favorite> lst = new List<Favorite>();
            string msg = "";
            // Process
            for (int i = 0; i < lstFavorites.CheckedItems.Count; i++) {
                lst.Add(new Favorite() { 
                    Name = lstFavorites.CheckedItems[i].ToString() });
                msg += lstFavorites.CheckedItems[i].ToString();
            }
            // Output
            ctlSeletedList.DataSource = lst; // 배열,컬렉션,리스트
            MessageBox.Show(msg);
        }
    }
    public class Favorite {
        public string Name { get; set; }
    }
}
