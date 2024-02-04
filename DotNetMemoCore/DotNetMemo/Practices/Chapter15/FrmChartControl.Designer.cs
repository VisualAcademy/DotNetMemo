//namespace DotNetMemo.Practices.Chapter15
//{
//    partial class FrmChartControl
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
//            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
//            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
//            this.ctlChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
//            ((System.ComponentModel.ISupportInitialize)(this.ctlChart)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // ctlChart
//            // 
//            chartArea1.Name = "ChartArea1";
//            this.ctlChart.ChartAreas.Add(chartArea1);
//            legend1.Name = "Legend1";
//            this.ctlChart.Legends.Add(legend1);
//            this.ctlChart.Location = new System.Drawing.Point(210, 71);
//            this.ctlChart.Name = "ctlChart";
//            series1.ChartArea = "ChartArea1";
//            series1.Legend = "Legend1";
//            series1.Name = "Series1";
//            this.ctlChart.Series.Add(series1);
//            this.ctlChart.Size = new System.Drawing.Size(447, 287);
//            this.ctlChart.TabIndex = 0;
//            // 
//            // FrmChartControl
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Controls.Add(this.ctlChart);
//            this.Name = "FrmChartControl";
//            this.Text = "FrmChartControl";
//            this.Load += new System.EventHandler(this.FrmChartControl_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.ctlChart)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.DataVisualization.Charting.Chart ctlChart;
//    }
//}