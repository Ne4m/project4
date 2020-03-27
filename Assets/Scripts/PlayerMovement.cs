using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody player;

    [SerializeField]
    private Text text;

    float jumpVal = 160;

    float startRotationX;
    float startRotationY;

    public float player_speed = 1;
    public Camera camera_1;

    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetInputData();

        text.text = "Velocity : " + camera_1.velocity;
    }


    void GetInputData()
    {

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position = transform.position + (camera_1.transform.right * -1) * player_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position = transform.position + camera_1.transform.right * player_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position = transform.position + camera_1.transform.forward * player_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position = transform.position + (camera_1.transform.forward * -1) * player_speed * Time.deltaTime;
        }

        player.constraints = RigidbodyConstraints.FreezeRotation;

        if (Input.GetKeyDown("space")) player.AddForce(0, jumpVal, 0); //  & rb.position.y <= 0.121184f
    }

}
