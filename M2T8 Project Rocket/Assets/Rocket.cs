using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Obstacle obs;
    Rigidbody _rigidBody;

    // Use this for initialization
    void Start () {
        _rigidBody = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void FixedUpdate () {
        ProcessInput();
    }

    void ProcessInput () {
        RocketUp();
        RocketLeft();
        RocketRight();
    }

    void RocketUp () {
        if (Input.GetKey(KeyCode.Space))
            _rigidBody.AddRelativeForce(Vector3.up* 40);
    }

    void RocketLeft () {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward * 3);
    }

    void RocketRight () {
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-Vector3.forward * 3);
    }

    private void resetShip()
    {
        transform.position = new Vector3(-30, 3.97f, 0);
        transform.rotation = Quaternion.identity;
        _rigidBody.velocity = new Vector3(0f, 0f, 0f);
        _rigidBody.angularVelocity = new Vector3(0f, 0f, 0f);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "obstacle")
        {
            obs = col.gameObject.GetComponent<Obstacle>();
            obs.collide();

            resetShip();
        }
    }
}
