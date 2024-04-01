namespace _05._EventsAndDelegates
{
    public class MailService
    {
        // event handler
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail Service: Sending email..." + e.Video.Title);
        }
    }
}
