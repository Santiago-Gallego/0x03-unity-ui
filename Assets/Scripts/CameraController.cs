using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
