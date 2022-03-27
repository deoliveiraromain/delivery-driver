using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D other) {
      Debug.Log("Outch");
  }

  private void OnTriggerEnter2D(Collider2D other) {
      Debug.Log("Zone Entered");
  }
  
  private void OnTriggerExit2D(Collider2D other) {
      Debug.Log("Zone Exited");
  }
}
