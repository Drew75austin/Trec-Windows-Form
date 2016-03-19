using System;
using System.Windows.Forms;
using myForm.Classes;
using System.Xml;
using System.ComponentModel;

namespace myForm
{
    public partial class TrecForm : Form
    {
        //Initialize the form
        public TrecForm()
        {
            InitializeComponent();
            submitTimer.Interval = 250;
            lblTrecFiles.Text = "";
            txtBoxServiceURL.Text = Properties.Settings.Default.ServerURL;
            textBoxDevToken.Text = Properties.Settings.Default.DevPWD;
            textBoxMethod.Text = Properties.Settings.Default.TrecServiceMethod;
        }

        #region ***Click event handler for the submission of the XML to Trec. Calls on the backGroundWorker to make the Trec Request. 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            myCntLabel.Text = "0";
            TimerLabel.Text = "Time elapsed in seconds: ";
            lblTrecFiles.Text = "";

            if (xmlSubmission.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;

                //Setup date time object for saving the filename of the request information
                var theDateTime = DateTime.Now;
                Random rnd = new Random();
                int myRand = rnd.Next(1, 9999);

                string _theDateTime = theDateTime.Year + "_" + theDateTime.Month.ToString().PadLeft(2, '0') + "_" + theDateTime.Day.ToString().PadLeft(2, '0') + "_" + theDateTime.Hour.ToString().PadLeft(2, '0') + "_" + theDateTime.Minute.ToString().PadLeft(2, '0') + "_" + myRand;

                lblCnt.Text = _theDateTime;

                btnSubmit.Enabled = false;
                listViewResponse.Items.Clear();

                try
                {
                    //start timer right before calling on backGrounWorker
                    submitTimer.Start();

                    //Setup arguments for backGroundWorker
                    string[] formString = new string[] { txtBoxServiceURL.Text, textBoxMethod.Text, textBoxDevToken.Text, xmlSubmission.Text, _theDateTime };
                    
                    //Call backGroundWorker
                    backGrdWorker.RunWorkerAsync(formString);
                }
                //Show exception in messagebox onscreen when error occurs
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                btnSubmit.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
            else //If there was nothing enteres into the XMLSubmission text box show an error
            {
                MessageBox.Show("Please make sure to enter a valid XML string!");
            }
        }
        #endregion

        #region ***This block of code handles the controls and logic to allow user to maitain the application constants including the Service URL, The Service Password and Service Process

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            txtBoxServiceURL.Enabled = true;
            textBoxDevToken.Enabled = true;
            textBoxMethod.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerURL = txtBoxServiceURL.Text;
            Properties.Settings.Default.DevPWD = textBoxDevToken.Text;
            Properties.Settings.Default.TrecServiceMethod = textBoxMethod.Text;
            Properties.Settings.Default.Save();
            txtBoxServiceURL.Enabled = false;
            textBoxMethod.Enabled = false;
            textBoxDevToken.Enabled = false;
        }
        #endregion

        #region ***This is the background worker that is making the soap request to the TREC webservice and returning the XML string
        private void backGrdWorker_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            string result = (string)e.Result;

            if (result != "")
            {
                XmlDocument xmlDoc = new XmlDocument();

                string myString = result;

                //clear text box
                xmlSubmission.Text = "";

                myString = myString.Replace("&lt;", "<");
                myString = myString.Replace("&gt;", ">");
                myString = myString.Replace("\"", "'");
                myString = myString.Replace("<?xml version='1.0' encoding='utf-8'?><soap:Envelope xmlns:soap='http://schemas.xmlsoap.org/soap/envelope/' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema'><soap:Body><ProcessRosterResponse xmlns='http://www.trec.state.tx.us/ProcessRoster'><ProcessRosterResult>", "");
                myString = myString.Replace("</ProcessRosterResult></ProcessRosterResponse></soap:Body></soap:Envelope>", "");

                //If mystring contains an error back from the server in the XML response, do not process the request.
                if (!myString.Contains("Server was unable to process request"))
                {

                    try
                    {

                        xmlDoc.LoadXml(myString);
                        io.logResponse(myString, lblCnt.Text);
                        io.logHeaderRow(lblCnt.Text);


                        XmlNodeList xnList = xmlDoc.SelectNodes("Records");
                        XmlNodeList xnList1 = xmlDoc.SelectNodes("Msg");

                        //Loop through all xml nodea to write out the data to the text file and into the list view datagrid
                        foreach (XmlNode childrenNode in xnList)
                        {
                            var cnt = 0;
                            foreach (XmlNode item in childrenNode)
                            {
                                cnt++;
                                io.logDataSet(cnt.ToString(), lblCnt.Text);
                                ListViewItem lvi = new ListViewItem(cnt.ToString());
                                foreach (XmlNode items in item)
                                {
                                    if (items.Name != "InstructorDetailData")
                                    {
                                        lvi.SubItems.Add(items.InnerText);
                                        io.logDataSet("," + items.InnerText, lblCnt.Text);
                                    }
                                }
                                io.logNewLine(lblCnt.Text);
                                listViewResponse.Items.Add(lvi);
                            };
                        };

                        lblTrecFiles.Text = "File has been saved to C:\\TrecFiles\\" + lblCnt.Text + ".txt";
                    }
                    catch (Exception ex)
                    {
                        submitTimer.Stop();
                        MessageBox.Show(ex.ToString());

                    }
                }
                else
                {
                    submitTimer.Stop();
                    MessageBox.Show("Please enter valid XML!");
                }

            }
            submitTimer.Stop();

        }

        private void backGrdWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] extracted = (string[])e.Argument;
            string xmlResult = "";

            try
            {
                xmlResult = soap.CallWebService(extracted[0], extracted[1], extracted[2], extracted[3], extracted[4]);
                e.Result = xmlResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        #endregion

        #region ***Handles the setup of the cut and past fucntionality in the xml submission text box
        private void xmlSubmission_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //MessageBox.Show("you got it!");
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                MenuItem menuItem = new MenuItem("Cut");
                menuItem.Click += new EventHandler(CutAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Copy");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Paste");
                menuItem.Click += new EventHandler(PasteAction);
                contextMenu.MenuItems.Add(menuItem);

                xmlSubmission.ContextMenu = contextMenu;
            }

        }
        void CutAction(object sender, EventArgs e)
        {
            xmlSubmission.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            Clipboard.SetText(xmlSubmission.SelectedText);
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                xmlSubmission.Text
                    += Clipboard.GetText(TextDataFormat.Text).ToString();
            }
        }
        #endregion

        //This is the event method for the timer
        private void submitTimer_Tick_1(object sender, EventArgs e)
        {
            double myCounter = Convert.ToDouble(myCntLabel.Text);
            myCounter = myCounter +.25;
            myCntLabel.Text = myCounter.ToString();
            if (myCounter < .5)
            {
                TimerLabel.Text = "Time elapsed in seconds: .5";
            }
            else {
                TimerLabel.Text = "Time elapsed in seconds: " + String.Format("{0:0.0}", myCounter);
            }
        }
     
    }
}

