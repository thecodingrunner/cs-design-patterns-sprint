using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint
{
    /// <summary>
    /// This class is a fictional database implementation that saves data if there's any waiting to be saved
    /// </summary>
    public static class ImaginaryDatabase
    {
        public static void FlushDataQueue()
        {
            Console.WriteLine("Flushing data queue...");

            // let's see if there's any data waiting to be saved
            var config = ConfigManager.GetInstance("https://example.com/db/url", 1000, 2000);

            if (config.DataCounter > 0)
            {
                Console.WriteLine("YES - Saving " + config.DataCounter + " pieces of data.");
            }
            else
            {
                Console.WriteLine("No data to be saved.");
            }
        }
    }
}
