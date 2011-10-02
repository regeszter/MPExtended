﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MPExtended.Services.MediaAccessService.Interfaces.TVShow
{
    public class WebTVSeasonDetailed : WebTVSeasonBasic
    {
        public IList<string> BackdropPaths { get; set; }
        public IList<string> PosterPaths { get; set; }
    }
}
