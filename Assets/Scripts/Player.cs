using UnityEngine;

public class Player : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;
    private float _leftRotateInput;
    private float _rightRotateInput;
    
    private Rigidbody _rigidBodyComponent;

    [SerializeField]
    private float Speed = 5.0f;

    // Initalization
    void Start()
    {
        _rigidBodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0.0f, 1f, 0.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0.0f, -1f, 0.0f, Space.Self);
        }

    }

    void FixedUpdate()
    {
        
        _rigidBodyComponent.velocity = new Vector3(_horizontalInput * Speed, _rigidBodyComponent.velocity.y, _verticalInput * Speed);
    }
}