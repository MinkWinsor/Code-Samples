using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/*Arrays and lists are used to store collections of variables or objects.
 * They are useful because if we use an array we don't need 100+ variables being tracked at once, and we can store larger amounts of data easier.
 * Arrays and lists use index values to refer to each 'element' inside the array or list.
 * */
public class ArraysAndLists : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //Arrays are declared like variables, but include [] after the data type. They must also be set to an instance of an array using the new keyword, before or after they are created.

        string[] bottlesOfBeerOnTheWall = new string[99];

        //Another way to declare an array is to automatically fill it with values. The size of the array will be set to the values.
        //Values are put inside {} with commas.
        string[] pokemonGames = { "Red", "Blue", "Yellow", "Gold", "Silver", "Crystal"};

        //To reference an element, simply use the array name with [index] after. Index is an integer, starting at 0.
        print(pokemonGames[2]); //Prints the third element.

        //Arrays have a set value. If you need to change the number of elements in an array, a new array is often needed. You can also reassign old arrays.
        bottlesOfBeerOnTheWall = new string[98]; //DELETES CONTENTS OF ARRAY.

        //Lists are similar to arrays, but with added features. They don't have a set size, and so the size can be changed on the fly.
        //Lists also have functions to insert values, sort values, and more.
        //Lists are made in a different way from arrays, and can hold more types of objects.
        //the library System.Collections.Generic is used for lists.

        List<string> redShirts = new List<string>();

        //This list can have elements added, which will automatically increase the size of the list.
        redShirts.Add("Marko");
        redShirts.Add("Mr. Tibbs");
        redShirts.Add("Guy");

        print("There are " + redShirts.Count + " Red shirts");

        foreach (string red in redShirts)
        {
            print(red + " has died.");
            
        }

        redShirts.Clear();
        print("There are " + redShirts.Count + " Red shirts");
    }
	
}
