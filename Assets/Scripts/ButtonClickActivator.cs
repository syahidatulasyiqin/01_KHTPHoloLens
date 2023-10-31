using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonClickActivator : MonoBehaviour
{
    public GameObject[] gameObjectsToActivate; // An array of game objects to activate
    private int activeObjectIndex = -1; // Index of the currently active game object

    private void Start()
    {
        // Deactivate all game objects at the start
        DeactivateAllGameObjects();
    }

    private void DeactivateAllGameObjects()
    {
        foreach (GameObject go in gameObjectsToActivate)
        {
            go.SetActive(false);
        }
        activeObjectIndex = -1;
    }

    public void ActivateGameObject(int index)
    {
        if (activeObjectIndex != -1)
        {
            gameObjectsToActivate[activeObjectIndex].SetActive(false);
        }
        gameObjectsToActivate[index].SetActive(true);
        activeObjectIndex = index;
    }

    private void ActivateNextGameObject()
    {
        // Deactivate the current active object
        if (activeObjectIndex != -1)
        {
            gameObjectsToActivate[activeObjectIndex].SetActive(false);
        }

        // Activate the next game object in the array
        activeObjectIndex = (activeObjectIndex + 1) % gameObjectsToActivate.Length;
        gameObjectsToActivate[activeObjectIndex].SetActive(true);
    }

    // You can create similar public functions for activating specific game objects as needed
    // For example:

    public void ActivateObject1()
    {
        ActivateGameObject(0);
    }

    public void ActivateObject2()
    {
        ActivateGameObject(1);
    }

    public void ActivateObject3()
    {
        ActivateGameObject(2);
    }

    public void ActivateObject4()
    {
        ActivateGameObject(3);
    }

    // And so on for each game object
}
