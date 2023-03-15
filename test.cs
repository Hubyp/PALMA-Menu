
        WebClient wc = new WebClient();
        private string defPath = Application.StartupPath + "//Monaco//";

     /*   private void addGlobalF()
        {
            string[] array = File.ReadAllLines(this.defPath + "//globalf.txt");
            foreach (string text in array)
            {
                bool flag = text.Contains(':');
                if (flag)
                {
                    this.addIntel(text, "Function", text, text.Substring(1));
                }
                else
                {
                    this.addIntel(text, "Function", text, text);
                }
            }
        }

        private void addGlobalV()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
            {
                this.addIntel(text, "Variable", text, text);
            }
        }

        private void addGlobalNS()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
            {
                this.addIntel(text, "Class", text, text);
            }
        }

        private void addMath()
        {
            foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
            {
                this.addIntel(text, "Method", text, text);
            }
        }

        private void addBase()
        {
            foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
            {
                this.addIntel(text, "Keyword", text, text);
            }
        }

        private async void executor_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.Proxy = null;
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                bool flag2 = registryKey.GetValue(friendlyName) == null;
                if (flag2)
                {
                    registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
                }
                registryKey = null;
                friendlyName = null;
            }
            catch (Exception)
            {
            }
            webBrowser1.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
            await Task.Delay(500);
            webBrowser1.Document.InvokeScript("SetTheme", new string[]
            {
                   "Dark" 
                   /*
                    There are 2 Themes Dark and Light
                   
            });
            addBase();
            addMath();
            addGlobalNS();
            addGlobalV();
            addGlobalF();
            webBrowser1.Document.InvokeScript("SetText", new object[]
            {
                 "-- Welcome to Palma--"
            });
        }
        */
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
           /* HtmlDocument document = webBrowser1.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();
            mdl.ExecuteScript(script);*/
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
           // mdl.LaunchExploit();
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
          //  webBrowser1.Document.InvokeScript("SetText", new object[]
          //  {
         //       ""
           // });
        }

        private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcessesByName("RobloxPlayerBeta"))
            {
               // mdl.LaunchExploit();
            }
        }

        private void executor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void siticonePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void siticonePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FastColoredTextBox textBox = new FastColoredTextBox();
            textBox.Size = new Size(200, 100);
            textBox.Location = new Point(50, 50);
            this.Controls.Add(textBox);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void executor_Load(object sender, EventArgs e)
        {

        }
    }
