using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core;
using Nop.Services.Plugins;

namespace Nop.Plugin.Tutorial.DistOfCustByCountry
{
    public class DistOfCustByCountryPlugin : BasePlugin
    {
        private readonly IWebHelper _webHelper;
        public DistOfCustByCountryPlugin(IWebHelper webHelper)
        {
            _webHelper = webHelper;
        }

        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/DistOfCustBuCountryPlugin/Configure";
        }

        public override void Install()
        {
            //Code you want to run while installing the plugin goes here.
            base.Install();
        }

        public override void Uninstall()
        {
            //Code you want to run while Uninstalling the plugin goes here.
            base.Uninstall();
        }
    }
}
