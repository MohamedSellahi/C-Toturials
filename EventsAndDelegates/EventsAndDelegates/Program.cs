using System;
using System.Threading;


namespace EventsAndDelegates {
  class Program {



    static void Main(string[] args) {

      VideoEncoder vduEnc = new VideoEncoder();
      Video vdu = new Video("MyVideo"); // publisher 
      MailService mailService = new MailService(); // subscriber 
      MessageService msgService = new MessageService();

      vduEnc.VideoEncoded += mailService.OnVideoEncoded;
      vduEnc.VideoEncoded += msgService.OnVideoEncoded;

      vduEnc.Encode(vdu);

    }

    

    



  }

}
