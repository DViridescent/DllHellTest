using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAddin1
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var version = typeof(MaterialDesignThemes.Wpf.ButtonAssist).Assembly.GetName().Version.ToString();
            TaskDialog.Show("Addin1", version);
            return Result.Succeeded;
        }
    }
}
