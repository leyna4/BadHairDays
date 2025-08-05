using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI continueButtonText;
    private int lastDay;

    void Start()
    {
        // Kay�tl� g�n� al, yoksa 1 olarak ba�lat
        lastDay = PlayerPrefs.GetInt("LastPlayedDay", 1);
        continueButtonText.text = "Continue Day " + lastDay;
    }

    public void OnContinuePressed()
    {
        // Oyun sahnesini ba�lat
        SceneManager.LoadScene("GameScene");
    }

    public void OnExitPressed()
    {
        Application.Quit();
    }
}
