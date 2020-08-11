﻿// ----------------------------------------------------------------------------

using Newtonsoft.Json;
using PeterHan.PLib;

// ----------------------------------------------------------------------------

namespace OniMods.UnknownWorldTraits
{
    [JsonObject(MemberSerialization.OptIn)]
    public class UnknownWorldTraitsModSettings
    {
        [Option("Display trait color", "Display trait color.")]
        [JsonProperty]
        public bool ShowTraitColor { get; set; }

        /// <summary>
        /// Ctor
        /// </summary>
        public UnknownWorldTraitsModSettings()
        {
            ShowTraitColor = true; // default if the config doesn't exist
        }
    }
}
