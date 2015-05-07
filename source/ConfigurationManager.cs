using System.Configuration;

namespace SystemHost
{
    public interface IConfigurationManager
    {
        System.Collections.Specialized.NameValueCollection AppSettings { get; }
        System.Configuration.ConnectionStringSettingsCollection ConnectionStrings { get; }
        object GetSection(string sectionName);
        Configuration OpenExeConfiguration(string exePath);
        Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel);
        Configuration OpenMachineConfiguration();
        Configuration OpenMachineConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel);
        Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap);
        void OpenMappedMachineConfiguration(string sectionName);
    }

    public class ConfigurationManager : IConfigurationManager
    {
        public System.Collections.Specialized.NameValueCollection AppSettings
        {
            get { return System.Configuration.ConfigurationManager.AppSettings; }
        }

        public System.Configuration.ConnectionStringSettingsCollection ConnectionStrings
        {
            get { return System.Configuration.ConfigurationManager.ConnectionStrings; }
        }

        public object GetSection(string sectionName)
        {
            return System.Configuration.ConfigurationManager.GetSection(sectionName);
        }

        public Configuration OpenExeConfiguration(string exePath)
        {
            return System.Configuration.ConfigurationManager.OpenExeConfiguration(exePath);
        }

        public Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel)
        {
            return System.Configuration.ConfigurationManager.OpenExeConfiguration(userLevel);
        }

        public Configuration OpenMachineConfiguration()
        {
            return System.Configuration.ConfigurationManager.OpenMachineConfiguration();
        }

        public Configuration OpenMachineConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel)
        {
            return System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(fileMap, userLevel);
        }

        public Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap)
        {
            return System.Configuration.ConfigurationManager.OpenMappedMachineConfiguration(fileMap);
        }

        public void OpenMappedMachineConfiguration(string sectionName)
        {
            System.Configuration.ConfigurationManager.RefreshSection(sectionName);
        }
      
    }
}
