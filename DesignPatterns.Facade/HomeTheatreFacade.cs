using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class HomeTheatreFacade
    {
        private readonly IAmplifier _amp;
        private readonly IPopcornMaker _popcornMaker;
        private readonly IPlayer _player;
        private readonly IScreen _screen;
        private readonly ILight _light;
        private readonly ITuner _tuner;
        private readonly IProjector _projector;

        public HomeTheatreFacade(IAmplifier amp, IPopcornMaker popcornMaker, IPlayer player, IScreen screen, ILight light, ITuner tuner, IProjector projector)
        {
            this._amp = amp;
            this._popcornMaker = popcornMaker;
            this._player = player;
            this._screen = screen;
            this._light = light;
            this._tuner = tuner;
            this._projector = projector;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _popcornMaker.On();
            _popcornMaker.Pop();

            _light.Dim(10);

            _screen.Down();

            _projector.On();
            _projector.WideScreenMode();

            _amp.On();
            _amp.SetStreamPlayer(_player);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);

            _player.On();
            _player.PlayMovie(movie);
            
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theatre down...");

            _popcornMaker.Off();
            _light.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _player.Stop();
            _player.Off();
        }
    }
}
