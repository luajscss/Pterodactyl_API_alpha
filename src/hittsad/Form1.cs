using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;


namespace hittsad
{
    public partial class LAPI : Form
    {
        public LAPI()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string path = @"c:\LAPI_API.txt";

            string APIVolume = textBox3.Text;
            // Запись ID сервера в txt для памяти.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(APIVolume);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string path = @"c:\LAPI_ServerCode.txt";

            string ClientIDValue = textBox2.Text;
            // Запись ID сервера в txt для памяти.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(ClientIDValue);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string path = @"c:\LAPI_URL.txt";
            string URLVolume = textBox4.Text;

            // Запись ID сервера в txt для памяти.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(URLVolume);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string path = @"c:\LAPI_Command.txt";

            string CommandValue = textBox1.Text;
            // Запись ID сервера в txt для памяти.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(CommandValue);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string pathid = @"c:\LAPI_ServerCode.txt";
                string pathapi = @"c:\LAPI_API.txt";
                string pathurl = @"c:\LAPI_URL.txt";
                // Чтение ID сервера из txt.
                using (StreamReader sr = File.OpenText(pathid))
                {
                    using (StreamReader sr2 = File.OpenText(pathapi))
                    {
                        using (StreamReader sr4 = File.OpenText(pathurl))
                        {
                            string ClientIDValue = "";
                            string APIVolume = "";
                            string URLVolume = "";
                            ClientIDValue = sr.ReadLine();
                            APIVolume = sr2.ReadLine();
                            URLVolume = sr4.ReadLine();
                            using (var request = new HttpRequestMessage(new HttpMethod("POST"), "" + URLVolume + "api/client/servers/" + ClientIDValue + "/power"))
                            {
                                request.Headers.TryAddWithoutValidation("Accept", "application/json");
                                request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + APIVolume);

                                request.Content = new StringContent("{\"signal\": \"start\"}");
                                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                                var response = httpClient.SendAsync(request);
                                var responseResult = response.Result;

                                if (responseResult.IsSuccessStatusCode)
                                {
                                    var result = responseResult.Content.ReadAsStringAsync().Result;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string pathid = @"c:\LAPI_ServerCode.txt";
                string pathapi = @"c:\LAPI_API.txt";
                string pathurl = @"c:\LAPI_URL.txt";
                // Чтение ID сервера из txt.
                using (StreamReader sr = File.OpenText(pathid))
                {
                    using (StreamReader sr2 = File.OpenText(pathapi))
                    {
                        using (StreamReader sr4 = File.OpenText(pathurl))
                        {
                            string ClientIDValue = "";
                            string APIVolume = "";
                            string URLVolume = "";
                            ClientIDValue = sr.ReadLine();
                            APIVolume = sr2.ReadLine();
                            URLVolume = sr4.ReadLine();
                            using (var request = new HttpRequestMessage(new HttpMethod("POST"), "" + URLVolume + "api/client/servers/" + ClientIDValue + "/power"))
                            {
                                request.Headers.TryAddWithoutValidation("Accept", "application/json");
                                request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + APIVolume);

                                request.Content = new StringContent("{\"signal\": \"restart\"}");
                                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                                var response = httpClient.SendAsync(request);
                                var responseResult = response.Result;

                                if (responseResult.IsSuccessStatusCode)
                                {
                                    var result = responseResult.Content.ReadAsStringAsync().Result;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string pathid = @"c:\LAPI_ServerCode.txt";
                string pathapi = @"c:\LAPI_API.txt";
                string pathurl = @"c:\LAPI_URL.txt";
                // Чтение ID сервера из txt.
                using (StreamReader sr = File.OpenText(pathid))
                {
                    using (StreamReader sr2 = File.OpenText(pathapi))
                    {
                        using (StreamReader sr4 = File.OpenText(pathurl))
                        {
                            string ClientIDValue = "";
                            string APIVolume = "";
                            string URLVolume = "";
                            ClientIDValue = sr.ReadLine();
                            APIVolume = sr2.ReadLine();
                            URLVolume = sr4.ReadLine();
                            using (var request = new HttpRequestMessage(new HttpMethod("POST"), "" + URLVolume + "api/client/servers/" + ClientIDValue + "/power"))
                            {
                                request.Headers.TryAddWithoutValidation("Accept", "application/json");
                                request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + APIVolume);

                                request.Content = new StringContent("{\"signal\": \"stop\"}");
                                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                                var response = httpClient.SendAsync(request);
                                var responseResult = response.Result;

                                if (responseResult.IsSuccessStatusCode)
                                {
                                    var result = responseResult.Content.ReadAsStringAsync().Result;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string pathid = @"c:\LAPI_ServerCode.txt";
                string pathapi = @"c:\LAPI_API.txt";
                string pathurl = @"c:\LAPI_URL.txt";
                // Чтение ID сервера из txt.
                using (StreamReader sr = File.OpenText(pathid))
                {
                    using (StreamReader sr2 = File.OpenText(pathapi))
                    {
                        using (StreamReader sr4 = File.OpenText(pathurl))
                        {
                            string ClientIDValue = "";
                            string APIVolume = "";
                            string URLVolume = "";
                            ClientIDValue = sr.ReadLine();
                            APIVolume = sr2.ReadLine();
                            URLVolume = sr4.ReadLine();
                            using (var request = new HttpRequestMessage(new HttpMethod("POST"), "" + URLVolume + "api/client/servers/" + ClientIDValue + "/power"))
                            {
                                request.Headers.TryAddWithoutValidation("Accept", "application/json");
                                request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + APIVolume);

                                request.Content = new StringContent("{\"signal\": \"kill\"}");
                                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                                var response = httpClient.SendAsync(request);
                                var responseResult = response.Result;

                                if (responseResult.IsSuccessStatusCode)
                                {
                                    var result = responseResult.Content.ReadAsStringAsync().Result;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LAPI_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string pathid = @"c:\LAPI_ServerCode.txt";
                string pathapi = @"c:\LAPI_API.txt";
                string pathcommand = @"c:\LAPI_Command.txt";
                string pathurl = @"c:\LAPI_URL.txt";
                // Чтение ID сервера из txt.
                using (StreamReader sr = File.OpenText(pathid))
                {
                    using (StreamReader sr2 = File.OpenText(pathapi))
                    {
                        using (StreamReader sr3 = File.OpenText(pathcommand))
                        {
                            using (StreamReader sr4 = File.OpenText(pathurl))
                            {
                                string ClientIDValue = "";
                                string APIVolume = "";
                                string URLVolume = "";
                                string CommandValue = "";
                                ClientIDValue = sr.ReadLine();
                                APIVolume = sr2.ReadLine();
                                CommandValue = sr3.ReadLine();
                                URLVolume = sr4.ReadLine();
                                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "" + URLVolume + "api/client/servers/" + ClientIDValue + "/command"))
                                {
                                    request.Headers.TryAddWithoutValidation("Accept", "application/json");
                                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + APIVolume);

                                    request.Content = new StringContent("{\"command\": " + CommandValue + "}");
                                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                                    var response = httpClient.SendAsync(request);
                                    var responseResult = response.Result;

                                    if (responseResult.IsSuccessStatusCode)
                                    {
                                        var result = responseResult.Content.ReadAsStringAsync().Result;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void VK_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
