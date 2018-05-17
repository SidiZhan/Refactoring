namespace AccessibilityDomainNamespace
{
    public class T1
    {
        public static int publicInt;
        internal static int internalInt;
        private static int privateInt = 0;
        static T1()
        {
//            M1.publicInt = 1;
//            M1.internalInt = 2;
//            M2.publicInt = 3;
//            M2.internalInt = 4;
//            M1.privateInt = 2; 
        }

        public class M1
        {
            public static int publicInt;
            internal static int internalInt;
            private static int privateInt = 0;
        }

        private class M2
        {
            public static int publicInt = 0;
            internal static int internalInt = 0;
            private static int privateInt = 0;
        }
    }

    class MainClass
    {
        static void Main()
        {
//            T1.publicInt = 1;

//            T1.internalInt = 2;

            // T1.privateInt = 3;  

//            T1.M1.publicInt = 1;

//            T1.M1.internalInt = 2;

            //    T1.M1.privateInt = 3; 

            //    T1.M2.publicInt = 1;

            //    T1.M2.internalInt = 2;

            //    T1.M2.privateInt = 3;



            // Keep the console open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}