using DiningSolution.WPF.Commands;
using System.ComponentModel;
using System.Windows.Threading;

namespace DiningSolution.WPF.ViewModels
{
    public class InfoBarVM : INotifyPropertyChanged
    {
        public CloseAppCommand CloseAppCommand { get; set; }
        private string _date;

        public string Date
        {
            get { return _date; }
            set 
            { 
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        private string _time;
        public string Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged(nameof(Time));
            }
        }

        public InfoBarVM()
        {
            CloseAppCommand = new CloseAppCommand(this);
            StartClock();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void CloseApp()
        {
            App.Current.Shutdown();
        }
        private void StartClock()
        {
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += (sender, e) =>
            {
                Time = DateTime.Now.ToString("HH:mm:ss");
                Date = DateTime.Now.ToString("yyyy-MM-dd");
            };
            timer.Start();
        }
    }
}
