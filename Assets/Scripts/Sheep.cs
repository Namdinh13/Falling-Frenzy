using System;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    [SerializeField] private GameObject sheepPrefabs;
    [SerializeField] private float spawnInterval = 1f;
    private float timer;

    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer > spawnInterval)
        {
            Instantiate(sheepPrefabs, transform.position, sheepPrefabs.transform.rotation);
            timer = 0f;
        }
    }
}
