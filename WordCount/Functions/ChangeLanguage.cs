using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace WordCount.Functions
{
    public class ChangeLanguage
    {
        public static void Language(string language)
        {
            string defaultLanguage = "en";
            //System.Configuration.ConfigurationManager.AppSettings["defaultLanguage"];
            
            if (defaultLanguage != "en" && defaultLanguage != "de")
            {
                defaultLanguage = "en";
            }

            if (language == null)
            {
                language = defaultLanguage;
            }

            CultureInfo ui_culture = new CultureInfo(language);
            CultureInfo culture = new CultureInfo(language);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = ui_culture;
            ResourceManager resourceManager = new ResourceManager("WordCount.Resource.Resource", typeof(Program).Assembly);
        }
    }
}

