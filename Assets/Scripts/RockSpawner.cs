using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject eggPrefab;
    private float respawnTime = 1.0f;
    private int currTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(rockWave());
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
            currTime = currTime + 1;
        }
        
    }



}
