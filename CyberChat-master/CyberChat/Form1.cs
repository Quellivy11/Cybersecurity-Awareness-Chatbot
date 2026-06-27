using System.Media;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CyberChat

{
    public partial class Form1 : Form
    {
        private int currentQuestion = 0;
        private int score = 0;
        private int correctAnswers = 0;
        private int incorrectAnswers = 0;
        private bool answerSubmitted = false;
        private List<QuizQuestion> quizQuestions = new List<QuizQuestion>();
        //ChatbotEngine chatbot = new ChatbotEngine();
        private List<string> tasks = new List<string>();
        List<string> activityLog = new List<string>();

        private string connectionString =
        "server=localhost;database=cyberchatdb;uid=root;pwd=;";
        public Form1()
        {
            InitializeComponent();
            LoadQuizQuestions();
            LoadTasksFromDatabase();
        }
        private void AddMessage(string sender, string message, Color color)
        {
            string time = DateTime.Now.ToShortTimeString();

            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionColor = Color.Gray;
            rtbChat.AppendText("[" + time + "] ");

            rtbChat.SelectionColor = color;
            rtbChat.AppendText(sender + ": ");

            rtbChat.SelectionColor = Color.White;
            rtbChat.AppendText(message + "\n\n");

            rtbChat.SelectionColor = rtbChat.ForeColor;

            rtbChat.ScrollToCaret();
        }

        ChatbotEngine chatbot = new ChatbotEngine();
        Random random = new Random();

        string currentTopic = "";
        string favouriteTopic = "";

        List<string> phishingResponses = new List<string>()
{
    "Be careful of emails asking for personal information.",
    "Never click suspicious links from unknown senders.",
    "Scammers often pretend to be trusted companies."
};

        List<string> passwordResponses = new List<string>()
{
    "Use strong passwords with symbols and numbers.",
    "Avoid using your birthday in passwords.",
    "Use a different password for every account."
};
        private void Form1_Load(object sender, EventArgs e)
        {
            rtbChat.BackColor = Color.Black;

            AddMessage("BOT",
                "Welcome to the Cybersecurity Awareness Bot!",
                Color.Lime);

            AddMessage("BOT",
                "Before we begin, what is your name?",
                Color.Lime);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text;

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            AddMessage("YOU", userInput, Color.Cyan);
            if (ProcessNLP(userInput))
            {
                txtUserInput.Clear();
                return;
            }

            string response = chatbot.GetResponse(userInput);

            AddMessage("BOT", response, Color.Lime);

            txtUserInput.Clear();
        }

        private void AddActivity(string activity)
        {
            string logEntry =
                DateTime.Now.ToString("dd/MM/yyyy HH:mm") +
                " - " +
                activity;

            activityLog.Add(logEntry);

            lstActivityLog.Items.Insert(0, logEntry);

            if (lstActivityLog.Items.Count > 10)
            {
                lstActivityLog.Items.RemoveAt(10);
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void rtbChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnPassword_Click(object sender, EventArgs e)
        {
            AddMessage("YOU", "Tell me about passwords", Color.Cyan);

            string response = chatbot.GetResponse("password");

            AddMessage("BOT", response, Color.Lime);
        }
        private void btnScam_Click(object sender, EventArgs e)
        {
            AddMessage("YOU", "Tell me about phishing", Color.Cyan);

            string response = chatbot.GetResponse("phishing");

            AddMessage("BOT", response, Color.Lime);
        }

        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            AddMessage("YOU", "Tell me about privacy", Color.Cyan);

            string response = chatbot.GetResponse("privacy");

            AddMessage("BOT", response, Color.Lime);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbChat.Clear();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            string audioFile = "Assets/greeting.wav";

            SoundPlayer player = new SoundPlayer(audioFile);
            player.PlaySync();
        }
        // TASK DATABASE METHODS
        private void txtTaskDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text.Trim();
            string description = txtTaskDescription.Text.Trim();
            string reminder = dtpReminder.Value.ToShortDateString();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            string taskInfo =
                title + " | " +
                description + " | Reminder: " +
                reminder;

            tasks.Add(taskInfo);

            lstTasks.Items.Add(taskInfo);
            SaveTaskToDatabase(title, description, dtpReminder.Value);

            txtTaskTitle.Clear();
            txtTaskDescription.Clear();

            AddActivity("Task Added: " + title);
            MessageBox.Show("Task added successfully.");
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTaskTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                string taskInfo = lstTasks.SelectedItem.ToString();

                if (taskInfo.StartsWith("[COMPLETED] "))
                {
                    taskInfo = taskInfo.Replace("[COMPLETED] ", "");
                }

                string title = taskInfo.Split('|')[0].Trim();

                AddActivity("Task Deleted: " + title);

                DeleteTaskFromDatabase(title);

                LoadTasksFromDatabase();

                MessageBox.Show("Task deleted.");
            }
            else
            {
                MessageBox.Show("Please select a task.");
            }
        }
        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                string taskInfo = lstTasks.SelectedItem.ToString();

                if (taskInfo.StartsWith("[COMPLETED] "))
                {
                    taskInfo = taskInfo.Replace("[COMPLETED] ", "");
                }

                string title = taskInfo.Split('|')[0].Trim();

                CompleteTaskInDatabase(title);

                AddActivity("Task Completed: " + title);

                LoadTasksFromDatabase();

                MessageBox.Show("Task marked as completed.");
            }
            else
            {
                MessageBox.Show("Please select a task.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void btnShowLog_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // QUIZ METHODS
        private void LoadQuizQuestions()
        {
            quizQuestions.Add(new QuizQuestion
            {
                Question = "What should you do if an email asks for your password?",
                OptionA = "Reply with your password",
                OptionB = "Delete the email",
                OptionC = "Report it as phishing",
                OptionD = "Forward it",
                CorrectAnswer = "C",
                Explanation = "Phishing emails should be reported."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "True or False: Reusing passwords is safe.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",
                CorrectAnswer = "B",
                Explanation = "Each account should have a unique password."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "What does 2FA stand for?",
                OptionA = "Two Factor Authentication",
                OptionB = "Two File Access",
                OptionC = "Transfer File Access",
                OptionD = "Two Fast Accounts",
                CorrectAnswer = "A",
                Explanation = "2FA adds an extra security layer."
            });
            quizQuestions.Add(new QuizQuestion
            {
                Question = "Which password is strongest?",
                OptionA = "123456",
                OptionB = "password",
                OptionC = "P@ssw0rd123!",
                OptionD = "abcdef",
                CorrectAnswer = "C",
                Explanation = "Strong passwords contain symbols, numbers and mixed case letters."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "What is phishing?",
                OptionA = "A fishing hobby",
                OptionB = "A cyberattack using fake messages",
                OptionC = "Antivirus software",
                OptionD = "A firewall",
                CorrectAnswer = "B",
                Explanation = "Phishing tricks users into revealing information."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "Should you share OTP codes with others?",
                OptionA = "Yes",
                OptionB = "No",
                OptionC = "Sometimes",
                OptionD = "Only with friends",
                CorrectAnswer = "B",
                Explanation = "OTPs should never be shared."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "What does VPN stand for?",
                OptionA = "Virtual Private Network",
                OptionB = "Verified Personal Number",
                OptionC = "Virtual Password Network",
                OptionD = "Very Protected Network",
                CorrectAnswer = "A",
                Explanation = "VPN stands for Virtual Private Network."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "True or False: Public Wi-Fi is always safe.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",
                CorrectAnswer = "B",
                Explanation = "Public Wi-Fi can be risky without protection."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "What should you do before clicking a link?",
                OptionA = "Click immediately",
                OptionB = "Verify the source",
                OptionC = "Forward it",
                OptionD = "Ignore it",
                CorrectAnswer = "B",
                Explanation = "Always verify links before clicking."
            });

            quizQuestions.Add(new QuizQuestion
            {
                Question = "What is malware?",
                OptionA = "A type of hardware",
                OptionB = "Malicious software",
                OptionC = "A browser",
                OptionD = "An operating system",
                CorrectAnswer = "B",
                Explanation = "Malware is software designed to harm devices."
            });
        }
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;
            score = 0;
            correctAnswers = 0;
            incorrectAnswers = 0;

            answerSubmitted = false;
            btnNextQuestion.Enabled = false;
            btnSubmitAnswer.Enabled = true;

            ShowQuestion();

            AddActivity("Quiz Started");
        }

        private void ShowQuestion()
        {
            QuizQuestion q = quizQuestions[currentQuestion];

            lblQuestionNumber.Text =
                "Question " +
                (currentQuestion + 1) +
                " of " +
                quizQuestions.Count;

            lblQuestion.Text = q.Question;

            rbOptionA.Text = q.OptionA;
            rbOptionB.Text = q.OptionB;
            rbOptionC.Text = q.OptionC;
            rbOptionD.Text = q.OptionD;

            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;

            answerSubmitted = false;
            btnNextQuestion.Enabled = false;
            btnSubmitAnswer.Enabled = true;
        }
        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            string selectedAnswer = "";

            if (rbOptionA.Checked) selectedAnswer = "A";
            else if (rbOptionB.Checked) selectedAnswer = "B";
            else if (rbOptionC.Checked) selectedAnswer = "C";
            else if (rbOptionD.Checked) selectedAnswer = "D";

            if (selectedAnswer == "")
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            QuizQuestion q = quizQuestions[currentQuestion];

            if (selectedAnswer == q.CorrectAnswer)
            {
                score++;
                correctAnswers++;

                MessageBox.Show(
                    "Correct!" +
                    Environment.NewLine +
                    q.Explanation);
            }
            else
            {
                incorrectAnswers++;

                MessageBox.Show(
                    "Incorrect!" +
                    Environment.NewLine +
                    q.Explanation);
            }

            lblScore.Text = "Score: " + score;
            lblCorrect.Text = "Correct: " + correctAnswers;
            lblIncorrect.Text = "Incorrect: " + incorrectAnswers;

            AddActivity("Quiz Question Answered");
            answerSubmitted = true;
            btnNextQuestion.Enabled = true;
            btnSubmitAnswer.Enabled = false;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (!answerSubmitted)
            {
                MessageBox.Show("Please answer the current question first.");
                return;
            }
            currentQuestion++;

            if (currentQuestion < quizQuestions.Count)
            {
                ShowQuestion();
            }
            else
            {
                string feedback = "";

                if (score >= 10)
                {
                    feedback = "Excellent! You're a cybersecurity expert!";
                }
                else if (score >= 7)
                {
                    feedback = "Great job! You have strong cybersecurity knowledge.";
                }
                else if (score >= 4)
                {
                    feedback = "Good effort! Keep learning to stay safe online.";
                }
                else
                {
                    feedback = "Keep practicing! Review the chatbot tips and try again.";
                }

                MessageBox.Show(
                    "Quiz Finished!" +
                    Environment.NewLine +
                    Environment.NewLine +
                    "Final Score: " + score + " / " + quizQuestions.Count +
                    Environment.NewLine +
                    Environment.NewLine +
                    feedback,
                    "Quiz Results");

                AddActivity("Quiz Completed - Score: " + score + "/" + quizQuestions.Count);

                answerSubmitted = true;
                btnSubmitAnswer.Enabled = false;
                btnNextQuestion.Enabled = false;
            }
        }

        private void btnResetQuiz_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;
            score = 0;
            correctAnswers = 0;
            incorrectAnswers = 0;

            lblScore.Text = "Score: 0";
            lblCorrect.Text = "Correct: 0";
            lblIncorrect.Text = "Incorrect: 0";

            btnSubmitAnswer.Enabled = true;
            btnNextQuestion.Enabled = true;

            ShowQuestion();

            AddActivity("Quiz Reset");
        }


        // TASK DATABASE METHODS
        private void SaveTaskToDatabase(string title, string description, DateTime reminder)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check for duplicate task
                    string checkQuery = "SELECT COUNT(*) FROM Tasks WHERE Title = @title";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@title", title);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("A task with this title already exists.");
                        return;
                    }

                    // Insert the new task
                    string query = @"INSERT INTO Tasks
                            (Title, Description, ReminderDate)
                            VALUES
                            (@title, @description, @reminder)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@reminder", reminder);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Task saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Task could not be saved.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database Error:\n\n" + ex.Message,
                    "MySQL Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadTasksFromDatabase()
        {
            lstTasks.Items.Clear();
            tasks.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Tasks";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        bool completed = Convert.ToBoolean(reader["IsCompleted"]);

                        string taskInfo =
                            reader["Title"].ToString() +
                            " | " +
                            reader["Description"].ToString() +
                            " | Reminder: " +
                            Convert.ToDateTime(reader["ReminderDate"]).ToShortDateString();

                        if (completed)
                        {
                            taskInfo = "[COMPLETED] " + taskInfo;
                        }

                        tasks.Add(taskInfo);
                        lstTasks.Items.Add(taskInfo);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database Error:\n\n" + ex.Message,
                    "MySQL Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DeleteTaskFromDatabase(string title)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                        "DELETE FROM Tasks WHERE TRIM(Title)=TRIM(@title) LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@title", title);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Task not found in the database.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database Error:\n\n" + ex.Message,
                    "MySQL Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CompleteTaskInDatabase(string title)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                        "UPDATE Tasks SET IsCompleted = 1 WHERE Title = @title LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@title", title);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Unable to mark task as completed.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database Error:\n\n" + ex.Message,
                    "MySQL Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            activityLog.Clear();
            lstActivityLog.Items.Clear();

            MessageBox.Show("Activity log cleared.");
        }

        private void tabActivity_Click(object sender, EventArgs e)
        {

        }

        // NLP PROCESSING
        private bool ProcessNLP(string input)
        {
            input = input.ToLower().Trim();

            // ===========================
            // QUIZ COMMANDS
            // ===========================
            if (input.Contains("quiz") ||
                input.Contains("start quiz") ||
                input.Contains("play quiz") ||
                input.Contains("take quiz") ||
                input.Contains("test me") ||
                input.Contains("test my knowledge") ||
                input.Contains("challenge me") ||
                input.Contains("ask me questions"))
            {
                tabControl1.SelectedTab = tabQuiz;

                string[] replies =
                {
            "Let's test your cybersecurity knowledge!",
            "Great! Opening the Cybersecurity Quiz.",
            "Ready for a challenge? Here's the quiz!",
            "Let's see how much you know about cybersecurity."
        };

                AddMessage("BOT", replies[random.Next(replies.Length)], Color.Lime);

                return true;
            }

            // ===========================
            // TASK COMMANDS
            // ===========================
            if (input.Contains("task") ||
                input.Contains("tasks") ||
                input.Contains("add task") ||
                input.Contains("create task") ||
                input.Contains("new task") ||
                input.Contains("reminder") ||
                input.Contains("remind me") ||
                input.Contains("remember to") ||
                input.Contains("set reminder"))
            {
                tabControl1.SelectedTab = tabTasks;

                string[] replies =
                {
            "Opening your Task Assistant.",
            "Let's organise your cybersecurity tasks.",
            "Sure! I'll help you manage your reminders.",
            "Opening the Task Manager now."
        };

                AddMessage("BOT", replies[random.Next(replies.Length)], Color.Lime);

                return true;
            }

            // ===========================
            // ACTIVITY LOG COMMANDS
            // ===========================
            if (input.Contains("activity") ||
                input.Contains("activity log") ||
                input.Contains("show history") ||
                input.Contains("show log") ||
                input.Contains("recent activity") ||
                input.Contains("what have i done") ||
                input.Contains("my activity"))
            {
                tabControl1.SelectedTab = tabActivity;

                string[] replies =
                {
            "Opening your Activity Log.",
            "Here are your recent activities.",
            "Showing your activity history.",
            "Opening the Activity Log now."
        };

                AddMessage("BOT", replies[random.Next(replies.Length)], Color.Lime);

                return true;
            }

            // ===========================
            // PASSWORD QUESTIONS
            // ===========================
            if (input.Contains("password") ||
                input.Contains("strong password") ||
                input.Contains("secure password") ||
                input.Contains("password safety") ||
                input.Contains("password tips"))
            {
                AddMessage("BOT", chatbot.GetResponse("password"), Color.Lime);
                return true;
            }

            // ===========================
            // PHISHING QUESTIONS
            // ===========================
            if (input.Contains("phishing") ||
                input.Contains("fake email") ||
                input.Contains("email scam") ||
                input.Contains("scam email") ||
                input.Contains("phishing attack"))
            {
                AddMessage("BOT", chatbot.GetResponse("phishing"), Color.Lime);
                return true;
            }

            // ===========================
            // PRIVACY QUESTIONS
            // ===========================
            if (input.Contains("privacy") ||
                input.Contains("protect my information") ||
                input.Contains("personal information") ||
                input.Contains("online privacy") ||
                input.Contains("data privacy"))
            {
                AddMessage("BOT", chatbot.GetResponse("privacy"), Color.Lime);
                return true;
            }

            // ===========================
            // MALWARE QUESTIONS
            // ===========================
            if (input.Contains("malware") ||
                input.Contains("virus") ||
                input.Contains("trojan") ||
                input.Contains("ransomware"))
            {
                AddMessage("BOT",
                    "Malware is malicious software designed to damage or gain unauthorized access to your computer. Always keep your antivirus software up to date and avoid downloading files from unknown sources.",
                    Color.Lime);

                return true;
            }

            // ===========================
            // SAFE BROWSING
            // ===========================
            if (input.Contains("safe browsing") ||
                input.Contains("browse safely") ||
                input.Contains("internet safety") ||
                input.Contains("online safety"))
            {
                AddMessage("BOT",
                    "Always use secure websites (HTTPS), avoid suspicious links, keep your browser updated, and never download files from untrusted websites.",
                    Color.Lime);

                return true;
            }

            // ===========================
            // GREETINGS
            // ===========================
            if (input.Contains("hello") ||
                input.Contains("hi") ||
                input.Contains("hey"))
            {
                string[] greetings =
                {
            "Hello! How can I help you today?",
            "Hi there! Ask me anything about cybersecurity.",
            "Welcome back! What would you like to know?",
            "Hello! I'm ready to help keep you safe online."
        };

                AddMessage("BOT", greetings[random.Next(greetings.Length)], Color.Lime);

                return true;
            }

            // ===========================
            // THANK YOU
            // ===========================
            if (input.Contains("thank"))
            {
                AddMessage("BOT",
                    "You're welcome! Stay safe online.",
                    Color.Lime);

                return true;
            }

            // ===========================
            // GOODBYE
            // ===========================
            if (input.Contains("bye") ||
                input.Contains("goodbye") ||
                input.Contains("see you"))
            {
                AddMessage("BOT",
                    "Goodbye! Remember to stay cyber safe!",
                    Color.Lime);

                return true;
            }

            return false;
        }

        private void lstActivityLogs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowMore_Click(object sender, EventArgs e)
        {
            lstActivityLog.Items.Clear();

            foreach (string activity in activityLog)
            {
                lstActivityLog.Items.Add(activity);
            }
        }
    }

}