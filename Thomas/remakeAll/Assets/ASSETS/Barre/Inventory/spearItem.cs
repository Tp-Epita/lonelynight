using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spearItem : MonoBehaviour {
    public Text text;
    public charCtrl max;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		setText("" + max.myInventory.GetWeaponQt(Weapon.TYPE.SPEAR));
        //setText("" + max.myInventory.spear.number);
	}

    public void setText(string Str)
    {
        text.GetComponent<Text>().text = Str;
    }
}
