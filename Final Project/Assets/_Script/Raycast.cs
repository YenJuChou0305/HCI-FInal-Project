using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {


    static public string hit_object;

    static public float X, Z;


    //Vector3 fwd = transform.TransformDirection(Vector3.forward) * 100;

    // Use this for initialization
    void Start () 
    {
		
	}


    void Update()
    {
        RaycastHit hit;
        //float distance;

        Vector3 fwd = transform.TransformDirection(Vector3.forward) * 100;
        Debug.DrawRay(transform.position, fwd, Color.green);

        if (Physics.Raycast(transform.position, fwd, out hit))
        {
            //distance = hit.distance;
            hit_object = hit.collider.gameObject.name;
            //Debug.Log("hit: " + hit_object);
        }


        X = fwd.x / 10;
        Z = fwd.z / 10;
        //Debug.Log(X + "  " + Z);

    }





}
