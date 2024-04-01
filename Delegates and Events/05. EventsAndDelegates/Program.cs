namespace _05._EventsAndDelegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video() { Title = "Monkey video" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber 1
            var messageService = new MessageService(); // subscriber 2

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // handler subscribes to event (with pointer to the method)
            // VideoEncoded is and event delegate 
            // Handlers/Subscribers are methods chained on the delegate making it a multicast or singlecast event delegate
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // adding a new subscriber did NON require change in the code

            videoEncoder.Encode(video);
        }
    }
}