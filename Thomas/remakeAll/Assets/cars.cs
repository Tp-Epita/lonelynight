using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class cars : MonoBehaviour
{
	public GameObject cam1;
	public GameObject cam2;
	public float vitesse = 10;
	private Vector3 init;

	public GameObject loadpage;

	public GameObject song;
	
	private bool isApend = false;
	void Start ()
	{
		cam1.SetActive(true);
		cam2.SetActive(false);
		init = transform.position;
	}
	

	void Update ()
	{
		transform.Translate(0,0, vitesse * Time.deltaTime);
		if (Time.time > 6 && !isApend)
		{
			transform.position = init;
			cam1.SetActive(false);
			cam2.SetActive(true);
			isApend = true;
			
		}
		if (Time.time > 12
		    )
		{
			loadpage.SetActive(true);
			DontDestroyOnLoad(song);
			SceneManager.LoadScene("Scene_Thomas_1");
		}
	}
}
