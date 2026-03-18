using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int numOfWords = 3;
    [SerializeField] TMP_Text findsTextBox;
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject wordsScreen;
    private int score = 0;
    public static GameManager instance;
    void Awake()
    {
        instance = this;
        StartCoroutine(WordsScreen());
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

    IEnumerator WordsScreen()
    {
        wordsScreen.SetActive(true);
        yield return new WaitForSeconds(10);
        wordsScreen.SetActive(false);
    }
}
