﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unbroken.LaunchBox.Plugins.Data;

namespace PegasusExportPlugin.Launchbox
{
    public class PlaylistSetting
    {
        public bool Selected { get; set; } = true;
        public string Name { get; set; }

        public bool ExportAssets { get; set; } = true;
        public bool ExportMetadata { get; set; } = true;
        public bool ExportApplication { get; set; } = true;

        public IGame[] Games;
    }
}
