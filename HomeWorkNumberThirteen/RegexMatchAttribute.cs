using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkNumberThirteen
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RegexMatchAttribute : Attribute
    {
        public string Pattern;

        public RegexMatchAttribute(string pattern)
        {
            Pattern = pattern;
        }
    }
}
