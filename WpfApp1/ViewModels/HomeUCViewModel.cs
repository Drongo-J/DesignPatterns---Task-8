using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Commands;
using WpfApp1.View;

namespace WpfApp1.ViewModels
{
    public class HomeUCViewModel : BaseViewModel
    {
        public RelayCommand YoutuberCommand { get; set; }
        public RelayCommand SubscriberCommand { get; set; }

        public HomeUCViewModel()
        {
            YoutuberCommand = new RelayCommand((y) => 
            {
                var youtuberWindow = new YoutuberWindow();
                var youtuberWindowViewModel =new YoutuberWindowViewModel();
                youtuberWindow.DataContext = youtuberWindowViewModel;
                youtuberWindow.Show();
            
            });

            SubscriberCommand = new RelayCommand((s) =>
            {
                var subscriberWindow = new SubscriberWindow();
                var subscriberWindowViewModel =new SubscriberWindowViewModel();
                subscriberWindow.DataContext = subscriberWindowViewModel;
                subscriberWindow.Show();

            });
        }
    }
}
