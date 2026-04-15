using System;
using System.Collections.Generic;

namespace дээм.Models;

public partial class Name
{
    public int IdName { get; set; }

    public string NameFio { get; set; } = null!;

    public int IdUser { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
