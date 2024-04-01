using System;

namespace _05._EventsAndDelegates
{
    public class MessageService
    {
        // event handler method
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message" + args.Video.Title);
        }
    }
}
