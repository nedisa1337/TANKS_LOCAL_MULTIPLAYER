using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    public GameObject HealthShot;
    public GameObject SpeedShot;
    public Vector3 minPosition;
    public Vector3 maxPosition;
    public int SpawnRate = 5;
    void Start()
    {
        InvokeRepeating("Randomize", 0f, SpawnRate);
    }
    void Randomize()
    {
        var rndm = Random.Range(0, 2);
        if (rndm == 0) InvokeRepeating("SpawnHealth", 0f, 0f);
        if (rndm == 1) InvokeRepeating("SpawnSpeed", 0f, 0f);
    }
    void SpawnHealth()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(minPosition.x, maxPosition.x),
            Random.Range(minPosition.y, maxPosition.y),
            Random.Range(minPosition.z, maxPosition.z));
        Instantiate(HealthShot, randomPosition, Quaternion.identity);
    }
    void SpawnSpeed()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(minPosition.x, maxPosition.x),
            Random.Range(minPosition.y, maxPosition.y),
            Random.Range(minPosition.z, maxPosition.z));
        Instantiate(SpeedShot, randomPosition, Quaternion.identity);
    }
}
