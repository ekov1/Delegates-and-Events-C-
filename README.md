<h1> DelegatesAndEventsCSharp </h1>

  <h2>  # What is a delegate </h2>
  <p> 
     A delegate is a type safe function pointer. That is,<br> 
     it holds a reference(Pointer) to a function.<br> 
    <br> 
     The signature of the delegate must mach the signature of the function,<br> 
     the delegate points to, otherwise you will get a compiler error.<br> 
     This is the reason why delegates are called as type safe function pointers.<br> 
     A Delegate is similar to a class. You can create an instance of it,<br> 
     and when you do so, you pass in the function name as a parameter to the delagate constructor,<br> 
     and it is this function the delegate will point to.<br> 
    </p>

  <h2>  # Multicast Delegates </h2>
     
     A Multicast delegate is a delegate that references to more than one function.<br>
     When you invoke a multicast delegate, all the functions the delegate is pointing to,<br>
     are invoked.<br>
     <br>
     There are two approaches to create a multicast delegate.<br>
     Depending on the approach you use<br>
     + or += to register a method with the delegate<br>
     - or -= to un-register a method with the delegate<br>
     <br>
     Note: A multicast delegate, invokes the methods in the invocation list,<br>
     in the same order in which they are added.<br>
     <br>
     If the delegate has a return type other than void and if the delegate is a multicast delegate,<br>
     only the value of the last invoked method will return. Along the same lines,<br>
     if the delegate has an out parameter, the value of the output paramter,<br>
     will be the value assigned by the last method.<br>
     <br>
     Common interview question - where do you use multicast delegates?<br>
     Multicast delegate makes implementation of observer design pattern very simple.<br>
     Observer pattern is also called publish/subscribe pattern<br>

<h1> Events </h1>
1. events are a mechanism for comunication between objects
2. events are used for building Loosley Coupled Applications

  <h1>  # Distingushing Delegates and Events </h1>
    
    1. Events and delegates are similar.
    2. Events are built using the language support for delegates.
    3. Both events and delegates offer a late binding scenario - they enable scenarios where a component comunicates by calling a method that is only known at rruntime.
    4. Both events and delegates support multiple subscriber methods.(singlecast multicast support)
    5. Both have similar syntax for adding and removing handlers.
    6. Same syntax for raising event and calling a delegate.
    7. Both support same syntax for Invoke() method with use of ? operator.

  <h2>    # Listening to events is optional </h2>

    1. If your code must call the code supplied by the subscriber, use a design based on delegates when you need to implement a callback.
    2. If your code can complete all its work without calling any subscribers, use a design based on events.
    
