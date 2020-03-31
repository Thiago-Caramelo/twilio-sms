using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using receiveVoice.Models;
using Twilio.AspNet.Core;
using Twilio.TwiML;

namespace receiveVoice.Controllers
{
  public class VoiceController : TwilioController
  {
    [HttpPost]
    public IActionResult Index()
    {
      var response = new VoiceResponse();
      response.Say("How are you ? Have a great day.");

      return TwiML(response);
    }
  }
}
