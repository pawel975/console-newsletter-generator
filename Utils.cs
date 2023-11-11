using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNewsletterGenerator
{
    static public class Utils
    {
        /// <summary>
        /// Saves string data into an HTML file for a given path.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filePath"></param>
        public static void SaveDataToHTMLFile(this string data, string filePath)
        {
            try
            {
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(data);

                htmlDocument.Save(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
