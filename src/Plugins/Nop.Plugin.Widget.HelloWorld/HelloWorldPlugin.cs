using Nop.Services.Plugins;

namespace Nop.Plugin.Widget.HelloWorld
{
    public class HelloWorldPlugin : BasePlugin
    {
        public override void Install()
        {
            //Logic during installation goes here...

            base.Install();
        }

        public override void Uninstall()
        {
            //Logic during uninstallation goes here...

            base.Uninstall();
        }
    }

}
