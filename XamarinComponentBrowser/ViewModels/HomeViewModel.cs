using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinComponentBrowser.Interfaces;
using XamarinComponentBrowser.Models;

namespace XamarinComponentBrowser.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableRangeCollection<XamarinComponent> Components { get; set; }
        IComponentService componentService;
        public HomeViewModel()
        {
            componentService = DependencyService.Get<IComponentService>();
            GetComponentsCommand = new Command(GetComponents);
            Components = new ObservableRangeCollection<XamarinComponent>();
        }

        public ICommand GetComponentsCommand { get; }

        void GetComponents()
        {
            Components.AddRange(componentService.GetComponents(0));
        }
    }
}
