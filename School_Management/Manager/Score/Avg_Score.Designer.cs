﻿
namespace School_Management.Manager.Score
{
    partial class Avg_Score
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.Chart_Avg = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart_control = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Avg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.Chart_Avg);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Chart_control);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(818, 436);
            this.splitContainerControl1.SplitterPosition = 419;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // Chart_Avg
            // 
            this.Chart_Avg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Chart_Avg.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_Avg.Legends.Add(legend1);
            this.Chart_Avg.Location = new System.Drawing.Point(3, 12);
            this.Chart_Avg.Name = "Chart_Avg";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_Avg.Series.Add(series1);
            this.Chart_Avg.Size = new System.Drawing.Size(412, 421);
            this.Chart_Avg.TabIndex = 0;
            this.Chart_Avg.Click += new System.EventHandler(this.Chart_Avg_Click);
            // 
            // Chart_control
            // 
            this.Chart_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart_control.Legend.Name = "Default Legend";
            this.Chart_control.Location = new System.Drawing.Point(0, 0);
            this.Chart_control.Name = "Chart_control";
            series2.Name = "Series 1";
            series2.View = pieSeriesView1;
            this.Chart_control.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.Chart_control.SeriesTemplate.SeriesColorizer = null;
            this.Chart_control.Size = new System.Drawing.Size(394, 436);
            this.Chart_control.TabIndex = 0;
            // 
            // Avg_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 436);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Avg_Score";
            this.Text = "Avg Score";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Avg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_control)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Avg;
        private DevExpress.XtraCharts.ChartControl Chart_control;
    }
}