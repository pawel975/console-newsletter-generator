﻿
namespace ConsoleNewsletterGenerator;

class Program
{
    private const string MenuMessage = """ ***** Newsletter Generator *****""";

    static void Main(string[] args)
    {
        Console.WriteLine(MenuMessage);

        User user = Services.GetUserById(1);

        NewsletterGenerator newsletterGenerator = new NewsletterGenerator();
        
        string templatePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Templates\newsletter-template.html"));

        var newsletter = newsletterGenerator.GenerateNewsletter(templatePath, user);
        File.WriteAllText(@"C:\Users\pawel\Desktop\example.html", newsletter);
    }
}
