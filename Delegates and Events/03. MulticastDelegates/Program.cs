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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}