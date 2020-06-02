using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeenCollision : MonoBehaviour
{
    public AudioSource audioCollision;
    // Start is called before the first frame update
    void Start()
    {
        audioCollision = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioCollision.Play();
            Debug.Log("Vous avez bousculé une poubelle vous perdez donc des points");
            GameManager.Instance.CreditSocial -= 5;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
