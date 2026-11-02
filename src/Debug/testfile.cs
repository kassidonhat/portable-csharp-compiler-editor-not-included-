

using Microsoft.Extensions.Configuration;


using Inventor;
using System.Runtime.InteropServices;
using Debug;


namespace Debug
{
    internal class ConfigDealer
    {



        public IConfiguration ConfigFunc()
        {
                    // private IConfiguration AddinConstants = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();
            return new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();
        }











    }
}