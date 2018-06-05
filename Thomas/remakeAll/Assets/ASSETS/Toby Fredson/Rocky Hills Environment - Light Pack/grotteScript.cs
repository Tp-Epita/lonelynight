using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class grotteScript : MonoBehaviour {


    public Transform Player;
    Vector3 Position = new Vector3();
    Vector3 playerPosition = new Vector3();
    // Use this for initialization
    void Start () {
        Position = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        playerPosition = Player.gameObject.transform.position;
        if (Input.GetKeyDown(KeyCode.E))
        {
            double distance = Math.Sqrt((Position.x - playerPosition.x) * (Position.x - playerPosition.x) + (Position.y - playerPosition.y) * (Position.y - playerPosition.y) + (Position.z - playerPosition.z) * (Position.z - playerPosition.z));
            if(distance < 10)
            {
                SceneManager.LoadScene("grotte bouton");
            }
        }
    }
}
