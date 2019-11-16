/*
 * Jacob Buri
 * EnemyDB.cs
 * Assignment 10
 * Contains Enemy and EnemyDB class useing dictionaries
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDB : MonoBehaviour
{
	//A dictionary stores key value pairs - the key and value can be of any type you choose

	//create a dictionary of Enemy objects with string keys
	public Dictionary<string, Enemy> Enemies = new Dictionary<string, Enemy>();

	void Start()
	{
		//add a Enemy to the dictionary with the default constructor
		Enemies.Add("Sandman", new Enemy());

		//add a Enemy to the dictionary with a separate temporary 
		//variable and with the overloaded constructor
		Enemy rhino = new Enemy("Rhino", 6.0f);
		Enemies.Add("Aleksei Sytsevich", rhino);

		//add a Enemy with the overloaded constructor directly
		Enemies.Add("Jack Napier", new Enemy("Joker", 7.0f));

		//access a Enemy from the dictionary with the key
		Enemy greenGoblin = Enemies["Norman Osborn"];

		// Check if a key is present
		if (Enemies.ContainsKey("Rhino"))
		{
			Debug.LogFormat("Yes, it is {0} that our dictionary contains the key Rhino",
				Enemies.Remove("Rhino"));
		}
		else
		{
			Debug.LogFormat("No, it is {0} because our dictionary does not contain the key Rhino",
				Enemies.ContainsKey("Rhino"));
		}


		// Cycle through key value pairs
		foreach (KeyValuePair<string, Enemy> villian in Enemies)
		{
			Debug.LogFormat("{0} : {1}",
				villian.Key,
				villian.Value.name);
			// With our ToString override, we can replace villian.Value.name with villian.Value

		}
	}


}
