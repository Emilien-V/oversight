using UnityEngine;

public class pnjMovement : MonoBehaviour
{
    [SerializeField] private Vector3 direction = Vector3.forward;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float scale = 1f;
    private Vector3 _defaultPosition;


    // Start is called before the first frame update
    private void Awake()
    {
        _defaultPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _defaultPosition + direction * Mathf.Sin(Time.realtimeSinceStartup * speed) * scale;
    }
}
