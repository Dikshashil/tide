using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideWebsiteNUnitProject.DriverFile;

namespace TideWebsiteNUnitProject
{
    public class ExcelFile
    {
        public static string excelRead(int rowNum, int cellNum)
        {
            string path = @"C:\Users\mindc1may168\Desktop\Comprehensive\TideWebsiteNUnitProject\TideWebsiteNUnitProject\ExcelSheet.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet1 = workbook.GetSheetAt(0).GetRow(rowNum).GetCell(cellNum).StringCellValue.Trim();
            return sheet1;
        }
    }
}
