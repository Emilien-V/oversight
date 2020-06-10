using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainQuest : MonoBehaviour
{
    public Collider step1;
    public Collider step2;
    // Hacker
    public GameObject hacker;
    public Canvas hackerDialogue;
    public GameObject hackerTextOnCharacter;

    // Facteur 
    public GameObject facteur;
    public Canvas facteurDialogue;
    public GameObject facteurTextOnCharacter;

    // CompteurElectrique 
    public GameObject compteurElectrique;
    public Canvas compteurElectriqueDialogue;
    public GameObject compteurElectriqueTextOnCharacter;

    // MaisonAmi 
    public GameObject maisonAmi;
    public Canvas maisonAmiDialogue;
    public GameObject maisonAmiTextOnCharacter;

    // Policier

    public GameObject policier;
    public Canvas policierDialogue;


    // Start is called before the first frame update
    void Start()
    {
        hacker.SetActive(false);
        hackerDialogue.enabled = false;
        hackerTextOnCharacter.GetComponent<Renderer>().enabled = false;

        facteur.SetActive(false);
        facteurDialogue.enabled = false;
        facteurTextOnCharacter.GetComponent<Renderer>().enabled = false;

        compteurElectrique.SetActive(false);
        compteurElectriqueDialogue.enabled = false;
        compteurElectriqueTextOnCharacter.GetComponent<Renderer>().enabled = false;

        maisonAmi.SetActive(false);
        maisonAmiDialogue.enabled = false;
        maisonAmiTextOnCharacter.GetComponent<Renderer>().enabled = false;

        policier.SetActive(false);
        policierDialogue.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("questStep : " + GameManager.Instance.QuestStep);
        if (GameManager.Instance.QuestStep == "1.0")
        {
            facteur.SetActive(true);
            facteurDialogue.enabled = true;
            facteurTextOnCharacter.GetComponent<Renderer>().enabled = true;
        }

        if (GameManager.Instance.QuestStep == "2.0")
        {
            hacker.SetActive(true);
            hackerDialogue.enabled = true;
            hackerTextOnCharacter.GetComponent<Renderer>().enabled = true;
        }
        if (GameManager.Instance.QuestStep == "2.1")
        {
            compteurElectrique.SetActive(true);
            compteurElectriqueDialogue.enabled = true;
            compteurElectriqueTextOnCharacter.GetComponent<Renderer>().enabled = true;
        }

        if (GameManager.Instance.QuestStep == "1.1" || GameManager.Instance.QuestStep == "1.2")
        {
            maisonAmi.SetActive(true);
            maisonAmiDialogue.enabled = true;
            maisonAmiTextOnCharacter.GetComponent<Renderer>().enabled = true;
        }
        if (GameManager.Instance.QuestStep == "1.1.1" || GameManager.Instance.QuestStep == "1.1.2" || GameManager.Instance.QuestStep == "2.1.1" || GameManager.Instance.QuestStep == "2.1.2")
        {
            policier.SetActive(true);
            policierDialogue.enabled = true;
        }

    }
}
