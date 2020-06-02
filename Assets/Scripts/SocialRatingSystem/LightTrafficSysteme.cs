using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrafficSysteme : MonoBehaviour
{
    // public Rigidbody TrafficLight;
    [SerializeField] private float delayToChangeColor;
    [SerializeField] private string color;
    // private string color = "rouge";
    [SerializeField] private Material FirstMaterial;
    [SerializeField] private Material SecondMaterial;
    private float delayValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (color == "rouge")
            {
                Debug.Log("Traverser au rouge est interdit, vous perdez donc des points");
            }
        }
    }

    void Start()
    {
        delayValue = delayToChangeColor;
    }
    private void ResetDelay()
    {
        delayToChangeColor = delayValue;
    }

    private void ChangeColor(Renderer rend)
    {
        if (color == "rouge")
        {
            rend.material = FirstMaterial;

            if (delayToChangeColor <= 0)
            {
                color = "vert";
                // delayToChangeColor = 5f;
                ResetDelay();
            }
        }
        if (color == "vert")
        {
            rend.material = SecondMaterial;

            if (delayToChangeColor <= 0)
            {
                color = "rouge";
                // delayToChangeColor = 5f;
                ResetDelay();
            }
        }
    }

    void Update()
    {
        Renderer rend = GetComponent<Renderer>();
        // rend.material = material1;
        delayToChangeColor -= Time.deltaTime;

        ChangeColor(rend);
    }
}
