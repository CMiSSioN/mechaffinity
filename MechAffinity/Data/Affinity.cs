﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MechAffinity.Data
{
    class Affinity
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public EAffinityType type = EAffinityType.Tatics;

        public int bonus = 0;
    }
}
