using System.Collections;
using System.Collections.Generic;
using ASSETS.Scripts;
using UnityEngine;

public class miniMapScript : MonoBehaviour
{

	public GameObject _cam_max;
	public GameObject _minimap_cam;
	public GameObject _canvas;

	public charCtrl _max;

	private bool isPressed = true;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (_max.myInventory.GetStuffQt(Stuff.Type.Map) > 0)
		{
			if (Input.GetKey(KeyCode.M))
			{
				isPressed = !isPressed;

			}
			changeMap(isPressed);
		}
	}


	public void changeMap(bool a)
	{
		if (a)
		{
			_cam_max.SetActive(false);
			_minimap_cam.SetActive(true);
			_canvas.SetActive(false);
		}
		else
		{
			_canvas.SetActive(true);
			_cam_max.SetActive(true);
			_minimap_cam.SetActive(false);
		}
	}
}
