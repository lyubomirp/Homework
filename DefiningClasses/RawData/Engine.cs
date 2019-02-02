using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Engine
    {
        int EngineSpeed { get; set; }
        int EnginePower { get; set; }


        public int GetEnginePower
        {
            get
            {
                return EnginePower;
            }
        }

        public Engine() : this(0, 0) { }

        public Engine(int engineSpeed, int enginePower)
        {
            this.EnginePower = enginePower;
            this.EngineSpeed = EngineSpeed;
        }
    }
}
