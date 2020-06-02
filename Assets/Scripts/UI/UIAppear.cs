
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField] private Canvas customImage;
    [SerializeField] private GameObject TextOnCharacter;
    private bool active;
    // à coté du perso -> ecrire "appuyer sur E"  -> afficher l'UIInterface
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            active = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            active = false;
        }
    }
    void Update()
    {
        if (active == true)
        {
            // Debug.Log("Appuyer sur la touche E pour parler avec Samuel.");
            TextOnCharacter.GetComponent<Renderer>().enabled = true;
            //Si UI text 2d :
            // TextOnCharacter.enabled = true;

            if (Input.GetKeyDown(KeyCode.E))
            {
                // Debug.Log("E key was pressed.");
                customImage.enabled = true;
            }
        }
        else
        {
            customImage.enabled = false;
            TextOnCharacter.GetComponent<Renderer>().enabled = false;
            //Si UI text 2d :
            // TextOnCharacter.enabled = false;
        }
    }
}
