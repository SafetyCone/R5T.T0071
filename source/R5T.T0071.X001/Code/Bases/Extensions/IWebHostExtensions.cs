using System;

using R5T.L0016.X001;
using R5T.T0071;
using R5T.T0076;

using MicrosoftWebHostBuilder = Microsoft.AspNetCore.Hosting.WebHostBuilder;


namespace System
{
    public static class IWebHostExtensions
    {
        public static IWebHostBuilder NewBuilder(this IWebHost _)
        {
            var microsoftWebHostBuilder = new MicrosoftWebHostBuilder()
                .ConfigureBasics()
                ;

            var output = new WebHostBuilder(microsoftWebHostBuilder);
            return output;
        }
    }
}
