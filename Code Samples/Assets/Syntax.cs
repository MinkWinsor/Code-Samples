
//Include statements. They allow access to 'libraries' or premade collections of code.
using UnityEngine;
using System.Collections;

//This is a class. it has the keyword public, the keyword class, then the name, a colon, and classes it inherits from.
//note that all code in the class is enclosed in curly braces. Code between braces is referred to as a code block.
public class Syntax : MonoBehaviour {

    //A statement often includes keywords, operators, and is ended by a semicolon. For example:
    public int myInt = 1;
    //Public and int are keywords used by the core programming language, and myInt is a user-defined keyword. The = sign is a keyword and an operator.
    //Keywords define ideas that can be performed by the computer.
    //Comments are preceded by // and are not seen by the computer when it uses the code.
    /*
    this is another way to write a comment
    with multiple lines.
    */


	// Use this for initialization
	void Start () {
        //keywords may require parameters in parentheses in order to know how to perform.
	for(int i = 0; i < 10; i++)
        {
            //A very simple function call. Functions always have parentheses after, even if no parameters are needed.
            helloWorldIsDumb();
            //If names conflict, using className.functionName can help clear it up. 'this' refers to the script itself or object the script is attached to.
            this.helloWorldIsDumb();
        }
	}

    //User defined function.
    void helloWorldIsDumb()
    {
        //Built in function, does require a paramter, or an object it can print.
        print("Anyone? Bueller?");
    }

    //Note that in C#, there are a lot of rules to stop confusion. Functions can only include letters, numbers, and underscores, and can't begin with a number.
    //Also, system keywords can't be used as user-defined keywords.

    //This function has even more syntax in it. Really though, there's way more syntax than I can cover.
    string[] uselessFunction(string myString, int[] myInt)
    {
        //Arrays are declared by putting [] after the data type, and can be given a size inside [] or even initialized with values in the form {dataOne, dataTwo, etc.}
        //Also, notice that code blocks are indented, to appear to be together.
        string[] stringArray = { myString, myString };
        return stringArray;
}

}
