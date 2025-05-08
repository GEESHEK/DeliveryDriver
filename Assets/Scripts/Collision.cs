using UnityEngine;

public class Collision : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D collision2D)
  {
    Debug.Log("that hurts, drive better");
  }
}
