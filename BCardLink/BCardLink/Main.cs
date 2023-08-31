﻿using MiFare;
using MiFare.Classic;
using MiFare.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace BCardLink
{
    public partial class Main : Form
    {
        private SmartCardReader reader;
        private MiFareCard card;
        public bool isLoginFormOpen = false;

        public Main()
        {
            InitializeComponent();
            GetDevices();

        }

        public class users
        {
            public string[] cardnumber { get; set; }
            public string[] username { get; set; }
            public string[] rdppassword { get; set; }
            public string[] rdpserver { get; set; }
        }
        private void CardRemoved(object sender, EventArgs e)
        {
            try
            {
                card.Dispose();
                card = null;

                var ignored = this.BeginInvoke((Action)(() =>
                {

                }));
            }
            catch (Exception E)
            {
                PopupMessage("error: " + E.Message);

            }

        }

        private async void CardAdded(object sender, CardEventArgs args)
        {


            // pakt de uid van de kaart en herkent het
            try
            {
                card = args.SmartCard.CreateMiFareCard();

                var cardIdentification = await card.GetCardInfo();
                var uid = await card.GetUid();


                var ignored = this.BeginInvoke((Action)(() =>
                {
                    txtUID.Visible = true;
                    WriteMessage("Card detected. Do not remove while linking.");
                    txtUID.Text = BitConverter.ToString(uid);


                    var values = new Dictionary<string, string>
                      {
                          { "cardid",txtUID.Text },
                          { "thing2", "world" }
                      };

                    var content = new FormUrlEncodedContent(values);
                    // hier kan je url veranderen
                    var httpClient = new HttpClient();
                    var response = httpClient.PostAsync(Properties.Settings.Default.URL, content).Result;
                    var resultaat = response.Content.ReadAsStringAsync().Result;
                    System.Diagnostics.Debug.WriteLine(resultaat);

                    dynamic c = JsonConvert.DeserializeObject(resultaat);

                    Console.WriteLine(c.cardnumber);

                    if (c.error == null) {

                        foreach (var process in Process.GetProcessesByName("mstsc"))
                        {
                            process.Kill();
                        }
                        // dit pakt de 
                        var password = c.rdppassword;
                        var username = c.username;
                        var ip = c.rdpserver;
                        String szCmd = "/c cmdkey.exe /generic:" + ip + " /user:" + username + " /pass:" + password + " & mstsc.exe /v " + ip + " /f";
                        Console.WriteLine(szCmd);
                        ProcessStartInfo info = new ProcessStartInfo("cmd.exe", szCmd);
                        Process proc = new Process();
                        proc.StartInfo = info;
                        proc.Start();
                    }
                    else
                    {
                        foreach (var process in Process.GetProcessesByName("mstsc"))
                        {
                            process.Kill();
                        }
                        MessageBox.Show("Error ... " + c.error);
                    }
                }));







            }
            catch (Exception ex)
            {
                PopupMessage("CardAdded Exception: " + ex.Message);
            }
        }



        private void cboDevices_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                cboDevices.Items.AddRange(readers.ToArray());
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

        private void txtUID_TextChanged(object sender, EventArgs e)
        {

        }

        private static readonly HttpClient client = new HttpClient();

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isLoginFormOpen)
            {
                isLoginFormOpen = true;
                var login = new login();
                login.FormClosed += LoginForm_FormClosed;
                login.Show();
            }
        }

        public void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isLoginFormOpen = false; // Reset the flag when the login form is closed
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(Properties.Settings.Default.URL);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
        private void Main_Shown(object sender, EventArgs e)
        {
            // voor de reader gelijk te kiezen
            Console.WriteLine("vxxcvcxv");
            if (cboDevices.Items.Count > 0 && cboDevices.Items.Count < 2)
            {
                cboDevices.SelectedIndex = 0;
            }

        }

    }


}