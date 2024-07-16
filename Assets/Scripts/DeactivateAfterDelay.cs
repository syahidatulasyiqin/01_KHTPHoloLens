using UnityEngine;

public class DeactivateAfterDelay : MonoBehaviour
{
    public float delay = 5f;

    void Start()
    {
        // Invoke the DeactivateObject method after the specified delay
        Invoke("DeactivateObject", delay);
    }

    void DeactivateObject()
    {
        // Deactivate the GameObject
        gameObject.SetActive(false);
    }
}
