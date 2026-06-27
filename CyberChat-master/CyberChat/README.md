

## Author

Developed as part of a Cybersecurity Awareness Chatbot Programming Project using C# and WinForms.
# CyberChat – Cybersecurity Awareness Chatbot

## Student Information

**Student Name:Fana Thopola

**Student Number:(ST10473433)

**Module:** PROG6221

**Project:** CyberChat – Cybersecurity Awareness Chatbot

---

### Part 1 Features

* Voice greeting using a WAV audio file.
* Cybersecurity-themed ASCII art and branding.
* Personalized greeting using the user's name.
* Basic cybersecurity question-and-answer system.
* Input validation for invalid or empty entries.
* Enhanced console styling and structured output.
* Modular code structure using classes and methods.

### Part 2 Features

* WinForms Graphical User Interface (GUI).
* Interactive chatbot conversation window.
* Keyword recognition for cybersecurity topics.
* Randomized responses for varied interactions.
* Conversation flow with follow-up responses.
* User memory and recall functionality.
* Sentiment detection and adaptive responses.
* Error handling for unexpected inputs.
* Organized code using dictionaries, lists, delegates, and OOP principles.

---

## Cybersecurity Topics Covered

The chatbot provides information and guidance on:

* Password Safety
* Phishing Attacks
* Online Scams
* Privacy Protection
* Safe Browsing
* Two-Factor Authentication (2FA)

---

## Memory Features

The chatbot can remember:

* User name
* User cybersecurity interests

Example:

User:

```
I am interested in privacy
```

Chatbot:

```
Great! I will remember that you are interested in privacy.
```

Later:

User:

```
What do you know about me?
```

Chatbot:

```
I remember that your name is John and you are interested in privacy.
```

---

## Sentiment Detection

The chatbot detects simple user emotions and adjusts its responses accordingly.

Supported sentiments include:

* Worried
* Curious
* Frustrated

Example:

User:

```
I am worried about online scams.
```

Chatbot:

```
It is understandable to feel worried. Cybersecurity can feel overwhelming, but there are practical steps you can take to stay safe online.
```

---

## Technologies Used

* C#
* .NET
* Windows Forms (WinForms)
* System.Media
* Object-Oriented Programming (OOP)
* Dictionaries
* Lists
* Delegates
* GitHub Version Control

---

## Example Questions

Users can ask questions such as:

* How are you?
* What is your purpose?
* Tell me about password safety.
* What is phishing?
* Give me a scam tip.
* Tell me about privacy.
* Explain safe browsing.
* What is 2FA?
* Tell me more.
* What do you know about me?

---

## Future Improvements

Potential future enhancements include:

* AI-powered responses
* Database integration
* User authentication
* Cybersecurity quizzes
* Threat awareness assessments
* Additional cybersecurity topics
* Cloud deployment

---

part 3
# Project Overview

CyberChat is a Windows Forms application developed using C# and MySQL. The application is designed to improve cybersecurity awareness by allowing users to interact with a chatbot, manage cybersecurity-related tasks, complete a cybersecurity quiz, and view an activity log.

The chatbot responds to cybersecurity questions, recognises natural language commands, stores tasks in a MySQL database, and records user activities performed within the application.

---

# System Requirements

Before running the application, ensure the following software is installed:

* Windows 10 or Windows 11
* Microsoft Visual Studio 2022
* .NET Framework
* MySQL Server
* MySQL Connector/NET
* phpMyAdmin (optional for viewing the database)

---

# Installation and Setup

## Step 1 – Download the Project

Extract the CyberChat project folder to your computer.

---

## Step 2 – Install MySQL

Install MySQL Server if it is not already installed.

Start the MySQL service before running the application.

---

## Step 3 – Create the Database

Open phpMyAdmin or MySQL Workbench.

Create a database named:

CyberChatDB

---

## Step 4 – Create the Tasks Table

Execute the following SQL statement:

```sql
CREATE TABLE Tasks
(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255),
    Description TEXT,
    ReminderDate DATETIME,
    IsCompleted BOOLEAN DEFAULT 0
);
```

---

## Step 5 – Configure the Connection String

