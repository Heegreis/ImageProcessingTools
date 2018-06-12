using ImageProcessingTools.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTools.Presenter
{
    class LogPresenter
    {
        private readonly ILogView _logView;

        private Stopwatch stopwatch = new Stopwatch();

        public LogPresenter(ILogView logView)
        {
            //將View拉進來以便控制
            _logView = logView;
        }

        public void TimeCountStart()
        {
            stopwatch.Reset();
            stopwatch.Start();
        }

        public void TimeStopToLog()
        {
            stopwatch.Stop();
            string totalTime = stopwatch.Elapsed.TotalMilliseconds.ToString();
            _logView.Log = _logView.Log + "> 處理時間: " + totalTime + "(ms)\n";
        }
    }
}
