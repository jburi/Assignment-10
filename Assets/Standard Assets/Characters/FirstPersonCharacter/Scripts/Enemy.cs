/*
 * Jacob Buri
 * Enemy.cs
 * Assignment 10
 * Contains Enemy and EnemyDB class useing dictionaries
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
	public string name { get; set; }
	public float speed { get; set; }
	public GameObject body { get; set; }
	public static int count { get; set; }

	public Enemy()
	{
		name = "Rhino";
		speed = 10f;
		count++;
	}

	public Enemy(string name, float speed)
	{
		this.name = name;
		this.speed = speed;
		count++;
	}

	public override string ToString()
	{
		return name + " runs at " + speed + " km per hour.";
	}

}
