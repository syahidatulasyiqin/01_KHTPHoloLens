using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed = 30.0f; // Adjust the speed as needed

    void Update()
    {
        // Rotate the object around its local Y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
    }
}

