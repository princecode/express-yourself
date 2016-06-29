﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressYourself
{
    public class Parser
    {
        /// <summary>
        /// Looks for a title in a Media file string.
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>the title string if it exists</returns>
        public static string GetTitle(string str)
        {
            // TODO
            var titleExpression = new Regex(@"Title\: (.*),+");

            var match = titleExpression.Match(str);
            if (!match.Success)
            {
                return "Title Not Found";
            }
            else
            {
                return match.Groups[1].Value;
            }
        }
        public static string GetType(string str)
        {
            // TODO
            //var typeExpression = new Regex();
            //var match = typeExpression.Match(str);
            //if (!match.Success)
            //{
            //    return "Type Not Found";
            //}
            //else
            //{
            //    return match.Groups[1].Value;
            //}
        }
        public static string GetLength(string str)
        {
            // TODO
            return "";
        }

        public static bool IsValidLine(string str)
        {
            // TODO
            return false;
        }
    }
}
