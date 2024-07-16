using UnityEngine;

public class MapPositionManager : MonoBehaviour
{
    private Vector3 defaultPosition = new Vector3(0f, 0f, 2f);

    void Start()
    {
        if (PlayerPrefs.HasKey("posX") && PlayerPrefs.HasKey("posY") && PlayerPrefs.HasKey("posZ"))
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("posX"),
                                             PlayerPrefs.GetFloat("posY"),
                                             PlayerPrefs.GetFloat("posZ"));
        }
        else
        {
            transform.position = defaultPosition;
            SavePosition();
        }
    }

    void OnDestroy()
    {
        SavePosition();
    }

    private void SavePosition()
    {
        PlayerPrefs.SetFloat("posX", transform.position.x);
        PlayerPrefs.SetFloat("posY", transform.position.y);
        PlayerPrefs.SetFloat("posZ", transform.position.z);
        PlayerPrefs.Save();
    }

    public void ResetPosition()
    {
        transform.position = defaultPosition;
        SavePosition();
    }
}
