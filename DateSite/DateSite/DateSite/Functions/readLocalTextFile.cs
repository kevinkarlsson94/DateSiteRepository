using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DateSite.Functions
{
    public class readLocalTextFile
    {

        public List<string> getCountries()
        {
            List<string> countries = new List<string>();
            var location = @"C:\Users\kevin\Desktop\DateSiteRepository\DateSiteRepository\DateSite\DateSite\DateSite\Content\Text\Countries.cntry";
            var lines = File.ReadLines(location);
            foreach (var line in lines)
            {
                countries.Add(line);
            }

            return countries;
        }
    }
}