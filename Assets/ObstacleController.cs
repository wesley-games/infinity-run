using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
    }

     void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("collision");
    }
}
