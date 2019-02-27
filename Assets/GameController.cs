using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    void OnEnable()
    {
        PlayerController.OnPlayerDead += OnPlayerDead;
    }

    void OnDisable()
    {
        PlayerController.OnPlayerDead -= OnPlayerDead;
    }

    void OnPlayerDead(GameObject player)
    {
        Debug.Log("Player dead");
        Destroy(player);
    }
}
