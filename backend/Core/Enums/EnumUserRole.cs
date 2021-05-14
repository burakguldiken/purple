using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enums
{
    public enum EnumUserRole
    {
        [Description("inactive")]
        Default = 0,
        [Description("active")]
        Admin = 1
    }
}
