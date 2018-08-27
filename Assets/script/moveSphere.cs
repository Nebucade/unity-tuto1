using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class moveSphere : MonoBehaviour {

    float pos_x = 0;
    float pos_y = 0;

    float direction = 0.02f;


	// Use this for initialization
	void Start () {
        Debug.Log("Init Sphere");
        CalculNewPosition();

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = this.transform.position;
        if (pos.x < -2 || pos.x > 2)
        { direction = -direction; }

        this.transform.Translate(new Vector3(direction, 0, 0), Space.World);
       
	}


    void CalculNewPosition()
    {

        Debug.Log("New position :" + pos_x + " : " + pos_y);
    }
}
