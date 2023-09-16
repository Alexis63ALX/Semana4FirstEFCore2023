using System;
using System.Collections.Generic;

namespace Semana4FirstEFCore.API.Models;

public partial class People
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public int? Dni { get; set; }
}
