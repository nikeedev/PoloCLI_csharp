using System;

namespace polo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            void version() 
            {
                Console.WriteLine("NikPolo Command Terminal \nv.0.4");
            }
            string user = null;
            string pswrd = null; 
            string checkuser = null; 
            string checkpswrd = null;
    
            bool whileterminal = true;
            bool while_login = true;
            bool while_pswrd = true;
            bool while_user = true;

            version();
            while (while_user) {
                Console.Write("Write new username: ");
                user = Console.ReadLine();
                Console.Write("Save username? Write yes or no: ");
                string yesno;
                yesno = Console.ReadLine();
                if ("yes" == yesno || "y" == yesno) {
                    while_user = false;
                    Console.WriteLine("\nSaved!");
                }
                else {
                    continue;
                }
            }
            while (while_pswrd) {
                Console.Write("Write new password: ");
                pswrd = Console.ReadLine();
                Console.Write("Save password? Write yes or no: ");
                string yesno2;
                yesno2 = Console.ReadLine();
                if ("yes" == yesno2 || "y" == yesno2) {
                    while_pswrd = false;
                    Console.Write("\nSaved!");
                }
                else {
                    continue;
                }  
            }
            Console.Clear();

            while (while_login) {
                Console.Write("Login: \n");
                Console.Write("Write username: ");
                checkuser = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Write password: ");
                checkpswrd = Console.ReadLine();
                Console.WriteLine();
                if (user == checkuser) {  
                    if (checkpswrd == pswrd) {
                        Console.Clear();
                        Console.Clear();
                        while_login = false;
                        Console.WriteLine("Login Complete!");   
                    }
                    else {
                        Console.WriteLine("Incorrect password or username");
                        Console.WriteLine();
                    }   
   
                }
                else {
                    Console.Write("Incorrect username or password");
                    Console.WriteLine();
                }
            }

            while (whileterminal) {
                Console.WriteLine();
                string commands;
                Console.Write("polo - " + user + " /> ");
                commands = Console.ReadLine();
                if (commands == "exit") {
                    Console.WriteLine();
                    Console.WriteLine("Confirming exit...");
                    Console.WriteLine("Click Enter to confirm exit...");
                    Console.ReadKey();
                    whileterminal = false;
                }
                else if (commands == "start print") {
                    string printinput;
                    Console.Write("print | Input: ");
                    printinput = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("print | Output: " + printinput + "\n \n");
                    Console.WriteLine("");
                }
                else if (commands == "user") {
                    Console.WriteLine("Current user logged in is: " + user);
                }
                else if (commands == "version" || commands == "--version" || commands == "about" || commands == "-v" || commands == "--v" ||commands == "-ver") {
                    version();
                }
                else if (commands == "help")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You can use Following commands: ");
                    Console.WriteLine("version, --version, --v, -ver, -v and about: All they show current version.");
                    Console.WriteLine("help: Shows this page. ");
                    Console.WriteLine("user: shows current user logged in. ");
                    Console.WriteLine("color: Shows available colors you can change between. ");
                    Console.WriteLine("color + \"Your color\": Activates color you wrote. ");
                    Console.WriteLine("exit: Exits current session. ");
                    Console.WriteLine("cls: Clears everything. ");
                    Console.WriteLine("start print: You can write input so it replys it back. ");

                }
                else if (commands == "color blue") {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (commands == "color green") {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (commands == "color red") {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (commands == "color yellow") {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (commands == "color cyan") {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (commands == "color white") {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (commands == "color") {
                    Console.WriteLine("You can choose between these colors:\ncyan,\nyellow,\nwhite,\nred,\ngreen\nand blue!\n To use any of these colors use command color + \"Your color here\" ");
                }
                else if (commands == "cls") {
                    Console.Clear();
                }
                else if (commands == "") {
                    continue;
                }
            }
        }
    }
}
