//using System;
//using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;

//namespace DotNetMemo.Practices.Chapter15
//{
//    public partial class FrmChartControl : Form
//    {
//        public FrmChartControl()
//        {
//            InitializeComponent();
//        }

//        private void FrmChartControl_Load(object sender, EventArgs e)
//        {
//            DisplayChar();
//        }

//        private void DisplayChar()
//        {
//            ctlChart.Series[0].LegendText = "성적";

//            ctlChart.Series[0].ChartType = SeriesChartType.Column;

//            ctlChart.Series[0].Points.AddXY("국어", 100);
//            ctlChart.Series[0].Points.AddXY("영어", 100);
//            ctlChart.Series[0].Points.AddXY("수학", 100); 
//        }
//    }
//}
