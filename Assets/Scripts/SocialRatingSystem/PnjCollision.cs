using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjCollision : MonoBehaviour
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
            Debug.Log("Vous avez bousculé quelqu'un vos perdez donc des points");
            GameManager.Instance.CreditSocial -= 5;
        }
    }
    void Update()
    {

    }
}
