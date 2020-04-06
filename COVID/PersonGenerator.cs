using CsvHelper;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace COVID
{
    public class PersonGenerator
    {
        public static Person[] Generate()
        {
            PopulationRegion total = new PopulationRegion();
            using (TextReader textReader = new StreamReader("./postcode-population.csv"))
            {
                using (CsvReader csvReader = new CsvReader(textReader,CultureInfo.InvariantCulture))
                {
                    foreach (PopulationRegion region in csvReader.GetRecords<PopulationRegion>())
                    {
                        total.HouseholdSpaces += region.HouseholdSpaces;
                        total.OccupiedHouseholdSpaces += region.OccupiedHouseholdSpaces;
                        total.UnoccupiedHouseholdSpaces += region.UnoccupiedHouseholdSpaces;
                    }
                }
            }
            Console.WriteLine(total.HouseholdSpaces);
            return null;
        }

        private static void GetNumCases()
        {
            //https://fingertips.phe.org.uk/documents/Historic%20COVID-19%20Dashboard%20Data.xlsx
            //https://fingertips.phe.org.uk/documents/Historic%20COVID-19%20Dashboard%20Data.xlsx
            var newFile = @"newbook.core.xlsx";

            using (var fs = new FileStream(newFile, FileMode.Open, FileAccess.Read))
            {

                IWorkbook workbook = new XSSFWorkbook();

                ISheet sheet1 = workbook.CreateSheet("UTLAs");
                sheet1.GetRow()
            }
        }
    }
}
