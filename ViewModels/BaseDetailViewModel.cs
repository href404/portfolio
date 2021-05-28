using System.IO;

namespace Portfolio.ViewModels
{
    public class BaseDetailViewModel
    {
        public string WebRootPath { get; init; }
        public string PathHtmlFile { get; init; }
        
        public string GetStaticHtml()
        {
            var htmlFile = IsArticleExist() ? PathHtmlFile : GetUndefinedHtml();
            var htmlString = File.ReadAllLines(htmlFile);
            var htmlContent = string.Join(string.Empty, htmlString);
            return htmlContent;
        }
        
        public bool IsArticleExist() => File.Exists(PathHtmlFile);

        public string GetReadTime()
        {
            const int wordsPerMinute = 100;
            
            var content = GetStaticHtml();
            var wordsCount = content.Split(' ').Length;
            var readtime = (wordsCount / wordsPerMinute).ToString("D");
            return readtime;
        }

        private string GetUndefinedHtml()
        {
            var undefinedHtmlFile = Path.Combine(
                WebRootPath,
                "articles",
                "shared",
                "undefined.html");

            return undefinedHtmlFile;
        }
    }
}
