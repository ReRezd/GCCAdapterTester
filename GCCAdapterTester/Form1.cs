using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUsbDotNet;
using LibUsbDotNet.Main;

namespace GCCAdapterTester
{
    public partial class Form1 : Form
    {

        //LibUSB Code
        int bytesWritten;
        ErrorCode ec = ErrorCode.None;//Error Checker and reader/ writer thing
        UsbEndpointReader reader;
        UsbEndpointWriter writer;
        public static UsbDevice GccDevice;
        public static UsbDeviceFinder AdapterFinder = new UsbDeviceFinder(0x057e, 0x0337);//(VendorID, ProductID)

        //Other vars
        int SelectedPort = 1;//Starts on port 1
        bool isRumbling = false;//The controller shouldn't be rumbling by default

        //Concept that isnt used here
        //Controller cnt1 = new Controller(1);//This will probably not be used in this program but this is how I'd go about setting different dead zone and stuff
       
        public Form1()
        {
            InitializeComponent();
        }

        //Make sure a port is selected by default
        private void Form1_Load(object sender, EventArgs e)
        {
            selectPort.SelectedText = "Port 1";
        }

        //Detect if an adapter is pulgged in, and that the drivers are installed
        private void adapterDetection()
        {
            GccDevice = UsbDevice.OpenUsbDevice(AdapterFinder);

            if (GccDevice != null)
            {
                detectLabel.Text = "Adapter Detected";
            }
            else if (GccDevice == null)
            {
                detectLabel.Text = "No Adapter Detected";
            }

            IUsbDevice wholeUsbDevice = GccDevice as IUsbDevice;
            if (!ReferenceEquals(wholeUsbDevice, null))
            {

                wholeUsbDevice.SetConfiguration(1);

                wholeUsbDevice.ClaimInterface(0);
            }

        }

        //calls adapterDetection() to detect adapter
        private void DetectButton_Click(object sender, EventArgs e)
        {
            adapterDetection();
        }

        //Starts and stops the vibration motors for all ports
        private void rumbleBTTN_Click(object sender, EventArgs e)
        {
            if (!isRumbling)
            {
                isRumbling = true;
                byte[] test = { 0x11, 0x01, 0x01, 0x01, 0x01 };
                ec = writer.Write(test, 2000, out bytesWritten);
            }
            else
            {
                isRumbling = false;
                byte[] test = { 0x11, 0x00, 0x00, 0x00, 0x00 };
                ec = writer.Write(test, 2000, out bytesWritten);
            }

        }

        //Poll adapter when called
        private async void button1_Click(object sender, EventArgs e)
        {
            // open read endpoint 1.
            reader = GccDevice.OpenEndpointReader(ReadEndpointID.Ep01);

            // open write endpoint 1.
            writer = GccDevice.OpenEndpointWriter(WriteEndpointID.Ep02);

            byte[] poll = { 0x13 };//Poll command, this must be sent to the adapter or nothing works

            ec = writer.Write(poll, 2000, out bytesWritten);

        }

        //being polling the adapter for inputs (Allows us to send vibration command as well)
        private async void button2_Click(object sender, EventArgs e)
        {
            await pollADPT();
        }

