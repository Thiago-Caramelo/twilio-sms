using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
  static void Main(string[] args)
  {
    switch (args[0])
    {
      case "send":
        SendSms();
        break;
      case "receive":
        break;
      default:
        throw new ArgumentException("Invalid Argument Value");
    }
  }
  private static void SendSms()
  {
    string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
    string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

    TwilioClient.Init(accountSid, authToken);

    var message = MessageResource.Create(
        body: "You have a New Order #456",
        from: new Twilio.Types.PhoneNumber(Environment.GetEnvironmentVariable("TWILIO_FROM")),
        to: new Twilio.Types.PhoneNumber(Environment.GetEnvironmentVariable("TWILIO_TO"))
    );

    Console.WriteLine(message.Sid);
  }
}