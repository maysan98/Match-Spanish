using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonsManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
