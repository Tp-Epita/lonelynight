using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barre_inventaire : MonoBehaviour {

    public List<GameObject> childs;
    public GameObject spear;
    public GameObject bow;
    public GameObject torch;
    public charCtrl max;
    public bool isHereSpear = false;
    public bool isHereBow = false;
    public bool isHereTorch = false;
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {        
        if(/*max.myInventory.spear.number*/ max.myInventory.GetWeaponQt(Weapon.TYPE.SPEAR) > 0 && !isHereSpear)
        {
            GameObject mySpear = Instantiate(spear) as GameObject;
            
            mySpear.transform.position = childs[/*max.myInventory.spear.index*/ max.myInventory.GetWeaponId(Weapon.TYPE.SPEAR)].transform.position;
            mySpear.transform.SetParent(childs[/*max.myInventory.spear.index*/ max.myInventory.GetWeaponId(Weapon.TYPE.SPEAR)].transform);
            mySpear.GetComponent<spearItem>().max = max;
            isHereSpear = true;
        }
        if (/*max.myInventory.bow.number*/ max.myInventory.GetWeaponQt(Weapon.TYPE.ARC) > 0 && !isHereBow)
        {
            GameObject myBow = Instantiate(bow) as GameObject;
            myBow.transform.position = childs[max.myInventory.GetWeaponId(Weapon.TYPE.ARC) /*max.myInventory.bow.index*/].transform.position;
            myBow.transform.SetParent(childs[/*max.myInventory.bow.index*/ max.myInventory.GetWeaponId(Weapon.TYPE.ARC)].transform);
            myBow.GetComponent<bowItem>().max = max;
            isHereBow = true;
        }
        if (/*max.myInventory.torch.number*/ max.myInventory.GetWeaponQt(Weapon.TYPE.TORCH) > 0 && !isHereTorch)
        {
            GameObject myTorch = Instantiate(torch) as GameObject;
            myTorch.transform.position = childs[max.myInventory.GetWeaponId(Weapon.TYPE.TORCH) /*max.myInventory.torch.index*/].transform.position;
            myTorch.transform.SetParent(childs[/*max.myInventory.torch.index*/ max.myInventory.GetWeaponId(Weapon.TYPE.TORCH)].transform);
            myTorch.GetComponent<torchItem>().max = max;
            isHereTorch = true;
        }
    }
}
