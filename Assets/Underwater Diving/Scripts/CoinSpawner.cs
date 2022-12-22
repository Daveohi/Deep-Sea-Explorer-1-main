using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinprefab;
    //public Transform player;
    public float spawnInterval = 5.0f;
    public float spawnRange = 2.0f;

    void start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            //Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), 0, Random.Range(-spawnRange.y, spawnRange.y));
            //Instantiate(coinprefab, spawnPosition, Quaternion.identity);

        }
    }

    /*private Vector3 RandomOffsetFromPlayer
    {
        get
        {
            Vector3 position = player.transform.position;
            position.x += (Random.value - .5f) * 2 * spawnRange;
            position.y += (Random.value - .5f) * 2 * spawnRange;
            return position;
        }
    }*/
}