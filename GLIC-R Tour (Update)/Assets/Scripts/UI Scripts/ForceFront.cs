using UnityEngine;

public class ForceFront : MonoBehaviour
{
#if UNITY_EDITOR
    public void OnGUI()
    {
        GUI.depth = 0;
    }
#endif
}
