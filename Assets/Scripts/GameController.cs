using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject spawnerController;
    public Button buttonRestart;

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
        Destroy(player);
        spawnerController.SetActive(false);
        buttonRestart.gameObject.SetActive(true);
    }

    public void Restart()
    {
        spawnerController.SetActive(true);
        buttonRestart.gameObject.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
