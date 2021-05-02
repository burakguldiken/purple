using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Business.Enums
{
    public enum EnumStatus
    {
        [Description("inactive")]
        Inactive = 1,
        [Description("active")]
        Active = 2
    }
}
