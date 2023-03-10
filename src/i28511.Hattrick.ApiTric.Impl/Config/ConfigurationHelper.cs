
namespace i28511.Hattrick.ApiTrick.Impl.Config
{
    internal class ConfigurationHelper
    {
        public static XmlApiConfig GetXmlConfig()
        {
            var config = new XmlApiConfig
            {
                ProtectedResourcesPath = "https://chpp.hattrick.org/chppxml.ashx/",
                XmlFiles = new Dictionary<string, XmlFileConfig>
                {
                    {
                        "MatchDetails", new XmlFileConfig
                        {
                            File = "matchdetails",
                            Versions = new List<string> { "3.1" }
                        }
                    },
                    {
                        "Achievements", new XmlFileConfig
                        {
                            File = "achievements",
                            Versions = new List<string> { "1.2" }
                        }
                    }
                }
            };

            return config;
        }

    }
}
