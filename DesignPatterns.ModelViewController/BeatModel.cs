using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading;

namespace DesignPatterns.ModelViewController
{
    public class BeatModel : IBeatModel
    {
        List<IBeatObserver> _beatObservers = new List<IBeatObserver>();
        List<IBPMObserver> _bpmObservers = new List<IBPMObserver>();

        int _bpm = 90;
        Thread _thread;

        volatile bool _stop = false;

        SoundPlayer _soundPlayer;

        public void Initialize()
        {
            _soundPlayer = new SoundPlayer(Properties.Resources.clap_hall_06);
        }

        public void Off()
        {
            StopBeat();
            _stop = true;
        }     

        public void On()
        {          
            _stop = false;
            NotifyBPMObserver();
            _thread = new Thread(Run);
            _thread.Start();
        }   

        public void Run()
        {
            while(!_stop)
            {
                PlayBeat();
                NotifyBeatObserver();
                Thread.Sleep(60000 / _bpm);                    
            }
        }

        private void NotifyBeatObserver()
        {
            _beatObservers.ForEach(x => x.UpdateBeat());
        }

        private void NotifyBPMObserver()
        {
            _bpmObservers.ForEach(x => x.UpdateBPM());
        }

        private void PlayBeat()
        {
            _soundPlayer.Play();
        }

        private void StopBeat()
        {
            _soundPlayer.Stop();
        }

        public int GetBPM() => _bpm;

        public void SetBPM(int bmp)
        {
            _bpm = bmp;
            NotifyBPMObserver();
        }

        public void RegisterObserver(IBeatObserver o)
        {
            _beatObservers.Add(o);
        }

        public void RegisterObserver(IBPMObserver o)
        {
            _bpmObservers.Add(o);
        }

        public void RemoveObserver(IBeatObserver o)
        {
            _beatObservers.Remove(o);
        }

        public void RemoveObserver(IBPMObserver o)
        {
            _bpmObservers.Remove(o);
        }
       
    }
}
