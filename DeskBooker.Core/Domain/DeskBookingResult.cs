using System;

namespace DeskBooker.Core.Domain
{
    public class DeskBookingResult : DeskBookingBase
    {
        public DeskBookginRequltCode Code { get; set; }
        public int? DeskBookginId { get; set; }
    }
}