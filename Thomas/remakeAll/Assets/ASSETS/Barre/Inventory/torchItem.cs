using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class torchItem : MonoBehaviour {

    public Text text;
    public charCtrl max;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        setText("" + max.myInventory.GetWeaponQt(Weapon.TYPE.TORCH));
        //setText("" + max.myInventory.torch.number);
    }

    public void setText(string Str)
    {
        text.GetComponent<Text>().text = Str;
    }
}
