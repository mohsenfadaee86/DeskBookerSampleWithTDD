﻿using System;

namespace DeskBooker.Core.Processor
{
    internal class DeskbookingRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}