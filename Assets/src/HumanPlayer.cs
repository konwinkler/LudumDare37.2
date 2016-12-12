using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPlayer : Player {

    void Update()
    {
        x_move = 0f;
        if (Input.GetKey(KeyCode.LeftArrow))
            x_move = -MOVE_FACTOR;
        if (Input.GetKey(KeyCode.RightArrow))
            x_move = MOVE_FACTOR;

        z_move = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
            z_move = MOVE_FACTOR;
        if (Input.GetKey(KeyCode.DownArrow))
            z_move = -MOVE_FACTOR;

        grab = false;
        if (Input.GetKey(KeyCode.LeftShift))
            grab = true;
    }
}
