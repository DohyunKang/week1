using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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

        // 이전 Tick 시간을 저장하기 위한 변수
        private DateTime lastTickTime;

        public DT(int index, Led led, WaveformGraph wfg)
        {
            this.index = index;
            this.led = led;
            this.wfg = wfg;

            SetUpDigitalRead(index);
            SetUpDigitalWrite(index);

            // 초기화 시점에 lastTickTime을 현재 시간으로 설정
            lastTickTime = DateTime.Now;

            timer = new Timer();
            timer.Interval = 100; // 타이머 간격 설정 (밀리초)
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
                    string.Format("DI{0}", (index + 1)),
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
                    string.Format("DO{0}", (index + 1)),
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
                // 현재 시간을 가져와 이전 Tick 시간과 비교
                DateTime currentTime = DateTime.Now;
                double elapsedSeconds = (currentTime - lastTickTime).TotalSeconds;

                data = reader.ReadSingleSamplePortUInt32();
                AnalyzeSignal(index, data, elapsedSeconds);

                // 현재 시간을 마지막 Tick 시간으로 업데이트
                lastTickTime = currentTime;
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

        // wfg에 아날로그 입력 값 플로팅
        public void AnalyzeSignal(int index, UInt32 data, double elapsedSeconds)
        {
            // 동적으로 아날로그 입력 채널 이름 생성
            string channelName = string.Format("Dev1/ai{0}", index);

            // 생성된 채널 이름을 사용하여 아날로그 입력 값 읽기
            double voltageValue = ReadAnalogInput(channelName);

            // 읽어온 전압 값을 그래프에 추가하고, LED 상태 변경
            if (data != 0)
            {
                wfg.PlotYAppend(voltageValue, elapsedSeconds); // 실제 경과 시간을 그래프에 반영
                led.Value = true;
            }
            else
            {
                wfg.PlotYAppend(voltageValue, elapsedSeconds); // 실제 경과 시간을 그래프에 반영
                led.Value = false;
            }
        }
    }
}
