﻿using System;

namespace DistrictServer.World.DW
{
    class RegisterDistrict : Packet
    {
        public RegisterDistrict(Byte type, Byte Id, Byte language, String password, String IP) : base()
        {
            WriteByte((Byte)OpCodes.WD_REGISTER_DISTRICT);
            WriteByte(type);
            WriteByte(Id);
            WriteByte(language);
            WriteS(password);
            WriteS(IP);
        }
    }
}
