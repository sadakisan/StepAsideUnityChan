﻿using UnityEngine;
using System.Collections;

public class ItemGenerator : MonoBehaviour
{
    public GameObject carPrefab;
   
    public GameObject coinPrefab;

    public GameObject conePrefab;

    private int startPos = -160;

    private int goalPos = 120;

    private float posRange = 3.4f;


    void Start()
    {
 
        for (int i = startPos; i < goalPos; i += 15)
        {
      
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
             
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {

               
                for (int j = -1; j <= 1; j++)
                {
            
                    int item = Random.Range(1, 11);
             
                    int offsetZ = Random.Range(-5, 6);
                 
                    if (1 <= item && item <= 6)
                    {
                
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                        Debug.Log(coin.transform.position.y);
                    }
                    else if (7 <= item && item <= 9)
                    {
              
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}