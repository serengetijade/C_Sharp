namespace ConsoleApp_EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args) 
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();  //instantiate a new instance of VideoEncoder (defined in VideoEncoder.cs)
            var mailService = new MailService();    //subscriber: instantiate a new instance of MailService (defined in MailService.cs)
            var messageService = new MessageService(); //subscriper: instantiate a new instance of MailService (defined in MessageService.cs)

            //Subscribe to an event-i.e when a method (the event) occurs, trigger these events as well:
            //class.method += pointer to a different class.method
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;   
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            //.VideoEncoded is an event of the videoEncoder class (defined in VideoEncoder.cs)
            //+= is the notation operator to REGISTER A HANDLER FOR THE EVENT. It is a "pointer" to a different method (in a different class).
            //mailService is an instance defined above. .OnVideoEncoded (the handler) is a method of the MailService class (defined in mailService.cs). 
            //because it is reference to a method, and not a method call, NO brakets are used after the methodName.

            videoEncoder.Encode(video);
        }
    }
}