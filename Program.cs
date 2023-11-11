
namespace ConsoleNewsletterGenerator;

class Program
{
    private const string MenuMessage = """ ***** Newsletter Generator *****""";
    static private readonly string templatePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Templates\newsletter-template.html"));

    static void Main(string[] args)
    {
        Console.WriteLine(MenuMessage);

        // TODO: Ask for user id / name an then fetch user
        User user = Services.GetUserById(1);

        NewsletterGenerator newsletterGenerator = new NewsletterGenerator();
        var newsletter = newsletterGenerator.GenerateNewsletter(templatePath, user);

        // TODO: Ask for path to save file
        newsletter.SaveDataToHTMLFile(@"C:\Users\pawel\Desktop\example.html");
    }
}
