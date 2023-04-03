using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public bool doubleSpeed = false;
    public float Score;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver);
            {
            if(playerControllerScript.doubleSpeed)
            {
                Score += 2;
            }
            else
            {
                Score++;
            }
            Debug.Log("Score: " + Score);
        }
    }
}
