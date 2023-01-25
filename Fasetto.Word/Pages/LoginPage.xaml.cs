using System.Windows;

namespace Fasetto.Word
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            await this.AnimateOut();
        }
    }
}
