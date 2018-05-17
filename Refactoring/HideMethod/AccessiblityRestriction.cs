//// Restrictions on Using Accessibility Levels  
//// CS0052 expected as well as CS0053, CS0056, and CS0057  
//// To make the program work, change access level of both class B  
//// and MyPrivateMethod() to public.  
//
//using System;  
//
//// A delegate:  
//delegate int MyDelegate();  
//
//class B  
//{  
//    // A private method:  
//    static int MyPrivateMethod()  
//    {  
//        return 0;  
//    }  
//}  
//
//public class A  
//{  
//    public B myField = new B();  
//
//    public readonly B myConst = new B();  
//
//    public B MyMethod()  
//    {  
//        return new B();  
//    }  
//
//    public B MyProp  
//    {  
//        set  
//        {  
//        }  
//    }  
//
//    MyDelegate d = new MyDelegate(B.MyPrivateMethod);  
//    // Even when B is declared public, you still get the error:   
//    // "The parameter B.MyPrivateMethod is not accessible due to   
//    // protection level."  
//
//    public static B operator +(A m1, B m2)  
//    {  
//        return new B();  
//    }  
//
//    static void Main()  
//    {  
//        Console.Write("Compiled successfully");  
//    }  
//}