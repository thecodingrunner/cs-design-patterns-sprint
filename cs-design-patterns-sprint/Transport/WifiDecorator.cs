using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint.Transport
{
    internal class WifiDecorator : ITransportDecorator
    {
        private ITransport _ITransport { get; set; }

        public WifiDecorator(ITransport iTransport)
        {
            _ITransport = iTransport;
        }

        public void Display()
        {
            _ITransport.Display();
            Console.WriteLine(" + Wi-Fi");
        }
    }
}
