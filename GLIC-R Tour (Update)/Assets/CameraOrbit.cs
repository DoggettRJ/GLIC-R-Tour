using UnityEngine;


[AddComponentMenu("Camera-Control/Mouse Orbit")]
public class CameraOrbit : MonoBehaviour {

    [SerializeField]
    public Transform target;
    [SerializeField]
    private float distance = 12;

}