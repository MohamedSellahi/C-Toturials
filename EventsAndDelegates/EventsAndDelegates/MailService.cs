using System;

namespace EventsAndDelegates
{


    public class MailService {

      public void OnVideoEncoded(object source, VideoEventArgs e) {
        Console.WriteLine("Mail Service: sending Email..." + e.Video.Title);
      }


    }
}