using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {

    public float waitTime = 0.01f;
    public int hiyaCount = 20;

    //Functions are blocks of code that can be called, and will execute their code before returning control of the program to whatever function called them.
    //All of programming works on functions, calling functions, calling functions, and then returning backwards towards the start.

	// An example of a built-in function, that is called when the object containing this script is initialized.
    //Functions have a return type, a name, a parameter list in parentheses, and then their contents in curly braces.
	void Start () {

        //This is a function call. We give the function name and any needed parameters. It will use the function within the local class.
        myPrintFunction("Hello World!");
        //This one calls a built in function from a different class, so the class name, Debug, has to be given, too.
        //This function is part of another library. By including and making libraries, lots of code can be made available to a script for use.
        Debug.Log("Debug World!");
        
	}

    void Update()
    {
        //Coroutines must be called like so.
        StartCoroutine(myCoroutine());
    }

    //User defined function.
    void myPrintFunction(string myString)
    {
        //Functions can always call more functions!
        print(myString);
    }

    //Unity has a special type of function called a Coroutine. A coroutine is a special function that can yield control of itself back to the program.
    //While many function don't need to explicitly return control, a coroutine does.
    IEnumerator myCoroutine()
    {
        print("Hiya");
        //This is an example of how a coroutine may return control, using a waitforseconds function, which will wait that long before recalling the coroutine.
        //Also note functions can use variables available to the class.
        while (hiyaCount > 0)
        {
            hiyaCount--;
            yield return new WaitForSeconds(waitTime);
        }
        
        //Just remember to use loops so you don't have an infinite coroutine call.
        //Coroutines are a lot like recursive functions, but with easier ways to return control to the main program.
    }


    //Functions can also call themselves.
    void myRecursive() //DON'T USE THIS 
    {
        myRecursive();

    }
}
