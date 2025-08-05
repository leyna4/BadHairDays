using UnityEngine;
using TMPro;

public class DialogSystem : MonoBehaviour
{
    public GameObject dialogPanel;
    public TextMeshProUGUI dialogText;
    public GameObject bossImage;
    public GameObject topUI; // puan, saat, memnuniyet barlar�n�n oldu�u panel
    public GameObject themeBoard; // g�n�n temas�n� yazaca��m�z tabela
    public TextMeshProUGUI themeText;
    public string todaysTheme = "Crazy Hair Monday!";


    private string[] sentences = new string[]
    {
        "G�nayd�n ��rak! Bug�n senin ilk i� g�n�n. T�rnaklar�n� kesip geldin umar�m.",
        "D�nk� ��rak h�l� kay�p, o y�zden s�ra sende. Makas� ters tutmazsan �ansl�s�n.",
        "�lk m��teri birazdan gelir, dikkatli ol.",
    };

    private int index = 0;

    public void Start()
    {
        dialogPanel.SetActive(true);
        dialogText.text = sentences[index];
    }

    public void NextSentence()
    {
        index++;

        if (index < sentences.Length)
        {
            dialogText.text = sentences[index];
        }
        else
        {
            dialogPanel.SetActive(false);
            bossImage.SetActive(false);

            // �st UI barlar�n� aktif et
            topUI.SetActive(true);

            // G�n�n temas� g�sterilsin
            themeBoard.SetActive(true);
            themeText.text = todaysTheme;

            // Tutorial�a ge�ilebilir
            Invoke("StartCustomerDialogDelayed", 2f);
            FindObjectOfType<CustomerDialog>().StartCustomerDialog();

        }
    }

}
