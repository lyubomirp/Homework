using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface IBrowseable
    {
        List<string> Websites { get; set; }

        void SurfTheWeb();
    }
}
