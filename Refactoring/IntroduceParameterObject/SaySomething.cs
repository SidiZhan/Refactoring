namespace Refactoring.IntroduceParameterObject
{
    public static class SaySomething
    {
        public static string Hello(string first, string middle, string last)
        {
            return $"Hello, {first} {middle} {last}";
        }

        public static string Hi(string first, string middle, string last)
        {
            return $"Hi, {first} {middle} {last}";
        }
    }
}
