using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPad : MonoBehaviour {
    public Renderer targetPad;
    public Material[] material;
    Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Rocket Ship")
            rend.sharedMaterial = material[1];
            targetPad.sharedMaterial = material[1];
    }

    private void OnCollisionExit(Collision collision)
    {
        rend.sharedMaterial = material[0];
        targetPad.sharedMaterial = material[0];
    }
}
