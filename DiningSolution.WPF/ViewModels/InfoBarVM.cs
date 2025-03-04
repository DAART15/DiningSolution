using DiningSolution.WPF.Commands;
using System.ComponentModel;

namespace DiningSolution.WPF.ViewModels
{
    public class InfoBarVM : INotifyPropertyChanged
    {
        public CloseAppCommand CloseAppCommand { get; set; }
        public InfoBarVM()
        {
            CloseAppCommand = new CloseAppCommand(this);
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
    }
}
