using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueFacteur : MonoBehaviour
{
    [SerializeField] private Canvas customImage;
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public GameObject Choice04;
    public GameObject TextChoice01;
    public GameObject TextChoice02;
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

        TextBox.GetComponent<Text>().text = "C'est votre collis ?";
        Choice01.SetActive(false);
        Choice02.SetActive(false);
        Choice03.SetActive(true);
        Choice04.SetActive(true);
        ChoiceMade = 1;
    }
    public void ChoiceOption2_Dialogue1()
    {
        TextBox.GetComponent<Text>().text = "D'accord, au revoir alors";

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
        GameManager.Instance.QuestStep = "1.1";
        Debug.Log("questStep : " + GameManager.Instance.QuestStep);

        TextBox.GetComponent<Text>().text = "Super, je compte sur toi pour réussir cette mission";
        Choice01.SetActive(false);
        Choice02.SetActive(false);
        Choice03.SetActive(false);
        Choice04.SetActive(false);
    }
    public void ChoiceOption2_Dialogue2()
    {
        GameManager.Instance.QuestStep = "1.2";
        Debug.Log("questStep : " + GameManager.Instance.QuestStep);

        TextBox.GetComponent<Text>().text = "D'accord je comprends, bonne chance à toi alors";
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