
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace CheckPort
{
    public partial class Form1 : Form
    {
        public const string greenTick = "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";

        public const string warningTick = "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";

        public const string c_allTests = "All Tests";

        public const string c_checkportbuttonGo = "Run Test";
        public const string c_checkportbuttonStop = "Stop Test";

        public class GlobalClass
        {
            private static string m_globalVar1;                      // Product Version
            private static string m_globalVar2;                      // Test Name
            private static bool m_globalVar3;                        // Thread running
            private static checklistCollection m_globalVar4;         // Checklist Collection
            private static Int32 m_globalVar5;                       // RPC dynamic port
            private static int m_globalVar6;                         // Port timeout value
            private static portlistitemCollection m_globalVar7;                // List for Port history
            private static bool m_globalVar8;                        // 

            public static string Version
            {
                get { return m_globalVar1; }
                set { m_globalVar1 = value; }
            }

            public static string TestName
            {
                get { return m_globalVar2; }
                set { m_globalVar2 = value; }
            }

            public static bool threadRunning
            {
                get { return m_globalVar3; }
                set { m_globalVar3 = value; }
            }

            public static checklistCollection checklistCol
            {
                get { return m_globalVar4; }
                set { m_globalVar4 = value; }
            }
            public static Int32 RPCDynamicPort
            {
                get { return m_globalVar5; }
                set { m_globalVar5 = value; }
            }

            public static int PortTimeout
            {
                get { return m_globalVar6; }
                set { m_globalVar6 = value; }
            }

            public static portlistitemCollection portHistory
            {
                get { return m_globalVar7; }
                set { m_globalVar7 = value; }
            }

            public static bool porthistoryEnabled
            {
                get { return m_globalVar8; }
                set { m_globalVar8 = value; }
            }
        }

        private Bitmap loadimagefromString(string Image)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(Image);

                MemoryStream ms = new MemoryStream(imageBytes);

                Bitmap streamImage = (Bitmap)Bitmap.FromStream(ms, true);

                return streamImage;
            }
            catch (Exception ee)
            {

            }

            return null;
        }

        public class messageBlock
        {
            public string State { get; set; }                           // State (Connected\Not Connected)
            public string ErrorCode { get; set; }                       // Error Code
            public string ErrorMessage { get; set; }                    // Error Message
            public string packetType { get; set; }                      // Packet Type (Udp\Tcp or Both)
            public int Port { get; set; }                               // Port
            public IPAddress Destination { get; set; }                  // Destination (Ip Address)
            public string portName { get; set; }                        // Port Name
            public string testName { get; set; }                        // Test Name
        }

        public class checklistItem
        {
            public string testName { get; set; }
            public string portName { get; set; }
            public int Port { get; set; }
            public string portType { get; set; }
            public IPAddress Destination { get; set; }
        }

        public class checklistCollection : System.Collections.CollectionBase
        {
            public void Add(checklistItem achecklistItem)
            {
                List.Add(achecklistItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public checklistItem Item(int Index)
            {
                return (checklistItem)List[Index];
            }
        }

        public class portlistItem
        {
            public int Port { get; set; }
            public string State { get; set; }
        }

        public class portlistitemCollection : System.Collections.CollectionBase
        {
            public void Add(portlistItem aportlistItem)
            {
                List.Add(aportlistItem);
            }

            public void RemoveAll()
            {
                for (int i = 0; i <= List.Count; i++)
                {
                    List.RemoveAt(i);
                }
            }

            public void Remove(int index)
            {
                if (index > Count - 1 || index < 0)
                {
                }
                else
                {
                    List.RemoveAt(index);
                }
            }

            public checklistItem Item(int Index)
            {
                return (checklistItem)List[Index];
            }

            public bool Contains(int intValue)
            {
                try
                {
                    foreach (portlistItem aPort in GlobalClass.portHistory)
                    {
                        if (aPort.Port == intValue)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception ee)
                {

                }

                return false;
            }
        }

        public Form1()
        {
            var arguments = new Dictionary<string, string>();

            foreach (var argument in Environment.GetCommandLineArgs())
            {
                try
                {
                    var elements = argument.ToLower().Split('=');
                    arguments.Add(elements[0], elements[1]);
                }
                catch (Exception ee)
                {
                    /// Could not split the command line
                }
            }

            if (arguments.Count > 0)
            {
                docmdLine(arguments);
            }

            InitializeComponent();
        }


        private string getpluralString(int theValue)
        {
            string returnString = "";

            if (theValue > 1)
            {
                returnString = "s";
            }

            return returnString;
        }

        private void docmdLine(Dictionary<string, string> myDictionary)
        {
            string myipAddress = "";
            int myPort = 0;

            if (myDictionary.Keys.Contains("ip"))
            {
                myipAddress = myDictionary["ip"];
            }

            if (myDictionary.Keys.Contains("port"))
            {
                myPort = Convert.ToInt32(myDictionary["port"]);
            }

            Console.WriteLine("Checking " + myipAddress + ":" + myPort);

            if (myipAddress != "" && myPort > 0)
            {
                // We're on

                Console.WriteLine("Checking " + myipAddress + ":" + myPort);

                messageBlock someBlock = new messageBlock();

                someBlock.packetType = "TCP";
                someBlock.portName = "Command Line entered Port";
                someBlock.testName = "Command Line";
                someBlock.Destination = (IPAddress)Dns.GetHostAddresses(myipAddress)[0];
                someBlock.Port = myPort;

                messageBlock returnedBlock = checkaPort(someBlock);

                Console.WriteLine("Output: " + returnedBlock.State);
            }

            Environment.Exit(1);
        }


        private void b_checkPort_Click(object sender, EventArgs e)
        {
            if (b_checkPort.Text == c_checkportbuttonGo && !GlobalClass.threadRunning) // Get underway as long as the thread is not currently running
            {
                updateLabel("Spinning up hold on ...");


                if (cb_clearList.Checked)
                {
                    dgv_Output.Rows.Clear();
                    dgv_Output.Refresh();
                }

                tss_Progress.Visible = true;

                GlobalClass.checklistCol = null;

                GlobalClass.portHistory = null;

                try
                {
                    GlobalClass.TestName = cb_Tests.SelectedItem.ToString();
                }
                catch (Exception ee)
                {
                    GlobalClass.TestName = "Could not get test name";
                }

                checklistItem singleportItem = new checklistItem();

                IPAddress ipAddress;

                try
                {
                    if (tb_Destination.Text.Contains(":"))
                    {                        
                        ipAddress = (IPAddress)Dns.GetHostAddresses(tb_Destination.Text)[0];
                    }
                    else
                    {
                        ipAddress = (IPAddress)Dns.GetHostAddresses(tb_Destination.Text)[0];
                    }                 

                    try
                    {
                        if (rb_singlePort.Checked)
                        {
                            updateLabel("Checking single port");

                            singleportItem.portType = this.cb_packetType.GetItemText(this.cb_packetType.SelectedItem);
                            singleportItem.portName = "Custom Port";
                            singleportItem.testName = "Single Port " + Convert.ToInt32(tb_Port.Text) + " check to " + ipAddress;
                            singleportItem.Port = Convert.ToInt32(tb_Port.Text);
                            singleportItem.Destination = ipAddress;

                            try
                            {
                                checklistCollection aCol = new checklistCollection();

                                aCol.Add(singleportItem);

                                GlobalClass.checklistCol = aCol;
                            }
                            catch
                            (Exception ee)
                            {

                            }
                        }

                        if (rb_multiplePorts.Checked)
                        {
                            updateLabel("Checking for CSV file in CWD");

                            // Read in the list of tests, the port names and port and build up a clItem collection

                            checklistCollection aCol = new checklistCollection();

                            try
                            {
                                string[] portDefinitions = File.ReadAllLines(System.IO.Directory.GetCurrentDirectory() + @"\Ports.csv");

                                var query = from portDefinition in portDefinitions
                                            let data = portDefinition.Split(',')
                                            select new
                                            {
                                                TestName = data[0],
                                                PortName = data[1],
                                                PortList = data[2],
                                                PortType = data[3],
                                            };

                                checklistCollection myCollection = new checklistCollection();

                                updateLabel("Found CSV, processing");

                                foreach (var element in query)
                                {
                                    string[] testSplit = new string[1];

                                    if (element.TestName.Contains("< -- >"))
                                    {
                                        testSplit = element.TestName.Split(new[] { "< -- >" }, StringSplitOptions.None);
                                    }

                                    if (element.TestName.Contains("-- >"))
                                    {
                                        testSplit = element.TestName.Split(new[] { "-- >" }, StringSplitOptions.None);
                                    }

                                    if (GlobalClass.TestName == c_allTests || GlobalClass.TestName.Replace("Group:", "") == element.TestName || GlobalClass.TestName.Replace("Group:", "") == testSplit[0])
                                    {
                                        string portName = element.PortName.ToString();
                                        string Ports = element.PortList.ToString();
                                        string testName = element.TestName.ToString();

                                        checklistItem clItem1 = new checklistItem();

                                        if (element.PortType != "")
                                        {
                                            clItem1.portType = element.PortType;
                                        }
                                        else
                                        {
                                            clItem1.portType = cb_packetType.SelectedItem.ToString(); // Will be Tcp until I implement Udp
                                        }

                                        clItem1.portName = element.PortName.ToString();
                                        clItem1.testName = element.TestName.ToString();
                                        clItem1.Port = Convert.ToInt32(element.PortList);
                                        clItem1.Destination = ipAddress;

                                        myCollection.Add(clItem1);
                                    }
                                }

                                GlobalClass.checklistCol = myCollection;
                            }
                            catch (Exception ee) // File doesn't exist or access to the file is denied
                            {
                                // Populate portDefinitions using internal copy                

                                updateLabel("CSV file not found in CWD, reverting to memory definition");

                                checklistCollection myCollection = new checklistCollection();

                                byte[] definitionBytes = Convert.FromBase64String(portdefinitionEncoded);

                                var table = (Encoding.Default.GetString(
                                 definitionBytes,
                                 0,
                                 definitionBytes.Length - 1)).Split(new string[] { "\r\n", "\r", "\n" },
                                                             StringSplitOptions.None);

                                foreach (string element in table)
                                {
                                    if (element != "")
                                    {
                                        string[] tempArray = element.Split(',');

                                        string[] testSplit = new string[1];

                                        if (tempArray[0].Contains("< -- >"))
                                        {
                                            testSplit = tempArray[0].Split(new[] { "< -- >" }, StringSplitOptions.None);
                                        }

                                        if (tempArray[0].Contains("-- >"))
                                        {
                                            testSplit = tempArray[0].Split(new[] { "-- >" }, StringSplitOptions.None);
                                        }

                                        if (GlobalClass.TestName == c_allTests || GlobalClass.TestName.Replace("Group:", "") == tempArray[0] || GlobalClass.TestName.Replace("Group:", "") == testSplit[0])
                                        {
                                            string portName = tempArray[1];
                                            string Ports = tempArray[2];
                                            string testName = tempArray[0];

                                            checklistItem clItem1 = new checklistItem();

                                            try
                                            {
                                                if (tempArray[3] != "")
                                                {
                                                    clItem1.portType = tempArray[3];
                                                }
                                                else
                                                {
                                                    clItem1.portType = cb_packetType.SelectedItem.ToString(); // Will be Tcp until I implement Udp
                                                }
                                            }
                                            catch (Exception eee)
                                            {
                                                clItem1.portType = cb_packetType.SelectedItem.ToString(); // Will be Tcp until I implement Udp
                                            }

                                            clItem1.portType = cb_packetType.SelectedItem.ToString(); // Will be Tcp until I implement Udp

                                            clItem1.portName = tempArray[1];
                                            clItem1.testName = tempArray[0];
                                            clItem1.Port = Convert.ToInt32(tempArray[2]);
                                            clItem1.Destination = ipAddress;

                                            myCollection.Add(clItem1);
                                        }
                                    }
                                }

                                GlobalClass.checklistCol = myCollection;
                            }
                        }

                        // Setup the background worker thread to handle the port checking, freeing up the UI thread

                        BackgroundWorker bw = new BackgroundWorker();
                        bw.WorkerSupportsCancellation = true;
                        bw.WorkerReportsProgress = true;
                        bw.DoWork +=
                            new DoWorkEventHandler(bw_DoWork);
                        bw.ProgressChanged +=
                            new ProgressChangedEventHandler(bw_ProgressChanged);
                        bw.RunWorkerCompleted +=
                            new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

                        // Setup the spinWheel background worker thread, deprecated

                        //BackgroundWorker spinWheel = new BackgroundWorker();
                        //spinWheel.WorkerSupportsCancellation = true;
                        //spinWheel.WorkerReportsProgress = true;
                        //spinWheel.DoWork +=
                        //    new DoWorkEventHandler(bw_spinWheel_DoWork);
                        //spinWheel.ProgressChanged +=
                        //    new ProgressChangedEventHandler(bw_spinWheel_ProgressChanged);
                        //spinWheel.RunWorkerCompleted +=
                        //    new RunWorkerCompletedEventHandler(bw_spinWheel_RunWorkerCompleted);


                        // Get the destination\target address

                        string Destination = tb_Destination.Text;

                        try
                        {
                            updateLabel("Port query in progress ...");

                            if (bw.IsBusy != true)
                            {
                                tss_Progress.MarqueeAnimationSpeed = 30;

                                tss_Progress.Style = ProgressBarStyle.Marquee;

                                // spinWheel.RunWorkerAsync(); // Start spinning the wheel

                                GlobalClass.threadRunning = true;

                                bw.RunWorkerAsync(); // Check the port or ports

                                // Set the text of the Go button for cancelling the thread

                                b_checkPort.Text = c_checkportbuttonStop;
                            }
                        }
                        catch (Exception ee)
                        {
                            tss_Progress.Visible = false;

                            updateLabel("Fatal error: " + ee.Message);
                        }
                    }
                    catch (Exception ee)
                    {
                        tss_Progress.Visible = false;

                        updateLabel("Fatal error: " + ee.Message);
                    }
                }
                catch (Exception ee)
                {
                    tss_Progress.Visible = false;

                    updateLabel("Destination could not be resolved");
                }
            }
            else
            {
                GlobalClass.threadRunning = false; // Set the trigger to stop the thread from running
            }
        }

        private void updateLabel(string myText)
        {
            tss_Text.Text = myText;

            Size myLabel = (Size)tss_Text.Size;
            Size statusstripSize = (Size)ss_Progress.Size;

            int mylabelWidth = (int)myLabel.Width;
            int statusstripsizeHeight = (int)statusstripSize.Height;
            int statusstripsizeWidth = (int)statusstripSize.Width;

            int myWidth = statusstripsizeWidth - mylabelWidth;

            Size mySize = new Size(myWidth - 30, statusstripsizeHeight);

            tss_Progress.Size = mySize;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == false)
            {

            }

            tss_Progress.MarqueeAnimationSpeed = 0;
            tss_Progress.Value = 0;
            tss_Progress.Style = ProgressBarStyle.Continuous;

            updateLabel("Port checking complete.");

            if (rb_singlePort.Checked)
            {

                if (tb_Destination.Text == "" || tb_Port.Text == "")
                {
                    b_checkPort.Enabled = false;
                }
                else
                {
                    b_checkPort.Enabled = true;
                }
            }
            else
            {
                if (tb_Destination.Text == "")
                {
                    b_checkPort.Enabled = false;
                }
                else
                {
                    b_checkPort.Enabled = true;
                }
            }

            b_checkPort.Text = c_checkportbuttonGo;

            tss_Progress.Visible = false;

            GlobalClass.threadRunning = false;
        }

        public messageBlock checkaPort(messageBlock mymessageBlock)
        {
            System.Net.Sockets.Socket ipSocket;

            // mymessageBlock.State = "";

            messageBlock returnedmessageBlock = new messageBlock();

            returnedmessageBlock.Port = mymessageBlock.Port;
            returnedmessageBlock.Destination = mymessageBlock.Destination;
            returnedmessageBlock.packetType = mymessageBlock.packetType;
            returnedmessageBlock.testName = mymessageBlock.testName;
            returnedmessageBlock.portName = mymessageBlock.portName;

            bool iConnected = false;
            bool iSent = false;

            if (returnedmessageBlock.packetType == "Tcp" || returnedmessageBlock.packetType == "Both")
            {
                try
                {
                    ipSocket = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                    ipSocket.SendTimeout = GlobalClass.PortTimeout * 1000; // Set Port time to seconds * 1000 milliseconds

                    ipSocket.ReceiveTimeout = GlobalClass.PortTimeout * 1000; // Set Port time to seconds * 1000 milliseconds

                    if (returnedmessageBlock.portName != "RPC")
                    {
                        try
                        {
                            IAsyncResult myResult = ipSocket.BeginConnect(returnedmessageBlock.Destination, returnedmessageBlock.Port, null, null);

                            bool weConnected = myResult.AsyncWaitHandle.WaitOne(GlobalClass.PortTimeout * 1000, true);

                            if (weConnected)
                            {
                                iConnected = true;

                                try
                                {
                                    Byte[] sendBytes = Encoding.UTF8.GetBytes("?");

                                    int totalbytesSent = ipSocket.Send(sendBytes);

                                    iSent = true;

                                    ipSocket.EndConnect(myResult);

                                }
                                catch (SocketException ee)
                                {
                                    // Failed to send do nothing
                                }
                            }
                        }
                        catch (SocketException ee)
                        {
                            // Timed out do nothing
                        }

                        //ipSocket.Blocking

                        if (iConnected && iSent)
                        {
                            returnedmessageBlock.State = "Connected";
                            returnedmessageBlock.ErrorCode = "";
                            returnedmessageBlock.ErrorMessage = "";
                        }
                        else
                        {
                            returnedmessageBlock.State = "Failure";
                            returnedmessageBlock.ErrorCode = "";
                            returnedmessageBlock.ErrorMessage = "";
                        }

                        ipSocket.Close();

                        // System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        returnedmessageBlock.Port = GlobalClass.RPCDynamicPort; // Low RPC Range Port

                        try
                        {
                            ipSocket.Blocking = false;

                            IAsyncResult result = ipSocket.BeginConnect(returnedmessageBlock.Destination, returnedmessageBlock.Port, null, null);

                            bool success = result.AsyncWaitHandle.WaitOne(GlobalClass.PortTimeout * 1000, true);

                            if (success)
                            {
                                iConnected = true;

                                try
                                {
                                    Byte[] sendBytes = Encoding.UTF8.GetBytes("?");

                                    int totalbytesSent = ipSocket.Send(sendBytes);

                                    iSent = true;

                                    ipSocket.EndConnect(result);
                                }
                                catch (SocketException ee)
                                {
                                    // Failed to send do nothing
                                }
                            }
                            else
                            {

                            }
                        }
                        catch (SocketException ee)
                        {
                            // Timed out do nothing
                        }

                        if (iConnected && iSent)
                        {
                            returnedmessageBlock.State = "Connected";
                            returnedmessageBlock.ErrorCode = "";
                            returnedmessageBlock.ErrorMessage = "";
                        }
                        else
                        {
                            returnedmessageBlock.State = "Failure";
                            returnedmessageBlock.ErrorCode = "";
                            returnedmessageBlock.ErrorMessage = "";
                        }

                        ipSocket.Close();
                    }
                }
                catch (System.Net.Sockets.SocketException ee)
                {
                    returnedmessageBlock.State = "Failure";
                    returnedmessageBlock.ErrorCode = ee.ErrorCode.ToString();
                    returnedmessageBlock.ErrorMessage = ee.Message.ToString();
                }
            }

            return returnedmessageBlock;
        }

        private string getporthistoryState(int aPort)
        {
            foreach (portlistItem ahistoryPort in GlobalClass.portHistory)
            {
                if (ahistoryPort.Port == aPort)
                {
                    return ahistoryPort.State;
                }
            }

            return "";
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (GlobalClass.checklistCol != null)
            {
                foreach (checklistItem theclItem in GlobalClass.checklistCol)
                {
                    if (GlobalClass.threadRunning)
                    {
                        messageBlock someBlock = new messageBlock();

                        someBlock.packetType = theclItem.portType;
                        someBlock.portName = theclItem.portName;
                        someBlock.testName = theclItem.testName;
                        someBlock.Destination = theclItem.Destination;

                        if (someBlock.portName != "RPC")
                        {
                            someBlock.Port = theclItem.Port;
                        }
                        else
                        {
                            someBlock.Port = GlobalClass.RPCDynamicPort;
                        }

                        if (GlobalClass.porthistoryEnabled)
                        {
                            bool porthistoryExists = false;

                            try
                            {
                                if (GlobalClass.portHistory.Contains(someBlock.Port))
                                {
                                    porthistoryExists = true;
                                }

                            }
                            catch (Exception ee)
                            {

                            }

                            if (porthistoryExists)
                            {
                                someBlock.State = getporthistoryState(someBlock.Port);

                                worker.ReportProgress(0, someBlock);
                            }
                            else
                            {
                                messageBlock returnBlock = checkaPort(someBlock);

                                worker.ReportProgress(0, returnBlock);

                                // Add the entry to the port history collection

                                portlistItem anewPort = new portlistItem();

                                anewPort.Port = returnBlock.Port;
                                anewPort.State = returnBlock.State;

                                try
                                {
                                    portlistitemCollection tempCol = GlobalClass.portHistory;

                                    tempCol.Add(anewPort);
                                }
                                catch (Exception ee)
                                {
                                    portlistitemCollection tempCol = new portlistitemCollection();

                                    tempCol.Add(anewPort);

                                    GlobalClass.portHistory = tempCol;
                                }
                            }
                        }
                        else
                        {
                            messageBlock returnBlock = checkaPort(someBlock);

                            worker.ReportProgress(0, returnBlock);
                        }
                    }
                    else
                    {
                        break; // Thread has been told to stop
                    }
                }
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            messageBlock passedBlock = (messageBlock)e.UserState;

            Bitmap x;

            string anyThing = "";

            if (passedBlock.State == "Connected")
            {
                x = new Bitmap(loadimagefromString(greenTick));

                anyThing = passedBlock.State + "|Green";
            }
            else
            {
                x = new Bitmap(loadimagefromString(warningTick));

                anyThing = passedBlock.State + "|Warning";
            }

            try
            {
                if (anyThing == "Connected|Warning")
                {
                    x = new Bitmap(loadimagefromString(greenTick));
                }

                dgv_Output.Rows.Add(passedBlock.testName, passedBlock.portName, passedBlock.Port, passedBlock.State.ToString(), x);

                int nrowIndex = dgv_Output.Rows.Count - 1;

                int nColumnIndex = 3;

                if (passedBlock.State == "Failure")
                {
                    DataGridViewRow aRow = dgv_Output.Rows[nrowIndex];

                    aRow.DefaultCellStyle.BackColor = Color.Olive;
                }

                dgv_Output.Rows[nrowIndex].Selected = true;
                dgv_Output.Rows[nrowIndex].Cells[nColumnIndex].Selected = true;
                dgv_Output.FirstDisplayedScrollingRowIndex = nrowIndex;
            }
            catch (Exception ee)
            {
                // That block wasn't added to the DGV
            }
        }

        private void bw_spinWheel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == false)
            {

            }
        }

        private void bw_spinWheel_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
        }

        private void bw_spinWheel_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_multiplePorts.Checked)
            {
                l_Type.Enabled = false;
                cb_packetType.Enabled = false;
                label1.Enabled = true;
                label2.Enabled = false;
                tb_Destination.Enabled = true;
                tb_Port.Enabled = false;
                cb_Tests.Enabled = true;

                l_rpcDynamic.Enabled = true;
                tb_rpcDynamic.Enabled = true;

                if (tb_Destination.Text != "")
                {
                    b_checkPort.Enabled = true;
                }
                else
                {
                    b_checkPort.Enabled = false;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_singlePort.Checked)
            {
                l_Type.Enabled = true;
                cb_packetType.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                tb_Destination.Enabled = true;
                tb_Port.Enabled = true;
                cb_Tests.Enabled = false;

                l_rpcDynamic.Enabled = false;
                tb_rpcDynamic.Enabled = false;

                if (!GlobalClass.threadRunning)
                {
                    if (tb_Destination.Text == "" || tb_Port.Text == "")
                    {
                        b_checkPort.Enabled = false;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set tool version

            GlobalClass.Version = "1.0";

            b_checkPort.Text = c_checkportbuttonGo;

            List<string> testNames = new List<string>();

            // Set the port timeout label to the trackbar's value

            tb_portTimeout.Value = 2;

            l_porttimeValue.Text = tb_portTimeout.Value.ToString() + " second" + getpluralString(tb_portTimeout.Value);

            GlobalClass.PortTimeout = tb_portTimeout.Value;

            // Initialise the RPC Dynamic port low-range number

            tb_rpcDynamic.Text = "49152"; 

            GlobalClass.RPCDynamicPort = 49152;

            // Set what is visible or enabled on first load

            tss_Progress.Visible = false;

            l_rpcDynamic.Enabled = false;
            tb_rpcDynamic.Enabled = false;

            b_checkPort.Enabled = false;

            // Port history Enabled

            cb_scanuniquePorts.Enabled = true;

            GlobalClass.porthistoryEnabled = true;
            
            // Read Port definitions from a CSV file

            updateLabel("Checking for CSV file in CWD ...");

            try
            {
                string dfdfd = System.IO.Directory.GetCurrentDirectory();
                string[] portDefinitions = File.ReadAllLines(System.IO.Directory.GetCurrentDirectory() + @"\Ports.csv");

                var query = from portDefinition in portDefinitions
                            let data = portDefinition.Split(',')
                            select new
                            {
                                TestName = data[0],
                                PortName = data[1],
                                PortList = data[2],
                                PortType = data[3],
                            };

                foreach (var element in query)
                {
                    if (!testNames.Contains(element.TestName))
                    {
                        testNames.Add(element.TestName);
                    }
                }
            }
            catch (Exception ee) // File doesn't exist or access to the file is denied so populate port definitions
            {
                updateLabel("CSV in CWD not found, using memory definition ...");

                byte[] definitionBytes = Convert.FromBase64String(portdefinitionEncoded);

                var table = (Encoding.Default.GetString(definitionBytes, 0, definitionBytes.Length - 1)).Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                foreach (string element in table)
                {
                    string[] tempArray = element.Split(',');

                    if (!testNames.Contains(tempArray[0]))
                    {
                        testNames.Add(tempArray[0]);
                    }
                }
            }

            // Now process the Test names and produce the categories

            updateLabel("Populating Tests");

            cb_Tests.Items.Add(c_allTests); // Add all tests option

            cb_Tests.Items.Add("-------");

            foreach (string testName in testNames) // Add categories
            {
                string[] testSplit = new string[1];

                if (testName.Contains("< -- >"))
                {
                    testSplit = testName.Split(new[] { "< -- >" }, StringSplitOptions.None);
                }
                else if (testName.Contains("-- >"))
                {
                    testSplit = testName.Split(new[] { "-- >" }, StringSplitOptions.None);
                }

                if (testSplit[0] != "")
                {
                    if (!cb_Tests.Items.Contains("Group:" + testSplit[0]))
                    {
                        if (testSplit[0] != null)
                        {
                            cb_Tests.Items.Add("Group:" + testSplit[0]);
                        }
                    }
                }
            }

            cb_Tests.Items.Add("-------");

            foreach (string testName in testNames) // Add full test names
            {
                if (testName != "" && testName != null)
                {
                    cb_Tests.Items.Add(testName);
                }
            }

            // Set Combobox selevted row

            cb_Tests.SelectedIndex = 0;

            // Set Application Title

            this.Text = "CheckPort " + " - V" + GlobalClass.Version;

            // Populate combobox

            cb_packetType.Items.Insert(0, "Tcp");
            // cb_packetType.Items.Insert(1,"Udp");
            // cb_packetType.Items.Insert(2,"Both");
            cb_packetType.SelectedIndex = 0;

            updateLabel("Ready");
        }

        private void b_clearList_Click(object sender, EventArgs e)
        {
            dgv_Output.Rows.Clear();
            dgv_Output.Refresh();
        }

        private void ss_Progress_Resize(object sender, EventArgs e)
        {
            Size myLabel = (Size)tss_Text.Size;
            Size statusstripSize = (Size)ss_Progress.Size;

            int mylabelWidth = (int)myLabel.Width;
            int statusstripsizeHeight = (int)statusstripSize.Height;
            int statusstripsizeWidth = (int)statusstripSize.Width;

            int myWidth = statusstripsizeWidth - mylabelWidth;

            Size mySize = new Size(myWidth - 30, statusstripsizeHeight);

            tss_Progress.Size = mySize;
        }

        private void b_Clipboard_Click(object sender, EventArgs e)
        {
            dgv_Output.MultiSelect = true;
            dgv_Output.SelectAll();
            DataObject dataObj = dgv_Output.GetClipboardContent();
            dgv_Output.MultiSelect = false;
            try
            {
                Clipboard.SetDataObject(dataObj, true);

                dgv_Output.ClearSelection();

                updateLabel("Copied contents to the Clipboard");
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("Value cannot be null"))
                {
                    updateLabel("Nothing to copy to the clipboard right now.");
                }
                else
                {
                    updateLabel("Problem copying contents to the Clipboard.");
                }
            }
        }

        private void tb_rpcDynamic_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.RPCDynamicPort = Convert.ToInt32(tb_rpcDynamic.Text);
            }
            catch (Exception ee)
            {
                GlobalClass.RPCDynamicPort = 49152;
            }
        }

        private void tb_portTimeout_ValueChanged(object sender, EventArgs e)
        {
            l_porttimeValue.Text = tb_portTimeout.Value.ToString() + " second" + getpluralString(tb_portTimeout.Value);

            GlobalClass.PortTimeout = tb_portTimeout.Value;
        }

        private void tb_Destination_TextChanged(object sender, EventArgs e)
        {
            if (!GlobalClass.threadRunning)
            {
                if (rb_singlePort.Checked)
                {
                    if (tb_Destination.Text != "")
                    {
                        if (tb_Port.Text != "")
                        {
                            b_checkPort.Enabled = true;
                        }
                    }
                    else
                    {
                        b_checkPort.Enabled = false;
                    }
                }
                else // Multiple port test selected
                {
                    if (tb_Destination.Text != "")
                    {
                        b_checkPort.Enabled = true;
                    }
                    else
                    {
                        if (!GlobalClass.threadRunning)
                        {
                            b_checkPort.Enabled = false;
                        }
                    }
                }
            }
        }

        private void tb_Port_TextChanged(object sender, EventArgs e)
        {
            if (!GlobalClass.threadRunning)
            {
                if (rb_singlePort.Checked)
                {
                    if (tb_Port.Text != "")
                    {
                        if (tb_Destination.Text != "")
                        {
                            b_checkPort.Enabled = true;
                        }
                    }
                    else
                    {
                        b_checkPort.Enabled = false;
                    }
                }
            }
        }

        private void cb_scanuniquePorts_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_scanuniquePorts.Checked)
            {
                GlobalClass.porthistoryEnabled = true;
            }
            else
            {
                GlobalClass.porthistoryEnabled = false;
            }
        }


        public const string portdefinitionEncoded = @"QXBwbGljYXRpb24gQ2F0YWxvZyBXZWIgU2VydmljZSBQb2ludCAtLSA+IFNRTCBTZXJ2ZXIsU1FM
