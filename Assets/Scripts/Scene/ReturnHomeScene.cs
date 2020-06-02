using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnHomeScene : MonoBehaviour
{
    public void ReturnHome()
    {
        SceneManager.LoadScene("Home");
    }
}
