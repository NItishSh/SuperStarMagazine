﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperStarMagazine.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual SubscriptionType SubscriptionType { get; set; }
        public string PaymentReferance { get; set; }
    }
}