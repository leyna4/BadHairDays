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
        // Kayýtlý günü al, yoksa 1 olarak baþlat
        lastDay = PlayerPrefs.GetInt("LastPlayedDay", 1);
        continueButtonText.text = "Continue Day " + lastDay;
    }

    public void OnContinuePressed()
    {
        // Oyun sahnesini baþlat
        SceneManager.LoadScene("GameScene");
    }

    public void OnExitPressed()
    {
        Application.Quit();
    }
}
