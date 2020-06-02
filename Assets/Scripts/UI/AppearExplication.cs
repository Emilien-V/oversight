using UnityEngine;
// using UnityEngine.UI;
public class AppearExplication : MonoBehaviour
{
    [SerializeField] private Canvas textExplication;
    private float timeToDisplay = 5.0f;
    void Update()
    {
        timeToDisplay -= Time.deltaTime; // Décrémente timeToDisplay jusqu'a 0;

        if (timeToDisplay <= 0) // Si timeToDisplay est inférieur ou égal à 0 alors
        {
            textExplication.enabled = false;
        }
    }
}

