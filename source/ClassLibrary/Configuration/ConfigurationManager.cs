using System.Collections.Specialized;

namespace System.Configuration
{
    public interface IConfigurationManagerProxy
    {
        NameValueCollection AppSettings { get; }
        ConnectionStringSettingsCollection ConnectionStrings { get; }
        object GetSection(string sectionName);
        Configuration OpenExeConfiguration(string exePath);
        Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel);
        Configuration OpenMachineConfiguration();
        Configuration OpenMachineConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel);
        Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap);
        void OpenMappedMachineConfiguration(string sectionName);
    }

    public class ConfigurationManagerProxy : IConfigurationManagerProxy
    {
        public NameValueCollection AppSettings
        {
            get { return ConfigurationManager.AppSettings; }
        }
        public ConnectionStringSettingsCollection ConnectionStrings
        {
            get { return ConfigurationManager.ConnectionStrings; }
        }
        public object GetSection(string sectionName)
        {
            return ConfigurationManager.GetSection(sectionName);
        }
        public Configuration OpenExeConfiguration(string exePath)
        {
            return ConfigurationManager.OpenExeConfiguration(exePath);
        }
        public Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel)
        {
            return ConfigurationManager.OpenExeConfiguration(userLevel);
        }
        public Configuration OpenMachineConfiguration()
        {
            return ConfigurationManager.OpenMachineConfiguration();
        }
        public Configuration OpenMachineConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel)
        {
            return ConfigurationManager.OpenMappedExeConfiguration(fileMap, userLevel);
        }
        public Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap)
        {
            return ConfigurationManager.OpenMappedMachineConfiguration(fileMap);
        }
        public void OpenMappedMachineConfiguration(string sectionName)
        {
            ConfigurationManager.RefreshSection(sectionName);
        }
      
    }
}
