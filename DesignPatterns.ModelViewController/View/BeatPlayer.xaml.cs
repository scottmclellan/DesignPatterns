using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesignPatterns.ModelViewController
{
    /// <summary>
    /// Interaction logic for BeatPlayer.xaml
    /// </summary>
    public partial class BeatPlayer : Window, IBeatObserver, IBPMObserver
    {
        IBeatController _controller;
        IBeatModel _model;

        public BeatPlayer(IBeatController controller, IBeatModel model)
        {
            InitializeComponent();

            _model = model;
            _controller = controller;

            _model.RegisterObserver((IBeatObserver)this);
            _model.RegisterObserver((IBPMObserver)this);
        }

        public void UpdateBeat()
        {
            this.Dispatcher.Invoke(() => beatBar.Value = 100);
        }

        public void UpdateBPM()
        {
            int bpm = _model.GetBPM();
            if (bpm == 0)
                lblBPMOutput.Content = "Offline";
            else
                lblBPMOutput.Content = bpm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(e.Source == btnSet)
            {
                int bpm = 0;

                if(int.TryParse(txtBPM.Text, out bpm))
                    _controller.SetBPM(bpm);
            }
            else if(e.Source == btnUp)
            {
                _controller.IncreaseBPM();
            }
            else if(e.Source == btnDown)
            {
                _controller.DecreaseBPM();
            }
            else if (e.Source == btnStart)
            {
                _controller.Start();
            }
            else if (e.Source == btnStop)
            {
                _controller.Stop();
            }
            else
            {
                this.Close();
            }
        }
    }
}
