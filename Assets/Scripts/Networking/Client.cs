using System;
using UnityEngine;
using WebSocketSharp;

using Utilities;
using Dictionary;

using UnityEngine.UI;



// using UnityEngine.SceneManagement;


// using System.Collections.Generic;
// using System.Web.UI;
// using System.Web.Script.Serialization;

namespace Networking
{
    public static class Client
    {
        // private static Scene scene;
        private static WebSocket _webSocket;
        private static object _dataObject;
        public static string codeRoomValue;
        // public static string creditSocialStatutValue;
        public static bool multideviceValue;


        [RuntimeInitializeOnLoadMethod]
        private static void Start()
        {
            _webSocket = new WebSocket("ws://server-oversight.herokuapp.com/?device=UNITY");
            ConnectClient();
        }

        private static void ConnectClient()
        {
            _webSocket.OnOpen += OnOpen;
            _webSocket.OnClose += OnClose;
            _webSocket.OnError += OnError;
            _webSocket.OnMessage += OnMessage;

            _webSocket.Connect();
        }

        private static void OnOpen(object sender, EventArgs e)
        {
            Debug.Log("Client - OnOpen");
        }

        private static void OnClose(object sender, CloseEventArgs e)
        {
            Debug.Log("Client - OnClose");

            _webSocket.OnOpen -= OnOpen;
            _webSocket.OnClose -= OnClose;
            _webSocket.OnError -= OnError;
            _webSocket.OnMessage -= OnMessage;
        }

        private static void OnError(object sender, ErrorEventArgs e)
        {
            Debug.Log($"Client - OnError : {e.Message}");
        }

        private static void OnMessage(object sender, MessageEventArgs e)
        {
            switch (Identification.TypeOfData(e.Data))
            {
                case "ROOM":
                    var room = JsonUtility.FromJson<Room>(e.Data);

                    codeRoomValue = room.value;
                    multideviceValue = room.multidevice;

                    Debug.Log("codeR " + codeRoomValue);
                    Debug.Log("eData : " + e.Data);
                    break;

                case "GOUV":
                    var gouvernmentData = JsonUtility.FromJson<Gouvernment>(e.Data);
                    gouvernmentData.notification = JsonUtility.FromJson<GouvernmentNotification>(Utilities.Convert.ObjectToString(gouvernmentData.notification));
                    Debug.Log(gouvernmentData.notification.label);
                    break;
            }
        }

        public static void OnSendMessage(string message)
        {
            _webSocket.Send(message);
        }

        public static void UpdateGlobalData()
        {
            GameManager.Instance.roomCode = codeRoomValue;
            GameManager.Instance.multidevice = multideviceValue;
            // GameManager.Instance.CreditSocialStatut = creditSocialStatutValue;
        }
    }
}

