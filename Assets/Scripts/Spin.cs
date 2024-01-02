using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation in degrees per second

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the Y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}