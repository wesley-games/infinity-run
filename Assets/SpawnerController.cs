using UnityEngine;

public class SpawnerController : MonoBehaviour
{

    public GameObject obstacle;
    public float timeBetweenSpawns = 2f;
    public float timeCount;

    public float minTimBetweenSpawns = .8f;
    public float decrementAmountBetweenSpawns = .2f;
    public float decrementTimeBetweenSpawns = 5f;
    public float decrementCount;

    private int[][] patterns = new int[][] { new int[] { 0, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 0 } };

    void Awake()
    {
        timeCount = timeBetweenSpawns;
        decrementCount = decrementTimeBetweenSpawns;
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

        if (timeBetweenSpawns > minTimBetweenSpawns)
        {
            if (decrementCount < 0)
            {
                timeBetweenSpawns -= decrementAmountBetweenSpawns;
                decrementCount = decrementTimeBetweenSpawns;
            }
            else
            {
                decrementCount -= Time.deltaTime;
            }
        }
    }
}
