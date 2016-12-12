using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
    public Team team;

    public void OnTriggerEnter(Collider other)
    {
        Rigidbody body = other.GetComponent<Rigidbody>();
        if (body.tag.Equals("Ball"))
            {
            World world = transform.parent.parent.GetComponent<World>();
            if (world != null)
            {
                world.score(team);
                world.reset();
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
