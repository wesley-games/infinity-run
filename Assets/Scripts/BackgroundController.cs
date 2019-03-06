using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{   
    public float speed = 10;
    public float endPosition = -18.9f;
    public float startPosition = 18.9f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= endPosition ) {
            Vector2 position = new Vector2(startPosition, transform.position.y);
            transform.position = position;
        }
    }
}
