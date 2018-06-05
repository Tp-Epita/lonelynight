using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeBar : MonoBehaviour {

	public List<Component> images;
    public charCtrl max;
    public GameObject text;
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        text.GetComponent<Text>().text = max.life + "%";
        float elt = 0;
        foreach(var image in images)
        {
            elt += (float) 4;
            if(elt < max.life)
            {
                image.gameObject.SetActive(true);
            }
            else
            {
                image.gameObject.SetActive(false);
            }
        }
	}


}
