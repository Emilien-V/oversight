using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChoiceScript : MonoBehaviour
{
    [SerializeField] private Canvas customImage;
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject TextChoice01;
    public GameObject TextChoice02;

    public GameObject Choice03;
    public GameObject Choice04;
    public GameObject TextChoice03;
    public GameObject TextChoice04;
    public int ChoiceMade;
    private bool noButton;
    private string initialText;

    void Start()
    {
        initialText = TextBox.GetComponent<Text>().text;
        Choice03.SetActive(false);
        Choice04.SetActive(false);
    }
    public void ChoiceOption1_Dialogue1()
    {

        TextBox.GetComponent<Text>().text = "Le prix du pack est de 7,5$";
        Choice01.SetActive(false);
        Choice02.SetActive(false);
        Choice03.SetActive(true);
        Choice04.SetActive(true);
        // TextChoice01.GetComponent<Text>().text = "Acheter";
        // TextChoice02.GetComponent<Text>().text = "Voler";

        ChoiceMade = 1;
    }
    public void ChoiceOption2_Dialogue1()
    {
        TextBox.GetComponent<Text>().text = "Dommage, bonne journée et à bientôt !";

        Choice01.SetActive(false);
        Choice02.SetActive(false);
        Choice03.SetActive(false);
        Choice04.SetActive(false);
        // noButton = true;
        ChoiceMade = 2;
    }

    //Dialogue 2 
    public void ChoiceOption1_Dialogue2()
    {
        GameManager.Instance.QuestStep = "1.0";
        Debug.Log("questStep : " + GameManager.Instance.QuestStep);

        TextBox.GetComponent<Text>().text = "Merci pour votre achat, au revoir.";
        Choice01.SetActive(false);
        Choice02.SetActive(false);
        Choice03.SetActive(false);
        Choice04.SetActive(false);
    }
    public void ChoiceOption2_Dialogue2()
    {
        GameManager.Instance.QuestStep = "2.0";
        Debug.Log("questStep : " + GameManager.Instance.QuestStep);

        TextBox.GetComponent<Text>().text = "Ne reviens jamais ici voleur, j'espère que tu va perdre beaucoup de points !";
        Choice01.SetActive(false);
        Choice02.SetActive(false);
        Choice03.SetActive(false);
        Choice04.SetActive(false);
    }
    void Update()
    {
        if (ChoiceMade >= 1)
        {
            // Choice01.SetActive(false);
            // Choice02.SetActive(false);
        }

        if (ChoiceMade == 2)
        {
            if (customImage.enabled == false)
            {
                TextBox.GetComponent<Text>().text = initialText;
                Choice01.SetActive(true);
                Choice02.SetActive(true);
            }
        }
    }
}