using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    public Camera vrCamera;
    public float distance = 1.5f;
    public Vector3 scale = new Vector3(0.002f, 0.002f, 0.002f);

    void OnEnable()
    {
        var t = transform;
        t.position = vrCamera.transform.position + vrCamera.transform.forward * distance;
        t.rotation = vrCamera.transform.rotation;
        t.localScale = scale;
    }
}
