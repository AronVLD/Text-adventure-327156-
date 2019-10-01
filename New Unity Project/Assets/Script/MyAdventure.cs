using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro, 
        delen, 
        antwoord1,
        antwoord2,
        lol
    }

    private States currentState = States.start;
    // Start is called before the first frame update
    void Start()
    {
       ShowMainmenu();
    }


    // Update is called once per frame
    void OnUserInput(string input)
    {
        if (currentState == States.start)
        {
            if (input == "start")
            {
                StartIntro();
            }
            else if (input == "credits")
            {
                Terminal.WriteLine("Gemaakt door: Aron van de Riddder");
            }
            else
            {
                Terminal.WriteLine("Typ start...");
            }
        }
    }
    

    void StartIntro()
    {
Terminal.ClearScreen();
Terminal.WriteLine("Het was een warme dag"); 
Terminal.WriteLine("je staat op een hele mooie boot");
currentState = States.intro
    }

    void ShowMainmenu()
    {
        Terminal.ClearScreen(); 
        Terminal.WriteLine("Welkom bij Kapsones");
        Terminal.WriteLine("Dit is zo nep als het maar kan");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("Typ start om te beginnen...");
    }
}

