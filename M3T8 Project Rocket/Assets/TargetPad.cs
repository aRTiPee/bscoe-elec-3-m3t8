using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetPad : MonoBehaviour {

    // Use this for initialization
    GameObject rocket;
    float dist = 0f;
    [SerializeField] float distance = 10f;
    public Material[] material;
    Renderer rend;
    Scene currentScene;
    public string sceneName;

    void Start () {
        rocket = GameObject.Find("RocketShip");
        rend = gameObject.GetComponent<Renderer>();
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("m3t8", LoadSceneMode.Single);
        }
            dist = Vector3.Distance(rocket.transform.position, transform.position);
        print(dist);
        if(dist <= 2.7)
        {
            rend.sharedMaterial = material[2];
        }
        else if (dist < distance)
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[0];
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (sceneName == "m3t8")
            SceneManager.LoadScene("m3t8scene2",LoadSceneMode.Single);
        else if (sceneName == "m3t8scene2")
            SceneManager.LoadScene("m3t8scene3", LoadSceneMode.Single);
    }
}
