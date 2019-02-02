using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ICallable
    {
        List<string> Numbers { get; set; }

        void Call();
    }
}
