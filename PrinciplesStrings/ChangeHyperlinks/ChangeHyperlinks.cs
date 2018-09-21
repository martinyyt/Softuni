using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ChangeHyperlinks
{
    class ChangeHyperlinks
    {
        
        
        static void Main(string[] args)
        {
            string text = "<p>Please visit <a href=\"http://softuni.bg\">our site</a> to choose a software engineering training course. " +
                "Also visit <a href=\"http://softuni.bg/forum\"> our forum</a> to discuss the courses.</p> ";

            //string[] dividedText=text.Split(new string[] { text},)
            text = Regex.Replace(text, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1]$2[/URL]"); // "." any character; "*" unlimited count; "?" MATCH LESS!!!
            

            Console.WriteLine(text);
        }
    }
}
