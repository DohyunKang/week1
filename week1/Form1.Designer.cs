namespace week1
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
            this.components = new System.ComponentModel.Container();
            this.led1 = new NationalInstruments.UI.WindowsForms.Led();
            this.label1 = new System.Windows.Forms.Label();
            this.switch1 = new NationalInstruments.UI.WindowsForms.Switch();
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.waveformGraph2 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.waveformGraph3 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot3 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis3 = new NationalInstruments.UI.XAxis();
            this.yAxis3 = new NationalInstruments.UI.YAxis();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.switch2 = new NationalInstruments.UI.WindowsForms.Switch();
            this.label4 = new System.Windows.Forms.Label();
            this.led2 = new NationalInstruments.UI.WindowsForms.Led();
            this.label5 = new System.Windows.Forms.Label();
            this.switch3 = new NationalInstruments.UI.WindowsForms.Switch();
            this.label6 = new System.Windows.Forms.Label();
            this.led3 = new NationalInstruments.UI.WindowsForms.Led();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led3)).BeginInit();
            this.SuspendLayout();
            // 
            // led1
            // 
            this.led1.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led1.Location = new System.Drawing.Point(12, 25);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(64, 64);
            this.led1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "LED1";
            // 
            // switch1
            // 
            this.switch1.Location = new System.Drawing.Point(12, 114);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(64, 66);
            this.switch1.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switch1.TabIndex = 2;
            this.switch1.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switch1_StateChanged);
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Location = new System.Drawing.Point(91, 12);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph1.Size = new System.Drawing.Size(788, 168);
            this.waveformGraph1.TabIndex = 3;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // xAxis1
            // 
            this.xAxis1.Mode = NationalInstruments.UI.AxisMode.StripChart;
            // 
            // waveformGraph2
            // 
            this.waveformGraph2.Location = new System.Drawing.Point(91, 195);
            this.waveformGraph2.Name = "waveformGraph2";
            this.waveformGraph2.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot2});
            this.waveformGraph2.Size = new System.Drawing.Size(788, 168);
            this.waveformGraph2.TabIndex = 4;
            this.waveformGraph2.UseColorGenerator = true;
            this.waveformGraph2.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.waveformGraph2.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            // 
            // waveformPlot2
            // 
            this.waveformPlot2.XAxis = this.xAxis2;
            this.waveformPlot2.YAxis = this.yAxis2;
            // 
            // xAxis2
            // 
            this.xAxis2.Mode = NationalInstruments.UI.AxisMode.StripChart;
            // 
            // waveformGraph3
            // 
            this.waveformGraph3.Location = new System.Drawing.Point(91, 378);
            this.waveformGraph3.Name = "waveformGraph3";
            this.waveformGraph3.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot3});
            this.waveformGraph3.Size = new System.Drawing.Size(788, 168);
            this.waveformGraph3.TabIndex = 5;
            this.waveformGraph3.UseColorGenerator = true;
            this.waveformGraph3.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis3});
            this.waveformGraph3.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis3});
            // 
            // waveformPlot3
            // 
            this.waveformPlot3.XAxis = this.xAxis3;
            this.waveformPlot3.YAxis = this.yAxis3;
            // 
            // xAxis3
            // 
            this.xAxis3.Mode = NationalInstruments.UI.AxisMode.StripChart;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(10, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "SWITCH1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("굴림", 11F);
            this.label3.Location = new System.Drawing.Point(10, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "SWITCH2";
            // 
            // switch2
            // 
            this.switch2.Location = new System.Drawing.Point(12, 297);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(64, 66);
            this.switch2.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switch2.TabIndex = 9;
            this.switch2.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switch2_StateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("굴림", 11F);
            this.label4.Location = new System.Drawing.Point(23, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "LED2";
            // 
            // led2
            // 
            this.led2.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led2.Location = new System.Drawing.Point(12, 208);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(64, 64);
            this.led2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("굴림", 11F);
            this.label5.Location = new System.Drawing.Point(10, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "SWITCH3";
            // 
            // switch3
            // 
            this.switch3.Location = new System.Drawing.Point(12, 480);
            this.switch3.Name = "switch3";
            this.switch3.Size = new System.Drawing.Size(64, 66);
            this.switch3.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switch3.TabIndex = 13;
            this.switch3.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switch3_StateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("굴림", 11F);
            this.label6.Location = new System.Drawing.Point(23, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "LED3";
            // 
            // led3
            // 
            this.led3.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led3.Location = new System.Drawing.Point(12, 391);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(64, 64);
            this.led3.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 558);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.switch3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.led3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.switch2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.waveformGraph3);
            this.Controls.Add(this.waveformGraph2);
            this.Controls.Add(this.waveformGraph1);
            this.Controls.Add(this.switch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.led1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.Led led1;
        private System.Windows.Forms.Label label1;
        private NationalInstruments.UI.WindowsForms.Switch switch1;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph2;
        private NationalInstruments.UI.WaveformPlot waveformPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph3;
        private NationalInstruments.UI.WaveformPlot waveformPlot3;
        private NationalInstruments.UI.XAxis xAxis3;
        private NationalInstruments.UI.YAxis yAxis3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private NationalInstruments.UI.WindowsForms.Switch switch2;
        private System.Windows.Forms.Label label4;
        private NationalInstruments.UI.WindowsForms.Led led2;
        private System.Windows.Forms.Label label5;
        private NationalInstruments.UI.WindowsForms.Switch switch3;
        private System.Windows.Forms.Label label6;
        private NationalInstruments.UI.WindowsForms.Led led3;
        private System.Windows.Forms.Timer timer1;
    }
}

