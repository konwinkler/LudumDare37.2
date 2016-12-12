using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Position
{
    protected float MOVE_FACTOR = 4f;
    protected float x_move, z_move = 0f;
    public bool grab = false;

    private void FixedUpdate()
    {
        body.velocity = new Vector3(x_move, 0, z_move);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
