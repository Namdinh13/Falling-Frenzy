using System;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    [SerializeField] private GameObject sheepPrefabs;
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private float spawnRangeX = 10f;

    private float timer;

    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer > spawnInterval)
        {
            float xPos = UnityEngine.Random.Range(-spawnRangeX, spawnRangeX);
            Vector3 spawnPosition = new Vector3(xPos, transform.position.y, transform.position.z);

            Instantiate(sheepPrefabs, spawnPosition, sheepPrefabs.transform.rotation);
            timer = 0f;
        }
    }
}
