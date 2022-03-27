using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField]
    float steerSpeed = 0.1f;

    [SerializeField]
    float moveSpeed = 0.01f;
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
}
