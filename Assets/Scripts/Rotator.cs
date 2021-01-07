using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(Time.deltaTime * 45, 0, 0));
    }
}
