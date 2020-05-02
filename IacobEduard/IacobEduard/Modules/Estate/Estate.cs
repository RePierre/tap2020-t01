using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Core.Assets
{
    public abstract class Estate: Asset
    {
        public int Rooms;
        public int Floor;

        public Estate(string address,int sm, int rooms, int floor) : base(sm, address)
        {
            this.Rooms = rooms;
            this.Floor = floor;
        }
    }
}
