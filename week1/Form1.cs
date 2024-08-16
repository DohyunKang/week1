using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Dsp.Filters;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.SpectralMeasurements;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.DAQmx;
using NationalInstruments.NI4882;
using NationalInstruments.VisaNS;
using NationalInstruments.NetworkVariable;
using NationalInstruments.NetworkVariable.WindowsForms;
using NationalInstruments.Tdms;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace week1
{
    public partial class Form1 : Form
    {
        private List<DT> T = new List<DT>();
 
        public Form1()
        {
            InitializeComponent();
            
            // Y축 자동 스케일링 비활성화 및 범위 설정
            // Y축 자동 스케일링 비활성화
            /*waveformGraph1.YAxes[0].Mode = NationalInstruments.UI.AxisMode.Fixed;
            waveformGraph1.YAxes[0].Range = new NationalInstruments.UI.Range(0, 10);
            waveformGraph2.YAxes[0].Mode = NationalInstruments.UI.AxisMode.Fixed;
            waveformGraph2.YAxes[0].Range = new NationalInstruments.UI.Range(0, 10);
            waveformGraph3.YAxes[0].Mode = NationalInstruments.UI.AxisMode.Fixed;
            waveformGraph3.YAxes[0].Range = new NationalInstruments.UI.Range(0, 10);*/
            //클래스 참조
            this.FormClosing += DisposeTask;
            T.Add(new DT(0, led1, waveformGraph1));
            T.Add(new DT(1, led2, waveformGraph2));
            T.Add(new DT(2, led3, waveformGraph3));


        }

        private void switch1_StateChanged(object sender, ActionEventArgs e)
        {
            T[0].WriteSignal(switch1.Value);
        }

        private void switch2_StateChanged(object sender, ActionEventArgs e)
        {
            T[1].WriteSignal(switch2.Value);

        }

        private void switch3_StateChanged(object sender, ActionEventArgs e)
        {
            T[2].WriteSignal(switch3.Value);
        }

        private void DisposeTask(object sender, EventArgs e)
        {
            disposeHandler();
        }

        private void disposeHandler()
        {
            switch1.Value = false;
            switch2.Value = false;
            switch3.Value = false;
            foreach (var task in T)
            {
                task.Dispose();
            }
        }
    }
}
