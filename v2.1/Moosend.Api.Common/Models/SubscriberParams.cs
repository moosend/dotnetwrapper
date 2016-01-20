﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Moosend.Api.Common.Models
{
    public class SubscriberParams
    {
        public SubscriberParams()
        {
            CustomFields = new Dictionary<string, string>();
        }

        public string Name
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public IDictionary<string, string> CustomFields
        {
            get;
            set;
        }
    }
}