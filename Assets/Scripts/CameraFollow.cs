using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        offset.x = 0.75f;
        offset.y = 0.15f;
        offset.z = -0.45f;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
