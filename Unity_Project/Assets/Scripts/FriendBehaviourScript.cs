using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendBehaviourScript : MonoBehaviour
{
    float direction_x,direction_y,rotation;

    // Start is called before the first frame update
    void Start()
    {
        direction_x = Random.Range(-2.0f, 2.0f);
        direction_y = Random.Range(-2.0f, 2.0f);
        rotation = Random.Range(-1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction_x * Time.deltaTime,0f, direction_x * Time.deltaTime);
        //transform.Rotate(rotation, rotation, rotation, Space.Self);
        transform.Rotate(0f, rotation, 0f, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);

        if (collision.gameObject.name == "RigidBodyFPSController")
        {

        }
        direction_x = Random.Range(-10.0f, 10.0f);
        direction_y = Random.Range(-10.0f, 10.0f);
        rotation = Random.Range(-2.0f, 2.0f);

    }

}
