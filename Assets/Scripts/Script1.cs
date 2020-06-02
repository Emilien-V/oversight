using UnityEngine;

public class Script1 : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float speed = 7f;
    [SerializeField] private float jumpSpeed = 5f;
    // [SerializeField] private float maxSpeed = 5f;

    private Camera _camera;
    private bool _isFalling = false;
    private float minDistanceFloor = 1.5f;
    private Vector3 _moveDirection = Vector3.zero;

    private Vector3 _defaultPosition;
    private Vector3 _checkpoint;

    void Start()
    {
        //Via le script
        _camera = Camera.main;
        _checkpoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _moveDirection = Vector3.zero;

        _moveDirection.x = Input.GetAxis("Horizontal");
        _moveDirection.z = Input.GetAxis("Vertical");

        if (Physics.Raycast(transform.position, Vector3.down, out var hit, Mathf.Infinity))
        {
            _isFalling = (hit.distance > minDistanceFloor);
        }
        else
        {
            _isFalling = true;
        }

        if (Input.GetKey(KeyCode.Space) && !_isFalling)
        {
            _moveDirection.y += 1f;
        }

        _moveDirection.Normalize();

        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Touche R pressé ! ");
            // Application.LoadLevel(0);
            transform.position = _checkpoint;
        }

        transform.rotation = Quaternion.Euler(0, _camera.transform.rotation.eulerAngles.y, 0f);

        /* if (Input.GetKeyUp(KeyCode.RightArrow)
             || Input.GetKeyUp(KeyCode.LeftArrow)
             || Input.GetKeyUp(KeyCode.UpArrow)
             || Input.GetKeyUp(KeyCode.DownArrow))
         {
             rigidbody.velocity = Vector3.zero;
             return;
         }
         if (Input.GetKey(KeyCode.DownArrow))
         {
             _moveDirection.x += 1f;
         }

         if (Input.GetKey(KeyCode.UpArrow))
         {
             _moveDirection.x -= 1f;
         }

         if (Input.GetKey(KeyCode.RightArrow))
         {
             _moveDirection.z += 1f;
         }

         if (Input.GetKey(KeyCode.LeftArrow))
         {
             _moveDirection.z -= 1f;
         }
         if (Input.GetKey(KeyCode.Space))
         {
             _moveDirection.y += 21f;
         }
         */

    }
    private void FixedUpdate()
    {
        if (_moveDirection.y > 0f)
        {
            rigidbody.AddForce(Vector3.up * jumpSpeed);
        }

        var viewDirection = transform.TransformDirection(new Vector3(_moveDirection.x, 0f, _moveDirection.z));

        rigidbody.MovePosition(transform.position + viewDirection * speed * Time.fixedDeltaTime);
    }

    public void setCheckPoint(Vector3 checkpointPosition)
    {
        _checkpoint = checkpointPosition;
    }
}