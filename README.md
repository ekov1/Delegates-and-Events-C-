# DelegatesAndEventsCSharp

    /// What is a delegate
    /// 
    /// A delegate is a type safe function pointer. That is,
    /// it holds a reference(Pointer) to a function.
    /// 
    /// The signature of the delegate must mach the signature of the function,
    /// the delegate points to, otherwise you will get a compiler error.
    /// This is the reason why delegates are called as type safe function pointers.
    /// A Delegate is similar to a class. You can create an instance of it,
    /// and when you do so, you pass in the function name as a parameter to the delagate constructor,
    /// and it is this function the delegate will point to.

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
