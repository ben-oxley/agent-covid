using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace COVID
{
    public class AreaHistoricData
    {
        [ExcelColumn("Area Code")] 
        public string AreaCode { get; set; }
        [ExcelColumn("Area Name")]
        public string AreaName { get; set; }
        [ExcelColumn("NHS region")]
        public string NHSRegion { get; set; }
        [ExcelColumn("Region (Governement) ")]
        public string GovernmentRegion { get; set; }
       

    }
}
