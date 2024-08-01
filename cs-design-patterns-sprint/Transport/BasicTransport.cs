using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint
{
    public class BasicTransport : ITransport
    {
        public string Description { get; private set; }

        public BasicTransport(string description)
        {
            this.Description = description;
        }

        
        public void Display()
        {
            Console.WriteLine("Transport: " + Description);
        }
    }                    

}
