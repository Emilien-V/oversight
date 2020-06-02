using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    [SerializeField] private Canvas menuCanvas;
    // Start is called before the first frame update
    void Start()
    {
        menuCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("touche Echape");
            menuCanvas.enabled = true;
        }

    }
}
