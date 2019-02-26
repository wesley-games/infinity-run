using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject hitParticle;
    private float health = 3f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("w") && transform.position.y < 3)
        {
            rb.MovePosition(transform.position + new Vector3(0, 3, 0));
        }
        if (Input.GetKeyDown("s") && transform.position.y > -3)
        {
            rb.MovePosition(transform.position + new Vector3(0, -3, 0));
        }
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        health -= 1;
        Instantiate(hitParticle, collider.gameObject.transform.position, Quaternion.identity);
        Destroy(collider.gameObject);
        
    }
}
