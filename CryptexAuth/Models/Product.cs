using System;
using System.Collections.Concurrent;
using System.ComponentModel;

namespace CryptexAuth.Models
{
    /**/
    public class Product{

        public UserExchange Exchange { get; set; }
        public string Name { get; set; }
        public string Instrument { get; set; }
        public string OrderInstrument { get; set; }
        public int TickIncrements { get; set; }
        public int DecimalPlaces { get; set; }
        public string Description { get; set; }
        public bool IsWebsocket { get; set; }
    }
}