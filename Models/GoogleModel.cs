using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnit3NetCoreFramework.Models
{
    class GoogleModel : IEnumerable
    {

        private dynamic searches;

        public GoogleModel()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\TestData\Google.json");
            string sFilepath = Path.GetFullPath(sFile);

            searches = JValue.Parse(File.ReadAllText(sFilepath));

        }

        public IEnumerator GetEnumerator()
        {
            foreach (dynamic search in searches)
            {
                yield return new object[] { search };
            }
        }
    }
}
