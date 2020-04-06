using COVID.Database;
using System;

namespace COVID
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonGenerator.Generate();
            ModelContext.loadData(new ModelContext());  
        }
    }
}
