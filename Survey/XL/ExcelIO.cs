using ExcelDataReader;
using System.Data;
using System.IO;

namespace Basics.XL

{
    class ExcelIO
    {
        public ExcelIO()
        {

        }

        public static void ExcelOpen()
        {
            //https://recordnotfound.com/ExcelDataReader-ExcelDataReader-14105

            FileStream fs = File.Open(@"C:\temp\my.xlsx", FileMode.Open, FileAccess.Read);
            //reader = ExcelReaderFactory.CreateBinaryReader(fs);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);

            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            

        }
    }
}
