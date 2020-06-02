using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using static GameManager;

// using Networking;
// using Utilities;
// using Dictionary;

// using UnityEngine.SceneManagement;


public class ShowCodeRoom : MonoBehaviour
{

    [SerializeField] private GameObject CodeRoom;
    [SerializeField] private GameObject Button;
    private string roomCode;
    private bool activeOrNot = true;

    void ShowCode()
    {
        CodeRoom.GetComponent<Text>().text = GameManager.Instance.roomCode;
        var text = CodeRoom.GetComponent<Text>().text;
        Debug.Log("code dans le script ShowRoom : " + GameManager.Instance.roomCode);


    }


    // Update is called once per frame
    void Update()
    {
        if (activeOrNot == true)
        {
            if (GameManager.Instance.roomCode != "error")
            {
                ShowCode();
                activeOrNot = false;
            }
        }
        GameManager.Instance.multidevice = true;
        // Show the button or not;
        Button.SetActive(GameManager.Instance.multidevice);

    }
}
