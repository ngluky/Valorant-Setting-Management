﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CopySettings.Obje.GuiObj
{
    public class Gui
    {
        [JsonPropertyName("general")] public Group[] general { get; set; }
        [JsonPropertyName("control")] public Group[] control { get; set; }
    }
}