Open **Form1.cs**.

Locate the following connection string:

```csharp
private string connectionString =
"server=localhost;database=CyberChatDB;uid=root;pwd=;";
```

If your MySQL username or password is different, update the values accordingly.

Example:

```csharp
private string connectionString =
"server=localhost;database=CyberChatDB;uid=root;pwd=yourpassword;";
```

---

## Step 6 – Build the Application

1. Open the solution in Visual Studio.
2. Select **Build → Build Solution**.
3. Resolve any missing package references if prompted.

---

## Step 7 – Run the Application

Press **F5** or click **Start** in Visual Studio.

The chatbot application will open.

---

# Application Features

## 1. Chatbot

The chatbot provides cybersecurity awareness information.

Users can ask questions about:

* Password security
* Phishing
* Privacy
* Malware
* Two-Factor Authentication (2FA)
* Safe browsing

### Example

User:

> Tell me about phishing

Bot:

> Be careful of emails asking for personal information. Never click suspicious links from unknown senders.

---

## 2. Quick Cybersecurity Buttons

The application includes quick-access buttons for:

* Passwords
* Phishing
* Privacy

Clicking a button immediately displays cybersecurity advice.

---

## 3. Task Assistant

The Task Assistant allows users to manage cybersecurity reminders.

Users can:

* Add tasks
* Delete tasks
* Mark tasks as completed
* Store tasks permanently in MySQL

### Adding a Task

1. Enter a task title.
2. Enter a task description.
3. Select a reminder date.
4. Click **Add Task**.

Example:

Title:

Update Password

Description:

Change Gmail password using a stronger password.

Reminder Date:

30 June 2026

---

### Completing a Task

1. Select the task.
2. Click **Complete Task**.

The task will be marked with:

[COMPLETED]

---

### Deleting a Task

1. Select a task.
2. Click **Delete Task**.

The task will be removed from:

* The application
* The MySQL database

---

## 4. Cybersecurity Quiz

The quiz contains ten cybersecurity questions.

The application tracks:

* Current score
* Correct answers
* Incorrect answers

### How to Use

1. Click **Start Quiz**.
2. Read the question.
3. Select an answer.
4. Click **Submit Answer**.
5. Read the explanation.
6. Click **Next Question**.
7. Repeat until the quiz finishes.

After the last question, the application displays:

* Final score
* Performance feedback

---

## 5. Activity Log

Every important action performed in the application is recorded.

Examples include:

* Task Added
* Task Deleted
* Task Completed
* Quiz Started
* Quiz Completed
* NLP Commands

Users may also clear the activity log using the **Clear Log** button.

---

## 6. Natural Language Processing (NLP)

The chatbot recognises natural language commands.

Supported examples include:

Example 1

User:

> Start quiz

Result:

The application automatically opens the Quiz tab and starts the quiz.

---

Example 2

User:

> Play quiz

Result:

The quiz starts automatically.

---

Example 3

User:

> Remind me to update my password

Result:

The Task Assistant tab opens so the user can create a reminder.

---

Example 4

User:

> Create task

Result:

The Task Assistant opens.

---

Example 5

User:

> Show activity log

Result:

The Activity Log tab opens.

---

# Database

The application stores tasks permanently using MySQL.

Each task stores:

* Title
* Description
* Reminder Date
* Completion Status

Database operations include:

* INSERT
* UPDATE
* DELETE
* SELECT

Database connection errors are handled using exception handling to prevent the application from crashing.

---

# Error Handling

The application validates user input and displays appropriate error messages.

Examples include:

* Empty task title
* No quiz answer selected
* Database connection unavailable
* Invalid user input

---

# Technologies Used

* C#
* Windows Forms
* .NET Framework
* MySQL
* MySQL Connector/NET
* Visual Studio 2022

---

# Future Improvements

Possible future enhancements include:

* User authentication
* Password strength checker
* Email reminders
* AI-powered chatbot responses
* Voice commands
* Data visualisation dashboard

---

# Author

Fana Thopola

CyberChat was developed as the final submission for the PROG6221 Cybersecurity Awareness Chatbot project.
