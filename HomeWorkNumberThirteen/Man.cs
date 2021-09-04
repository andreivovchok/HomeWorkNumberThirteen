using System;

namespace HomeWorkNumberThirteen
{
    public class Man
    {
        private int _age;
        private string _firstName;
        private string _lastName;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        [RegexMatch(@"\A[a-zA-Z]{2,8}\Z")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        [RegexMatch(@"\A[a-zA-Z]{2,8}\Z")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
