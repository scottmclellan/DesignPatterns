using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Controls;

namespace DesignPatterns.ModelViewController
{
    public class BeatBar : ProgressBar, IDisposable
    {
        Thread thread;

        volatile bool runAnimation = true;

        public BeatBar()
        {
            thread = new Thread(Run);
            Maximum = 100;
            thread.Start();
            
        }

        public void Dispose()
        {
            runAnimation = false;
        }

        private void Run()
        {
            while (runAnimation)
            {
                if (Thread.CurrentThread.IsAlive)
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        double value = Value;
                        value *= .75;
                        Value = value;
                        InvalidateVisual();
                    });

                    try
                    {
                        Thread.Sleep(50);
                    }
                    catch
                    { }
                }
            }

        }   

    }
}
