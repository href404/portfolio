using System.IO;

namespace Portfolio.ViewModels
{
    public class BaseDetailViewModel
    {
        public string PathHtmlFile { get; set; }

        public string GetStaticHtml()
        {
            if (!File.Exists(PathHtmlFile))
                return $"Une erreur est survenue lors de la récupération de cet article.";

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
