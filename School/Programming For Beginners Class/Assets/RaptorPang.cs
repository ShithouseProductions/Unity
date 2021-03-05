using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RaptorPang : MonoBehaviour
{
    private int å;
    private bool ޢަ;

/*
    The name is not enough:
-	Spaghetti n°5            110.6  (how much, float, real number)
-	Fresh tomatoes           2      (how many, int, whole number)
-	Extra Virgin Olive oil   20.5   (how much, float, real number)
-	Parmesan cheese          20.02  (how much, float, real number)
-	Salt                     40.1   (how much, float, real number)
-	Basil leaves             5      (how many, int, whole number)
-	Water                    2.2    (how much, float, real number)
*/




    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale += new Vector3(6.0f, 4.0f, 4.0f);

        //Debug.Log("James");

        string dish_name = "Pasta with tomatoes";

        float spaghetti_n5 = 110.6F;
        int tomatoes = 2;
        // TODO: Put the rest here

        Debug.Log(dish_name); // Write the name of the dish.

        // Write all the ingredients on a piece of paper, and the respective amount and unit.
        Debug.Log("Spaghetti n5 " + spaghetti_n5 + "g");
        Debug.Log("Tomatoes " + tomatoes + "pcs");
        // TODO: Write the others here



        // Cut the tomatoes in 10 slices each.
        // Count the slices.

        int tomato_slices = tomatoes * 10;

        // TODO: Write how many slices of tomatoes you have on a piece of paper.

        // Throw everything away, this is not an actual recipe.
        Debug.Log(tomato_slices);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, transform.rotation.y + 2f, 0f, 0f);
        transform.position = new Vector3(5f * (Mathf.Sin(Time.time)), 0f, 0f);

    }

    void FixedUpdate()
    {

    }
}

public struct Keke
{

}

internal class James
{

}
