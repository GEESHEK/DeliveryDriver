using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 0.1f;
    [SerializeField] private float moveSpeed = 0.01f;

    void Start()
    {
    }

    void Update()
    {
        // player can press from -1 (left) to +1 (right)
        // Positive Z rotation = counter-clockwise (left turn)
        // Negative Z rotation = clockwise (right turn)
        var steerAmount = Input.GetAxis("Horizontal") * steerSpeed  * Time.deltaTime;
        var moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}