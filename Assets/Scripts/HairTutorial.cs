using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HairTutorial : MonoBehaviour
{
    public GameObject toolboxPanel;
    public Button scissorsButton;
    public Button stylerButton;
    public TextMeshProUGUI tutorialText;
    public Slider satisfactionSlider;
    public TextMeshProUGUI scoreText;

    private int score = 0;

    public void StartTutorial()
    {
        toolboxPanel.SetActive(true);
        tutorialText.gameObject.SetActive(true);
        tutorialText.text = "Þimdi makasa týkla ve saçý kes!";

        scissorsButton.onClick.RemoveAllListeners();
        scissorsButton.onClick.AddListener(OnScissorsClick);
    }

    private void OnScissorsClick()
    {
        score += 10;
        satisfactionSlider.value += 20;
        scoreText.text = "Puan: " + score;

        tutorialText.text = "Harika! Þimdi þekillendiriciye týkla.";
        scissorsButton.interactable = false;

        stylerButton.onClick.RemoveAllListeners();
        stylerButton.onClick.AddListener(OnStylerClick);
    }

    private void OnStylerClick()
    {
        score += 10;
        satisfactionSlider.value += 30;
        scoreText.text = "Puan: " + score;

        tutorialText.text = "Mükemmel! Artýk hazýrsýn!";
        stylerButton.interactable = false;
    }
}
