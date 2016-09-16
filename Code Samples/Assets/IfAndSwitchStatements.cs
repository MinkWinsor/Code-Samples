using UnityEngine;
using System.Collections;

public class IfAndSwitchStatements : MonoBehaviour {

    //If and switch statements are the basis for logic in scripts. If statements allow certain code to be run only if a requirement is fulfilled.
    //Switch statements will run blocks of code for each value that is fulfilled.

    //Switch statements are almost always preferable when more than one option is used. If statements are best used for single options.

    public int stormtroopers = 20;
    public int weapon;


	// Use this for initialization
	void Start ()
    {
        weapon = Random.Range(1, 5);
	}
	
	// Update is called once per frame
	void Update ()
    {

        killTrooper();

	}



    void killTrooper()
    {
        if (stormtroopers > 0)
        {
            //Example of if statement. in this case, a variable is tested. In if statements, anything can be used, but the if statement will execute if any value that is 'true' is used.
            //Any number that isn't 0 is true, and relational operators such as > < <= >= == and != can be used.
            //Booleans work as well.
            stormtroopers--;
            print("Down with the empire! " + stormtroopers + " troopers left.");
            print("You used the " + checkWeapon());
        }
        else if (true)
        {
            //This is an example of an else/if statement, which is evaluated ONLY if all other if or else/if statements before it were false.
            //"THESE ARE BAAAAAAD" -Anthony, Supreme Dictator of his daughter and all Associated Boyfriends
            //Mainly because it's hard to keep track of it all. Also it's bad to use 'true' as an argument.

        }
    }

    string checkWeapon()
    {

        //This is an example of a switch statement. This allows options to be used, and will run the code that corresponds with the option.
        //The downside is you can't use boolean statements, and other data types. Ints are the easiest to use.
        //Normall break statements are needed to stop the statements 'falling through' and doing all the statements after the one that was evaluated to be true.
        //Since this returns on each function, that isn't needed.
        switch (weapon)
        {
            case 1: 
                return ("Pulse Rifle");
            case 2:
                return ("Shotgun");
            case 3:
                return ("Grenade");
            case 4:
                return ("Candlestick");
            case 5:
                return ("Vulcan Death Grip");
            default:
                return ("Bare Hands");
        }
        //These are better than if statements because the way the control of the code flows is easier to see, as well as more stable.
        //Nested if statements to test the presence of several options get long, complicated, and hard to understand.
    }
}
