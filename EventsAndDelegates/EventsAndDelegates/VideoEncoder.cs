using System;
using System.Threading;


namespace EventsAndDelegates {

  public class VideoEventArgs: EventArgs {
    public Video Video { get; set; }
  }

  public class VideoEncoder {
    public VideoEncoder() {}

    // 1- Define a delegate ; 
    // 2- Define an event based on that delegate 
    // 3- Raise the event

    public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

    public event VideoEncodedEventHandler VideoEncoded; 

    public void Encode(Video video) {
      Console.WriteLine("Encoding video ...");
      Thread.Sleep(3000); // 3 sec delay

      OnVideoEncoded(video);
    }


    // Raising the event 

    protected virtual void OnVideoEncoded(Video video) {
      if (VideoEncoded != null) // there are some subscibers 
        VideoEncoded(this, new VideoEventArgs() {Video = video });

    }



  }
}