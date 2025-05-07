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
        // player can press from -1 to +1
        var steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        var moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}