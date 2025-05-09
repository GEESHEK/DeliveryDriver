using UnityEngine;

public class Delivery : MonoBehaviour
{
  private bool hasPackage;
  [SerializeField] private float destoryDelay = 0.5f;
  
  private void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("that hurts, drive better");
  }

  // other gives us the other thing (gameObject) we bumped into
  private void OnTriggerEnter2D(Collider2D other)
  {
    // use tag to categorize objects
    if (other.tag == "Package" && !hasPackage)
    {
      Debug.Log("Package picked up");
      hasPackage = true;
      Destroy(other.gameObject, destoryDelay);
    }

    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Delivered package");
      hasPackage = false;
    }
  }
}
