using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegister.Enums
{
    public enum UserRanks : ushort
    {
        User,
        Admin,
        Banned = 255
    }
}
