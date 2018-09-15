﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnPool : MonoBehaviour {

    public int columnPoolSize = 5;
    public GameObject columnPrefab;
    public float spawnRate = 4f;
    public float columnMin = -2f;
    public float columnMax = -3.5f;

    private GameObject[] columns;
    private Vector2 columnPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawn;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;

	void Start ()
    {
        timeSinceLastSpawn = 0f;
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate (columnPrefab, columnPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if ( gameControl.instance.gameOver == false && timeSinceLastSpawn >= spawnRate)
        {
            timeSinceLastSpawn = 0f;
            float spawnYPosition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentColumn++;
            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
	}
}