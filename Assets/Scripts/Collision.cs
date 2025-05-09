using System;
using UnityEngine;

public class Collision : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("that hurts, drive better");
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    Debug.Log("power up triggered");
  }
}
