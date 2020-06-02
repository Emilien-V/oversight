using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangerV2 : MonoBehaviour
{
    [SerializeField] private Canvas CanvasHome;
    [SerializeField] private GameObject ButtonHome;
    [SerializeField] private Canvas CanvasConnexionDevice;
    [SerializeField] private GameObject ButtonConnexionDevice;

    public void SceneChange1()
    {
        CanvasHome.enabled = false;
        CanvasConnexionDevice.enabled = true;
    }
}
