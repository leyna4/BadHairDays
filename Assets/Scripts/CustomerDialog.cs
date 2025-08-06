using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CustomerDialog : MonoBehaviour
{
    public GameObject customer;
    public GameObject dialogPanel;
    public TextMeshProUGUI dialogText;
    public Button nextButton;

    private string[] customerSentences = new string[]
    {
        "Merhaba! Bugün saçýmý çýlgýn bir stil istiyorum...",
        "Rüzgarda uçacak gibi duran bir saç mesela...",
        "Senin ellerine güveniyorum çýrak!"
    };

    private int index = 0;

    public void StartCustomerDialog()
    {
        customer.SetActive(true);
        dialogPanel.SetActive(true);
        index = 0;
        dialogText.text = customerSentences[index];

        nextButton.onClick.RemoveAllListeners();
        nextButton.onClick.AddListener(NextSentence);
    }

    public void NextSentence()
    {
        index++;

        if (index < customerSentences.Length)
        {
            dialogText.text = customerSentences[index];
        }
        else
        {
            dialogPanel.SetActive(false);
            StartHairTutorial(); // Saç kesimi tutorial'ý baþlasýn
        }
    }

    private void StartHairTutorial()
    {
        Debug.Log("Saç kesim tutorial baþladý...");
        FindObjectOfType<HairTutorial>().StartTutorial();
    }
}
