﻿using System.Collections.Generic;
using Moosend.Api.Common.Models;

namespace Moosend.Api.Common.Responses
{
    public class SegmentsResult : PagedResponse
    {
         public IList<Segment> Segments { get; set; } 
    }
}