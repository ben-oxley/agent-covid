using CsvHelper;
using NPOI.SS.UserModel;
using NPOI.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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

        public static async Task GetNumCases()
        {
            WebClient webClient = new WebClient();
            Uri uri = new Uri("https://fingertips.phe.org.uk/documents/Historic%20COVID-19%20Dashboard%20Data.xlsx");
            byte[] v = await webClient.DownloadDataTaskAsync(uri);
            ByteArrayInputStream byteArrayInputStream = new ByteArrayInputStream(v);
            IWorkbook workbook = new XSSFWorkbook(byteArrayInputStream);

            ISheet sheet1 = workbook.GetSheet("UTLAs");
            IRow headerRow = sheet1.GetRow(7);
            if (headerRow.GetCell(0).StringCellValue != "Area Code") throw new FormatException("Table not in the expected format");
            
        }
    }
}
