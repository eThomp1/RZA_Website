﻿using System;
using System.Collections.Generic;

namespace RZA_Website.Models;

public partial class Attraction
{
    public int AttractionId { get; set; }

    public string AttractionName { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}