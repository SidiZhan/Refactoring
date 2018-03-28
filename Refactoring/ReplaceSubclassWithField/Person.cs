using System;

namespace Refactoring.ReplaceSubclassWithField
{
    public class Person
    {
        readonly bool isMale;
        readonly char code;

        protected Person(bool isMale, char code)
        {
            this.isMale = isMale;
            this.code = code;
        }

        public static Person CreateMale()
        {
            return new Person(true, 'M');
        }

        public static Person CreateFeMale()
        {
            return new Person(false, 'F');
        }

        public bool IsMale() { return isMale; }

        public char GetCode() { return code; }
    }
}
