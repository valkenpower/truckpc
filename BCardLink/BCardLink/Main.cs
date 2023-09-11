using MiFare;
using MiFare.Classic;
using MiFare.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace BCardLink
{
    public partial class Main : Form
    {
        private SmartCardReader reader;
        private MiFareCard card;
        public bool isLoginFormOpen = false;
        private string juid = null;
        private bool iscardtrue = false;

        public Main()
        {
            InitializeComponent();
            GetDevices();
        }
        public class userlist
        {
            public string username { get; set; }
            public string rdppassword { get; set; }
            public string rdpserver { get; set; }
            public string portal_cardnumber { get; set; }
            public userlist(dynamic username, dynamic rdppassword, dynamic rdpserver, dynamic portal_cardnumber)
            {
                this.username = username;
                this.rdppassword = rdppassword;
                this.rdpserver = rdpserver;
                this.portal_cardnumber = portal_cardnumber;
            }


        }
        private List<userlist> list = new List<userlist>();



        private async void CardAdded(object sender, CardEventArgs args)
        {
            try
            {
                card = args.SmartCard.CreateMiFareCard();
                var cardIdentification = await card.GetCardInfo();
                var uid = await card.GetUid();
                string juids = BitConverter.ToString(uid);
                juid = juids;
                WriteMessage("Card detected. Do not remove while linking.");
                if (list.Count <= 0)
                {
                    var ignored = this.BeginInvoke((Action)(() =>
                    {
                        //txtUID.Visible = true;
                        //label2.Visible = true;


                        var values = new Dictionary<string, string>
                        {
                        { "cardid", juid },
                        { "thing2", "world" }
                        };

                        var content = new FormUrlEncodedContent(values);

                        // Modify the URL to match your server endpoint
                        var httpClient = new HttpClient();
                        var response = httpClient.PostAsync(Properties.Settings.Default.URL, content).Result;
                        var resultaat = response.Content.ReadAsStringAsync().Result;

                        dynamic c = JsonConvert.DeserializeObject(resultaat);
                        if (c.error == null)
                        {
                            foreach (var i in c.userlist)
                            {
                                list.Add(new userlist(i.username, i.rdppassword, i.rdpserver, i.portal_cardnumber));
                            }
                            iscardtrue = true;
                            cardadded(sender, args);
                        }
                        else
                        {
                            iscardtrue = false;
                            WriteMessage("This card is not authorized. Try another card.");
                            PopupMessage("This card is not authorized. Try another card.");
                        }
                    }));
                }
                else
                {
                    foreach (var item in list)
                    {
                        if (item.portal_cardnumber == juid)
                        {

                            iscardtrue = true;
                        }
                    }
                    cardadded(sender, args);
                }
            }
            catch (Exception ex)
            {
                WriteMessage("Can't read the UID. Try again.");
                if (ex.Message == "CardAdded Exception: Failure getting UID of MIFARE Standard card, ApduResponse SW=6300(Unknown)")
                {
                    PopupMessage("place card until you see the windows loading form");
                }
                else
                {
                    PopupMessage("CardAdded Exception: " + ex.Message);
                }
            }
        }
        private async void cardadded(object sender, EventArgs args)
        {
            try
            {
                if (iscardtrue == true)
                {
                    foreach (var item in list)
                    {
                        if (item.portal_cardnumber == juid)
                        {
                            foreach (var process in Process.GetProcessesByName("mstsc"))
                            {
                                process.Kill();
                            }
                            var password = item.rdppassword;
                            var username = item.username;
                            var ip = item.rdpserver;
                            String szCmd = "/c cmdkey.exe /generic:" + ip + " /user:" + username + " /pass:" + password + " & mstsc.exe /v " + ip + " /f";

                            ProcessStartInfo info = new ProcessStartInfo
                            {
                                FileName = "cmd.exe",
                                Arguments = szCmd,
                                CreateNoWindow = true, // Hide the command prompt window
                                RedirectStandardOutput = true,
                                RedirectStandardError = true,
                                RedirectStandardInput = true,
                                UseShellExecute = false
                            };

                            Process proc = new Process
                            {
                                StartInfo = info,
                                EnableRaisingEvents = true,
                            };

                            proc.Start();
                        }
                    }
                    iscardtrue = false;
                }
                else
                {
                    WriteMessage("This card is not authorized. Try another card.");
                    PopupMessage("This card is not authorized. Try another card.");
                }

            }
            catch (Exception e)
            {

                PopupMessage("error: " + e.Message);
            }
           
        }

        private void CardRemoved(object sender, EventArgs e)
        {
            try
            {
                card.Dispose();
                card = null;

                var ignored = this.BeginInvoke((Action)(() =>
                {
                    WriteMessage("place card on the reader to scan until you see a loading bar.");
                }));
            }
            catch (Exception E)
            {
                PopupMessage("error: " + E.Message);


            }

        }


        private void cboDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDevices();
            // pakt de device(s) op
            DeactivateDevice();
            ConnectToDevice(cboDevices.Text);
            Console.WriteLine(cboDevices);
            if (cboDevices.Items.Count > 0)
            {
                Console.WriteLine(cboDevices.Text);

            }


        }

        private void GetDevices()
        {
            Console.WriteLine("gfdgdfg");
            try
            {
                IReadOnlyList<string> readers = CardReader.GetReaderNames();
                cboDevices.Items.Clear();
                cboDevices.Items.AddRange(readers.ToArray());

                // Clear the readers list or create a new empty one
                readers = new List<string>();
            }
            catch (Exception e)
            {
                PopupMessage("Exception: " + e.Message);
            }


        }

        private async void ConnectToDevice(string name)
        {
            try
            {
                reader = await CardReader.FindAsync(name);
                if (reader == null)
                {
                    PopupMessage("No Readers Found");
                    return;
                }
                reader.CardAdded += CardAdded;
                reader.CardRemoved += CardRemoved;
                WriteMessage("Place card on the reader to scan.");
            }
            catch (Exception e)
            {
                PopupMessage("Exception: " + e.Message);

            }
        }



        public void PopupMessage(string message)
        {
            var ignored = this.BeginInvoke((Action)(() =>
            {
                MessageBox.Show(message);
                GetDevices();
            }));
        }

        public void WriteMessage(string message)
        {
            var ignored = this.BeginInvoke((Action)(() =>
            {
                lblMessage.Text = message;
            }));
        }

        private void DeactivateDevice()
        {
            if (reader == null)
            {
                return;
            }
            reader.CardAdded -= CardAdded;
            reader.CardRemoved -= CardRemoved;
            reader.Dispose();
            reader = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isLoginFormOpen)
            {
                isLoginFormOpen = true;
                var login = new Login();
                login.FormClosed += LoginForm_FormClosed;
                login.Show();
            }
        }

        public void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isLoginFormOpen = false; // Reset the flag when the login form is closed

        }

        private void Main_Shown(object sender, EventArgs e)
        {
            // voor de reader gelijk te kiezen
            if (cboDevices.Items.Count > 0 && cboDevices.Items.Count < 2)
            {
                cboDevices.SelectedIndex = 0;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isLoginFormOpen == false)
            {
                this.Close();
            }
            else
            {
                PopupMessage("close the login form");
            }
        }
    }

}