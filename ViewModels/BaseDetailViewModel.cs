using System.IO;

namespace Portfolio.ViewModels
{
    public class BaseDetailViewModel
    {
        public string PathHtmlFile { get; init; }

        public string GetStaticHtml()
        {
            if (!File.Exists(PathHtmlFile))
                return "Oops, cet article n'existe pas encore pour le moment.";

            var htmlString = File.ReadAllLines(PathHtmlFile);
            var htmlContent = string.Join(string.Empty, htmlString);
            return htmlContent;
        }

        public string GetReadTime()
        {
            var content = GetStaticHtml();
            var wordsCount = content.Split(' ').Length;
            var readtime = (wordsCount / 200).ToString("D");
            return readtime;
        }
    }
}
