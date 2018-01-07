using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    int level;
    int holder;
    string str;
    string output = "";
    string input2 = "";
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;
    string[] level1 = { "blood", "knife", "noose", "guns", "print" };
    string[] level2 = { "firearm", "shotgun", "holster", "shields", "radios" };
    string[] level3 = { "insubordination", "extortion", "espionage", "kidnapping", "manslaughter" };

    // Use this for initialization
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine(" ");
        Terminal.WriteLine("#M1T8");
        Terminal.WriteLine("Which folder do you want to hack?");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Press 1 for List of Evidences");
        Terminal.WriteLine("Press 2 for Police Inventory");
        Terminal.WriteLine("Press 3 for Crime Specifics");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Enter your selection:");
    }

    string shuffle(string output)
    {
        int ranIndex = 0;
        List<int> indexes = new List<int>();
        char[] split = input2.ToCharArray();
        //Random ran = new Random();

        for (int i = 0; i < input2.Length; i++)
        {
            ranIndex = Random.Range(0, input2.Length);

            if (!indexes.Contains(ranIndex))
            {
                indexes.Add(ranIndex);
            }
            else
            {
                i--;
            }
        }

        foreach (int value in indexes)
        {
            output += split[value];
        }

        return output;
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            Terminal.ClearScreen();
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            Process(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Please choose a level, Mr. Bond.");
        }
        else
        {
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Please choose a valid level.");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Level: " + level);
        if (level == 1)
        {
            holder = Random.Range(0, 5);
            input2 = level1[holder];
            Terminal.WriteLine("Hint: " + shuffle(output)); 

        }
        else if (level == 2)
        {
            holder = Random.Range(0, 5);
            input2 = level2[holder];
            Terminal.WriteLine("Hint: " + shuffle(output));
        }
        else if (level == 3)
        {
            holder = Random.Range(0, 5);
            input2 = level3[holder];
            Terminal.WriteLine("Hint: " + shuffle(output));
        }
        Terminal.WriteLine("Enter password:");
    }

    void Process(string input)
    {
        if (level == 1)
        {
            if (holder == 0)
            {
                if (input == level1[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 1)
            {
                if (input == level1[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 2)
            {
                if (input == level1[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 3)
            {
                if (input == level1[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 4)
            {
                if (input == level1[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
        }
        else if (level == 2)
        {
            if (holder == 0)
            {
                if (input == level2[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 1)
            {
                if (input == level2[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 2)
            {
                if (input == level2[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 3)
            {
                if (input == level2[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 4)
            {
                if (input == level2[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
        }
        else if (level == 3)
        {
            if (holder == 0)
            {
                if (input == level3[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 1)
            {
                if (input == level3[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 2)
            {
                if (input == level3[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 3)
            {
                if (input == level3[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
            else if (holder == 4)
            {
                if (input == level3[holder])
                {
                    EndGame();
                }
                else
                {
                    StartGame();
                }
            }
        }
        else
        {
            Terminal.WriteLine(" ");
            Terminal.WriteLine("Please input a valid option");
        }
    }

    void EndGame()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        Terminal.WriteLine("CASE CLOSED!");
        Terminal.WriteLine("You have successfully hacked into the  folder!");
        Terminal.WriteLine("      /////");
        Terminal.WriteLine("    /   ///");
        Terminal.WriteLine("   /  // /");
        Terminal.WriteLine("  / //  /");
        Terminal.WriteLine(" ///   /");
        Terminal.WriteLine(" /////");
        Terminal.WriteLine("Type 'menu' to go back to the main menu");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
