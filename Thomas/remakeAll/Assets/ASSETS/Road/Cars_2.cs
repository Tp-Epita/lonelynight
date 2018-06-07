using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars_2 : MonoBehaviour
{

	public float _vitesse = 20;
	public float _max_vitesse = 8;
	public GameObject _canvas;
	public GameObject _max_intro;
	public GameObject _max_good;
	public List<GameObject> _cams;

	private Animation _maxAnimation;


	private float timeStart;
	
	void Start ()
	{
		timeStart = Time.time;
		_maxAnimation = _max_intro.GetComponent<Animation>();
		_max_good.SetActive(false);
		_max_intro.SetActive(false);
		_canvas.SetActive(false);
		_cams[0].SetActive(false);
		_cams[1].SetActive(true);
		_cams[2].SetActive(false);
		_cams[3].SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - timeStart< 7)
		{
			transform.Translate(0,0,_vitesse * Time.deltaTime);
		}
		else
		{
			_cams[1].SetActive(false);
			_cams[2].SetActive(true);
			_max_intro.SetActive(true);
			if (Time.time - timeStart < 15)
			{
				_maxAnimation.Play("walk");
				_max_intro.transform.Translate(0,0,_max_vitesse * Time.deltaTime);
				if (Time.time - timeStart > 11)
				{
					_cams[2].SetActive(false);
					_cams[3].SetActive(true);
				}
			}
			else
			{
				_cams[3].SetActive(false);
				_cams[0].SetActive(true);
				_max_intro.SetActive(false);
				_max_good.SetActive(true);
				_canvas.SetActive(true);
			}
		}
		
	}
}
