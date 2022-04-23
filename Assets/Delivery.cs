using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{


    [SerializeField]
    private Color32 hasPackageColor = new Color32(195, 34, 48, 255);
    [SerializeField]
    private Color32 noPackageColor = new Color32(255, 255, 255, 255);

    [SerializeField]
    private float destroyDelay = 0.1f;
    private bool hasPackage;

    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("Outch");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Zone Entered");
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up !");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered !");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
       

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Debug.Log("Zone Exited");
    }
}
