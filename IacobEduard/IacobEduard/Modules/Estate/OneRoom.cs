using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Core.Assets
{
    public class OneRoom : Estate
    {
        public OneRoom(string address, int sm, int floor, int rooms) : base(address, sm, rooms, floor) { }
    }
}
