using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

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
        
    }

    void FixedUpdate()
    {
        
        _rigidBodyComponent.velocity = new Vector3(_horizontalInput * Speed, _rigidBodyComponent.velocity.y, _verticalInput * Speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<AudioSource>().Stop();
        if (collision.gameObject.name.Contains("NPC"))
        {
            ScoreKeeper.Total -= 100;
        }
        if (collision.gameObject.name.Contains("Bonus"))
        {
            gameObject.GetComponents<AudioSource>()[0].Play();
            ScoreKeeper.Total += 100;
        }
        if (collision.gameObject.name.Contains("Death-Dealer"))
        {
            StartCoroutine(Sound());
            ScoreKeeper.Total = 0;            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }

    IEnumerator Sound()
    {
        var tada = gameObject.GetComponents<AudioSource>()[1];
        tada.Play();
        yield return new WaitForSeconds(10.0f);
    }
}