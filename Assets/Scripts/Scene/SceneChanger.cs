using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // public string sceneName;
    public float waitTime;
    public Animator musicAnim;
    public void SceneJeu()
    {
        SceneManager.LoadScene("Jeu");
        // StartCoroutine(ChangeScene());
    }
    public void SceneHome()
    {
        SceneManager.LoadScene("Home");
    }
    public void CloseGame()
    {
        Application.Quit();
    }

    IEnumerator ChangeScene()
    {
        musicAnim.SetTrigger("fadeOut");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Jeu");
    }

}
