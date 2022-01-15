using ExcelDna.Integration.CustomUI;
using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibraryExcel02

{
    public class RibbonActions
    {



        public void OnExample1ButtonPressed(IRibbonControl control)
        {
            MessageBoxResult mbr = MessageBox.Show("Enter Yes or No into selected Cell?",
                                                    "Choose",
                                                    MessageBoxButton.YesNo);
            Microsoft.Office.Interop.Excel.Application excel_application =
                (Microsoft.Office.Interop.Excel.Application)ExcelDnaUtil.Application;

            string result = (mbr == MessageBoxResult.Yes) ? "Yes" : "No";

            object selection = excel_application.Selection;
            if (selection is Microsoft.Office.Interop.Excel.Range)
            {
                Microsoft.Office.Interop.Excel.Range selected_range =
                    (Microsoft.Office.Interop.Excel.Range)selection;
                int first_col = selected_range.Column;
                int first_row = selected_range.Row;

                selected_range.Worksheet.Cells[first_row, first_col].Value = result;
            }
        }



    }
}
