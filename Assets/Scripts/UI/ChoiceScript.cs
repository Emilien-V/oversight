using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChoiceScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject TextChoice01;
    public GameObject TextChoice02;
    public int ChoiceMade;

    public void ChoiceOption1()
    {
        TextBox.GetComponent<Text>().text = "Le prix de la bouteille est de 2,5$, veut tu l'acheter ?";
        // TextChoice01.GetComponent<Text>().text = "wook";
        // TextChoice02.GetComponent<Text>().text = "nanana";

        ChoiceMade = 1;
    }
    public void ChoiceOption2()
    {
        TextBox.GetComponent<Text>().text = "Dommage, bonne journée et à bientôt !";
        // TextChoice01.GetComponent<Text>().text = "wook2";
        // TextChoice02.GetComponent<Text>().text = "nanana2";
        ChoiceMade = 2;
    }
    void Update()
    {
        if (ChoiceMade >= 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
        }
    }
}