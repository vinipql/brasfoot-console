using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Brasfoot
{
   public class Country
    {










        //Metodo para retornar lista com todos os países
        public static List<string> GetCountryList()
        {
            List<string> cultureList = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);

            foreach (CultureInfo Culture in cultures)
            {
 //               RegionInfo region = new RegionInfo(culture.LCID);

            }
            return cultureList;
        }

    }
}
