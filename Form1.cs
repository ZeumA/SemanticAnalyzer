using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;

namespace SemanticAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            string url = textBoxURL.Text;
            HttpClient client = new HttpClient();
            try
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        TextBoxHTML.Text = content.ReadAsStringAsync().Result;
                    }
                }

                ExtractText(TextBoxHTML.Text);
            }
            catch (Exception exn)
            {
                textBoxURL.Text = exn.Message;
            }
        }

        public void ExtractText(string html)
        {
            if (html == null)
            {
                throw new ArgumentNullException("html");
            }

            HtmlAgilityPack.HtmlDocument doc = 
                new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var metaChunks = new List<string>();
            var textChunks = new List<string>();
            foreach (var item in doc.DocumentNode.DescendantNodesAndSelf())
{
                if (item.Name == "a" ||
                    item.Name == "span" ||
                    item.Name == "title")
                {
                    if (item.InnerText.Trim() != "")
                    {
                        textChunks.Add(item.InnerText.Trim());
                    }
                }

                if(item.Name == "meta")
                {

                    foreach (var attr in item.Attributes)
                    {
                        if (attr.Name == "property")
                        {
                            metaChunks.Add(attr.Value);
                        }

                        if (attr.Name == "content")
                        {
                            if (item.InnerText.Trim().Length > 1)
                            {
                                textChunks.Add(item.InnerText.Trim());
                            }
                        }
                    }
                }

            }

            
            TextBoxText.Text = String.Join("\n", textChunks);
            TextBoxMeta.Text = String.Join("\n", metaChunks);
        }
    }
}
