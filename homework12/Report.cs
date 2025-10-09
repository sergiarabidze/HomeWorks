using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework12
{
    public interface IHeader
    {
        string GetHeader(string content);
    }

    public interface IBody
    {
        string GetBodyContent(string content);
    }

    public interface IFooter
    {
        string GetFooter(string content);
    }

    public class HtmlHeader : IHeader
    {
        public string GetHeader(string content) => $"<header>{content}</header>";
    }

    public class HtmlBody : IBody
    {
        public string GetBodyContent(string content) => $"<body>\n{content}\n</body>";
    }

    public class HtmlFooter : IFooter
    {
        public string GetFooter(string content) => $"<footer>{content}</footer>";
    }

    public class PdfHeader : IHeader
    {
        public string GetHeader(string content) => $"Header: {content}";
    }

    public class PdfBody : IBody
    {
        public string GetBodyContent(string content) => $"Body:\n{content}";
    }

    public class PdfFooter : IFooter
    {
        public string GetFooter(string content) => $"Footer: {content}";
    }

    public class ReportFacade
    {
        private readonly IHeader _header;
        private readonly IBody _body;
        private readonly IFooter _footer;

        public ReportFacade(IHeader header, IBody body, IFooter footer)
        {
            _header = header;
            _body = body;
            _footer = footer;
        }

        public void GenerateReport(string headerText, string bodyText, string footerText)
        {
            Console.WriteLine(_header.GetHeader(headerText));
            Console.WriteLine();
            Console.WriteLine(_body.GetBodyContent(bodyText));
            Console.WriteLine();
            Console.WriteLine(_footer.GetFooter(footerText));
        }
    }

}
