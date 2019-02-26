using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

    public GameObject obstacle;
    public float timeBetweenSpawns = 2f; // 0.8f maybe minimun
    public float timeCount;

    private int[][] patterns = new int[][] { new int[] { 0, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 0 } };

    void Awake()
    {
        timeCount = timeBetweenSpawns;
    }

    void Update()
    {
        if (timeCount < 0)
        {
            int[] pattern = patterns[Random.Range(0, 3)];
            if (pattern[0] == 1)
            {
                Instantiate(obstacle, transform.position + new Vector3(0, 3, 0), Quaternion.identity);
            }
            if (pattern[1] == 1)
            {
                Instantiate(obstacle, transform.position, Quaternion.identity);
            }
            if (pattern[2] == 1)
            {
                Instantiate(obstacle, transform.position + new Vector3(0, -3, 0), Quaternion.identity);
            }
            timeCount = timeBetweenSpawns;
        }
        else
        {
            timeCount -= Time.deltaTime;
        }
    }
}
