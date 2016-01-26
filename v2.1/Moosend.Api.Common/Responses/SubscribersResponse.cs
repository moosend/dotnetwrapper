﻿using System.Collections.Generic;
using Moosend.Api.Common.Models;

namespace Moosend.Api.Common.Responses
{
    public class SubscribersResponse : PagedResponse
    {
        public IList<Sender> Subscribers { get; set; }
    }
}