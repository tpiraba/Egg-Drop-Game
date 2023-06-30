using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;
using System;
using System.Threading;

public class RockSpawner : MonoBehaviour
{
    public GameObject eggPrefab;
    private float respawnTime = 1.0f;
    public TimeSpan ts = new TimeSpan(0,0,5);
    // private int currTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            StartCoroutine(rockWave());
            Thread.Sleep(ts);
        }
        
    }

    private void spawnRock()
    {
        GameObject a = Instantiate(eggPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-5.85f, 5.2f), 6.25f);
    }

    IEnumerator rockWave()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(respawnTime);
            spawnRock();
        }
        
    }



}
