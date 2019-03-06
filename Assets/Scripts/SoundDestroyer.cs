using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDestroyer : MonoBehaviour
{
    public float timeToDestroy = 1f;

    private float counter = 0f;

    void Update()
    {
        if (counter > timeToDestroy) {
            Destroy(gameObject);
            counter = 0f;
        } else {
            counter += Time.deltaTime;
        }
    }
}
