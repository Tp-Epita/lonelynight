using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rockinventory : MonoBehaviour {

    public charCtrl max;
    public GameObject text;

    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        text.GetComponent<Text>().text = "" + max.myInventory.GetGoodQt(Good.TYPE.ROCK);
    }
}
