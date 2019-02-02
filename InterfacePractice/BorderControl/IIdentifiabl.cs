using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IIdentifiabl
    {
        int Age { get; set; }

        void SetStatus(string year);
    }
}
