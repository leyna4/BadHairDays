using UnityEngine;
using TMPro;

public class DialogSystem : MonoBehaviour
{
    public GameObject dialogPanel;
    public TextMeshProUGUI dialogText;
    public GameObject bossImage;
    public GameObject topUI; // puan, saat, memnuniyet barlarýnýn olduðu panel
    public GameObject themeBoard; // günün temasýný yazacaðýmýz tabela
    public TextMeshProUGUI themeText;
    public string todaysTheme = "Crazy Hair Monday!";


    private string[] sentences = new string[]
    {
        "Günaydýn çýrak! Bugün senin ilk iþ günün. Týrnaklarýný kesip geldin umarým.",
        "Dünkü çýrak hâlâ kayýp, o yüzden sýra sende. Makasý ters tutmazsan þanslýsýn.",
        "Ýlk müþteri birazdan gelir, dikkatli ol.",
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

            // Üst UI barlarýný aktif et
            topUI.SetActive(true);

            // Günün temasý gösterilsin
            themeBoard.SetActive(true);
            themeText.text = todaysTheme;

            // Tutorial’a geçilebilir
            Invoke("StartCustomerDialogDelayed", 2f);
            FindObjectOfType<CustomerDialog>().StartCustomerDialog();

        }
    }

}
