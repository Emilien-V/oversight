using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSayHi : MonoBehaviour
{
    // [SerializeField] private float speed = 7f;
    private int num = 1;
    int randomNumber = 0;
    int finishedCount = 0;

    bool activeInput = false;
    bool activeFunction;
    public AudioSource audioSelected;
    public AudioClip soundHey;
    public AudioClip soundCollision;

    private float delayToChangeSound = 1f;

    private Animator animPnj;
    [SerializeField] public Animator animMainCharacter;

    void Start()
    {
        audioSelected = GetComponent<AudioSource>();
        animPnj = GetComponent<Animator>();
        // animMainCharacter = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSelected.clip = soundCollision;

        // Generate a random password  
        randomNumber = Random.Range(1, 3);
        Debug.Log("randomNumber : " + randomNumber);

        if (randomNumber == num)
        {
            if (other.CompareTag("Player"))
            {
                activeInput = true;
                activeFunction = true;
                Debug.Log("ok les deux sont pareils");
                audioSelected.Stop();
                audioSelected.clip = soundHey;
                SayHi();
            }
        }
        else if (randomNumber != num)
        {
            activeInput = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        delayToChangeSound -= Time.deltaTime;

        if (delayToChangeSound <= 0)
        {
            audioSelected.clip = soundCollision;
        }

        if (activeInput == true && activeFunction == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                animMainCharacter.SetTrigger("sayHi");
                delayToChangeSound = 1f;
                Debug.Log("Tu lui a répondu bonjour, tu gagnes des points ");
                GameManager.Instance.CreditSocial += 10;
                activeFunction = false;
                audioSelected.Stop();
                audioSelected.clip = soundHey;
                audioSelected.Play();
            }
        }
    }
    private void SayHi()
    {
        animPnj.SetTrigger("sayHi");
        Debug.Log("Bonjour ! ");
        delayToChangeSound = 1f;
        Debug.Log("delayToChangeSound = " + delayToChangeSound);
        audioSelected.Play();
        // audioSelected.clip = soundCollision;
    }
}
