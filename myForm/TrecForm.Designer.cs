namespace myForm
{
    partial class TrecForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewResponse = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PROV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CRSE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CSTARTDATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CDATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LICENSE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RESPONSE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.lblServiceMethod = new System.Windows.Forms.Label();
            this.textBoxDevToken = new System.Windows.Forms.TextBox();
            this.lblDevToken = new System.Windows.Forms.Label();
            this.lblServiceURL = new System.Windows.Forms.Label();
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.txtBoxServiceURL = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.xmlSubmission = new System.Windows.Forms.RichTextBox();
            this.lblTrecFiles = new System.Windows.Forms.Label();
            this.backGrdWorker = new System.ComponentModel.BackgroundWorker();
            this.lblCnt = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.myCntLabel = new System.Windows.Forms.Label();
            this.submitTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(941, 556);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 47);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewResponse);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 167);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1098, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Response Data";
            // 
            // listViewResponse
            // 
            this.listViewResponse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.PROV,
            this.CRSE,
            this.CSTARTDATE,
            this.CDATE,
            this.LICENSE,
            this.NAME,
            this.RESPONSE});
            this.listViewResponse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewResponse.Location = new System.Drawing.Point(13, 20);
            this.listViewResponse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewResponse.Name = "listViewResponse";
            this.listViewResponse.Size = new System.Drawing.Size(1073, 347);
            this.listViewResponse.TabIndex = 3;
            this.listViewResponse.UseCompatibleStateImageBehavior = false;
            this.listViewResponse.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 31;
            // 
            // PROV
            // 
            this.PROV.Text = "PROVIDER";
            this.PROV.Width = 88;
            // 
            // CRSE
            // 
            this.CRSE.Text = "COURSE";
            this.CRSE.Width = 84;
            // 
            // CSTARTDATE
            // 
            this.CSTARTDATE.DisplayIndex = 4;
            this.CSTARTDATE.Text = "START";
            this.CSTARTDATE.Width = 95;
            // 
            // CDATE
            // 
            this.CDATE.DisplayIndex = 3;
            this.CDATE.Text = "COMPLETION";
            this.CDATE.Width = 119;
            // 
            // LICENSE
            // 
            this.LICENSE.Text = "LICENSE #";
            this.LICENSE.Width = 121;
            // 
            // NAME
            // 
            this.NAME.Text = "NAME";
            this.NAME.Width = 210;
            // 
            // RESPONSE
            // 
            this.RESPONSE.Text = "RESPONSE";
            this.RESPONSE.Width = 320;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnUnlock);
            this.groupBox2.Controls.Add(this.lblServiceMethod);
            this.groupBox2.Controls.Add(this.textBoxDevToken);
            this.groupBox2.Controls.Add(this.lblDevToken);
            this.groupBox2.Controls.Add(this.lblServiceURL);
            this.groupBox2.Controls.Add(this.textBoxMethod);
            this.groupBox2.Controls.Add(this.txtBoxServiceURL);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(519, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Constants";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(421, 113);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.Location = new System.Drawing.Point(343, 113);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(70, 23);
            this.btnUnlock.TabIndex = 9;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // lblServiceMethod
            // 
            this.lblServiceMethod.AutoSize = true;
            this.lblServiceMethod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceMethod.Location = new System.Drawing.Point(12, 59);
            this.lblServiceMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceMethod.Name = "lblServiceMethod";
            this.lblServiceMethod.Size = new System.Drawing.Size(111, 16);
            this.lblServiceMethod.TabIndex = 8;
            this.lblServiceMethod.Text = "Service Method";
            // 
            // textBoxDevToken
            // 
            this.textBoxDevToken.Enabled = false;
            this.textBoxDevToken.Location = new System.Drawing.Point(140, 84);
            this.textBoxDevToken.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDevToken.Name = "textBoxDevToken";
            this.textBoxDevToken.Size = new System.Drawing.Size(351, 23);
            this.textBoxDevToken.TabIndex = 4;
            // 
            // lblDevToken
            // 
            this.lblDevToken.AutoSize = true;
            this.lblDevToken.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevToken.Location = new System.Drawing.Point(12, 91);
            this.lblDevToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevToken.Name = "lblDevToken";
            this.lblDevToken.Size = new System.Drawing.Size(78, 16);
            this.lblDevToken.TabIndex = 7;
            this.lblDevToken.Text = "Dev Token";
            // 
            // lblServiceURL
            // 
            this.lblServiceURL.AutoSize = true;
            this.lblServiceURL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceURL.Location = new System.Drawing.Point(12, 27);
            this.lblServiceURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceURL.Name = "lblServiceURL";
            this.lblServiceURL.Size = new System.Drawing.Size(86, 16);
            this.lblServiceURL.TabIndex = 6;
            this.lblServiceURL.Text = "Service URL";
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Enabled = false;
            this.textBoxMethod.Location = new System.Drawing.Point(140, 52);
            this.textBoxMethod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.Size = new System.Drawing.Size(351, 23);
            this.textBoxMethod.TabIndex = 5;
            // 
            // txtBoxServiceURL
            // 
            this.txtBoxServiceURL.Enabled = false;
            this.txtBoxServiceURL.Location = new System.Drawing.Point(140, 20);
            this.txtBoxServiceURL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxServiceURL.Name = "txtBoxServiceURL";
            this.txtBoxServiceURL.Size = new System.Drawing.Size(351, 23);
            this.txtBoxServiceURL.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.xmlSubmission);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(540, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(571, 143);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XML Request";
            // 
            // xmlSubmission
            // 
            this.xmlSubmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.xmlSubmission.Location = new System.Drawing.Point(7, 22);
            this.xmlSubmission.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xmlSubmission.Name = "xmlSubmission";
            this.xmlSubmission.Size = new System.Drawing.Size(553, 114);
            this.xmlSubmission.TabIndex = 0;
            this.xmlSubmission.Text = "";
            this.xmlSubmission.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xmlSubmission_MouseDown_1);
            // 
            // lblTrecFiles
            // 
            this.lblTrecFiles.AutoSize = true;
            this.lblTrecFiles.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrecFiles.Location = new System.Drawing.Point(56, 590);
            this.lblTrecFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrecFiles.Name = "lblTrecFiles";
            this.lblTrecFiles.Size = new System.Drawing.Size(0, 16);
            this.lblTrecFiles.TabIndex = 4;
            // 
            // backGrdWorker
            // 
            this.backGrdWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backGrdWorker_DoWork);
            this.backGrdWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backGrdWorker_RunWorkerCompleted_1);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(21, 151);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(0, 13);
            this.lblCnt.TabIndex = 5;
            this.lblCnt.Visible = false;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(56, 556);
            this.TimerLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(180, 16);
            this.TimerLabel.TabIndex = 6;
            this.TimerLabel.Text = "Time elapsed in seconds: ";
            // 
            // myCntLabel
            // 
            this.myCntLabel.AutoSize = true;
            this.myCntLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCntLabel.Location = new System.Drawing.Point(151, 556);
            this.myCntLabel.MaximumSize = new System.Drawing.Size(20, 0);
            this.myCntLabel.Name = "myCntLabel";
            this.myCntLabel.Size = new System.Drawing.Size(16, 32);
            this.myCntLabel.TabIndex = 7;
            this.myCntLabel.Text = ".5";
            this.myCntLabel.Visible = false;
            // 
            // submitTimer
            // 
            this.submitTimer.Interval = 1000;
            this.submitTimer.Tick += new System.EventHandler(this.submitTimer_Tick_1);
            // 
            // TrecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 618);
            this.Controls.Add(this.myCntLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.lblCnt);
            this.Controls.Add(this.lblTrecFiles);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "TrecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TREC XML Submission";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDevToken;
        private System.Windows.Forms.Label lblServiceURL;
        private System.Windows.Forms.TextBox textBoxDevToken;
        private System.Windows.Forms.TextBox txtBoxServiceURL;
        private System.Windows.Forms.Label lblServiceMethod;
        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listViewResponse;
        private System.Windows.Forms.ColumnHeader PROV;
        private System.Windows.Forms.ColumnHeader CRSE;
        private System.Windows.Forms.ColumnHeader CDATE;
        private System.Windows.Forms.ColumnHeader CSTARTDATE;
        private System.Windows.Forms.ColumnHeader LICENSE;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader RESPONSE;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox xmlSubmission;
        private System.Windows.Forms.Label lblTrecFiles;
        private System.ComponentModel.BackgroundWorker backGrdWorker;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label myCntLabel;
        private System.Windows.Forms.Timer submitTimer;
    }
}



