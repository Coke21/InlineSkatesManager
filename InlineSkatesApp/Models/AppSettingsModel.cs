using System.Collections.Generic;

namespace InlineSkatesApp.Models
{
    public class AppSettingsModel
    {
        public string Version { get; set; }

        public Data DummyData { get; set; }
        public class Data
        {
            public List<string> UserNames { get; set; }
            public List<string> Products { get; set; }
        }
    }
}
