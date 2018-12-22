using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinComponentBrowser.Interfaces;
using XamarinComponentBrowser.Models;

namespace XamarinComponentBrowser.Services.Design
{
    public class DesignComponentService : IComponentService
    {
        public IEnumerable<XamarinComponent> GetComponents(int skip)
        {
            var essentials = new XamarinComponent
            {
                Authors = new Author[]
                {
                    new Author
                    {
                        Email = "components@xamarin.com",
                        GitHub = "Xamarin",
                        Name = "Microsoft | Xamarin",
                        Twitter = "XamarinHQ"
                    }
                },
                DailyNuGetDownloads = 1000,
                Description = "Xamarin.Essentials gives developers essential cross-platform APIs for their mobile applications. iOS, Android, and UWP offer unique operating system and platform APIs that developers have access to, all in C# leveraging Xamarin. It is great that developers have 100% API access in C# with Xamarin, but these APIs are different per platform. This means developers have to learn three different APIs to access platform-specific features. With Xamarin.Essentials, developers have a single cross-platform API that works with any iOS, Android, or UWP application that can be accessed from shared code no matter how the user interface is created.",
                ForkCount = 153,
                IconUrl = "https://raw.githubusercontent.com/xamarin/Essentials/master/Assets/xamarin.essentials_128x128.png",
                IsOfficial = true,
                IsPreRelease = false,
                License = "MIT",
                LicenseUrl = "https://go.microsoft.com/fwlink/?linkid=868961",
                Name = "Xamarin.Essentials",
                NuGetId = "Xamarin.Essentials",
                Platforms = Platform.Android | Platform.iOS | Platform.UWP,
                ProjectUrl = "https://go.microsoft.com/fwlink/?linkid=868960",
                SourceRepositoryUrl = "https://github.com/xamarin/Essentials",
                StarCount = 724,
                Summary = "Xamarin.Essentials: a kit of essential API's for your apps",
                TotalNuGetDownloads = 232720
            };

            for (int i = 0; i < 10; i++)
                yield return essentials;
        }
    }
}
