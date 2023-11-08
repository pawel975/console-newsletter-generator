using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNewsletterGenerator
{
    public class NewsletterGenerator
    {
        // TODO: Possibly will delete this property
        static private string HTMLTemplate { get; set; }

        // TODO: Possibly will change this function to return html file string
        static void ReadHTMLTemplate(string templatePath)
        {
            //TODO: Check if template has .html extension
            string fileExtension = Path.GetExtension(templatePath);

            if (File.Exists(templatePath) && fileExtension.Equals(".html", StringComparison.OrdinalIgnoreCase))
            {
                File.WriteAllText(templatePath, HTMLTemplate);
            }
        }

        // TODO: placeholders dictionary should contain placeholder-value pairs
        static string FillTemplate(Dictionary<string, string> placeholders) 
        {
            string filledTemplate = default;

            return filledTemplate;
        }
    }

}
