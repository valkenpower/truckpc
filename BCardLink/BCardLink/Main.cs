///dit gebruiken we voor de nfc kaarten
using MiFare;
using MiFare.Classic;
using MiFare.Devices;
//dit is voor de json dat we van de server terug krijgen
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
//dit gebruiken we om een http request te maken
using System.Net.Http;
using System.Windows.Forms;

namespace BCardLink
{
    public partial class Main : Form
    {
        // dit zijn variables die we in elke methode kunnen gebruiken
        // dit is een variable voor de nfc reader
        private SmartCardReader reader;
        // dit is een variable voor de nfc kaart
        private MiFareCard card;
        // dit is een bool om aantegeven dat de login form dicht is
        public bool isLoginFormOpen = false;
        // dit is een variable voor de uid
        private string juid = null;
        // dit is een bool dat laat weten of de kaart geautoriseerd is 
        private bool iscardtrue = false;

        public Main()
        {
            InitializeComponent();
            // hij roept get devices op lijn 258
            GetDevices();
        }
        // dit is een class userlist dit gebruik ik om de users in een lijst te zetten.
        // dit geeft het meer structuur en elke value heeft een naam.
        // als je meer data in de lijst wilt dan moet je hier een naam voor de data geven.
        // Anders gaat het niet in de lijst of je krijgt een error.
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
        // dit is de lijst waar we alle data erin zetten
        private List<userlist> list = new List<userlist>();


        // deze methode wordt aangeroepen wanneer er een kaart op de reader zit 
        private async void CardAdded(object sender, CardEventArgs args)
        {
            try
            {
                // er wordt een kaart aangemaakt voor de kaart dat op de reader zit
                card = args.SmartCard.CreateMiFareCard();
                // er wordt voor informatie van de kaart gevraagd
                var cardIdentification = await card.GetCardInfo();
                var uid = await card.GetUid();
                // nu converten wij de uid zodat het leesbaar is
                string juids = BitConverter.ToString(uid);
                // nu wordt het in een variable juids gedaan dat op lijn 27 is 
                juid = juids;
                //txtUID.Text = juids; //// uncomment dit als je de uid v/d kaart wil zien zorg ervoor dat dit niet om de eind programma staat
                WriteMessage("Card detected. Do not remove while linking.");
                // als de lijst leeg is dan wordt de conditie gedaan
                if (list.Count <= 0)
                {
                    var ignored = this.BeginInvoke((Action)(() =>
                    {
                        //txtUID.Visible = true; //// zie lijn 77
                        //label2.Visible = true;

                        //headers voor de http request
                        var values = new Dictionary<string, string>
                        {
                        { "cardid", juid },
                        { "thing2", "world" }
                        };
                        // hij maakt hem klaar voor de request 
                        var content = new FormUrlEncodedContent(values);

                        //  hier wordt een request gemaakt en we krijgen een json terug
                        var httpClient = new HttpClient();
                        var response = httpClient.PostAsync(Properties.Settings.Default.URL, content).Result;
                        var resultaat = response.Content.ReadAsStringAsync().Result;
                        //resultaat wordt geconvert naar json
                        dynamic c = JsonConvert.DeserializeObject(resultaat);

                        // als er geen error is, dan wordt er een foreach gemaaktt
                        if (c.error == null)
                        {
                            // voor elke user dat er in de json is dan maken we daarvoor een class dat in de lijst gaat zie class user list
                            foreach (var i in c.userlist)
                            {
                                list.Add(new userlist(i.username, i.rdppassword, i.rdpserver, i.portal_cardnumber));
                            }
                            // bool wordt op true gezet dus de kaart is geautoriseerd
                            iscardtrue = true;
                            // we roepen een andere methode aan om de RDP te starten
                            cardadded(sender, args);
                        }
                        // er is een error dat we hebben gekregen dat betekend dat de kaart niet geautoriseerd is  
                        else
                        {
                            // kaart is op niet geautoriseerd gezet
                            iscardtrue = false;
                            // error message 
                            WriteMessage("This card is not authorized. Try another card.");
                            PopupMessage("This card is not authorized. Try another card.");
                        }
                    }));
                }
                else // er zit data in de lijst 
                {
                    // we zoeken met een foreach en if de uid van de kaart om hem als geautoriseerd te maken in dit programma
                    foreach (var item in list)
                    {
                        if (item.portal_cardnumber == juid) 
                        {
                            // uid in lijst is gelijk aan de gegeven uid 
                            // kaart is geautoriseerd
                            iscardtrue = true;
                        }
                    }
                    // we roepen de methode cardadded om de rdp te starten
                    cardadded(sender, args);
                }
            }
            catch (Exception ex)
            {
                // er is iets in de proces fout gegaan. bijv kaart is te snel eraf gehaald
                WriteMessage("Can't read the UID. Try again.");
                PopupMessage("CardAdded Exception: " + ex.Message);
                
            }
        }