        //Reads all inputs from the adapter - I forgot to add the dpad, Ill do it later
        public async Task pollADPT()
        {
            Task t = Task.Run(async () =>
            {
                byte[] readBuffer = new byte[37];
            while (ec == ErrorCode.None)
            {
                int bytesRead;

                // If the device hasn't sent data in the last 100 milliseconds,
                // a timeout error (ec = IoTimedOut) will occur. 
                ec = reader.Read(readBuffer, 100, out bytesRead);

                if (bytesRead == 0) throw new Exception("No more bytes!");

                Console.WriteLine((int)readBuffer[ControllerBytes(SelectedPort)[1]]);

                    //Port 1 is/ isn't in use
                    if (P1.Checked && SelectedPort == 1)
                        isPresentLabel.Invoke(new Action(() => isPresentLabel.Text = "Controller Present"));
                    else if(!P1.Checked && SelectedPort == 1)
                        isPresentLabel.Invoke(new Action(() => isPresentLabel.Text = "No Controller Present"));

                    //Port 2 is/ isn't in use
                    if (P2.Checked && SelectedPort == 2)
                        isPresentLabel.Invoke(new Action(() => isPresentLabel.Text = "Controller Present"));
                    else if (!P2.Checked && SelectedPort == 2)
                        isPresentLabel.Invoke(new Action(() => isPresentLabel.Text = "No Controller Present"));

                    //Port 3 is/ isn't in use
                    if (P3.Checked && SelectedPort == 3)
                        isPresentLabel.Invoke(new Action(() => isPresentLabel.Text = "Controller Present"));
                    else if (!P3.Checked && SelectedPort == 3)
                        isPresentLabel.Invoke(new Action(() => isPresentLabel.Text = "No Controller Present"));

                    //Port 4 is/ isn't in use
                    if (P4.Checked && SelectedPort == 4)
                        isPresentLabel.Invoke(new Action(() => isPresentLabel.Text = "Controller Present"));
                    else if (!P4.Checked && SelectedPort == 4)
                        isPresentLabel.Invoke(new Action(() => isPresentLabel.Text = "No Controller Present"));

                    //Port 1
                    if ((int)readBuffer[1] == 16)
                        P1.Invoke(new Action(() => P1.Checked = true));
                    else
                        P1.Invoke(new Action(() => P1.Checked = false));
                    //Port 2
                    if ((int)readBuffer[10] == 16)
                        P2.Invoke(new Action(() => P2.Checked = true));
                    else
                        P2.Invoke(new Action(() => P2.Checked = false));
                    //Port 3
                    if ((int)readBuffer[19] == 16)
                        P3.Invoke(new Action(() => P3.Checked = true));
                    else
                        P3.Invoke(new Action(() => P3.Checked = false));
                    //Port 4
                    if ((int)readBuffer[28] == 16)
                        P4.Invoke(new Action(() => P4.Checked = true));
                    else
                        P4.Invoke(new Action(() => P4.Checked = false));

                    

                    //stick lables
                    LeftStickXLabel.Invoke(new Action(() => LeftStickXLabel.Text = readBuffer[ControllerBytes(SelectedPort)[3]].ToString()));
                    LeftStickYLabel.Invoke(new Action(() => LeftStickYLabel.Text = readBuffer[ControllerBytes(SelectedPort)[4]].ToString()));

                    RightStickXLabel.Invoke(new Action(() => RightStickXLabel.Text = readBuffer[ControllerBytes(SelectedPort)[5]].ToString()));
                    RightStickYLabel.Invoke(new Action(() => RightStickYLabel.Text = readBuffer[ControllerBytes(SelectedPort)[6]].ToString()));

                    //Face Buttons
                    if((int)readBuffer[ControllerBytes(SelectedPort)[1]] == 1)//A Button
                        ALabel.Invoke(new Action(() => ALabel.Text = "Pressed"));
                    else
                        ALabel.Invoke(new Action(() => ALabel.Text = "Not Pressed"));

                    if ((int)readBuffer[ControllerBytes(SelectedPort)[1]] == 2)//B Button
                        BLabel.Invoke(new Action(() => BLabel.Text = "Pressed"));
                    else
                        BLabel.Invoke(new Action(() => BLabel.Text = "Not Pressed"));

                    if ((int)readBuffer[ControllerBytes(SelectedPort)[1]] == 4)//X Button
                        XLabel.Invoke(new Action(() => XLabel.Text = "Pressed"));
                    else
                        XLabel.Invoke(new Action(() => XLabel.Text = "Not Pressed"));

                    if ((int)readBuffer[ControllerBytes(SelectedPort)[1]] == 8)//Y Button
                        YLabel.Invoke(new Action(() => YLabel.Text = "Pressed"));
                    else
                        YLabel.Invoke(new Action(() => YLabel.Text = "Not Pressed"));

                    //DPad Buttons
                    switch ((int)readBuffer[ControllerBytes(SelectedPort)[1]])
                    {
                        case 16:
                            DPLabel.Invoke(new Action(() => DPLabel.Text = "Left"));
                            break;
                        case 32:
                            DPLabel.Invoke(new Action(() => DPLabel.Text = "Right"));
                            break;
                        case 64:
                            DPLabel.Invoke(new Action(() => DPLabel.Text = "Down"));
                            break;
                        case 128:
                            DPLabel.Invoke(new Action(() => DPLabel.Text = "Up"));
                            break;
                        default:
                            DPLabel.Invoke(new Action(() => DPLabel.Text = "Not Pressed"));
                            break;
                    }

                    //Other Buttons
                    if ((int)readBuffer[ControllerBytes(SelectedPort)[2]] == 1)//Start Button
                        StartLabel.Invoke(new Action(() => StartLabel.Text = "Pressed"));
                    else
                        StartLabel.Invoke(new Action(() => StartLabel.Text = "Not Pressed"));

                    if ((int)readBuffer[ControllerBytes(SelectedPort)[2]] == 2)//Z Button
                        ZLabel.Invoke(new Action(() => ZLabel.Text = "Pressed"));
                    else
                        ZLabel.Invoke(new Action(() => ZLabel.Text = "Not Pressed"));

                    if ((int)readBuffer[ControllerBytes(SelectedPort)[2]] == 4)//R Digital Button
                        RLabel.Invoke(new Action(() => RLabel.Text = "Pressed"));
                    else
                        RLabel.Invoke(new Action(() => RLabel.Text = "Not Pressed"));

                    if ((int)readBuffer[ControllerBytes(SelectedPort)[2]] == 8)//L Digital Button
                        LLabel.Invoke(new Action(() => LLabel.Text = "Pressed"));
                    else
                        LLabel.Invoke(new Action(() => LLabel.Text = "Not Pressed"));

                    //Ananlog input from triggers
                    LTLabel.Invoke(new Action(() => LTLabel.Text = readBuffer[ControllerBytes(SelectedPort)[7]].ToString()));//Left Trigger Analog
                    RTLabel.Invoke(new Action(() => RTLabel.Text = readBuffer[ControllerBytes(SelectedPort)[8]].ToString()));//Right Trigger Analog

                    //Debug/ Raw input Labels
                    FBLabel.Invoke(new Action(() => FBLabel.Text = "" + (int)readBuffer[ControllerBytes(SelectedPort)[1]]));
                    OBLabel.Invoke(new Action(() => OBLabel.Text = "" + (int)readBuffer[ControllerBytes(SelectedPort)[2]]));
                }
            });
        }

