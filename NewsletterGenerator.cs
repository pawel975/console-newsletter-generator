using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNewsletterGenerator;

public class NewsletterGenerator
{
    private string HTMLTemplate = default;
    private string FilledOutTemplate = default;

    public string GenerateNewsletter(string templatePath, User user)
    {
        ReadHTMLTemplate(templatePath);
        FillTemplate(user);

        if (FilledOutTemplate != null)
        {
            return FilledOutTemplate;
        } else
        {
            return null;
        }
    }

    /// <summary>
    /// Reads html file from given path and saves it to NewsletterGenerator
    /// </summary>
    /// <param name="templatePath"></param>
    /// <returns>HTML file parsed to string</returns>
    private void ReadHTMLTemplate(string templatePath)
    {
        //TODO: Check if template has .html extension
        string fileExtension = Path.GetExtension(templatePath);
        try
        {
            if (File.Exists(templatePath) && fileExtension.Equals(".html", StringComparison.OrdinalIgnoreCase))
            {
                File.WriteAllText(templatePath, HTMLTemplate);
            }
            else
            {
                throw new Exception();
            }

        }
        catch (Exception ex)
        {
            HTMLTemplate = default;
            Console.WriteLine("\n" + ex.Message);
            Console.WriteLine("\n" + ex.StackTrace);
            
        }

    }

    private void FillTemplate(User user)
    {
        Type objType = user.GetType();
        var properties = objType.GetProperties();

        List<string> allNewsletterPlaceholders = new List<string>();
        
        NewsletterPlaceholders[] enumNames = (NewsletterPlaceholders[])Enum.GetValues(typeof(NewsletterPlaceholders));
        foreach (var enumName in enumNames)
        {
            allNewsletterPlaceholders.Add(enumName.ToString());
        }

        try
        {
            FilledOutTemplate = new string(HTMLTemplate.ToCharArray());

            foreach (var property in properties)
            {
                if (allNewsletterPlaceholders.Contains(property.Name))
                {
                    string propValue = (string)property.GetValue(user);
                    FilledOutTemplate.Replace($"[{property}]", propValue);
                }
                else
                {
                    throw new Exception();
                }
            }
        } catch (Exception ex)
        {
            FilledOutTemplate = default;
            Console.WriteLine("\n" + ex.Message);
            Console.WriteLine("\n" + ex.StackTrace);
        }
    }
}
