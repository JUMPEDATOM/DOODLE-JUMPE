using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform target;
    public Transform CameraMain;
    public float restartDelay = 1f;
    public float numPlatform = 200f;

    public void loseGame()
    {
        if(target.position.y < CameraMain.position.y - 7)
        {
            Invoke("Restart",restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    void Update()
    {
        loseGame();
    }
}
