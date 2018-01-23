using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour {

    public Material[] material;
    Renderer rend;

    // Use this for initialization
    void Start () {
        rend = gameObject.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void colorObstacle()
    {
        if (rend.sharedMaterial == material[0])
        {
            rend.sharedMaterial = material[1];
        }
        else if (rend.sharedMaterial == material[1])
        {
            rend.sharedMaterial = material[0];
        }
    }
}
