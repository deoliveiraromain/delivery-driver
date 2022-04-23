using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField]
    float steerSpeed = 300f;

    [SerializeField]
    float moveSpeed = 20f;

    [SerializeField]
    float slowSpped = 15f;
    [SerializeField]
    float boostSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.Rotate(0,0,45);
    }

    // Update is called once per frame
    //Time.deltaTime => to be FPS independant
    void Update()
    {
        float steerAmont = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmont);
        transform.Translate(0, -moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
         if (other.tag == "SpeedUp"){
            
            moveSpeed=boostSpeed;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        // if (other.tag == "SlowDown"){
        // }
        moveSpeed=slowSpped;
    }
}
