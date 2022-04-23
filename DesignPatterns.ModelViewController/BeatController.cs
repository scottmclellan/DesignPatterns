using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ModelViewController
{
    public class BeatController : IBeatController
    {
        IBeatModel _model;
        public BeatPlayer View { get; private set; }

        public BeatController(IBeatModel model)
        {
            _model = model;
            View = new BeatPlayer(this, model);

            _model.Initialize();
        }

        public void DecreaseBPM()
        {
            _model.SetBPM(_model.GetBPM()-1);
        }

        public void IncreaseBPM()
        {
            _model.SetBPM(_model.GetBPM() +1);
        }

        public void SetBPM(int bpm)
        {
            _model.SetBPM(bpm);
        }

        public void Start()
        {
            _model.On();
        }

        public void Stop()
        {
            _model.Off();
        }
    }
}
