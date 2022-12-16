using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        //A custom class that will pass through which video/object has been encoded and will send info
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //To use EVENTS: 
        // 1- Define a delegate to determine the signature of the method
        // 2- Define an event based on the delegate
        // 3- Raise the event, using a method

        //A DELEGATE is a required reference to a method or an event handler.
        //EventHandler Shorthand Syntax: public event EventHandler<VideoEventArgs> VideoEncoded;
        //Define a delegate Syntax: accessModifier delegate returnType name(object source, EventArgs args);
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //Define an event based on the delegate:
        //Every time the "VideoEncoded" event is called, the "VideoEncodedEventHandler" is called.
        public event VideoEncodedEventHandler VideoEncoded;      

        //Create a method for this class: This holds a protected method that will call the event. 
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);  //temporarily suspends the current execution of the thread for specified milliseconds, so that other threads can get the chance to start the execution, or may get the CPU for execution.
            OnVideoEncoded(video);  //Call a method (defined below) whose function triggers the event and pass in a parameter.
        }

        //Raise the event. This is what, when called, will "trigger" the event in other classes (this "trigger" relationship is defined in program.cs by using += operators)
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() {Video = video});  //Call the event and pass in parameters.
                //instantiate a VideoEventArgs as a parameter and pass in the video object 
            }
        }
    }
}
