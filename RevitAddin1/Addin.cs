using Autodesk.Revit.UI;
using System.Linq;

namespace RevitAddin1
{
    public class Addin : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            //注册面板
            string tabName = "DllHellTest";
            string buttonName = "Addin1Test";
            string panelName = "DllHellTest";
            string registTitle = "Addin1Test";
            var buttonData = new PushButtonData(registTitle, buttonName, typeof(Addin).Assembly.Location, typeof(Command).FullName);

            try
            {
                //有可能和别的插件重复，会导致报错
                application.CreateRibbonTab(tabName);
            }
            catch { }

            RibbonPanel panel;
            try
            {
                panel = application.CreateRibbonPanel(tabName, panelName);
            }
            catch
            {
                panel = application.GetRibbonPanels(tabName).FirstOrDefault(p => p.Name == panelName);
            }
            panel.AddItem(buttonData);

            return Result.Succeeded;
        }
    }
}
