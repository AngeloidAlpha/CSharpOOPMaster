using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Interfaces;

namespace Telephony
{
    public class SmartPhone : ICaller, IBrowser
    {
        //имплементираме 2та метода от Interface-ите
        public string Browse(string site) => $"Browsing: {site}!";
        public string Call(string phoneNumber) => $"Calling... {phoneNumber}";
    }
}
