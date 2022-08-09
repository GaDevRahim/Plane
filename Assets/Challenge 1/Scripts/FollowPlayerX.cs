using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    private GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);

    void Start()
    {
        plane = GameObject.Find("Plane");
    }

    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
