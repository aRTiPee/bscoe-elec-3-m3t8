using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public Material[] material;
    Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void collide()
    {
        if (rend.sharedMaterial == material[0])
            rend.sharedMaterial = material[1];
        else if (rend.sharedMaterial == material[1])
            rend.sharedMaterial = material[2];
        else if (rend.sharedMaterial == material[2])
            rend.sharedMaterial = material[3];
        else
            rend.sharedMaterial = material[0];
    }
}
