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
            string path = @"c:\API.txt";

            string APIVolume = textBox3.Text;
            // Запись ID сервера в txt для памяти.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(APIVolume);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string path = @"c:\ServerCode.txt";

            string ClientIDValue = textBox2.Text;
            // Запись ID сервера в txt для памяти.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(ClientIDValue);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string pathid = @"c:\ServerCode.txt";
                string pathapi = @"c:\API.txt";
                // Чтение ID сервера из txt.
                using (StreamReader sr = File.OpenText(pathid))
                {
                    using (StreamReader sr2 = File.OpenText(pathapi))
                    {
                        string ClientIDValue = "";
                        string APIVolume = "";
                        ClientIDValue = sr.ReadLine();
                        APIVolume = sr2.ReadLine();
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.xeinhost.ru/api/client/servers/" + ClientIDValue + "/power"))
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string pathid = @"c:\ServerCode.txt";
                string pathapi = @"c:\API.txt";
                // Чтение ID сервера из txt.
                using (StreamReader sr = File.OpenText(pathid))
                {
                    using (StreamReader sr2 = File.OpenText(pathapi))
                    {
                        string ClientIDValue = "";
                        string APIVolume = "";
                        ClientIDValue = sr.ReadLine();
                        APIVolume = sr2.ReadLine();
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.xeinhost.ru/api/client/servers/" + ClientIDValue + "/power"))
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string pathid = @"c:\ServerCode.txt";
                string pathapi = @"c:\API.txt";
                // Чтение ID сервера из txt.
                using (StreamReader sr = File.OpenText(pathid))
                {
                    using (StreamReader sr2 = File.OpenText(pathapi))
                    {
                        string ClientIDValue = "";
                        string APIVolume = "";
                        ClientIDValue = sr.ReadLine();
                        APIVolume = sr2.ReadLine();
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.xeinhost.ru/api/client/servers/" + ClientIDValue + "/power"))
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string pathid = @"c:\ServerCode.txt";
                string pathapi = @"c:\API.txt";
                // Чтение ID сервера из txt.
                using (StreamReader sr = File.OpenText(pathid))
                {
                    using (StreamReader sr2 = File.OpenText(pathapi))
                    {
                        string ClientIDValue = "";
                        string APIVolume = "";
                        ClientIDValue = sr.ReadLine();
                        APIVolume = sr2.ReadLine();
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.xeinhost.ru/api/client/servers/" + ClientIDValue + "/power"))
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string path = @"c:\Command.txt";

            string CommandValue = textBox1.Text;
            // Запись ID сервера в txt для памяти.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(CommandValue);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string pathid = @"c:\ServerCode.txt";
                string pathapi = @"c:\API.txt";
                string pathcommand = @"c:\Command.txt";
                // Чтение ID сервера из txt.
                using (StreamReader sr = File.OpenText(pathid))
                {
                    using (StreamReader sr2 = File.OpenText(pathapi))
                    {
                        using (StreamReader sr3 = File.OpenText(pathcommand))
                        {
                            string ClientIDValue = "";
                            string APIVolume = "";
                            string CommandValue = "";
                            ClientIDValue = sr.ReadLine();
                            APIVolume = sr2.ReadLine();
                            CommandValue = sr3.ReadLine();
                            using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.xeinhost.ru/api/client/servers/" + ClientIDValue + "/command"))
                            {
                                request.Headers.TryAddWithoutValidation("Accept", "application/json");
                                request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + APIVolume);

                                request.Content = new StringContent("{\"command\": "+CommandValue+"}");
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

        private void VK_Click(object sender, EventArgs e)
        {

        }
    }
}
