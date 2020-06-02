using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Networking;
using Utilities;
using Dictionary;

public class GameManager : Singleton<GameManager>
{
    public int CreditSocial;
    public string CreditSocialStatut;
    public string roomCode = "error";
    public bool multidevice;
    public string codeFinal;

    void Update()
    {
        Client.UpdateGlobalData();
    }
}
