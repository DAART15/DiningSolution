using DiningSolution.WPF.ViewModels;
using System.Windows.Controls;
namespace DiningSolution.WPF.Views
{
    public partial class InfoBarView : UserControl
    {
        public InfoBarView()
        {
            InitializeComponent();
            DataContext = new InfoBarVM();
        }
    }
}
