using PocNet.Standard.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocNet.Infra.NetFramework
{
    public class Message : IMessage
    {
        public string Greeting()
        {
            return "Hello from .net framework";
        }
    }
}
