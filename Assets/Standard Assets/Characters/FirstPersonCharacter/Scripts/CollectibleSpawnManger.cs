/*
 * Jacob Buri
 * CollectibleSpawnManager.cs
 * Assignment 10
 * Spawn manager for collectibles
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawnManger : MonoBehaviour
{
	[SerializeField]
	List<GameObject> collectibles = new List<GameObject>();
	List<GameObject> multicolorCollectibles = new List<GameObject>();
	GameObject player;
	Vector3 spawnPos;
	public float playerX;
	public float playerY;
	public float playerZ;

	// Start is called before the first frame update
	void Start()
	{
		player = GameObject.Find("Player");
	}

    // Update is called once per frame
    void Update()
    {
		spawnPos = player.transform.forward*5;
		playerX = spawnPos.x;
		playerY = spawnPos.y;
		playerZ = spawnPos.z;

		//Press 1 on Keyboard
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			foreach (GameObject collectible in collectibles)
			{
				//Creates a new object called itemToPaint using one of the collectibles
				GameObject itemToPaint = Instantiate(collectibles[Random.Range(0, collectibles.Count)]);

				//Gets itemToPaint's material and randomizes the color
				itemToPaint.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

				//Adds itemToPaint to the multicolor List
				multicolorCollectibles.Insert(Random.Range(0, multicolorCollectibles.Count), itemToPaint);
			}
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			//Gets the last collectible added in the multicolor List
			GameObject multicolorCollectible = multicolorCollectibles[multicolorCollectibles.Count -1];

			Instantiate(multicolorCollectible, new Vector3(Random.Range(playerX - 5, playerX + 5),
			Random.Range(playerY + 20, playerY + 50), Random.Range(playerZ - 5, playerZ + 5)), Quaternion.identity);

			multicolorCollectibles.Remove(multicolorCollectible);
		}
	}
}
