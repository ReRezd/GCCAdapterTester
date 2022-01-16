using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GCCAdapterTester
{
    public class ControllerENUM
    {

        private int controllerPort = 0;


        public enum ControllerPresent//check these bytes. If any = 16 that means they are plugged in otherwise 0 mean unplugged
        {
            C1 = 1,
            C2 = 10,
            C3 = 19,
            C4 = 28,
        };

        public enum ButtonsFace
        {
            Abtn = 1,
            Bbtn = 2,
            Xbtn = 4,
            Ybtn = 8,
            DpUp = 128,
            DpDown = 64,
            DpLeft = 16,
            DpRight = 32,
        };

        public enum ButtonsOther//NO analog for the triggers, thst is in a different byte
        {
            Start = 1,
            Zbtn = 2,
            RTrigger = 4,
            LTrigger = 8,
        };

        public enum LeftJoy //Has to be set, controlers dont have the the same deadzone 
        {
            Xmax = 233,//right
            Xmin = 33,//left

            Ymax = 246,//up
            Ymin = 42,//down
        }

        public enum RightJoy //Has to be set, controlers dont have the the same deadzone 
        {
            Xmax = 222,//right
            Xmin = 33,//left

            Ymax = 197,//up
            Ymin = 11,//down
        }

        public enum LeftTriggerA //Has to be set, controlers dont have the the same deadzone 
        {
            min = 27,
            max = 200,
        }

        public enum RightTriggerA //Has to be set, controlers dont have the the same deadzone 
        {
            min = 31,
            max = 229,
        }

        public ControllerENUM()
        {
            controllerPort = 0; //please dont use this
        }

        //Ports can be 1, 2, 3, or 4
        public ControllerENUM(int port)
        {
            controllerPort = port;
        }

        public int GetControllerByte()
        {
            switch (controllerPort)
            {
                case 1:
                    return (int)ControllerPresent.C1;
                case 2:
                    return (int)ControllerPresent.C2;
                case 3:
                    return (int)ControllerPresent.C3;
                case 4:
                    return (int)ControllerPresent.C4;
                default:
                    return 0;// this should be handled in the program
            }

        }

        public static int[] ControllerBytes(int PortNum)
        {
            int[] bytes;


            switch (PortNum)
            {
                case 1:
                    bytes = new int[] { 1,  2,  3,  4,  5,  6,  7,  8,  9 };
                    break;
                case 2:
                    bytes = new int[] { 10,  11,  12,  13,  14,  15,  16,  17,  18 };
                    break;
                case 3:
                    bytes = new int[] { 19,  20,  21,  22,  23,  24,  25,  26,  27 };
                    break;
                case 4:
                    bytes = new int[] { 28,  29,  30,  31,  32,  33,  34,  35,  36 };
                    break;
                default:
                    bytes = null;
                    break;
            }

            return bytes;
        }

    }
}
