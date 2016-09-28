using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour {

    //Scope and Access Modifiers

    /* All code has a scope, or a section where it can be used.
     * Some examples of scope are private and public.
     * Public variables and functions can be accessed by the class or object they are in, as well as other scripts.
     * Private variables are only available to the code block they exist in.
     * The block a variable exists in is the block where it is defined. If a variable is made in an if statement, for example,
     * that variable will only be available while the if statement is executing.
     */


     //This public variable will always be available while this scrip is loaded, or in Unity's case, while an object containing this script exists.
    public int freeNumber = 10;

    //Unity can access public variables available to classes in the investigator, so they are very useful for variables such as the following:
    public int speed;
    public float pointsPerKill;
    public Vector3 moveDirection;
    //They don't even have to be initialized before use in some cases, because they can be given a setting in the investigator. But usually a default value is preferable.
    //Unity overrides initialization values if the investigator is used.

    //This variable can't be accessed outside this script
    private int secretNumber = 0;

    //Variables are private by default.
    int otherSecretNumber = 5;


	// Functions are also scoped. They are private by default. They can also be protected, which makes them public to children but private to everything else.
	void Start () {

        if (true)
        {
            //This variable can't be used outside the if statement, and is pretty useless.
            int unusableNumber = 2;
        }

        //Variables can be made with the same name in different areas of code, as long as those blocks of code aren't in the same hierarchy.
        //For instance, this one can't be initialized because then the one above conflicts with it.
        //int unusableNumber = 3;

	}
	
}
