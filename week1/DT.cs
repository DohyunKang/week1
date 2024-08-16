using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
//using System.Threading.Task;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NationalInstruments.DAQmx;
using NationalInstruments.UI.WindowsForms;

namespace week1
{
    public class DT : IDisposable
    { 
        private Task diTask = new Task();
        private Task doTask = new Task();
        private UInt32 data;
        private int index;

        Timer timer;

        DigitalSingleChannelReader reader;
        DigitalSingleChannelWriter writer;

        Led led;
        WaveformGraph wfg;

        public DT(int index, Led led, WaveformGraph wfg)
        {
            this.index = index;
            this.led = led;            
            this.wfg = wfg;

            SetUpDigitalRead(index);
            SetUpDigitalWrite(index);

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += ReadSignal;
            timer.Start();
               
        }

        public void Dispose()
        {
            if (timer != null)
            {
                timer.Dispose();

            }
            if (diTask != null)
            {
               diTask.Dispose();

            }
            if (doTask != null)
            {
                doTask.Dispose();
            }
        }

        // 아날로그 입력 값을 읽는 메서드
        public double ReadAnalogInput(string channelName)
        {
            // 아날로그 입력용 Task 생성
            using (Task aiTask = new Task())
            {
                // 아날로그 입력 채널 생성
                aiTask.AIChannels.CreateVoltageChannel(channelName, "AI Channel",
                    AITerminalConfiguration.Rse, 0, 10, AIVoltageUnits.Volts);

                // 아날로그 신호를 읽기 위해 AnalogSingleChannelReader 생성
                AnalogSingleChannelReader reader = new AnalogSingleChannelReader(aiTask.Stream);

                // 단일 샘플을 읽어 전압 값 반환
                return reader.ReadSingleSample();
            }
        }

        private void SetUpDigitalRead(int index)
        {
           diTask = new Task();
            try
            {
               diTask.DIChannels.CreateChannel(
                       string.Format("Dev1/port1/line{0}", index),
                       string.Format("DI{0}", (index+1)),
                       ChannelLineGrouping.OneChannelForAllLines
                       );
            }
            catch (Exception)
            {

                Application.Exit();
            }


            reader = new DigitalSingleChannelReader(diTask.Stream);
        }

        private void SetUpDigitalWrite(int index)
        {
            doTask = new Task();

            try
            {
                doTask.DOChannels.CreateChannel(
                        string.Format("Dev1/port0/line{0}", index),
                        string.Format("DO{0}", (index+1)),
                        ChannelLineGrouping.OneChannelForAllLines
                        );
            }
            catch (Exception)
            {
                Application.Exit();
            }

            writer = new DigitalSingleChannelWriter(doTask.Stream);
        }


        private void ReadSignal(object sender, EventArgs e)
        {
            try
            {
                data = reader.ReadSingleSamplePortUInt32();
                //AnalyzeSignal(data);
                AnalyzeSignal(index, data);
            }
            catch (Exception)
            {
                Application.Exit();
            }

        }

        public void WriteSignal(bool switchValue)
        {
            writer.WriteSingleSampleSingleLine(true, switchValue);
        }

        /*public void AnalyzeSignal(UInt32 data)
        {
            if (data != 0)
            {
                wfg.PlotYAppend(Convert.ToDouble(true), 0.1);              
                led.Value = true;
            }
            else
            {
                wfg.PlotYAppend(Convert.ToDouble(false), 0.1);
                led.Value = false;
            }
        }*/

        // wfg에 아날로그 입력 값 플로팅
        public void AnalyzeSignal(int index, UInt32 data)
        {
            // 동적으로 아날로그 입력 채널 이름 생성
            string channelName = string.Format("Dev1/ai{0}", index);
            string.Format("AI{0}", (index + 1));

            // 생성된 채널 이름을 사용하여 아날로그 입력 값 읽기
            double voltageValue = ReadAnalogInput(channelName);

            if (data != 0)
            {
                // 읽어온 전압 값을 그래프에 추가
                wfg.PlotYAppend(voltageValue, 0.1);
                led.Value = true;
            }
            else
            {
                // 읽어온 전압 값을 그래프에 추가
                //wfg.PlotYAppend(Convert.ToDouble(false), 0.1);
                wfg.PlotYAppend(voltageValue, 0.1);
                led.Value = false;
            }
        }



        /*public void AnalyzeSignal(UInt32 data)
        {
            if (data != 0)
            {
                for (double i = 0; i <= 10; i += 0.1)
                {
                    wfg.PlotYAppend(i, 0.1);
                }
                led.Value = true;
            }
            else
            {
                for (double i = 10; i >= 0; i -= 0.1)
                {
                    wfg.PlotYAppend(i, 0.1);
                }
                led.Value = false;
            }
        }*/
    }
}
