using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPlayer : Player
{
    public Transform ball;
    public Transform targetGoal;
    private readonly float TOLERANCE = 0.25f;
    private float SHOOTING_DISTANCE = 2f;

    // Update is called once per frame
    void Update()
    {
        x_move = 0;
        z_move = 0;
        Vector3 target;

        //close enough -> shoot
        if (Vector3.Distance(transform.position, ball.position) < SHOOTING_DISTANCE)
        {
            target = ball.position;
        }
        else {
            //aim at opponent goal, go behind ball
            target = targetGoal.position - ball.position;
            target = ball.position - target.normalized * 1.5f;
        }

        if (target.x < transform.position.x - TOLERANCE)
            x_move = -MOVE_FACTOR;
        if (target.x > transform.position.x + TOLERANCE)
            x_move = MOVE_FACTOR;

        if (target.z < transform.position.z - TOLERANCE)
            z_move = -MOVE_FACTOR;
        if (target.z > transform.position.z + TOLERANCE)
            z_move = MOVE_FACTOR;

    }
}
