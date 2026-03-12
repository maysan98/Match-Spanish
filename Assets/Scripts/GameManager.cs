using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int numOfWords = 3;
    [SerializeField] TMP_Text findsTextBox;
    [SerializeField] GameObject winScreen;
    private int score = 0;
    public static GameManager instance;
    void Awake()
    {
        instance = this;
        findsTextBox.text = "Finds: " + score;
    }
    public void AddFinds()
    {
        score++;
        findsTextBox.text = "Finds: " + score;
    }
    void Update()
    {
        if (score == numOfWords)
        {
            StartCoroutine(WonGame());
        }

    }

    IEnumerator WonGame()
    {
        winScreen.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }

    
}
