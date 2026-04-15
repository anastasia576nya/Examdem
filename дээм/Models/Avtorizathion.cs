using System;
using System.Collections.Generic;

namespace дээм.Models;

public partial class Avtorizathion
{
    public int Idavtorizathion { get; set; }

    public string Login { get; set; } = null!;

    public string Parole { get; set; } = null!;
}
