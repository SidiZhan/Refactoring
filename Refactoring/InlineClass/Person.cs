namespace refactoring
{
    public class Person {
        public Person(string name, string officeAreaCode, string officeNumber) {
            this.name = name;
            officeTelephone = new TelephoneNumber(officeAreaCode, officeNumber);
        }
        public string GetTelephoneNumber() {
            return officeTelephone.GetTelephoneNumber();
        }

        public string GetAddress() {
            return "fake address";
        }

        string name { get; }
        readonly TelephoneNumber officeTelephone;
    }

    public class TelephoneNumber {
        readonly string officeAreaCode1;
        readonly string officeNumber1;

        public TelephoneNumber(string officeAreaCode, string officeNumber) {
            officeAreaCode1 = officeAreaCode;
            officeNumber1 = officeNumber;
        }
        public string GetTelephoneNumber() {
             return "(" + getOfficeAreaCode() + ") " + getOfficeNumber();
        }

        public string getOfficeAreaCode()
        {
            return officeAreaCode1;
        }

        public string getOfficeNumber()
        {
            return officeNumber1;
        }
    }
}