        //Changes the selected port 
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (this.selectPort.GetItemText(this.selectPort.SelectedItem))
            {
                case "Port 1":
                    SelectedPort = 1;
                    break;
                case "Port 2":
                    SelectedPort = 2;
                    break;
                case "Port 3":
                    SelectedPort = 3;
                    break;
                case "Port 4":
                    SelectedPort = 4;
                    break;
                default:
                    SelectedPort = 1;
                    break;
            }
        }

        //Returns the bytes for each port
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

        #region I messed up and created these whoops
        private void detectLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        #endregion


        bool debugbool = false;
        private async void debug_Click(object sender, EventArgs e)
        {
            byte[] test = { 0x12 };
            ec = writer.Write(test, 2000, out bytesWritten);
            debugbool = true;
        }

        public async Task pollADPTOrigin()
        {
            Task t = Task.Run(async () =>
            {
                byte[] readBuffer = new byte[50];
                while (ec == ErrorCode.None)
                {
                    int bytesRead;

                    // If the device hasn't sent data in the last 100 milliseconds,
                    // a timeout error (ec = IoTimedOut) will occur. 
                    ec = reader.Read(readBuffer, 100, out bytesRead);

                    if (bytesRead == 0) throw new Exception("No more bytes!");


                    if (debugbool)
                    {
                        for (int i = 0; i < 50; i++)
                        {
                            Console.Write(readBuffer[i] + " | ");
                        }
                        Console.WriteLine();
                        Console.WriteLine("-" + bytesRead + "-");
                        Console.WriteLine();
                        debugbool = false;
                    }

                    

                    
                }
            });
        }

        private async void TestRead_Click(object sender, EventArgs e)
        {
            await pollADPTOrigin();
        }
    }
}
