using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Networking;
using Utilities;
using Dictionary;


public class ZoneDetection : MonoBehaviour
{
    // public int score = 100;
    private bool active = false;
    private float delayToJump = 1f;
    private float delayToRun = 1f;
    private int compteurJump;
    private int compteurRun;
    private int LostPoints;
    private string type;
    private Gouvernment _gouvernment;
    private int _score;

    void Start()
    {
        _score = GameManager.Instance.CreditSocial;

        _gouvernment = new Gouvernment();
        _gouvernment.notification = new GouvernmentNotification();
        _gouvernment.type = "GOUV";
        _gouvernment.score = _score;

        print("credit social note : " + GameManager.Instance.CreditSocial);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            delayToJump = 1f;
            delayToRun = 1f;
            active = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        active = false;
    }
    private void Punishement(int compteur)
    {
        if (type == "run")
        {
            delayToRun = 1f;

            if (compteurRun < 3)
            {
                SendData(1, "Courir sur la voie publique");
            }
            if (compteurRun == 3)
            {
                SendData(4, "Résidive : Courir sur la voie publique");
                compteurRun = 0;
            }
        }

        if (type == "jump")
        {
            delayToJump = 1f;

            if (compteurJump < 3)
            {
                SendData(1, "Sauter sur la voie publique");
            }
            if (compteurJump == 3)
            {
                SendData(4, "Résidive : Sauter sur la voie publique");
                compteurJump = 0;
            }
        }
    }
    private void SendData(int point, string label)
    {
        GameManager.Instance.CreditSocial -= point;
        _score = GameManager.Instance.CreditSocial;

        _gouvernment.notification.value = -point;
        _gouvernment.notification.label = label;
        _gouvernment.score = _score;

        Debug.Log("_score : " + _score);

        // Debug.Log("test2 : " + e.Data);
        // Debug.Log("jififi " + GameManager.Instance.roomCode);

        //Envoie de la data
        Client.OnSendMessage(Convert.ObjectToString(_gouvernment));
    }

    // Update is called once per frame
    void Update()
    {
        // Décrémente timeToDisplay jusqu'a 0;
        delayToJump -= Time.deltaTime;
        delayToRun -= Time.deltaTime;

        if (active == true)
        {
            if (delayToRun <= 0)
            {
                if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.D))
                {
                    if (Input.GetKey(KeyCode.LeftShift))
                    {
                        type = "run";
                        compteurRun = compteurRun + 1;
                        Punishement(compteurRun);
                    }
                }
            }

            if (delayToJump <= 0)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    type = "jump";
                    compteurJump = compteurJump + 1;
                    Punishement(compteurJump);
                }
            }
        }
    }
}
