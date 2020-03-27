using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_PogU : MonoBehaviour
{
    Rigidbody PogU;
    public Vector3 currentPos;

    int Omega = 5;
    int Amplitude = 80;

    // Start is called before the first frame update
    void Start()
    {
        PogU = this.GetComponent<Rigidbody>();
        currentPos = PogU.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion target = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.eulerAngles.y, Amplitude * Mathf.Sin(Time.time * Omega));
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
    }
}
