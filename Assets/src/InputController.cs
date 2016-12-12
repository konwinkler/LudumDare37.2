using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
    private World world;
    private GameObject startScreen;
    private GameObject endScreen;

    // Use this for initialization
    void Start () {
        startScreen = GameObject.Find("startScreen");
        endScreen = GameObject.Find("endScreen");
        startScreen.SetActive(true);
        endScreen.SetActive(false);

        world = GetComponentInParent<World>();
        world.pause();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void endGame()
    {
        endScreen.SetActive(true);
    }

    public void clickStart()
    {
        startScreen.SetActive(false);
        endScreen.SetActive(false);
        world.awake();
        world.updateScore();
    }
}
