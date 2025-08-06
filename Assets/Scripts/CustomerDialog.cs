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
        "Merhaba! Bug�n sa��m� ��lg�n bir stil istiyorum...",
        "R�zgarda u�acak gibi duran bir sa� mesela...",
        "Senin ellerine g�veniyorum ��rak!"
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
            StartHairTutorial(); // Sa� kesimi tutorial'� ba�las�n
        }
    }

    private void StartHairTutorial()
    {
        Debug.Log("Sa� kesim tutorial ba�lad�...");
        FindObjectOfType<HairTutorial>().StartTutorial();
    }
}
