using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerController : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
