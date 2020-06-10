using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIAppearPolicier : MonoBehaviour
{
    [SerializeField] private Canvas customImage;
    public Collider blockUser;
    private bool active;

    void Start()
    {
        Cursor.visible = false;
        blockUser.isTrigger = true;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            active = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            active = false;
            Cursor.visible = false;
        }
    }
    void Update()
    {
        if (active == true)
        {
            blockUser.isTrigger = false;
            customImage.enabled = true;
            Cursor.visible = true;

        }
        else
        {
            customImage.enabled = false;
        }

        if (GameManager.Instance.blockUserActive == false)
        {
            blockUser.isTrigger = true;
        }
        Debug.Log(" blockUserActive : " + GameManager.Instance.blockUserActive);
    }
}