IG92ZXIgVENQLDE0MzMsVGNwDQpBcHBsaWNhdGlvbiBDYXRhbG9nIFdlYnNpdGUgUG9pbnQgLS0g
PiBBcHBsaWNhdGlvbiBDYXRhbG9nIFdlYiBTZXJ2aWNlIFBvaW50LEh5cGVydGV4dCBUcmFuc2Zl
ciBQcm90b2NvbCAoSFRUUCksODAsVGNwDQpBcHBsaWNhdGlvbiBDYXRhbG9nIFdlYnNpdGUgUG9p
bnQgLS0gPiBBcHBsaWNhdGlvbiBDYXRhbG9nIFdlYiBTZXJ2aWNlIFBvaW50LFNlY3VyZSBIeXBl
cnRleHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFBTKSw0NDMsVGNwDQpBc3NldCBJbnRlbGxpZ2Vu
Y2UgU3luY2hyb25pemF0aW9uIFBvaW50IC0tID4gTWljcm9zb2Z0LFNlY3VyZSBIeXBlcnRleHQg
VHJhbnNmZXIgUHJvdG9jb2wgKEhUVFBTKSw0NDMsVGNwDQpBc3NldCBJbnRlbGxpZ2VuY2UgU3lu
Y2hyb25pemF0aW9uIFBvaW50IC0tID4gU1FMIFNlcnZlcixTUUwgb3ZlciBUQ1AsMTQzMyxUY3AN
CkNsaWVudCAtLSA+IEFwcGxpY2F0aW9uIENhdGFsb2cgV2Vic2l0ZSBQb2ludCxIeXBlcnRleHQg
VHJhbnNmZXIgUHJvdG9jb2wgKEhUVFApLDgwLFRjcA0KQ2xpZW50IC0tID4gQXBwbGljYXRpb24g
Q2F0YWxvZyBXZWJzaXRlIFBvaW50LFNlY3VyZSBIeXBlcnRleHQgVHJhbnNmZXIgUHJvdG9jb2wg
KEhUVFBTKSw0NDMsVGNwDQpDbGllbnQgLS0gPiBDbGllbnQsV2FrZSBvbiBMQU4sOSxVZHANCkNs
aWVudCAtLSA+IENsaWVudCxXYWtlLXVwIHByb3h5LDI1NTM2LFVkcA0KQ2xpZW50IC0tID4gQ2xv
dWQtQmFzZWQgRGlzdHJpYnV0aW9uIFBvaW50LFNlY3VyZSBIeXBlcnRleHQgVHJhbnNmZXIgUHJv
dG9jb2wgKEhUVFBTKSw0NDMsVGNwDQpDbGllbnQgLS0gPiBDb25maWd1cmF0aW9uIE1hbmFnZXIg
UG9saWN5IE1vZHVsZSAoTmV0d29yayBEZXZpY2UgRW5yb2xsbWVudCBTZXJ2aWNlKSxIeXBlcnRl
eHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFApLDgwLFRjcA0KQ2xpZW50IC0tID4gQ29uZmlndXJh
dGlvbiBNYW5hZ2VyIFBvbGljeSBNb2R1bGUgKE5ldHdvcmsgRGV2aWNlIEVucm9sbG1lbnQgU2Vy
dmljZSksU2VjdXJlIEh5cGVydGV4dCBUcmFuc2ZlciBQcm90b2NvbCAoSFRUUFMpLDQ0MyxUY3AN
CkNsaWVudCAtLSA+IERpc3RyaWJ1dGlvbiBQb2ludCxIeXBlcnRleHQgVHJhbnNmZXIgUHJvdG9j
b2wgKEhUVFApLDgwLFRjcA0KQ2xpZW50IC0tID4gRGlzdHJpYnV0aW9uIFBvaW50LFNlY3VyZSBI
eXBlcnRleHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFBTKSw0NDMsVGNwDQpDbGllbnQgLS0gPiBE
aXN0cmlidXRpb24gUG9pbnQgQ29uZmlndXJlZCBmb3IgTXVsdGljYXN0LFNlcnZlciBNZXNzYWdl
IEJsb2NrIChTTUIpLDQ0NSxUY3ANCkNsaWVudCAtLSA+IEZhbGxiYWNrIFN0YXR1cyBQb2ludCxI
eXBlcnRleHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFApLDgwLFRjcA0KQ2xpZW50IC0tID4gR2xv
YmFsIENhdGFsb2cgRG9tYWluIENvbnRyb2xsZXIsR2xvYmFsIENhdGFsb2cgTERBUCwzMjY4LFRj
cA0KQ2xpZW50IC0tID4gR2xvYmFsIENhdGFsb2cgRG9tYWluIENvbnRyb2xsZXIsR2xvYmFsIENh
dGFsb2cgTERBUCBTU0wsMzI2OSxUY3ANCkNsaWVudCAtLSA+IE1hbmFnZW1lbnQgUG9pbnQsSHlw
ZXJ0ZXh0IFRyYW5zZmVyIFByb3RvY29sIChIVFRQKSw4MCxUY3ANCkNsaWVudCAtLSA+IE1hbmFn
ZW1lbnQgUG9pbnQsU2VjdXJlIEh5cGVydGV4dCBUcmFuc2ZlciBQcm90b2NvbCAoSFRUUFMpLDQ0
MyxUY3ANCkNsaWVudCAtLSA+IE1hbmFnZW1lbnQgUG9pbnQsTm90aWZpY2F0aW9uIENoYW5uZWws
MTAxMjMsVGNwDQpDbGllbnQgLS0gPiBTb2Z0d2FyZSBVcGRhdGUgUG9pbnQsSHlwZXJ0ZXh0IFRy
YW5zZmVyIFByb3RvY29sIChIVFRQKSw4MCxUY3ANCkNsaWVudCAtLSA+IFNvZnR3YXJlIFVwZGF0
ZSBQb2ludCxTZWN1cmUgSHlwZXJ0ZXh0IFRyYW5zZmVyIFByb3RvY29sIChIVFRQUyksNDQzLFRj
cA0KQ2xpZW50IC0tID4gU29mdHdhcmUgVXBkYXRlIFBvaW50LFdpbmRvd3MgU2VydmVyIFVwZGF0
ZSBTZXJ2aWNlcyw4NTMwLFRjcA0KQ2xpZW50IC0tID4gU29mdHdhcmUgVXBkYXRlIFBvaW50LFNl
Y3VyZSBXaW5kb3dzIFNlcnZlciBVcGRhdGUgU2VydmljZXMsODUzMSxUY3ANCkNsaWVudCAtLSA+
IFN0YXRlIE1pZ3JhdGlvbiBQb2ludCxIeXBlcnRleHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFAp
LDgwLFRjcA0KQ2xpZW50IC0tID4gU3RhdGUgTWlncmF0aW9uIFBvaW50LFNlY3VyZSBIeXBlcnRl
eHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFBTKSw0NDMsVGNwDQpDbGllbnQgLS0gPiBTdGF0ZSBN
aWdyYXRpb24gUG9pbnQsU2VydmVyIE1lc3NhZ2UgQmxvY2sgKFNNQiksNDQ1LFRjcA0KQ29uZmln
dXJhdGlvbiBNYW5hZ2VyIENvbnNvbGUgLS0gPiBDbGllbnQsUmVtb3RlIENvbnRyb2wgKGNvbnRy
b2wpLDI3MDEsVGNwDQpDb25maWd1cmF0aW9uIE1hbmFnZXIgQ29uc29sZSAtLSA+IENsaWVudCxS
ZW1vdGUgQXNzaXN0YW5jZSAoUkRQIGFuZCBSVEMpLDMzODksVGNwDQpDb25maWd1cmF0aW9uIE1h
bmFnZXIgQ29uc29sZSAtLSA+IEludGVybmV0LEh5cGVydGV4dCBUcmFuc2ZlciBQcm90b2NvbCAo
SFRUUCksODAsVGNwDQpDb25maWd1cmF0aW9uIE1hbmFnZXIgQ29uc29sZSAtLSA+IFJlcG9ydGlu
ZyBTZXJ2aWNlcyBQb2ludCxIeXBlcnRleHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFApLDgwLFRj
cA0KQ29uZmlndXJhdGlvbiBNYW5hZ2VyIENvbnNvbGUgLS0gPiBSZXBvcnRpbmcgU2VydmljZXMg
UG9pbnQsU2VjdXJlIEh5cGVydGV4dCBUcmFuc2ZlciBQcm90b2NvbCAoSFRUUFMpLDQ0MyxUY3AN
CkNvbmZpZ3VyYXRpb24gTWFuYWdlciBDb25zb2xlIC0tID4gU2l0ZSBTZXJ2ZXIsUlBDIEVuZHBv
aW50IE1hcHBlciwxMzUsVGNwDQpDb25maWd1cmF0aW9uIE1hbmFnZXIgQ29uc29sZSAtLSA+IFNN
UyBQcm92aWRlcixSUEMsMSxUY3ANCkNvbmZpZ3VyYXRpb24gTWFuYWdlciBDb25zb2xlIC0tID4g
U01TIFByb3ZpZGVyLFJQQyBFbmRwb2ludCBNYXBwZXIsMTM1LFRjcA0KQ29uZmlndXJhdGlvbiBN
YW5hZ2VyIFBvbGljeSBNb2R1bGUgKE5ldHdvcmsgRGV2aWNlIEVucm9sbG1lbnQgU2VydmljZSkg
LS0gPiBDZXJ0aWZpY2F0ZSBSZWdpc3RyYXRpb24gUG9pbnQsU2VjdXJlIEh5cGVydGV4dCBUcmFu
c2ZlciBQcm90b2NvbCAoSFRUUFMpLDQ0MyxUY3ANCkRpc3RyaWJ1dGlvbiBQb2ludCAtLSA+IE1h
bmFnZW1lbnQgUG9pbnQsSHlwZXJ0ZXh0IFRyYW5zZmVyIFByb3RvY29sIChIVFRQKSw4MCxUY3AN
CkRpc3RyaWJ1dGlvbiBQb2ludCAtLSA+IE1hbmFnZW1lbnQgUG9pbnQsU2VjdXJlIEh5cGVydGV4
dCBUcmFuc2ZlciBQcm90b2NvbCAoSFRUUFMpLDQ0MyxUY3ANCkVuZHBvaW50IFByb3RlY3Rpb24g
UG9pbnQgLS0gPiBJbnRlcm5ldCxIeXBlcnRleHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFApLDgw
LFRjcA0KRW5kcG9pbnQgUHJvdGVjdGlvbiBQb2ludCAtLSA+IFNRTCBTZXJ2ZXIsU1FMIG92ZXIg
VENQLDE0MzMsVGNwDQpFbnJvbGxtZW50IFBvaW50IC0tID4gU1FMIFNlcnZlcixTUUwgb3ZlciBU
Q1AsMTQzMyxUY3ANCkVucm9sbG1lbnQgUHJveHkgUG9pbnQgLS0gPiBFbnJvbGxtZW50IFBvaW50
LFNlY3VyZSBIeXBlcnRleHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFBTKSw0NDMsVGNwDQpFeGNo
YW5nZSBTZXJ2ZXIgQ29ubmVjdG9yIC0tID4gRXhjaGFuZ2UgT25saW5lLFdpbmRvd3MgUmVtb3Rl
IE1hbmFnZW1lbnQgb3ZlciBIVFRQUyw1OTg2LFRjcA0KRXhjaGFuZ2UgU2VydmVyIENvbm5lY3Rv
ciAtLSA+IE9uIFByZW1pc2VzIEV4Y2hhbmdlIFNlcnZlcixXaW5kb3dzIFJlbW90ZSBNYW5hZ2Vt
ZW50IG92ZXIgSFRUUCw1OTg1LFRjcA0KTWFjIENvbXB1dGVyIC0tID4gRW5yb2xsbWVudCBQcm94
eSBQb2ludCxTZWN1cmUgSHlwZXJ0ZXh0IFRyYW5zZmVyIFByb3RvY29sIChIVFRQUyksNDQzLFRj
cA0KTWFuYWdlbWVudCBQb2ludCAtLSA+IERvbWFpbiBDb250cm9sbGVyLFJQQywxLFRjcA0KTWFu
YWdlbWVudCBQb2ludCAtLSA+IERvbWFpbiBDb250cm9sbGVyLFJQQyBFbmRwb2ludCBNYXBwZXIs
MTM1LFRjcA0KTWFuYWdlbWVudCBQb2ludCAtLSA+IERvbWFpbiBDb250cm9sbGVyLExpZ2h0d2Vp
Z2h0IERpcmVjdG9yeSBBY2Nlc3MgUHJvdG9jb2wgKExEQVApLDM4OSxUY3ANCk1hbmFnZW1lbnQg
UG9pbnQgLS0gPiBEb21haW4gQ29udHJvbGxlcixMREFQIChTZWN1cmUgU29ja2V0cyBMYXllciBb
U1NMXSBjb25uZWN0aW9uKSw2MzYsVGNwDQpNYW5hZ2VtZW50IFBvaW50IC0tID4gRG9tYWluIENv
bnRyb2xsZXIsR2xvYmFsIENhdGFsb2cgTERBUCwzMjY4LFRjcA0KTWFuYWdlbWVudCBQb2ludCAt
LSA+IERvbWFpbiBDb250cm9sbGVyLEdsb2JhbCBDYXRhbG9nIExEQVAgU1NMLDMyNjksVGNwDQpN
YW5hZ2VtZW50IFBvaW50IDwgLS0gPiBTaXRlIFNlcnZlcixSUEMsMSxUY3ANCk1hbmFnZW1lbnQg
UG9pbnQgPCAtLSA+IFNpdGUgU2VydmVyLFJQQyBFbmRwb2ludCBNYXBwZXIsMTM1LFRjcA0KTWFu
YWdlbWVudCBQb2ludCA8IC0tID4gU2l0ZSBTZXJ2ZXIsU2VydmVyIE1lc3NhZ2UgQmxvY2sgKFNN
QiksNDQ1LFRjcA0KTWFuYWdlbWVudCBQb2ludCA8IC0tID4gU1FMIFNlcnZlcixTUUwgb3ZlciBU
Q1AsMTQzMyxUY3ANCk1vYmlsZSBEZXZpY2UgLS0gPiBFbnJvbGxtZW50IFByb3h5IFBvaW50LFNl
Y3VyZSBIeXBlcnRleHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFBTKSw0NDMsVGNwDQpNb2JpbGUg
RGV2aWNlIC0tID4gTWljcm9zb2Z0IEludHVuZSxTZWN1cmUgSHlwZXJ0ZXh0IFRyYW5zZmVyIFBy
b3RvY29sIChIVFRQUyksNDQzLFRjcA0KUmVwb3J0aW5nIFNlcnZpY2VzIFBvaW50IC0tID4gU1FM
IFNlcnZlcixTUUwgb3ZlciBUQ1AsMTQzMyxUY3ANClNlcnZpY2UgQ29ubmVjdGlvbiBQb2ludCAt
LSA+IE1pY3Jvc29mdCBJbnR1bmUsU2VjdXJlIEh5cGVydGV4dCBUcmFuc2ZlciBQcm90b2NvbCAo
SFRUUFMpLDQ0MyxUY3ANClNpdGUgU2VydmVyIC0tID4gQ2xvdWQtQmFzZWQgRGlzdHJpYnV0aW9u
IFBvaW50LFNlY3VyZSBIeXBlcnRleHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFBTKSw0NDMsVGNw
DQpTaXRlIFNlcnZlciAtLSA+IERpc3RyaWJ1dGlvbiBQb2ludCxSUEMsMSxUY3ANClNpdGUgU2Vy
dmVyIC0tID4gRGlzdHJpYnV0aW9uIFBvaW50LFJQQyBFbmRwb2ludCBNYXBwZXIsMTM1LFRjcA0K
U2l0ZSBTZXJ2ZXIgLS0gPiBEaXN0cmlidXRpb24gUG9pbnQsU2VydmVyIE1lc3NhZ2UgQmxvY2sg
KFNNQiksNDQ1LFRjcA0KU2l0ZSBTZXJ2ZXIgLS0gPiBEb21haW4gQ29udHJvbGxlcixSUEMsMSxU
Y3ANClNpdGUgU2VydmVyIC0tID4gRG9tYWluIENvbnRyb2xsZXIsUlBDIEVuZHBvaW50IE1hcHBl
ciwxMzUsVGNwDQpTaXRlIFNlcnZlciAtLSA+IERvbWFpbiBDb250cm9sbGVyLExpZ2h0d2VpZ2h0
IERpcmVjdG9yeSBBY2Nlc3MgUHJvdG9jb2wgKExEQVApLDM4OSxUY3ANClNpdGUgU2VydmVyIC0t
ID4gRG9tYWluIENvbnRyb2xsZXIsTERBUCAoU2VjdXJlIFNvY2tldHMgTGF5ZXIgW1NTTF0gY29u
bmVjdGlvbiksNjM2LFRjcA0KU2l0ZSBTZXJ2ZXIgLS0gPiBEb21haW4gQ29udHJvbGxlcixHbG9i
YWwgQ2F0YWxvZyBMREFQLDMyNjgsVGNwDQpTaXRlIFNlcnZlciAtLSA+IERvbWFpbiBDb250cm9s
bGVyLEdsb2JhbCBDYXRhbG9nIExEQVAgU1NMLDMyNjksVGNwDQpTaXRlIFNlcnZlciAtLSA+IElu
dGVybmV0LEh5cGVydGV4dCBUcmFuc2ZlciBQcm90b2NvbCAoSFRUUCksODAsVGNwDQpTaXRlIFNl
cnZlciAtLSA+IFNNUyBQcm92aWRlcixSUEMsMSxUY3ANClNpdGUgU2VydmVyIC0tID4gU01TIFBy
b3ZpZGVyLFJQQyBFbmRwb2ludCBNYXBwZXIsMTM1LFRjcA0KU2l0ZSBTZXJ2ZXIgLS0gPiBTTVMg
UHJvdmlkZXIsU2VydmVyIE1lc3NhZ2UgQmxvY2sgKFNNQiksNDQ1LFRjcA0KU2l0ZSBTZXJ2ZXIg
LS0gPiBTUUwgU2VydmVyLFNRTCBvdmVyIFRDUCwxNDMzLFRjcA0KU2l0ZSBTZXJ2ZXIgLS0gPiBT
UUwgU2VydmVyIChEdXJpbmcgSW5zdGFsbGF0aW9uKSxSUEMsMSxUY3ANClNpdGUgU2VydmVyIC0t
ID4gU1FMIFNlcnZlciAoRHVyaW5nIEluc3RhbGxhdGlvbiksUlBDIEVuZHBvaW50IE1hcHBlciwx
MzUsVGNwDQpTaXRlIFNlcnZlciAtLSA+IFNRTCBTZXJ2ZXIgKER1cmluZyBJbnN0YWxsYXRpb24p
LFNlcnZlciBNZXNzYWdlIEJsb2NrIChTTUIpLDQ0NSxUY3ANClNpdGUgU2VydmVyIDwgLS0gPiBB
cHBsaWNhdGlvbiBDYXRhbG9nIFdlYiBTZXJ2aWNlIFBvaW50LFJQQywxLFRjcA0KU2l0ZSBTZXJ2
ZXIgPCAtLSA+IEFwcGxpY2F0aW9uIENhdGFsb2cgV2ViIFNlcnZpY2UgUG9pbnQsUlBDIEVuZHBv
aW50IE1hcHBlciwxMzUsVGNwDQpTaXRlIFNlcnZlciA8IC0tID4gQXBwbGljYXRpb24gQ2F0YWxv
ZyBXZWIgU2VydmljZSBQb2ludCxTZXJ2ZXIgTWVzc2FnZSBCbG9jayAoU01CKSw0NDUsVGNwDQpT
aXRlIFNlcnZlciA8IC0tID4gQXBwbGljYXRpb24gQ2F0YWxvZyBXZWJzaXRlIFBvaW50LFJQQywx
LFRjcA0KU2l0ZSBTZXJ2ZXIgPCAtLSA+IEFwcGxpY2F0aW9uIENhdGFsb2cgV2Vic2l0ZSBQb2lu
dCxSUEMgRW5kcG9pbnQgTWFwcGVyLDEzNSxUY3ANClNpdGUgU2VydmVyIDwgLS0gPiBBcHBsaWNh
dGlvbiBDYXRhbG9nIFdlYnNpdGUgUG9pbnQsU2VydmVyIE1lc3NhZ2UgQmxvY2sgKFNNQiksNDQ1
LFRjcA0KU2l0ZSBTZXJ2ZXIgPCAtLSA+IEFzc2V0IEludGVsbGlnZW5jZSBTeW5jaHJvbml6YXRp
b24gUG9pbnQsUlBDLDEsVGNwDQpTaXRlIFNlcnZlciA8IC0tID4gQXNzZXQgSW50ZWxsaWdlbmNl
IFN5bmNocm9uaXphdGlvbiBQb2ludCxSUEMgRW5kcG9pbnQgTWFwcGVyLDEzNSxUY3ANClNpdGUg
U2VydmVyIDwgLS0gPiBBc3NldCBJbnRlbGxpZ2VuY2UgU3luY2hyb25pemF0aW9uIFBvaW50LFNl
cnZlciBNZXNzYWdlIEJsb2NrIChTTUIpLDQ0NSxUY3ANClNpdGUgU2VydmVyIDwgLS0gPiBDZXJ0
aWZpY2F0ZSBSZWdpc3RyYXRpb24gUG9pbnQsUlBDLDEsVGNwDQpTaXRlIFNlcnZlciA8IC0tID4g
Q2VydGlmaWNhdGUgUmVnaXN0cmF0aW9uIFBvaW50LFJQQyBFbmRwb2ludCBNYXBwZXIsMTM1LFRj
cA0KU2l0ZSBTZXJ2ZXIgPCAtLSA+IENlcnRpZmljYXRlIFJlZ2lzdHJhdGlvbiBQb2ludCxTZXJ2
ZXIgTWVzc2FnZSBCbG9jayAoU01CKSw0NDUsVGNwDQpTaXRlIFNlcnZlciA8IC0tID4gRW5kcG9p
bnQgUHJvdGVjdGlvbiBQb2ludCxSUEMsMSxUY3ANClNpdGUgU2VydmVyIDwgLS0gPiBFbmRwb2lu
dCBQcm90ZWN0aW9uIFBvaW50LFJQQyBFbmRwb2ludCBNYXBwZXIsMTM1LFRjcA0KU2l0ZSBTZXJ2
ZXIgPCAtLSA+IEVuZHBvaW50IFByb3RlY3Rpb24gUG9pbnQsU2VydmVyIE1lc3NhZ2UgQmxvY2sg
KFNNQiksNDQ1LFRjcA0KU2l0ZSBTZXJ2ZXIgPCAtLSA+IEVucm9sbG1lbnQgUG9pbnQsUlBDLDEs
VGNwDQpTaXRlIFNlcnZlciA8IC0tID4gRW5yb2xsbWVudCBQb2ludCxSUEMgRW5kcG9pbnQgTWFw
cGVyLDEzNSxUY3ANClNpdGUgU2VydmVyIDwgLS0gPiBFbnJvbGxtZW50IFBvaW50LFNlcnZlciBN
ZXNzYWdlIEJsb2NrIChTTUIpLDQ0NSxUY3ANClNpdGUgU2VydmVyIDwgLS0gPiBFbnJvbGxtZW50
IFByb3h5IFBvaW50LFJQQywxLFRjcA0KU2l0ZSBTZXJ2ZXIgPCAtLSA+IEVucm9sbG1lbnQgUHJv
eHkgUG9pbnQsUlBDIEVuZHBvaW50IE1hcHBlciwxMzUsVGNwDQpTaXRlIFNlcnZlciA8IC0tID4g
RW5yb2xsbWVudCBQcm94eSBQb2ludCxTZXJ2ZXIgTWVzc2FnZSBCbG9jayAoU01CKSw0NDUsVGNw
DQpTaXRlIFNlcnZlciA8IC0tID4gRmFsbGJhY2sgU3RhdHVzIFBvaW50LFJQQywxLFRjcA0KU2l0
ZSBTZXJ2ZXIgPCAtLSA+IEZhbGxiYWNrIFN0YXR1cyBQb2ludCxSUEMgRW5kcG9pbnQgTWFwcGVy
LDEzNSxUY3ANClNpdGUgU2VydmVyIDwgLS0gPiBGYWxsYmFjayBTdGF0dXMgUG9pbnQsU2VydmVy
IE1lc3NhZ2UgQmxvY2sgKFNNQiksNDQ1LFRjcA0KU2l0ZSBTZXJ2ZXIgPCAtLSA+IElzc3Vpbmcg
Q2VydGlmaWNhdGlvbiBBdXRob3JpdHkgKENBKSxSUEMsMSxUY3ANClNpdGUgU2VydmVyIDwgLS0g
PiBJc3N1aW5nIENlcnRpZmljYXRpb24gQXV0aG9yaXR5IChDQSksUlBDIEVuZHBvaW50IE1hcHBl
ciwxMzUsVGNwDQpTaXRlIFNlcnZlciA8IC0tID4gUmVwb3J0aW5nIFNlcnZpY2VzIFBvaW50LFJQ
QywxLFRjcA0KU2l0ZSBTZXJ2ZXIgPCAtLSA+IFJlcG9ydGluZyBTZXJ2aWNlcyBQb2ludCxSUEMg
RW5kcG9pbnQgTWFwcGVyLDEzNSxUY3ANClNpdGUgU2VydmVyIDwgLS0gPiBSZXBvcnRpbmcgU2Vy
dmljZXMgUG9pbnQsU2VydmVyIE1lc3NhZ2UgQmxvY2sgKFNNQiksNDQ1LFRjcA0KU2l0ZSBTZXJ2
ZXIgPCAtLSA+IFNpdGUgU2VydmVyLFNlcnZlciBNZXNzYWdlIEJsb2NrIChTTUIpLDQ0NSxUY3AN
ClNpdGUgU2VydmVyIDwgLS0gPiBTb2Z0d2FyZSBVcGRhdGUgUG9pbnQsSHlwZXJ0ZXh0IFRyYW5z
ZmVyIFByb3RvY29sIChIVFRQKSw4MCxUY3ANClNpdGUgU2VydmVyIDwgLS0gPiBTb2Z0d2FyZSBV
cGRhdGUgUG9pbnQsU2VjdXJlIEh5cGVydGV4dCBUcmFuc2ZlciBQcm90b2NvbCAoSFRUUFMpLDQ0
MyxUY3ANClNpdGUgU2VydmVyIDwgLS0gPiBTb2Z0d2FyZSBVcGRhdGUgUG9pbnQsU2VydmVyIE1l
c3NhZ2UgQmxvY2sgKFNNQiksNDQ1LFRjcA0KU2l0ZSBTZXJ2ZXIgPCAtLSA+IFNvZnR3YXJlIFVw
ZGF0ZSBQb2ludCxXaW5kb3dzIFNlcnZlciBVcGRhdGUgU2VydmljZXMsODUzMCxUY3ANClNpdGUg
U2VydmVyIDwgLS0gPiBTb2Z0d2FyZSBVcGRhdGUgUG9pbnQsU2VjdXJlIFdpbmRvd3MgU2VydmVy
IFVwZGF0ZSBTZXJ2aWNlcyw4NTMxLFRjcA0KU2l0ZSBTZXJ2ZXIgPCAtLSA+IFN0YXRlIE1pZ3Jh
dGlvbiBQb2ludCxSUEMgRW5kcG9pbnQgTWFwcGVyLDEzNSxUY3ANClNpdGUgU2VydmVyIDwgLS0g
PiBTdGF0ZSBNaWdyYXRpb24gUG9pbnQsU2VydmVyIE1lc3NhZ2UgQmxvY2sgKFNNQiksNDQ1LFRj
cA0KU01TIFByb3ZpZGVyIC0tID4gU1FMIFNlcnZlcixTUUwgb3ZlciBUQ1AsMTQzMyxUY3ANClNv
ZnR3YXJlIFVwZGF0ZSBQb2ludCAtLSA+IEludGVybmV0LEh5cGVydGV4dCBUcmFuc2ZlciBQcm90
b2NvbCAoSFRUUCksODAsVGNwDQpTb2Z0d2FyZSBVcGRhdGUgUG9pbnQgLS0gPiBVcHN0cmVhbSBX
U1VTIFNlcnZlcixIeXBlcnRleHQgVHJhbnNmZXIgUHJvdG9jb2wgKEhUVFApLDgwLFRjcA0KU29m
dHdhcmUgVXBkYXRlIFBvaW50IC0tID4gVXBzdHJlYW0gV1NVUyBTZXJ2ZXIsU2VjdXJlIEh5cGVy
dGV4dCBUcmFuc2ZlciBQcm90b2NvbCAoSFRUUFMpLDQ0MyxUY3ANClNvZnR3YXJlIFVwZGF0ZSBQ
b2ludCAtLSA+IFVwc3RyZWFtIFdTVVMgU2VydmVyLFdpbmRvd3MgU2VydmVyIFVwZGF0ZSBTZXJ2
aWNlcyw4NTMwLFRjcA0KU29mdHdhcmUgVXBkYXRlIFBvaW50IC0tID4gVXBzdHJlYW0gV1NVUyBT
ZXJ2ZXIsU2VjdXJlIFdpbmRvd3MgU2VydmVyIFVwZGF0ZSBTZXJ2aWNlcyw4NTMxLFRjcA0KU1FM
IFNlcnZlciAtLT4gU1FMIFNlcnZlcixTUUwgb3ZlciBUQ1AsMTQzMyxUY3ANClNRTCBTZXJ2ZXIg
LS0+IFNRTCBTZXJ2ZXIsU1FMIFNlcnZlciBTZXJ2aWNlIEJyb2tlciw0MDIyLFRjcA0KU3RhdGUg
TWlncmF0aW9uIFBvaW50IC0tID4gU1FMIFNlcnZlcixTUUwgb3ZlciBUQ1AsMTQzMyxUY3ANClNp
dGUgU2VydmVyIC0tID4gRE5TIFNlcnZlcixEb21haW4gTmFtZSBTeXN0ZW0gKEROUyksNTMsVGNw
DQpTaXRlIFNlcnZlciAtLSA+IFNpdGUgc3lzdGVtLE5ldEJJT1MgU2Vzc2lvbiBTZXJ2aWNlLDEz
OSxUY3ANCg==";
    }
}