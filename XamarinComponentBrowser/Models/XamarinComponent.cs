using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinComponentBrowser.Models
{
    public class XamarinComponent
    {
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the NuGet Id
        /// </summary>
        public string NuGetId { get; set; }

        public string NuGetUrl => $"https://www.nuget.org/packages/{NuGetId}/";


        public string ProjectUrl { get; set; }
        public string SourceRepositoryUrl { get; set; }

        public string IconUrl { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }

        public string License { get; set; }
        public string LicenseUrl { get; set; }

        /// <summary>
        /// Gets or sets the platforms that the component is for
        /// </summary>
        public Platform Platforms { get; set; }

        /// <summary>
        /// Gets or sets if the package is only in pre-release
        /// AKA it has never been in stable.
        /// </summary>
        public bool IsPreRelease { get; set; }
        
        /// <summary>
        /// Gets or sets if this if an official package from Microsoft
        /// </summary>
        public bool IsOfficial { get; set; }

        /// <summary>
        /// Gets or sets the main 
        /// </summary>
        public IEnumerable<Author> Authors { get; set; }

        /// <summary>
        /// Gets or sets the GitHub star count
        /// </summary>
        public ulong StarCount { get; set; }

        /// <summary>
        /// Gets or sets the GitHub fork number
        /// </summary>
        public ulong ForkCount { get; set; }

        /// <summary>
        /// Gets or sets the number of total downloads
        /// </summary>
        public ulong TotalNuGetDownloads { get; set; }

        /// <summary>
        /// Gets or sets the Daily NuGet Downloads
        /// </summary>
        public ulong DailyNuGetDownloads { get; set; }

        

    }
}
