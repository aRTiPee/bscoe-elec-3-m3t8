using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionShip : MonoBehaviour {

    bool collision = true;
    Rocket rocket;
    ObstacleCollision[] obstacleCollision;
    GameObject[] obstacles;
    TargetPad sample;
    Scene currentScene;
    string sceneName;

    // Use this for initialization
    void Start () {
        rocket = gameObject.GetComponent<Rocket>();
        obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
        obstacleCollision = new ObstacleCollision[obstacles.Length];
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }
	
	// Update is called once per frame
	void Update () {
        CollisionToggle();
	}

    void CollisionToggle()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (collision == true)
            {
                print("collision off");
                collision = false;
            }
            else
            {
                print("collision on");
                collision = true;
            }
            
            //obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
            //obstacleCollision = obstacles.GetComponent<ObstacleCollision>();
            for (int i = 0; i < obstacles.Length; i++)
            {
                obstacleCollision[i] = obstacles[i].GetComponent<ObstacleCollision>();
                print(obstacleCollision[i]);
                obstacleCollision[i].colorObstacle();
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (collision == true)
        {
            if (col.gameObject.tag == "Obstacles")
            {
                if (sceneName == "m3t8")
                    rocket.resetShip();
                else
                    SceneManager.LoadScene("m3t8");
                //rocket.pauseGame = true;
            }
        }
    }

}
