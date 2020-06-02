using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialRatingSystemManagement : MonoBehaviour
{
    private int creditSocialValue;
    private string creditSocialStatut;
    public Collider parkEntrance;
    public Collider parkEntrance2;
    void Start()
    {
        creditSocialStatut = GameManager.Instance.CreditSocialStatut;
        // Debug.Log("statut de base : " + creditSocialStatut);
    }

    void Update()
    {
        creditSocialValue = GameManager.Instance.CreditSocial;
        Debug.Log(" creditSocialValue : " + creditSocialValue);

        if (creditSocialValue >= 180)
        {
            creditSocialStatut = "superCitoyen";
            // Debug.Log("creditSocialStatut : " + creditSocialStatut);
        }

        if (creditSocialValue <= 159 && creditSocialValue >= 100)
        {
            creditSocialStatut = "citoyenHonnete";
            parkEntrance.isTrigger = true;
            parkEntrance2.isTrigger = true;
            // Debug.Log("creditSocialStatut : " + creditSocialStatut);
        }

        if (creditSocialValue <= 99 && creditSocialValue >= 50)
        {
            creditSocialStatut = "malhonnete";
            parkEntrance.isTrigger = false;
            parkEntrance2.isTrigger = false;
            // Debug.Log("creditSocialStatut : " + creditSocialStatut);
        }

        else if (creditSocialValue <= 49)
        {
            creditSocialStatut = "brigand";
            // Debug.Log("creditSocialStatut : " + creditSocialStatut);
        }
    }
}
