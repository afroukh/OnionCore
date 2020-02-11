using PocNet.Standard.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocNet.infra.Core
{
    public class Message : IMessage
    {
        public string Greeting()
        {
            return "Hello from .net core";
        }
    }
}
