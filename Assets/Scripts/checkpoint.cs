using UnityEngine;

public class checkpoint : MonoBehaviour
{
    [SerializeField] private Script1 player;

    private void OnTriggerEnter(Collider other)
    {
        player.setCheckPoint(player.transform.position);
    }
}
