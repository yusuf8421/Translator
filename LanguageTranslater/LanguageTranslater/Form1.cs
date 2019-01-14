using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Portable.HttpClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using RestSharp.Portable;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Extensions;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using NAudio;
using NAudio.Wave;
using System.Linq;

namespace LanguageTranslater
{


    public partial class Form1 : Form
    {
        class AppCache
        {

            public static string API { get; } = @"trnsl.1.1.20190108T085921Z.132ddff657f9e612.9f4c5cbb77785b4f80b7590becef006d9c413593";
            public static string UrlGetAvailableLanguages { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/getLangs?key={0}&ui={1}";
            public static string UrlDetectSrcLanguage { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/detect?key={0}&text={1}";
            public static string UrlTranslateLanguage { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}";
        }


        private List<string> AvailLangs;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var response = RequestService(string.Format(AppCache.UrlDetectSrcLanguage, AppCache.API, txtSrc.Text));
            var dict = JsonConvert.DeserializeObject<IDictionary>(response.Content);

            var statusCode = dict["code"].ToString();
            if (statusCode.Equals("200"))
            {
                lblSrcLang.Text = dict["lang"].ToString();
            }


        }



        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string key = "cf807d0e-9aae-445c-88df-570c995c3e91";
            var response = RequestService(string.Format(AppCache.UrlTranslateLanguage, AppCache.API, txtSrc.Text, AvailLangs[comboAvailableLangs.SelectedIndex]));
            var dict = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            var statusCode = dict["code"].ToString();
            SpeechRecognitionEngine TnmMtr = new SpeechRecognitionEngine();
            SpeechSynthesizer Sentez = new SpeechSynthesizer();
            Sentez.SelectVoiceByHints(VoiceGender.Female);
            if (statusCode.Equals("200"))
            {
                txtDestLang.Text = string.Join(separator: ",", value: new string[] { dict["text"].ToString() });
                //Sentez.SpeakAsync(txtDestLang.Text).ToString();
                PlayMp3FromUrl("https://tts.voicetech.yandex.net/generate?text=" + txtDestLang.Text + "&speed=1&format=mp3&lang=tr-TR&speaker=" + CmbSpeakers.Text.ToString().Replace(" ", "") + "&emotion=good&key=" + key);

            }

        }
        public static void PlayMp3FromUrl(string url)
        {

            using (Stream ms = new MemoryStream())
            {
                using (Stream stream = WebRequest.Create(url)
                    .GetResponse().GetResponseStream())
                {
                    byte[] buffer = new byte[32768];
                    int read;
                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                }

                ms.Position = 0;
                using (WaveStream blockAlignedStream =
                    new BlockAlignReductionStream(
                        WaveFormatConversionStream.CreatePcmStream(
                            new Mp3FileReader(ms))))
                {
                    using (WaveOut waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
                    {
                        waveOut.Init(blockAlignedStream);
                        waveOut.Play();
                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
            }
        }
        private void BtnAc_Click(object sender, EventArgs e)
        {
            var response = RequestService(string.Format(AppCache.UrlGetAvailableLanguages, AppCache.API, lblSrcLang.Text));
            var dict = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (DictionaryEntry entry in dict)
            {
                if (entry.Key.Equals("langs"))
                {
                    var availableConverts = (JObject) entry.Value;
                    AvailLangs = new List<string>();

                    comboAvailableLangs.Items.Clear();
                    foreach (var Lang in availableConverts)
                    {
                        if (!Lang.Equals(lblSrcLang.Text))
                        {
                            comboAvailableLangs.Items.Add(Lang.Value);
                            AvailLangs.Add(Lang.Key);
                        }
                    }
                }
                BtnAc.Enabled = false;
            }

        }
        private RestSharp.IRestResponse RequestService(string strUrl)
        {
            var client = new RestSharp.RestClient()
            {
                BaseUrl = new Uri(strUrl).ToString()
            };
            var request = new RestSharp.RestRequest()
            {
                Method = RestSharp.Method.GET
            };
            return client.Execute(request);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CmbSpeakers.AutoCompleteMode = AutoCompleteMode.Suggest;

            string myString = "jane | oksana | alyss | omazh | zahar | ermil";
            List<string> myList = myString.Split('|').ToList();
            
            foreach (string str in myList)
            {
                CmbSpeakers.Items.Add(str);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }
    }
}
