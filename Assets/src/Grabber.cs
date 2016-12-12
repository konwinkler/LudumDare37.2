using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour {
    private Player parentScript;

	// Use this for initialization
	void Start () {
        parentScript = transform.parent.GetComponent<Player>();
	}

    private void OnTriggerStay(Collider other)
    {
        if (parentScript.grab)
        {
            Rigidbody body = other.GetComponent<Rigidbody>();
            if (body != null && body.tag.Equals("Ball"))
            {
                Debug.Log("Grab " + other.transform.name);
                body.velocity = Vector3.zero;
            }
        }
    }

    // Update is called once per frame
    void Update () {
        MeshRenderer r = GetComponent<MeshRenderer>();
        r.enabled = parentScript.grab;
	}
}
