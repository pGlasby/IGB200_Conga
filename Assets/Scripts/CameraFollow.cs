
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float speed = 0.125f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 position = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, position, speed);
        transform.position = smoothPosition;

        //this one is for more dynamic camera :)
        //transform.LookAt(target);

    }
}
