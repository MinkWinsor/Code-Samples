using UnityEngine;
using System.Collections;

/* INHERITANCE:
 * Inheritance is used in almost all code, especially in Unity.
 * Basically inheritance is when one object, such as a class, 'inherits' or gains all the parts of a parent object.
 * Many scripts inherit from MonoBehaviour, which is a Unity class with basic functions such as Start() and Update()
 */


    //This is an example of a class that inherits from Monobehaviour, as declared in the first line.
    //It will have any public or protected functions available to Monobehaviour.
public class Inheritance : MonoBehaviour {
    Trekkie steven = new Trekkie();
    Whovian liz = new Whovian();
    

    void Start()
    {
        //The following statement throws an error because the variable is protected, see below.
        //if (steven.wearsGlasses)
        //However non-protected variables can be accessed by child objects.
        if (steven.hasAsthma)
        {
            print("Steven has asthma, like all nerds");
        }

        print(liz.getString());
        print(steven.getString());

    }

}

public class Nerd
{
    //public variables are accessible to all children. private are not. protected are basically public in regards to the child, but private to everything else.
    protected bool wearsGlasses = true;
    public bool hasAsthma = true;
    protected string nerdSaying = "Derp";
    public string getString()
    {
       return nerdSaying;
    }
}

//An example of a class inheriting from another class so it can easily be seen how inheritance works.
public class Trekkie : Nerd
{


    //This is an overriding function and variable. It will 'hide' the function of the parent object so that when called, only this function is used.
    new protected string nerdSaying = "Live long and prosper.";
    new public string getString()
    {
        return nerdSaying;
    }
}

public class Whovian : Nerd
{
    new protected string nerdSaying = "It's bigger on the inside!";
    new public string getString()
    {
        return nerdSaying;
    }
}