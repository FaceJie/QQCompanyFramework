using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitils
{
    public static class ConfigManager
    {
        public static Dictionary<string, string> GetWebConfigurations(Dictionary<string, string> configs)
        {
            Dictionary<string, string> cfgs = new Dictionary<string, string>();
            try
            {
                foreach (var config in configs)
                {
                    if (System.Configuration.ConfigurationManager.AppSettings[config.Key] != "")
                    {
                        string value = System.Configuration.ConfigurationManager.AppSettings[config.Key].ToString();
                        cfgs.Add(config.Key, value);
                    }
                }
                return cfgs;
            }
            catch (Exception ex)
            {
                Unitils.LogManager.SaveMessage("系统", "ConfigurationManager", "加载配置文件", ex.ToString(), 3);
                return cfgs;
            }
        }
    }
}
