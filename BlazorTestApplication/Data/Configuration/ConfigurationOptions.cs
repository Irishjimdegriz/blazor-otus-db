using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTestApplication.Data.Configuration
{
    public static class ConfigurationContstants
    {
        public const string CONNECTION_STRING_SECTION = "ConnectionString";
    }

    public class ConnectionStringConfiguration
    {
        public string DefaultConnection { get; set; }
    }
}
