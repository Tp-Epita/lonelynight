using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("En contacte avec " + collision.gameObject.name);
        if (collision.gameObject.name == "MAX" && collision.gameObject.GetComponent<Animation>().IsPlaying("punch"))
        {
            Debug.Log("ça marche");
            //ishurting = true;
        }
    }
}
