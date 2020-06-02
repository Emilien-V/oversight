using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Networking;
using Utilities;
using Dictionary;

public class WalkOnRoadDetect : MonoBehaviour
{
    private bool active;
    private float delayToWalkOnRoad = 1f;
    private int compteurWalkOnRoad;
    private string type;
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

    private void Punishement(int compteur)
    {
        if (type == "walkOnRoad")
        {
            delayToWalkOnRoad = 1f;
            Debug.Log("attention");

            if (compteurWalkOnRoad >= 5)
            {
                Debug.Log("vous marcher sur une voie non pietone : -5 point");
                GameManager.Instance.CreditSocial -= 5;
                compteurWalkOnRoad = 0;
            }

            // if (compteurWalkOnRoad < 3)
            // {
            //     Debug.Log("vous marcher sur une voie non pietone : -1 point");
            // }
            // if (compteurWalkOnRoad == 3)
            // {
            //     Debug.Log("vous marcher sur une voie non pietone : -1 point");
            //     compteurWalkOnRoad = 0;
            // }
        }

    }

    // Update is called once per frame
    void Update()
    {
        delayToWalkOnRoad -= Time.deltaTime;

        if (delayToWalkOnRoad <= 0)
        {
            if (active == true)
            {
                type = "walkOnRoad";
                compteurWalkOnRoad = compteurWalkOnRoad + 1;
                Punishement(compteurWalkOnRoad);
            }
        }
    }
}
