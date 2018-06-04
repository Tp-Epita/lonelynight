using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_script : MonoBehaviour {

    public List<GameObject> lumieres;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.F6))
        {
            foreach(GameObject lum in lumieres)
            {
                lum.SetActive(true);
            }
        }
        if (Input.GetKey(KeyCode.F7))
        {
            foreach (GameObject lum in lumieres)
            {
                lum.SetActive(false);
            }
        }
    }
}
