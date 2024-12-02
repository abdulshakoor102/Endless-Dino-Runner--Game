using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DinoPlayeRestartManagerrController : MonoBehaviour
{
public void RestartGame()
{
    UnityEngine.SceneManagement.SceneManager.LoadScene("Dino_Runner");
    Time.timeScale = 1f;

}
}