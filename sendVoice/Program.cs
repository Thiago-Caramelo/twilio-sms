using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace sendVoice
{
  class Program
  {
    static void Main(string[] args)
    {
      string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
      string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

      TwilioClient.Init(accountSid, authToken);

      var to = new PhoneNumber(Environment.GetEnvironmentVariable("TWILIO_TO"));
      var from = new PhoneNumber(Environment.GetEnvironmentVariable("TWILIO_FROM"));
      var call = CallResource.Create(to, from,
          url: new Uri("http://demo.twilio.com/docs/voice.xml"));

      Console.WriteLine(call.Sid);
    }
  }
}
