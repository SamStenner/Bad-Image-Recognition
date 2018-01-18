namespace ImageIdentifier {
    partial class Graph {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            this.barCoeff = new System.Windows.Forms.TrackBar();
            this.lblSharpness = new System.Windows.Forms.Label();
            this.btnSigSave = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSigReset = new System.Windows.Forms.Button();
            this.boxBinary = new System.Windows.Forms.CheckBox();
            this.lblSigmoid = new System.Windows.Forms.Label();
            this.chrtSigmoid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barRange = new System.Windows.Forms.TrackBar();
            this.barPosition = new System.Windows.Forms.TrackBar();
            this.barMaximum = new System.Windows.Forms.TrackBar();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.boxCircular = new System.Windows.Forms.CheckBox();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSigmoid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMaximum)).BeginInit();
            this.SuspendLayout();
            // 
            // barCoeff
            // 
            this.barCoeff.Location = new System.Drawing.Point(130, 482);
            this.barCoeff.Maximum = 60;
            this.barCoeff.Minimum = 1;
            this.barCoeff.Name = "barCoeff";
            this.barCoeff.Size = new System.Drawing.Size(673, 45);
            this.barCoeff.TabIndex = 2;
            this.barCoeff.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barCoeff.Value = 2;
            this.barCoeff.Scroll += new System.EventHandler(this.barCoeff_Scroll);
            // 
            // lblSharpness
            // 
            this.lblSharpness.AutoSize = true;
            this.lblSharpness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSharpness.Location = new System.Drawing.Point(8, 481);
            this.lblSharpness.Name = "lblSharpness";
            this.lblSharpness.Size = new System.Drawing.Size(90, 20);
            this.lblSharpness.TabIndex = 3;
            this.lblSharpness.Text = "Sharpness:";
            // 
            // btnSigSave
            // 
            this.btnSigSave.Enabled = false;
            this.btnSigSave.Location = new System.Drawing.Point(12, 528);
            this.btnSigSave.Name = "btnSigSave";
            this.btnSigSave.Size = new System.Drawing.Size(80, 30);
            this.btnSigSave.TabIndex = 4;
            this.btnSigSave.Text = "Save";
            this.btnSigSave.UseVisualStyleBackColor = true;
            this.btnSigSave.Click += new System.EventHandler(this.btnSigSave_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHelp.Location = new System.Drawing.Point(340, 526);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(31, 30);
            this.btnHelp.TabIndex = 33;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSigReset
            // 
            this.btnSigReset.Enabled = false;
            this.btnSigReset.Location = new System.Drawing.Point(98, 528);
            this.btnSigReset.Name = "btnSigReset";
            this.btnSigReset.Size = new System.Drawing.Size(80, 30);
            this.btnSigReset.TabIndex = 35;
            this.btnSigReset.Text = "Reset";
            this.btnSigReset.UseVisualStyleBackColor = true;
            this.btnSigReset.Click += new System.EventHandler(this.btnSigReset_Click);
            // 
            // boxBinary
            // 
            this.boxBinary.AutoSize = true;
            this.boxBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxBinary.Location = new System.Drawing.Point(184, 532);
            this.boxBinary.Name = "boxBinary";
            this.boxBinary.Size = new System.Drawing.Size(68, 22);
            this.boxBinary.TabIndex = 36;
            this.boxBinary.Text = "Binary";
            this.boxBinary.UseVisualStyleBackColor = true;
            this.boxBinary.CheckedChanged += new System.EventHandler(this.boxBinary_CheckedChanged);
            // 
            // lblSigmoid
            // 
            this.lblSigmoid.AutoSize = true;
            this.lblSigmoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigmoid.Location = new System.Drawing.Point(7, 9);
            this.lblSigmoid.Name = "lblSigmoid";
            this.lblSigmoid.Size = new System.Drawing.Size(248, 25);
            this.lblSigmoid.TabIndex = 36;
            this.lblSigmoid.Text = "Modified Sigmoid Graph:";
            // 
            // chrtSigmoid
            // 
            this.chrtSigmoid.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BorderWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chrtSigmoid.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtSigmoid.Legends.Add(legend1);
            this.chrtSigmoid.Location = new System.Drawing.Point(12, 40);
            this.chrtSigmoid.Name = "chrtSigmoid";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtSigmoid.Series.Add(series1);
            this.chrtSigmoid.Size = new System.Drawing.Size(784, 351);
            this.chrtSigmoid.TabIndex = 35;
            this.chrtSigmoid.Text = "chart1";
            // 
            // barRange
            // 
            this.barRange.Location = new System.Drawing.Point(130, 430);
            this.barRange.Maximum = 180;
            this.barRange.Minimum = 1;
            this.barRange.Name = "barRange";
            this.barRange.Size = new System.Drawing.Size(673, 45);
            this.barRange.TabIndex = 38;
            this.barRange.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barRange.Value = 60;
            this.barRange.Scroll += new System.EventHandler(this.valueChanged);
            // 
            // barPosition
            // 
            this.barPosition.Location = new System.Drawing.Point(130, 456);
            this.barPosition.Maximum = 360;
            this.barPosition.Name = "barPosition";
            this.barPosition.Size = new System.Drawing.Size(673, 45);
            this.barPosition.TabIndex = 39;
            this.barPosition.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barPosition.Value = 40;
            this.barPosition.Scroll += new System.EventHandler(this.valueChanged);
            // 
            // barMaximum
            // 
            this.barMaximum.Location = new System.Drawing.Point(130, 405);
            this.barMaximum.Maximum = 360;
            this.barMaximum.Minimum = 1;
            this.barMaximum.Name = "barMaximum";
            this.barMaximum.Size = new System.Drawing.Size(673, 45);
            this.barMaximum.TabIndex = 40;
            this.barMaximum.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barMaximum.Value = 360;
            this.barMaximum.Scroll += new System.EventHandler(this.valueChanged);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRange.Location = new System.Drawing.Point(38, 430);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(65, 20);
            this.lblRange.TabIndex = 41;
            this.lblRange.Text = "Range: ";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(30, 456);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(73, 20);
            this.lblPosition.TabIndex = 42;
            this.lblPosition.Text = "Position: ";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximum.Location = new System.Drawing.Point(23, 405);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(80, 20);
            this.lblMaximum.TabIndex = 43;
            this.lblMaximum.Text = "Maximum:";
            // 
            // boxCircular
            // 
            this.boxCircular.AutoSize = true;
            this.boxCircular.Checked = true;
            this.boxCircular.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boxCircular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCircular.Location = new System.Drawing.Point(257, 532);
            this.boxCircular.Name = "boxCircular";
            this.boxCircular.Size = new System.Drawing.Size(78, 22);
            this.boxCircular.TabIndex = 44;
            this.boxCircular.Text = "Circular";
            this.boxCircular.UseVisualStyleBackColor = true;
            this.boxCircular.CheckedChanged += new System.EventHandler(this.valueChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(588, 536);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(225, 20);
            this.lblNote.TabIndex = 45;
            this.lblNote.Text = "Note: Only sharpness is saved.";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 568);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.barCoeff);
            this.Controls.Add(this.barPosition);
            this.Controls.Add(this.boxCircular);
            this.Controls.Add(this.lblSigmoid);
            this.Controls.Add(this.barRange);
            this.Controls.Add(this.chrtSigmoid);
            this.Controls.Add(this.barMaximum);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.boxBinary);
            this.Controls.Add(this.btnSigReset);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSigSave);
            this.Controls.Add(this.lblSharpness);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Graph";
            this.Text = "Tolerance Editor";
            ((System.ComponentModel.ISupportInitialize)(this.barCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSigmoid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMaximum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar barCoeff;
        private System.Windows.Forms.Label lblSharpness;
        private System.Windows.Forms.Button btnSigSave;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSigReset;
        private System.Windows.Forms.CheckBox boxBinary;
        private System.Windows.Forms.Label lblSigmoid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtSigmoid;
        private System.Windows.Forms.TrackBar barMaximum;
        private System.Windows.Forms.TrackBar barPosition;
        private System.Windows.Forms.TrackBar barRange;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.CheckBox boxCircular;
        private System.Windows.Forms.Label lblNote;
    }
}