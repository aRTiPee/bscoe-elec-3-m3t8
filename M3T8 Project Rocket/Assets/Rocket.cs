using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody _rigidBody;
    AudioSource sfx;
    GameObject rocket;
    bool soundActive = false;
    [SerializeField] float rocketUp = 1000;
    [SerializeField] float rocketLeft = 100;
    [SerializeField] float rocketRight = 100;
    //public bool pauseGame = true;

	// Use this for initialization
	void Start () {
        _rigidBody = GetComponent<Rigidbody>();
        sfx = GetComponent<AudioSource>();
        rocket = GameObject.Find("RocketShip");
        //StartCoroutine(PauseGameTimer());
    }
	
	// Update is called once per frame
	void Update () {
        //if (!pauseGame)
        //{
            ProcessInput();
        //}
        //else
        //{
        //StartCoroutine(PauseGameTimer());
        //}
    }


    void ProcessInput()
    {
        RocketUp();
        RocketLeft();
        RocketRight();
    }

    void RocketUp()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            soundActive = true;
            sfx.Play();
            sfx.loop = true;
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            //soundActive = false;
            sfx.Pause();
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            _rigidBody.AddRelativeForce(Vector3.up * Time.deltaTime * rocketUp);
        }
    }

    void RocketLeft()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward * Time.deltaTime * rocketLeft);
    }

    void RocketRight()
    {
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-Vector3.forward * Time.deltaTime * rocketRight);
    }

    public void resetShip()
    {
        transform.position = new Vector3(-16.43f, 4.53f, -1f);
        transform.rotation = Quaternion.identity;
        _rigidBody.velocity = new Vector3(0f, 0f, 0f);
        _rigidBody.angularVelocity = new Vector3(0f, 0f, 0f);
    }

    void sound()
    {
        if (soundActive == true)
        {
            sfx.Play();
        }
        else
        {
            sfx.Pause();
        }
    }

    /*IEnumerator PauseGameTimer()
    {
        yield return new WaitForSeconds(1.25f);
        pauseGame = false;
    }*/
}
