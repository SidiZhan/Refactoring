namespace Refactoring.ReplaceTypeCodeWithClass
{
    public class Student
    {
        public static int Active = 0;
        public static int Sleepd = 1;
        public static int Deleted = 2;

        public string name { get; }

        public int status { get; set;}

        public Student(string name, int status)
        {
            this.name = name;
            this.status = status;
        }

        public void Archive()
        {
            status = Deleted;
        }

        public void Sleep()
        {
            status = Sleepd;
        }
    }
}
