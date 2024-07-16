using UnityEngine;
using System.Collections.Generic;

public class MapActivation : MonoBehaviour
{
    public List<GameObject> gameObjectsToActivate;
    public List<GameObject> gameObjectsToDeactivate;

    public void ActivateGameObject()
    {
        foreach (GameObject obj in gameObjectsToActivate)
        {
            obj.SetActive(true);
        }

        foreach (GameObject obj in gameObjectsToDeactivate)
        {
            obj.SetActive(false);
        }
    }
}
