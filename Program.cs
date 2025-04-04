using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Wave; // This line is added to manipulate the audio file.


namespace AwarenessBot
{
    internal class Program
  
    {
     
public class CybersecurityAwarenessBot
        {
            static void Main(string[] args)
            {
                PlayGreeting();//Playing the voice message that i recorded,
                DisplayAsciiLogo();//Displaying the ArtLogo that i coded.
                GreetUser();
                StartChat();
            }

            static void PlayGreeting()
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(@"Greeting.wav"); 
                    player.PlaySync(); // Play synchronously to wait for completion.
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error playing greeting: {ex.Message}");
                }
            }

            static void DisplayAsciiLogo()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"

   ______      __                _________ __     
  / ____/_  __/ /_  ___  _____  / ____/ (_) /____ 
 / /   / / / / __ \/ _ \/ ___/ / __/ / / / __/ _ \
/ /___/ /_/ / /_/ /  __/ /    / /___/ / / /_/  __/
\____/\__, /_.___/\___/_/____/_____/_/_/\__/\___/ 
     /____/            /_____/                    

");
                Console.ResetColor();
                Console.WriteLine(new string('-', 40)); // Decorative divider
            }

            static void GreetUser() 
            {
                Console.Write("Please enter your name: ");// Asking the user to add their name.
                string userName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userName))
                {
                    userName = "User"; // Default name if input is empty
                }

                Console.WriteLine($"\nHello, {userName}! I'm here to help you stay safe online.");
                Console.WriteLine("Ask me anything about myself as a chatbox, password safety, phishing, safe browsing, and more.\n");
                Console.WriteLine(new string('-', 40)); // Decorative divider
            }

            static void StartChat()
            {
                while (true)
                {
                    Console.Write("\nYou: ");
                    string userInput = Console.ReadLine().ToLower();

                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Respond("I didn't quite understand that. Could you rephrase?");
                        continue;
                    }

                    Respond(userInput);
                }
            }

            static void Respond(string input)
            {
                Console.Write("Bot: ");
                string response = "";

                if (input.Contains("how are you?"))
                {
                    response = "I'm doing well, thank you!";
                }
                else if (input.Contains("what's your purpose?") || input.Contains("what are you?"))
                {
                    response = "My purpose is to help you learn about cybersecurity and stay safe online.";
                }
                else if (input.Contains("what can i ask you about?"))
                {
                    response = "You can ask me about password safety, phishing, safe browsing, and other cybersecurity topics.";
                }
                else if (input.Contains("password safety"))
                {
                    response = "For strong passwords, use a mix of uppercase and lowercase letters, numbers, and symbols. Avoid personal information and use a password manager.";
                }
                else if (input.Contains("phishing"))
                {
                    response = "Phishing is when someone tries to trick you into giving them personal information. Be wary of suspicious emails and links.";
                }
                else if (input.Contains("safe browsing"))
                {
                    response = "Use a reputable browser, keep it updated, and avoid clicking on suspicious links. Install an adblocker and antivirus software.";
                }
                else if (input.Contains("exit") || input.Contains("quit") || input.Contains("bye"))
                {
                    Console.WriteLine("Goodbye! Stay safe online.");
                    Environment.Exit(0);
                }
                else
                {
                    response = "I didn't quite understand that. Could you rephrase?";
                }
                TypeText(response);
            }

            static void TypeText(string text)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(30); // Simulate typing effect
                }
                Console.WriteLine();
            }
        }
    }
    }

