using UnityEngine;

public class ToggleOnOff : MonoBehaviour {

    public GameObject ObjectToToggle;

    public void ToggleOn()
    {
        ObjectToToggle.SetActive(true);
    }

    public void ToggleOff()
    {
        ObjectToToggle.SetActive(false);
    }

}
