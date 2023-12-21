using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCodeUnitTest
{
    [TestClass]
    public class HtmlFormatHelperUnitTest
    {
        private HtmlFormatHelper _htmlFormatHelper = new HtmlFormatHelper();

        [TestMethod]
        public void GetBoldFormat_WithBasicContent_isCorrect()
        {
            var content = "Test";
            string result = _htmlFormatHelper.GetBoldFormat(content);
            Assert.AreEqual($"<b>{content}</b>", result);
        }

        [TestMethod]
        public void GetItalicFormat_WithBasicContent_isCorrect()
        {
            var content = "Test";
            string result = _htmlFormatHelper.GetItalicFormat(content);
            Assert.AreEqual($"<i>{content}</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_WithBasicContent_isCorrect()
        {
            var list = new List<string> { "Tess", "Rémi", "Théo", "Cedric" };
            string result = _htmlFormatHelper.GetFormattedListElements(list);

            var htmlList = new StringBuilder();
            htmlList.Append("<ul>");

            list.ForEach(x => {
                htmlList.Append("<li>");
                htmlList.Append(x);
                htmlList.Append("</li>");
            });

            htmlList.Append("</ul>");
            var expectedResult = htmlList.ToString();

            Assert.AreEqual(result, expectedResult);
        }
    }
}
