using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    Rigidbody ourRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        {

            if (Input.GetKey(KeyCode.W))
            {
                ourRigidbody.velocity = new Vector3(-40, 0, 0);
            }

            if (Input.GetKey(KeyCode.S))
            {
                ourRigidbody.velocity = new Vector3(40, 0, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                ourRigidbody.velocity = new Vector3(0, 0, -40);
            }

            if (Input.GetKey(KeyCode.D))
            {
                ourRigidbody.velocity = new Vector3(0, 0, 40);
            }

        }
    }
}
    