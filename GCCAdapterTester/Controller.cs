using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCCAdapterTester
{
    public class Controller
    {
        int portNum = 0;
        int isRumbling = 0;

        public Controller()
        {
            portNum = 0;
        }

        public Controller(int Port)
        {
            portNum = Port;
        }


    }
}
