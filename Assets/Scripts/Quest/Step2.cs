using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.Instance.QuestStep == "2.1" || GameManager.Instance.QuestStep == "2.2")
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("step 2 !");
                Debug.Log("questStep : " + GameManager.Instance.QuestStep);
                if (GameManager.Instance.QuestStep == "2.1")
                {
                    Debug.Log("Message du hacker : tiens voici la map de l'endroit où tu trouvera le compteur electrique");
                    Destroy(GetComponent<BoxCollider>());
                }
                if (GameManager.Instance.QuestStep == "2.2")
                {
                    Debug.Log("Message hacker : T'as intérêt à ne pas parle de moi à qui que ce soit");
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
