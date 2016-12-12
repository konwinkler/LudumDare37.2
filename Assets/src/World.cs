using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class World : MonoBehaviour
{
    public List<Transform> objects;
    private Dictionary<Transform, Vector3> startingPositions = new Dictionary<Transform, Vector3>();
    public bool paused = false;
    private int goalHuman, goalAI = 0;
    private GameObject scoreText;
    public Transform endScreen;


    // Use this for initialization
    void Start()
    {
        scoreText = GameObject.Find("scoreText");

        updateScore();

        foreach (Transform t in objects)
        {
            startingPositions.Add(t, t.transform.position);
        }
    }

    public void score(Team t)
    {
        switch (t)
        {
            case Team.HUMAN:
                goalHuman++;
                break;
            case Team.AI:
                goalAI++;
                break;
        }

        updateScore();
    }

    public void updateScore()
    {
        Text text = scoreText.GetComponent<Text>();
        text.text = "You : " + goalHuman + " - AI: " + goalAI;

        if (goalAI >= 3 || goalHuman >= 3)
        {
            endGame();
        }
    }

    private void endGame()
    {
        pause();
        endScreen.GetComponent<InputController>().endGame();
    }

    public void pause()
    {
        Debug.Log("Pause");
        foreach (Transform t in objects)
        {
            t.GetComponent<Rigidbody>().isKinematic = true;
            t.GetComponent<Rigidbody>().Sleep();
        }
    }

    public void awake()
    {
        Debug.Log("Awake");

        goalHuman = 0;
        goalAI = 0;

        foreach (Transform t in objects)
        {
            t.GetComponent<Rigidbody>().isKinematic = false;
            t.GetComponent<Rigidbody>().WakeUp();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void reset()
    {
        foreach (Transform t in objects)
        {
            t.transform.position = startingPositions[t];
            Rigidbody body = t.GetComponent<Rigidbody>();
            body.velocity = Vector3.zero;
            t.rotation = Quaternion.identity;
        }
    }
}
