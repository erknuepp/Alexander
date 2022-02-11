using UnityEngine;

public class Player : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;
    
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
        //var inputString = "";
        //try
        //{
            
        //    //inputString = Input.inputString;

        //    //if (inputString != "q" && inputString != "e" && inputString != "")
        //    //{
        //    //    throw new System.FormatException("invalid key");
        //    //}

            
        //}
        //catch (System.FormatException fe)
        //{
        //    Debug.Log(fe.Message);
        //    throw fe;
        //}
        //finally
        //{
        //    //Debug.Log(inputString);
        //}

    }

    void FixedUpdate()
    {
        
        _rigidBodyComponent.velocity = new Vector3(_horizontalInput * Speed, _rigidBodyComponent.velocity.y, _verticalInput * Speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("NPC"))
        {
            ScoreKeeper.Total -= 100;
        }
    }
}