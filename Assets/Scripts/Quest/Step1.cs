using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.Instance.QuestStep != "0")
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("step 1 !");
                Debug.Log("questStep : " + GameManager.Instance.QuestStep);
                if (GameManager.Instance.QuestStep == "1.0")
                {
                    Debug.Log("message d'un ami");
                    Destroy(GetComponent<BoxCollider>());
                }
                if (GameManager.Instance.QuestStep == "2.0")
                {
                    Debug.Log("message d'un hacker");
                    Destroy(GetComponent<BoxCollider>());
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
