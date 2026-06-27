
using System;
using System.Collections.Generic;

public delegate string BotResponseDelegate(string input);

public class ChatbotEngine
{
    // ================= VARIABLES =================

    private string userName = "";
    private string favouriteTopic = "";
    private string currentTopic = "";

    private bool waitingForName = true;

    private Random random = new Random();

    // ================= DICTIONARIES =================

    private Dictionary<string, string> generalResponses;
    private Dictionary<string, string> passwordResponses;
    private Dictionary<string, string> phishingResponses;
    private Dictionary<string, string> safeBrowsingResponses;

    private Dictionary<string, List<string>> randomTopicResponses;
    private Dictionary<string, List<string>> sentimentResponses;

    // ================= CONSTRUCTOR =================

    public ChatbotEngine()
    {
        // ---------- GENERAL RESPONSES ----------

        generalResponses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "how are you", "I am functioning well and ready to help you stay safe online." },

            { "what is your purpose", "My purpose is to educate users about cybersecurity awareness and online safety." },

            { "what can i ask you about", "You can ask me about passwords, phishing, scams, privacy, safe browsing, and 2FA." }
        };

        // ---------- PASSWORD RESPONSES ----------

        passwordResponses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "how to create strong password", "Use a combination of uppercase letters, lowercase letters, numbers, and symbols." },

            { "what is password manager", "A password manager securely stores and generates strong passwords for your accounts." },

            { "should i reuse passwords", "No. Using the same password everywhere increases security risks." },

            { "what is two factor authentication", "Two-factor authentication adds an extra layer of security by requiring a second verification step." }
        };

        // ---------- PHISHING RESPONSES ----------

        phishingResponses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "what is phishing", "Phishing is a scam where attackers trick people into revealing sensitive information." },

            { "how to spot phishing email", "Check for suspicious links, urgent language, spelling mistakes, and unknown senders." },

            { "what are phishing red flags", "Unexpected attachments, fake login pages, and urgent requests are common phishing warning signs." }
        };

        // ---------- SAFE BROWSING RESPONSES ----------

        safeBrowsingResponses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "how to identify safe websites", "Look for HTTPS and a padlock symbol before entering personal information." },

            { "how to avoid fake websites", "Double-check URLs carefully and avoid clicking suspicious advertisements." },

            { "how to browse safely on public wifi", "Avoid banking or sensitive logins on public Wi-Fi unless using a VPN." }
        };

        // ---------- RANDOM TOPIC RESPONSES ----------

        randomTopicResponses = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
        {
            {
                "password",
                new List<string>
                {
                    passwordResponses["how to create strong password"],
                    passwordResponses["what is password manager"],
                    passwordResponses["should i reuse passwords"],
                    "Use different passwords for different accounts."
                }
            },

            {
                "phishing",
                new List<string>
                {
                    phishingResponses["what is phishing"],
                    phishingResponses["how to spot phishing email"],
                    phishingResponses["what are phishing red flags"],
                    "Never trust urgent emails blindly."
                }
            },

            {
                "scam",
                new List<string>
                {
                    "Scams often pressure users to act quickly.",
                    "Never share passwords or banking details unexpectedly.",
                    "Too-good-to-be-true offers are usually scams."
                }
            },

            {
                "privacy",
                new List<string>
                {
                    "Privacy means controlling what personal information you share online.",
                    "Review social media privacy settings regularly.",
                    "Avoid oversharing personal details online."
                }
            },

            {
                "safe browsing",
                new List<string>
                {
                    safeBrowsingResponses["how to identify safe websites"],
                    safeBrowsingResponses["how to avoid fake websites"],
                    safeBrowsingResponses["how to browse safely on public wifi"]
                }
            },

            {
                "2fa",
                new List<string>
                {
                    passwordResponses["what is two factor authentication"],
                    "2FA helps protect accounts even if passwords are stolen.",
                    "Authenticator apps are safer than SMS verification."
                }
            }
        };

        // ---------- SENTIMENT RESPONSES ----------

        sentimentResponses = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
        {
            {
                "worried",
                new List<string>
                {
                    "It is understandable to feel worried. Cybersecurity can feel overwhelming at first.",
                    "Do not panic. Start with strong passwords and avoiding suspicious links."
                }
            },

            {
                "frustrated",
                new List<string>
                {
                    "Cybersecurity can feel frustrating sometimes, but protecting your accounts is important.",
                    "Let us focus on one simple safety step at a time."
                }
            },

            {
                "curious",
                new List<string>
                {
                    "Curiosity is a great mindset for learning cybersecurity.",
                    "Learning about online safety helps you avoid cyber threats."
                }
            }
        };
    }

    // ================= MAIN RESPONSE METHOD =================

    public string GetResponse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "Please type something so I can help you.";
        }

        input = input.ToLower().Trim();

        // ---------- NAME INPUT ----------

        if (waitingForName)
        {
            userName = input;

            waitingForName = false;

            return "Nice to meet you, " + userName +
                   "! You can go ahead and ask me about cybersecurity topics.";
        }

        // ---------- SENTIMENT DETECTION ----------

        BotResponseDelegate sentimentChecker = DetectSentiment;

        string sentimentResponse = sentimentChecker(input);

        // ---------- MEMORY ----------

        if (input.Contains("remember") ||
     input.Contains("what do you know about me") ||
     input.Contains("what is my name"))
        {
            if (!string.IsNullOrWhiteSpace(favouriteTopic))
            {
                return "Your name is " + userName +
                       " and you are interested in " +
                       favouriteTopic + ".";
            }

            return "Your name is " + userName + ".";
        }

        // ---------- PART 1 RESPONSES ----------

        string exactResponse = DetectPartOneResponse(input);

        if (!string.IsNullOrWhiteSpace(exactResponse))
        {
            return exactResponse;
        }

        // ---------- TOPIC RESPONSES ----------

        string topicResponse = DetectTopic(input);

        if (!string.IsNullOrWhiteSpace(sentimentResponse) &&
            !string.IsNullOrWhiteSpace(topicResponse))
        {
            return sentimentResponse + Environment.NewLine +
                   Environment.NewLine +
                   topicResponse;
        }

        if (!string.IsNullOrWhiteSpace(sentimentResponse))
        {
            return sentimentResponse;
        }

        if (!string.IsNullOrWhiteSpace(topicResponse))
        {
            return topicResponse;
        }

        // ---------- FOLLOW-UP RESPONSES ----------

        if (input.Contains("tell me more") ||
            input.Contains("another tip") ||
            input.Contains("explain more"))
        {
            return GiveFollowUpResponse();
        }

        // ---------- UNKNOWN INPUT ----------

        return "I didn’t quite understand that. Could you rephrase?";
    }

    // ================= PART 1 RESPONSES =================

    private string DetectPartOneResponse(string input)
    {
        string response;

        response = GetDictionaryResponse(input, generalResponses);
        if (response != null) return response;

        response = GetDictionaryResponse(input, phishingResponses);
        if (response != null)
        {
            currentTopic = "phishing";
            return response;
        }

        response = GetDictionaryResponse(input, passwordResponses);
        if (response != null)
        {
            currentTopic = "password";
            return response;
        }

        response = GetDictionaryResponse(input, safeBrowsingResponses);
        if (response != null)
        {
            currentTopic = "safe browsing";
            return response;
        }

        return "";
    }

    // ================= TOPIC DETECTION =================

    private string DetectTopic(string input)
    {
        foreach (string topic in randomTopicResponses.Keys)
        {
            if (input.Contains(topic))
            {
                currentTopic = topic;

                return GetRandomResponse(randomTopicResponses[topic]);
            }
        }

        return "";
    }

    // ================= SENTIMENT DETECTION =================

    private string DetectSentiment(string input)
    {
        foreach (string sentiment in sentimentResponses.Keys)
        {
            if (input.Contains(sentiment))
            {
                return GetRandomResponse(sentimentResponses[sentiment]);
            }
        }

        return "";
    }

    // ================= MEMORY =================

    private string DetectMemory(string input)
    {
        if (input.Contains("interested in"))
        {
            foreach (string topic in randomTopicResponses.Keys)
            {
                if (input.Contains(topic))
                {
                    favouriteTopic = topic;

                    currentTopic = topic;

                    return "Great, " + userName +
                           ". I will remember that you are interested in " +
                           favouriteTopic + ".";
                }
            }
        }

        if (input.Contains("remember") ||
            input.Contains("what do you know about me"))
        {
            if (!string.IsNullOrWhiteSpace(favouriteTopic))
            {
                return "I remember that your name is " +
                       userName +
                       " and you are interested in " +
                       favouriteTopic + ".";
            }

            return "I remember that your name is " + userName + ".";
        }

        return "";
    }

    // ================= FOLLOW-UP =================

    private string GiveFollowUpResponse()
    {
        if (string.IsNullOrWhiteSpace(currentTopic))
        {
            return "Please ask about a cybersecurity topic first.";
        }

        if (randomTopicResponses.ContainsKey(currentTopic))
        {
            return GetRandomResponse(randomTopicResponses[currentTopic]);
        }

        return "Ask me about passwords, phishing, scams, privacy, safe browsing, or 2FA.";
    }

    // ================= DICTIONARY RESPONSE =================

    private string GetDictionaryResponse(
        string userInput,
        Dictionary<string, string> responses)
    {
        string normalized = userInput.ToLower().Trim();

        if (responses.ContainsKey(normalized))
        {
            return responses[normalized];
        }

        foreach (string key in responses.Keys)
        {
            if (normalized.Contains(key))
            {
                return responses[key];
            }
        }

        return "";
    }

    // ================= RANDOM RESPONSE =================

    private string GetRandomResponse(List<string> responses)
    {
        int index = random.Next(responses.Count);

        return responses[index];
    }

 
}