using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBlog.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLength = 140)
        {
            if (text == null || text.Length < maxLength)
            {
                return text; 
            }
            var shortText = text.Substring(0, maxLength-3) + "...";
            return shortText;
        }
    }
}