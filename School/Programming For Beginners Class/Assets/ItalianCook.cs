/*
Human beings have been programming for way more than we think, it just wasn’t called programming.

Some examples of programming outside computers, checklists, safety procedures, cooking recipes.

There are at least two reasons why we use types in programming:
	1: Computers have a finite precision and a finite amount of memory.
 		You cannot represent PI in a computer, you can only represent an approximation.
	2: We need to treat information in a different way based on what it represents.


Pasta with tomatoes: // Assuming you can cook, that you are on earth and many other things

These are some of the things you need:
-	Pasta
-	Fresh tomatoes
-	Olive oil
-	Parmesan cheese
-	Salt
-	Basil leaves
-	Water

-	Pan
-	Pot
-	Knife
-	Cutting board
-	Stove

The name is not enough:
-	Spaghetti n°5            110.6  (how much, float,  real number)
-	Fresh tomatoes           2      (how many, int,   whole number)
-	Extra Virgin Olive oil   20.5   (how much, float,  real number)
-	Parmesan cheese          20.02  (how much, float,  real number)
-	Salt                     40.1   (how much, float,  real number)
-	Basil leaves             5      (how many, int,   whole number)
-	Water                    2.2    (how much, float,  real number)

Process:
	Write the name of the dish on a piece of paper.
	Write all the ingredients on a piece of paper, and the respective amount and unit.
	Cut the tomatoes in 10 slices each.
	Count the slices.
	Write how many slices of tomatoes you have on a piece of paper.

	Throw everything away, this is not an actual recipe.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItalianCook : MonoBehaviour {
	void Start()
	{
		string dish_name = "Pasta with tomatoes";

		float spaghetti_n5    = 110.6F;
		int tomatoes          = 2;
		// TODO: Put the rest here

		Debug.Log(dish_name); // Write the name of the dish.

		// Write all the ingredients on a piece of paper, and the respective amount and unit.
		Debug.Log("Spaghetti n5" + spaghetti_n5 + "g");
		Debug.Log("Tomatoes " + tomatoes + "pcs");
		// TODO: Write the others here

		

		// Cut the tomatoes in 10 slices each.
		// Count the slices.

		int tomato_slices = tomatoes * 10;
	
		// TODO: Write how many slices of tomatoes you have on a piece of paper.

		// Throw everything away, this is not an actual recipe.
	}

	void Update()
	{
	}
}