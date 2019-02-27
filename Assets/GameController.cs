using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject buttonRestart;
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
        Time.timeScale = 0;
        buttonRestart.SetActive(true);
    }

    public void Restart() 
    {
        Time.timeScale = 1;
        buttonRestart.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
