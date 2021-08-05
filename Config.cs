using Exiled.API.Interfaces;
using System.ComponentModel;


namespace WarheadPanel_Hint
{
    public class Config : IConfig
    {
        [Description("Indicates whether the plugin is enabled or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("Hint that will appear when you activate the generator")]
        public string Hint { get; set; } = "Generator Activated";
    }
}
