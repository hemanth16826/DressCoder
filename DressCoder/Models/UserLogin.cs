using System;
using System.Collections.Generic;

namespace DressCoder.Models;

public partial class UserLogin
{
    public int LoginId { get; set; }

    public string? LoginName { get; set; }

    public string? LoginPassword { get; set; }
}
