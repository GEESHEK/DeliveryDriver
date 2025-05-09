using UnityEngine;

public class Delivery : MonoBehaviour
{
  [SerializeField] Color32 hasPackageColor = new Color32(255, 255, 255, 255);
  [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);
  [SerializeField] private float destoryDelay = 0.5f;
  private bool hasPackage;
  private SpriteRenderer _spriteRenderer;

  private void Start()
  {
    _spriteRenderer = GetComponent<SpriteRenderer>();
  }

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
      _spriteRenderer.color = hasPackageColor;
      Destroy(other.gameObject, destoryDelay);
    }

    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Delivered package");
      hasPackage = false;
      _spriteRenderer.color = noPackageColor;
    }
  }
}
