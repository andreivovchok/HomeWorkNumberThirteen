using System;
using HomeWorkNumberThirteen;
using System.Text.RegularExpressions;
using System.Reflection;

namespace ConsoleAppMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man { Age = 23, FirstName = "Vanya", LastName = "Ivanov" };

            VerifyRegexMatch(man);
        }

        private static void VerifyRegexMatch(object objectToVerify)
        {
            Type type = objectToVerify.GetType();

            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                var attributes = propertyInfo.GetCustomAttributes<RegexMatchAttribute>();
                foreach (var attribute in attributes)
                {
                    if (propertyInfo.PropertyType == typeof(string))
                    {
                        var propertyValue = (string)propertyInfo.GetValue(objectToVerify);
                        if (!Regex.IsMatch(propertyValue, attribute.Pattern))
                        {
                            Console.WriteLine($"В объекте типа {type.FullName} свойство {propertyInfo.Name} " +
                                $"со значением {propertyValue} не соответствует паттерну {attribute.Pattern}");
                        }                       
                    }
                }
            }
        }
    }
}
