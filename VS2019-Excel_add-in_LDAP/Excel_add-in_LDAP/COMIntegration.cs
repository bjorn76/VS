using ExcelDna.Integration;
using ExcelDna.IntelliSense;
using System.Runtime.InteropServices;

[ComVisible(false)]
internal class ExcelAddin : IExcelAddIn
{
    public void AutoOpen()
    {
        IntelliSenseServer.Install();
    }
    public void AutoClose()
    {
        IntelliSenseServer.Uninstall();
    }
}