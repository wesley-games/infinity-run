using UnityEngine;

public class DestroyerController : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
