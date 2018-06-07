using System.Collections;
using System.Collections.Generic;
using ASSETS.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class Woodinventoryscript : MonoBehaviour {

    public charCtrl max;
    public GameObject text;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        text.GetComponent<Text>().text = "" + max.myInventory.GetGoodQt(Ressource.Type.Wood);
	}
}
