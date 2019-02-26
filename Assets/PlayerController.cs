using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            rb.MovePosition(transform.position + new Vector3(0, 3, 0));
        }
        if (Input.GetKeyDown("s"))
        {
            rb.MovePosition(transform.position + new Vector3(0, -3, 0));
        }
    }
}
