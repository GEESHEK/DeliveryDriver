using System;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("that hurts, drive better");
  }

  // other gives us the other thing we bumped into
  private void OnTriggerEnter2D(Collider2D other)
  {
    // use tag to categorize objects
    switch (other.tag)
    {
      case "Package":
        Debug.Log("Package picked up");
        break;
      case "Customer":
        Debug.Log("Delivered package");
        break;
    }
  }
}
