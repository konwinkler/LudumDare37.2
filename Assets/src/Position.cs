using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour {
    protected Rigidbody body;
    protected World world;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Transform t = GetComponent<Transform>();
        Debug.Log(transform.name + " scale y " + t.localScale.y);
        t.position = new Vector3(body.position.x, t.localScale.y, body.position.z);

        world = GetComponentInParent<World>();
    }


    // Update is called once per frame
    void Update () {

	}
}
