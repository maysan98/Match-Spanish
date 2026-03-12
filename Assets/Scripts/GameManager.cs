using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int numOfWords = 3;
    [SerializeField] TMP_Text findsTextBox;
    [SerializeField] GameObject winScreen;
    private int score = 0;
    void Awake()
    {
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
           winScreen.SetActive(true);
        }
    }
}
