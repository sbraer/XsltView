using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XsltViewer.CustomControls
{
    public class BackgroudWorkerCustom<T> : BackgroundWorker
    {
        public BackgroudWorkerCustom()
        {
        }

        public delegate void DoWorkCustomEventHandler(object sender, DoWorkCustomEventArgs<T> e);
        public new event DoWorkCustomEventHandler DoWork;

        public delegate void RunWorkerCompletedCustomEventHandler(object sender, RunWorkerCompletedCustomEventArgs<T> e);
        public new event RunWorkerCompletedCustomEventHandler RunWorkerCompleted;

        protected void OnDoWork(DoWorkCustomEventArgs<T> e)
        {
            DoWork?.Invoke(this, e);
            base.OnDoWork(e);
        }

        protected void OnRunWorkerCompleted(RunWorkerCompletedCustomEventArgs<T> e)
        {
            RunWorkerCompleted?.Invoke(this, e);
            base.OnRunWorkerCompleted(e);
        }

        public void RunWorkerAsync(T argument)
        {
            this.RunWorkerAsync(argument);
            //base.RunWorkerAsync(argument);
        }
    }

    public class DoWorkCustomEventArgs<T> : DoWorkEventArgs
    {
        public DoWorkCustomEventArgs(T argument) : base(argument)
        { }

        public new T Argument { get; }
        public new T Result { get; set; }
    }

    public class RunWorkerCompletedCustomEventArgs<T> : RunWorkerCompletedEventArgs
    {
        public RunWorkerCompletedCustomEventArgs(object result, Exception error, bool cancelled) : base(result, error, cancelled)
        { }
        public new T Result { get; }
        public new T UserState { get; }
    }
}