using Microsoft.VisualStudio.TestTools.UnitTesting;
using COVID;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace COVID.Tests
{
    [TestClass()]
    public class PersonGeneratorTests
    {
       

        [TestMethod()]
        public async Task GetNumCasesTestAsync()
        {
            await PersonGenerator.GetNumCases();
        }
    }
}