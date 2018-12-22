using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinComponentBrowser.ViewModels;

namespace XamarinComponentBrowser.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        HomeViewModel VM { get; }
        public HomePage()
        {
            InitializeComponent();

            VM = (HomeViewModel)BindingContext;

            VM.GetComponentsCommand.Execute(null);

        }
    }
}