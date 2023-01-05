using System;
using System.Collections.Generic;

namespace webapi.MyDbContext;

public partial class User
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }
}
