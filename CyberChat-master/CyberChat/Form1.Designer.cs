namespace CyberChat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbChat = new RichTextBox();
            txtUserInput = new TextBox();
            btnSend = new Button();
            lblTitle = new Label();
            picLogo = new PictureBox();
            groupBox1 = new GroupBox();
            btnPrivacy = new Button();
            btnPassword = new Button();
            btnScam = new Button();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnGreeting = new Button();
            lblStatus = new Label();
            tabControl1 = new TabControl();
            tabChat = new TabPage();
            tabTasks = new TabPage();
            lstTasks = new ListBox();
            btnDeleteTask = new Button();
            btnCompleteTask = new Button();
            btnAddTask = new Button();
            dtpReminder = new DateTimePicker();
            label1 = new Label();
            txtTaskDescription = new TextBox();
            txtTaskTitle = new TextBox();
            txtDescription = new Label();
            Title = new Label();
            tabQuiz = new TabPage();
            btnSubmitAnswer = new Button();
            lblQuestion = new Label();
            grpQuizStats = new GroupBox();
            lblIncorrect = new Label();
            lblCorrect = new Label();
            lblScore = new Label();
            btnResetQuiz = new Button();
            btnNextQuestion = new Button();
            lblQuestionNumber = new Label();
            rbOptionD = new RadioButton();
            rbOptionC = new RadioButton();
            rbOptionB = new RadioButton();
            rbOptionA = new RadioButton();
            lblFeedback = new Label();
            btnStartQuiz = new Button();
            lblQuizInstructions = new Label();
            tabActivity = new TabPage();
            btnShowMore = new Button();
            lblStatusA = new Label();
            btnClearLog = new Button();
            groupBox3 = new GroupBox();
            lstActivityLog = new ListBox();
            lblActivityInfo = new Label();
            lblActivityTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabChat.SuspendLayout();
            tabTasks.SuspendLayout();
            tabQuiz.SuspendLayout();
            grpQuizStats.SuspendLayout();
            tabActivity.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.BackColor = Color.Black;
            rtbChat.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbChat.ForeColor = SystemColors.HotTrack;
            rtbChat.Location = new Point(20, 29);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(798, 480);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            rtbChat.TextChanged += rtbChat_TextChanged;
            // 
            // txtUserInput
            // 
            txtUserInput.BackColor = Color.LightGray;
            txtUserInput.BorderStyle = BorderStyle.FixedSingle;
            txtUserInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserInput.ForeColor = SystemColors.Window;
            txtUserInput.Location = new Point(20, 525);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(627, 39);
            txtUserInput.TabIndex = 1;
            txtUserInput.TextChanged += textBox1_TextChanged;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ActiveBorder;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(653, 519);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(153, 48);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Coral;
            lblTitle.Location = new Point(226, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 60);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "CYBERSECURITY AWARENESS BOT";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = SystemColors.ActiveCaption;
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = Properties.Resources.WhatsApp_Image_2026_05_29_at_18_52_59;
            picLogo.Location = new Point(12, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(120, 120);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnPrivacy);
            groupBox1.Controls.Add(btnPassword);
            groupBox1.Controls.Add(btnScam);
            groupBox1.ForeColor = Color.DarkOrange;
            groupBox1.Location = new Point(871, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 250);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Suggested Topics";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnPrivacy
            // 
            btnPrivacy.BackColor = Color.MidnightBlue;
            btnPrivacy.Location = new Point(6, 158);
            btnPrivacy.Name = "btnPrivacy";
            btnPrivacy.Size = new Size(238, 34);
            btnPrivacy.TabIndex = 8;
            btnPrivacy.Text = "Online Privacy";
            btnPrivacy.UseVisualStyleBackColor = false;
            btnPrivacy.Click += btnPrivacy_Click;
            // 
            // btnPassword
            // 
            btnPassword.BackColor = Color.MidnightBlue;
            btnPassword.Location = new Point(6, 42);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(238, 34);
            btnPassword.TabIndex = 6;
            btnPassword.Text = "Password Safety";
            btnPassword.UseVisualStyleBackColor = false;
            btnPassword.Click += btnPassword_Click;
            // 
            // btnScam
            // 
            btnScam.BackColor = Color.MidnightBlue;
            btnScam.Location = new Point(6, 98);
            btnScam.Name = "btnScam";
            btnScam.Size = new Size(238, 34);
            btnScam.TabIndex = 7;
            btnScam.Text = "Scam Awareness";
            btnScam.UseVisualStyleBackColor = false;
            btnScam.Click += btnScam_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnGreeting);
            groupBox2.ForeColor = Color.DarkOrange;
            groupBox2.Location = new Point(871, 375);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 150);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quick Actions";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MidnightBlue;
            btnClear.Location = new Point(31, 110);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear Chat";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnGreeting
            // 
            btnGreeting.BackColor = Color.MidnightBlue;
            btnGreeting.Location = new Point(31, 44);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(155, 34);
            btnGreeting.TabIndex = 0;
            btnGreeting.Text = "Play Greeting";
            btnGreeting.UseVisualStyleBackColor = false;
            btnGreeting.Click += btnGreeting_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = SystemColors.HotTrack;
            lblStatus.Location = new Point(20, 567);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(117, 25);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status: Ready";
            lblStatus.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabChat);
            tabControl1.Controls.Add(tabTasks);
            tabControl1.Controls.Add(tabQuiz);
            tabControl1.Controls.Add(tabActivity);
            tabControl1.Location = new Point(12, 126);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1196, 643);
            tabControl1.TabIndex = 8;
            // 
            // tabChat
            // 
            tabChat.BackColor = SystemColors.ActiveCaption;
            tabChat.Controls.Add(btnSend);
            tabChat.Controls.Add(rtbChat);
            tabChat.Controls.Add(txtUserInput);
            tabChat.Controls.Add(groupBox2);
            tabChat.Controls.Add(lblStatus);
            tabChat.Controls.Add(groupBox1);
            tabChat.Location = new Point(4, 34);
            tabChat.Name = "tabChat";
            tabChat.Padding = new Padding(3);
            tabChat.Size = new Size(1188, 605);
            tabChat.TabIndex = 0;
            tabChat.Text = "Chatbot";
            // 
            // tabTasks
            // 
            tabTasks.BackColor = Color.DarkSeaGreen;
            tabTasks.Controls.Add(lstTasks);
            tabTasks.Controls.Add(btnDeleteTask);
            tabTasks.Controls.Add(btnCompleteTask);
            tabTasks.Controls.Add(btnAddTask);
            tabTasks.Controls.Add(dtpReminder);
            tabTasks.Controls.Add(label1);
            tabTasks.Controls.Add(txtTaskDescription);
            tabTasks.Controls.Add(txtTaskTitle);
            tabTasks.Controls.Add(txtDescription);
            tabTasks.Controls.Add(Title);
            tabTasks.Location = new Point(4, 34);
            tabTasks.Name = "tabTasks";
            tabTasks.Padding = new Padding(3);
            tabTasks.Size = new Size(1188, 605);
            tabTasks.TabIndex = 1;
            tabTasks.Text = "Tasks";
            // 
            // lstTasks
            // 
            lstTasks.BackColor = SystemColors.InactiveCaption;
            lstTasks.BorderStyle = BorderStyle.FixedSingle;
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(494, 121);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(586, 277);
            lstTasks.TabIndex = 9;
            lstTasks.SelectedIndexChanged += lstTasks_SelectedIndexChanged;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.CornflowerBlue;
            btnDeleteTask.FlatStyle = FlatStyle.Popup;
            btnDeleteTask.Location = new Point(300, 383);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(112, 34);
            btnDeleteTask.TabIndex = 8;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.BackColor = Color.Red;
            btnCompleteTask.FlatStyle = FlatStyle.Popup;
            btnCompleteTask.Location = new Point(148, 383);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(146, 34);
            btnCompleteTask.TabIndex = 7;
            btnCompleteTask.Text = "Complete Task";
            btnCompleteTask.UseVisualStyleBackColor = false;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Lime;
            btnAddTask.FlatStyle = FlatStyle.Popup;
            btnAddTask.ForeColor = SystemColors.ActiveCaptionText;
            btnAddTask.Location = new Point(30, 383);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(112, 34);
            btnAddTask.TabIndex = 6;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dtpReminder
            // 
            dtpReminder.Location = new Point(30, 327);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.Size = new Size(300, 31);
            dtpReminder.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(30, 299);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 4;
            label1.Text = "Reminder Date:";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(30, 181);
            txtTaskDescription.Multiline = true;
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(382, 92);
            txtTaskDescription.TabIndex = 3;
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(30, 100);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(382, 31);
            txtTaskTitle.TabIndex = 2;
            txtTaskTitle.TextChanged += txtTaskTitle_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.AutoSize = true;
            txtDescription.ForeColor = SystemColors.ActiveCaptionText;
            txtDescription.Location = new Point(30, 153);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(106, 25);
            txtDescription.TabIndex = 1;
            txtDescription.Text = "Description:";
            txtDescription.Click += txtTaskDescription_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.ForeColor = SystemColors.ActiveCaptionText;
            Title.Location = new Point(30, 72);
            Title.Name = "Title";
            Title.Size = new Size(86, 25);
            Title.TabIndex = 0;
            Title.Text = "Task Title:";
            // 
            // tabQuiz
            // 
            tabQuiz.BackColor = Color.LightGray;
            tabQuiz.Controls.Add(btnSubmitAnswer);
            tabQuiz.Controls.Add(lblQuestion);
            tabQuiz.Controls.Add(grpQuizStats);
            tabQuiz.Controls.Add(btnResetQuiz);
            tabQuiz.Controls.Add(btnNextQuestion);
            tabQuiz.Controls.Add(lblQuestionNumber);
            tabQuiz.Controls.Add(rbOptionD);
            tabQuiz.Controls.Add(rbOptionC);
            tabQuiz.Controls.Add(rbOptionB);
            tabQuiz.Controls.Add(rbOptionA);
            tabQuiz.Controls.Add(lblFeedback);
            tabQuiz.Controls.Add(btnStartQuiz);
            tabQuiz.Controls.Add(lblQuizInstructions);
            tabQuiz.Location = new Point(4, 34);
            tabQuiz.Name = "tabQuiz";
            tabQuiz.Padding = new Padding(3);
            tabQuiz.Size = new Size(1188, 605);
            tabQuiz.TabIndex = 2;
            tabQuiz.Text = "Quiz";
            tabQuiz.Click += tabPage3_Click;
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.Location = new Point(21, 442);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(191, 34);
            btnSubmitAnswer.TabIndex = 19;
            btnSubmitAnswer.Text = "Submit Answer";
            btnSubmitAnswer.UseVisualStyleBackColor = true;
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(21, 97);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(191, 25);
            lblQuestion.TabIndex = 18;
            lblQuestion.Text = "Question appears here";
            // 
            // grpQuizStats
            // 
            grpQuizStats.BackColor = Color.LightGray;
            grpQuizStats.Controls.Add(lblIncorrect);
            grpQuizStats.Controls.Add(lblCorrect);
            grpQuizStats.Controls.Add(lblScore);
            grpQuizStats.Location = new Point(779, 250);
            grpQuizStats.Name = "grpQuizStats";
            grpQuizStats.Size = new Size(300, 226);
            grpQuizStats.TabIndex = 17;
            grpQuizStats.TabStop = false;
            grpQuizStats.Text = "Quiz Statistics";
            // 
            // lblIncorrect
            // 
            lblIncorrect.AutoSize = true;
            lblIncorrect.Location = new Point(17, 170);
            lblIncorrect.Name = "lblIncorrect";
            lblIncorrect.Size = new Size(100, 25);
            lblIncorrect.TabIndex = 20;
            lblIncorrect.Text = "Incorrect: 0";
            // 
            // lblCorrect
            // 
            lblCorrect.AutoSize = true;
            lblCorrect.Location = new Point(17, 115);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(88, 25);
            lblCorrect.TabIndex = 19;
            lblCorrect.Text = "Correct: 0";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(17, 54);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(75, 25);
            lblScore.TabIndex = 18;
            lblScore.Text = "Score: 0";
            // 
            // btnResetQuiz
            // 
            btnResetQuiz.Location = new Point(456, 442);
            btnResetQuiz.Name = "btnResetQuiz";
            btnResetQuiz.Size = new Size(112, 34);
            btnResetQuiz.TabIndex = 16;
            btnResetQuiz.Text = "Reset Quiz";
            btnResetQuiz.UseVisualStyleBackColor = true;
            btnResetQuiz.Click += btnResetQuiz_Click;
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.Location = new Point(233, 442);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new Size(163, 34);
            btnNextQuestion.TabIndex = 15;
            btnNextQuestion.Text = "Next Question";
            btnNextQuestion.UseVisualStyleBackColor = true;
            btnNextQuestion.Click += btnNextQuestion_Click;
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Location = new Point(759, 97);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(151, 25);
            lblQuestionNumber.TabIndex = 14;
            lblQuestionNumber.Text = " Question 1 of 10";
            // 
            // rbOptionD
            // 
            rbOptionD.AutoSize = true;
            rbOptionD.Location = new Point(21, 361);
            rbOptionD.Name = "rbOptionD";
            rbOptionD.Size = new Size(141, 29);
            rbOptionD.TabIndex = 11;
            rbOptionD.TabStop = true;
            rbOptionD.Text = "radioButton4";
            rbOptionD.UseVisualStyleBackColor = true;
            // 
            // rbOptionC
            // 
            rbOptionC.AutoSize = true;
            rbOptionC.Location = new Point(21, 289);
            rbOptionC.Name = "rbOptionC";
            rbOptionC.Size = new Size(141, 29);
            rbOptionC.TabIndex = 10;
            rbOptionC.TabStop = true;
            rbOptionC.Text = "radioButton3";
            rbOptionC.UseVisualStyleBackColor = true;
            // 
            // rbOptionB
            // 
            rbOptionB.AutoSize = true;
            rbOptionB.Location = new Point(21, 218);
            rbOptionB.Name = "rbOptionB";
            rbOptionB.Size = new Size(141, 29);
            rbOptionB.TabIndex = 9;
            rbOptionB.TabStop = true;
            rbOptionB.Text = "radioButton2";
            rbOptionB.UseVisualStyleBackColor = true;
            // 
            // rbOptionA
            // 
            rbOptionA.AutoSize = true;
            rbOptionA.Location = new Point(21, 147);
            rbOptionA.Name = "rbOptionA";
            rbOptionA.Size = new Size(141, 29);
            rbOptionA.TabIndex = 8;
            rbOptionA.TabStop = true;
            rbOptionA.Text = "radioButton1";
            rbOptionA.UseVisualStyleBackColor = true;
            // 
            // lblFeedback
            // 
            lblFeedback.Location = new Point(21, 520);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(500, 50);
            lblFeedback.TabIndex = 7;
            lblFeedback.Text = "Ready to start...";
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(479, 31);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(112, 34);
            btnStartQuiz.TabIndex = 5;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // lblQuizInstructions
            // 
            lblQuizInstructions.Location = new Point(21, 18);
            lblQuizInstructions.Name = "lblQuizInstructions";
            lblQuizInstructions.Size = new Size(437, 60);
            lblQuizInstructions.TabIndex = 0;
            lblQuizInstructions.Text = "Welcome to the Cybersecurity Quiz!\nClick Start Quiz and answer each question.";
            // 
            // tabActivity
            // 
            tabActivity.BackColor = Color.PowderBlue;
            tabActivity.BorderStyle = BorderStyle.FixedSingle;
            tabActivity.Controls.Add(btnShowMore);
            tabActivity.Controls.Add(lblStatusA);
            tabActivity.Controls.Add(btnClearLog);
            tabActivity.Controls.Add(groupBox3);
            tabActivity.Controls.Add(lblActivityInfo);
            tabActivity.Controls.Add(lblActivityTitle);
            tabActivity.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabActivity.ForeColor = Color.White;
            tabActivity.Location = new Point(4, 34);
            tabActivity.Name = "tabActivity";
            tabActivity.Padding = new Padding(3);
            tabActivity.Size = new Size(1188, 605);
            tabActivity.TabIndex = 3;
            tabActivity.Text = "Activity Log";
            tabActivity.Click += tabActivity_Click;
            // 
            // btnShowMore
            // 
            btnShowMore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowMore.ForeColor = Color.Black;
            btnShowMore.Location = new Point(732, 511);
            btnShowMore.Name = "btnShowMore";
            btnShowMore.Size = new Size(156, 40);
            btnShowMore.TabIndex = 6;
            btnShowMore.Text = "Show More";
            btnShowMore.UseVisualStyleBackColor = true;
            btnShowMore.Click += btnShowMore_Click;
            // 
            // lblStatusA
            // 
            lblStatusA.AutoSize = true;
            lblStatusA.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusA.ForeColor = Color.FromArgb(0, 192, 0);
            lblStatusA.Location = new Point(1015, 27);
            lblStatusA.Name = "lblStatusA";
            lblStatusA.Size = new Size(156, 30);
            lblStatusA.TabIndex = 5;
            lblStatusA.Text = "Status: Online";
            // 
            // btnClearLog
            // 
            btnClearLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearLog.ForeColor = Color.Black;
            btnClearLog.Location = new Point(59, 511);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(156, 40);
            btnClearLog.TabIndex = 4;
            btnClearLog.Text = "Clear Log";
            btnClearLog.UseVisualStyleBackColor = true;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstActivityLog);
            groupBox3.Location = new Point(48, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(862, 356);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Recent Chatbot Activity";
            // 
            // lstActivityLog
            // 
            lstActivityLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstActivityLog.FormattingEnabled = true;
            lstActivityLog.Location = new Point(11, 74);
            lstActivityLog.Name = "lstActivityLog";
            lstActivityLog.Size = new Size(829, 228);
            lstActivityLog.TabIndex = 0;
            lstActivityLog.SelectedIndexChanged += lstActivityLogs_SelectedIndexChanged;
            // 
            // lblActivityInfo
            // 
            lblActivityInfo.AutoSize = true;
            lblActivityInfo.BackColor = Color.Transparent;
            lblActivityInfo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActivityInfo.ForeColor = Color.Black;
            lblActivityInfo.Location = new Point(48, 99);
            lblActivityInfo.Name = "lblActivityInfo";
            lblActivityInfo.Size = new Size(685, 38);
            lblActivityInfo.TabIndex = 2;
            lblActivityInfo.Text = "Here are the recent actions performed by the chatbot.";
            // 
            // lblActivityTitle
            // 
            lblActivityTitle.AutoSize = true;
            lblActivityTitle.ForeColor = Color.Navy;
            lblActivityTitle.Location = new Point(389, 12);
            lblActivityTitle.Name = "lblActivityTitle";
            lblActivityTitle.Size = new Size(205, 48);
            lblActivityTitle.TabIndex = 1;
            lblActivityTitle.Text = "Activity Log";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1236, 801);
            Controls.Add(tabControl1);
            Controls.Add(picLogo);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "CyberSecurity";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabChat.ResumeLayout(false);
            tabChat.PerformLayout();
            tabTasks.ResumeLayout(false);
            tabTasks.PerformLayout();
            tabQuiz.ResumeLayout(false);
            tabQuiz.PerformLayout();
            grpQuizStats.ResumeLayout(false);
            grpQuizStats.PerformLayout();
            tabActivity.ResumeLayout(false);
            tabActivity.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbChat;
        private TextBox txtUserInput;
        private Button btnSend;
        private Label lblTitle;
        private PictureBox picLogo;
        private GroupBox groupBox1;
        private Button btnPrivacy;
        private Button btnPassword;
        private Button btnScam;
        private GroupBox groupBox2;
        private Button btnClear;
        private Button btnGreeting;
        private Label lblStatus;
        private TabControl tabControl1;
        private TabPage tabChat;
        private TabPage tabTasks;
        private TabPage tabQuiz;
        private TabPage tabActivity;
        private Label txtDescription;
        private Label Title;
        private TextBox txtTaskDescription;
        private TextBox txtTaskTitle;
        private Label label1;
        private Button btnDeleteTask;
        private Button btnCompleteTask;
        private Button btnAddTask;
        private DateTimePicker dtpReminder;
        private ListBox lstTasks;
        private Label lblQuizInstructions;
        private Button btnStartQuiz;
        private Label lblFeedback;
        private RadioButton rbOptionD;
        private RadioButton rbOptionC;
        private RadioButton rbOptionB;
        private RadioButton rbOptionA;
        private Label lblQuestionNumber;
        private Button btnNextQuestion;
        private GroupBox grpQuizStats;
        private Label lblIncorrect;
        private Label lblCorrect;
        private Label lblScore;
        private Button btnResetQuiz;
        private Label lblQuestion;
        private Button btnSubmitAnswer;
        private ListBox lstActivityLog;
        private Label lblActivityTitle;
        private Label lblActivityInfo;
        private Button btnClearLog;
        private GroupBox groupBox3;
        private Label lblStatusA;
        private Button btnShowMore;
    }
}
