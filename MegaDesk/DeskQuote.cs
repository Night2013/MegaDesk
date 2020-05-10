using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public enum DeliveryType
    {
        rush3,
        rush5,
        rush7,
        normal
    }

    public class DeskQuote
    {
        public string Desk { get; set; }

        public DateTime QuoteDate { get; set; }

        public string CustomerName { get; set; }

        public DeliveryType DeliveryType { get; set; }
    }
}
