namespace _03._MulticastDelegates
{
    /// <summary>
    /// Multicast Delegates
    /// 
    /// A Multicast delegate is a delegate that references to more than one function.
    /// When you invoke a multicast delegate, all the functions the delegate is pointing to,
    /// are invoked.
    /// 
    /// There are two approaches to create a multicast delegate.
    /// Depending on the approach you use
    /// + or += to register a method with the delegate
    /// - or -= to un-register a method with the delegate
    /// 
    /// Note: A multicast delegate, invokes the methods in the invocation list,
    /// in the same order in which they are added.
    /// 
    /// If the delegate has a return type other than void and if the delegate is a multicast delegate,
    /// only the value of the last invoked method will return. Along the same lines,
    /// if the delegate has an out parameter, the value of the output paramter,
    /// will be the value assigned by the last method.
    /// 
    /// Common interview question - where do you use multicast delegates?
    /// Multicast delegate makes implementation of observer design pattern very simple.
    /// Observer pattern is also called publish/subscribe pattern
    /// 
    /// </summary>

    using System;

    public delegate void SampleDelegate();
    public delegate int SampleDelegateInt();
    public delegate void SampleDelegateWithOut(out int Integer);

    internal class MulticastDelegates
    {
        static void Main(string[] args)
        {
            // void
            var del = new SampleDelegate(SampleMethodOne);

            SampleDelegate del1, del2, del3, del4, del5;

            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);

            del4 = del1 + del2 + del3;
            del4();
            
            Console.WriteLine();

            del5 = del1 + del2 + del3 - del2;
            del5();

            Console.WriteLine();

            var del6 = new SampleDelegate(SampleMethodOne);
            del6 += SampleMethodTwo;
            del6 += SampleMethodThree;
            del6 -= SampleMethodOne;
            del6();

            Console.WriteLine();

            // reurn int
            var del7 = new SampleDelegateInt(SampleReturnMethodOne);
            del7 += SampleReturnMethodTwo;
            Console.WriteLine("delegate return value = " + del7());

            Console.WriteLine();

            // void out
            var del8 = new SampleDelegateWithOut(SampleMethodWithOutOne);
            del8 += SampleMethodWithOutTwo;
            int delegateOutputParameterValue = -1;
            del8(out delegateOutputParameterValue);
            Console.WriteLine("delegate out value = " + delegateOutputParameterValue);

        }

        // void
        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }

        // reurn int
        public static int SampleReturnMethodOne()
        {
            return 1;
        }

        public static int SampleReturnMethodTwo()
        {
            return 2;
        }

        // void out
        public static void SampleMethodWithOutOne(out int Number)
        {
            Number = 1;
        }

        public static void SampleMethodWithOutTwo(out int Number)
        {
            Number = 2;
        }
    }
}