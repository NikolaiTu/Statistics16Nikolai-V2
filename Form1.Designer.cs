namespace Statistics16Nikolai_V2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.AverageButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.ModeButton = new System.Windows.Forms.Button();
            this.ChartButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.White;
            this.InputBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.InputBox.Location = new System.Drawing.Point(-2, 82);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(144, 29);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AverageButton
            // 
            this.AverageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.AverageButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AverageButton.FlatAppearance.BorderSize = 0;
            this.AverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AverageButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AverageButton.Location = new System.Drawing.Point(-2, 127);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Size = new System.Drawing.Size(144, 36);
            this.AverageButton.TabIndex = 1;
            this.AverageButton.Text = "Average";
            this.AverageButton.UseVisualStyleBackColor = false;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AnswerLabel.Location = new System.Drawing.Point(8, 51);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(122, 18);
            this.AnswerLabel.TabIndex = 2;
            this.AnswerLabel.Text = "Awaiting Input";
            this.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModeButton
            // 
            this.ModeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.ModeButton.FlatAppearance.BorderSize = 0;
            this.ModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.ModeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ModeButton.Location = new System.Drawing.Point(-2, 169);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(144, 36);
            this.ModeButton.TabIndex = 3;
            this.ModeButton.Text = "Mode";
            this.ModeButton.UseVisualStyleBackColor = false;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // ChartButton
            // 
            this.ChartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.ChartButton.FlatAppearance.BorderSize = 0;
            this.ChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChartButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.ChartButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChartButton.Location = new System.Drawing.Point(-2, 211);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(144, 36);
            this.ChartButton.TabIndex = 4;
            this.ChartButton.Text = "Chart";
            this.ChartButton.UseVisualStyleBackColor = false;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 5;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisX.IsInterlaced = true;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartArea3.AxisX.LineWidth = 6;
            chartArea3.AxisX2.IsLabelAutoFit = false;
            chartArea3.AxisX2.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F);
            chartArea3.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F);
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            chartArea3.AxisY2.IsLabelAutoFit = false;
            chartArea3.AxisY2.LabelStyle.Font = new System.Drawing.Font("Arial", 9.75F);
            chartArea3.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(136, -4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.BackImageTransparentColor = System.Drawing.Color.White;
            series3.BackSecondaryColor = System.Drawing.Color.White;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(192)))), ((int)(((byte)(127)))));
            series3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelBorderColor = System.Drawing.Color.Transparent;
            series3.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(85)))), ((int)(((byte)(39)))));
            series3.Legend = "Legend1";
            series3.LegendText = " ";
            series3.MarkerBorderColor = System.Drawing.Color.White;
            series3.MarkerColor = System.Drawing.Color.Transparent;
            series3.Name = "ListThing";
            series3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(154)))), ((int)(((byte)(103)))));
            series3.ShadowOffset = 1;
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YValuesPerPoint = 3;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(301, 313);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(433, 295);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ChartButton);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.AverageButton);
            this.Controls.Add(this.InputBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Thing";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.Button ChartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

