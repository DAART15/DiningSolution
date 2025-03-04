using DiningSolution.WPF.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace DiningSolution.WPF.Commands
{
    public class CloseAppCommand : ICommand
    {
        public InfoBarVM VM { get; set; }
        public event EventHandler? CanExecuteChanged;

        public CloseAppCommand(InfoBarVM infoBarVM)
        {
            VM = infoBarVM;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            var result = MessageBox.Show("Do You realy whant to CLOSE the Program?", "CLOSE PROGRAM?", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.OK)
            {
                VM.CloseApp();
            }
        }
    }
}
