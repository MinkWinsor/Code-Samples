using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

    //Variables are storage locations on a computer, and refer to a specific type of data.
    //When a variable is created, the syntax is 'type name;' or 'type name = startingValue;'
    //The type is the data type the variable refers to. The name is used to refer to the variable, or most often, the contents.
    //Variables can also be given a starting value.
    //Always put private or public before a variable to determine access.
    private int myInt;
    private int myInitializedInt = 2;

    //Variables can only be assigned data that fits them, in this case we must tell the computer our number is a float when we assign it.
    //In unity, public variables can be changed in Unity, and if given a different value in Unity, will start at that value instead.
    public float myFloat = 1f;


	// This is a function. When called, it performs all code within it. This one is called when the object is initialized.
	void Start ()
    {
        //Variables can do almost anything. Here we add and display two variables.
        //One needs a beginning value.
        myInt = 3;
        int myTempInt = myInt + myInitializedInt; //New variables can be made on the fly, and are private by default. Though usually you should say so.
        Debug.Log("Added number: " + myTempInt);
        //in some cases even variables of different types can cooperate, if there is code to support it.
        float myTempFloat = myInt + myFloat; //These automatically convert ints to floats to be used.
        Debug.Log("Added float: " + myTempFloat);
	}
	


}
