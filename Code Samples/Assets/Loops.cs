using UnityEngine;
using System.Collections;
using System;

//Loops are used to repeat code so you never have to copy/paste, and allow usage of code to be modular in many cases.
//Common loop types are for, while, do-while, and for each.
public class Loops : MonoBehaviour {
    
    //Variables for loops.
    private string[] deathNote = {"Annoying Neighbor", "Weird waiter that winked at me", "Woody the Woodpecker"};
    private int donutsForTeacher = 0;
    private float gradePercentage = 25;
    private int teacherWeight = 100;
        

	// Use this for initialization
	void Start () {

        myForLoop();
        myWhileLoop();
        myDoWhileLoop();
        myForEachLoop();
	}

    private void myForLoop()
    {
        //For loops are nice for running code a specified number of times.
        //One bonus is the declaration of hte loop has the counter, the conditional statement, and the increment all in one place.
        //The counter doesn't need to be initialized, incremented or created in the loop, but often is.
        //Syntax is a little complex. for(dataType iteratorName = initialValue; conditional statement; incrementation statement)
        //Usually the loop appears exactly like below.
        for(int i = 0; i < 10; i++)
        {
            print("Ze Count would like ye to count wif heem! Count wif ze Count! " + i);
        }
    }



    private void myWhileLoop()
    {
        //This is a while loop. It's a lot like a for loop, but the conditional statement is dependent on outside variables, as variables can't be created inside.
        //Always remember to check a while loop to make sure it won't go infinitely.
        while (gradePercentage < 100)
        {
            donutsForTeacher++;
            print("Have this box of " + donutsForTeacher + " donuts, my beloved professor!");
            gradePercentage++;
            teacherWeight += donutsForTeacher;
            print("Grade: " + gradePercentage + "   Weight of professor: " + teacherWeight);
        }
    }

    private void myDoWhileLoop()
    {
        //Do-while loops are exactly like while loops, but run AT LEAST once because the conditional statement is tested after the loop ends each time.
        do
        {
            print("They thought my code would never run! They set my conditional statement to false! WELL JOKE'S ON THEM!");
        } while (false);

    }

    private void myForEachLoop()
    {
        //For each loops are nice because they can be given a 'list' object or variable, such as an array, and run the code inside for each list member.
        //The syntax is foreach(dataType variableName in listName){code to run} where variableName is what can refer to the list in the code.
        //Remember because lists are passed by reference, changes made to the list will stay that way.
        foreach(string name in deathNote)
        {
            print(name + " was announced dead, today at " + System.DateTime.Now.ToString("HH:mm:ss"));
        }
    }


}