        // deze method wordt aangeroepen door card added 
        // er is een kaart dat geautoriseerd is op de reader gezet je mag de rdp starten
        private void cardadded(object sender, EventArgs args)
        {
            try
            {
                // er wordt gekeken of de kaart geautoriseerd is 
                if (iscardtrue == true)
                {
                    // we zoeken de juiste userlist class in de lijst door de uid's te vergelijken
                    foreach (var item in list)
                    {
                        if (item.portal_cardnumber == juid)
                        {
                            // alle eerdere rdp's worden gesloten
                            foreach (var process in Process.GetProcessesByName("mstsc"))
                            {
                                process.Kill();
                            }
                            // variables dat we maken zodat we de juiste data van de userlist class hebben
                            var password = item.rdppassword;
                            var username = item.username;
                            var ip = item.rdpserver;
                            // er is een string gemaak met eem cmd code dat de rdp start
                            String szCmd = "/c cmdkey.exe /generic:" + ip + " /user:" + username + " /pass:" + password + " & mstsc.exe /v " + ip + " /f";
                            // hier geven we aan wat we allemaal in de rdp willen
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
                            // we maken een proces aan
                            Process proc = new Process
                            {
                                StartInfo = info,
                                EnableRaisingEvents = true,
                            };
                            // we starten de proces
                            proc.Start();
                        }
                    }
                    // bool wordt op false gezet voor de volgende kaart.
                    iscardtrue = false;
                }
                else
                {
                    // kaart was niet geautoriseerd bool stond op false
                    WriteMessage("This card is not authorized. Try another card.");
                    PopupMessage("This card is not authorized. Try another card.");
                }

            }
            catch (Exception e)
            {
                // er is iest fouts gegaan in deze methode
                PopupMessage(e.Message);
            }
           
        }
        // alles wat we weten van deze kaart wordt verwijderd behalve de data in de lijst
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
                // er is iest fout gegaan binnen deze methode
                PopupMessage("error: " + E.Message);

            }

        }

        // deze methode wordt aangeroepen wanneer er iets verandert in de combobox
        private void cboDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDevices();
            // pakt de device(s) op
            // deactiveer vorige reader
            DeactivateDevice();
            // connect met nieuwe reader
            ConnectToDevice(cboDevices.Text);

            // test
            Console.WriteLine(cboDevices);
            if (cboDevices.Items.Count > 0)
            {
                Console.WriteLine(cboDevices.Text);

            }


        }

        private void GetDevices()
        {
          
            try
            {
                // pakt alle readers. ze worden in een lijst gestopt en in de combobox 
                IReadOnlyList<string> readers = CardReader.GetReaderNames();
                cboDevices.Items.Clear();
                cboDevices.Items.AddRange(readers.ToArray());

                // Clear the readers list or create a new empty one
                readers = new List<string>();
            }
            catch (Exception e)
            {
                // er is iets fout gegaan in de methode 
                PopupMessage("Exception: " + e.Message);
            }


        }
        // deze methode wordt door getdevice aangeroepen. getdevice heeft ook de naam van de reader gegeven
        private async void ConnectToDevice(string name)
        {
            try
            {
                // er wordt met naam de reader opgezocht
                reader = await CardReader.FindAsync(name);
                if (reader == null) // als er geen readers zijn dan komt een popupmessage
                {
                    PopupMessage("No Readers Found");
                    return;
                }
                // als er een kaart op die reader zit dan weet de device dat hij deze method moet uitvoeren
                reader.CardAdded += CardAdded;
                reader.CardRemoved += CardRemoved;
                WriteMessage("Place card on the reader to scan.");
            }
            catch (Exception e)
            {
                // er is iets fout gegaan in de methode 
                PopupMessage("Exception: " + e.Message);

            }
        }


        //dit is de popup message dat we in allerlei methods aanroepen 
        public void PopupMessage(string message)
        {
            var ignored = this.BeginInvoke((Action)(() =>
            {
                // er wordt een message box aangemaakt met de message van de andere method 
                MessageBox.Show(message);
                GetDevices();
            }));
        }
        // dit is de message dat we onderaan het scherm weergeven. deze message komen ookvan ander methodes
        public void WriteMessage(string message)
        {
            var ignored = this.BeginInvoke((Action)(() =>
            {
                //Label veranderd van text
                lblMessage.Text = message;
            }));
        }

        //alles wat we van de reader hebben wordt verwijderd behalve de naam
        private void DeactivateDevice()
        {
            if (reader == null)
            {
                return;
            }
            // de methods van de reader worden eruit gedaan
            reader.CardAdded -= CardAdded;
            reader.CardRemoved -= CardRemoved;
            reader.Dispose();
            reader = null;

        }

        // de login form wordt geopend
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isLoginFormOpen)
            {
                isLoginFormOpen = true;
                var login = new Login();
                // als login fom gesloten is da wordt deze methode aangeroepen
                login.FormClosed += LoginForm_FormClosed;
                // login form is geopend
                login.Show();
            }
        }
        // deze methode wordt aangeroepen wanneer de login form gesloten wordt
        public void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // deze bool laat bepaalde buttons weten of de login form open of gesloten is.
             isLoginFormOpen = false;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            // er wordt gekeken of er readers zijn
            if (cboDevices.Items.Count > 0 && cboDevices.Items.Count < 2)
            {
                // eerste reader wordt gekozen
                cboDevices.SelectedIndex = 0;
            }

        }
        // deze methode wordt aangeroepen wanneer er op de exit buton wordt geklikt
        private void button1_Click_1(object sender, EventArgs e)
        {
            // als de login form niet gesloten is dan wordt de main venster niet gesloten
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