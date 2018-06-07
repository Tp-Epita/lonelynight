using System.Collections;
using System.Collections.Generic;
using ASSETS.Scripts;
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
        if(/*max.myInventory.spear.number*/ max.myInventory.GetStuffQt(Stuff.Type.Spear)> 0 && !isHereSpear)
        {
            GameObject mySpear = Instantiate(spear) as GameObject;
            
            mySpear.transform.position = childs[/*max.myInventory.spear.index*/ max.myInventory.GetStuffId(Stuff.Type.Spear)].transform.position;
            mySpear.transform.SetParent(childs[/*max.myInventory.spear.index*/ max.myInventory.GetStuffId(Stuff.Type.Spear)].transform);
            mySpear.GetComponent<spearItem>().max = max;
            isHereSpear = true;
        }
        if (/*max.myInventory.bow.number*/ max.myInventory.GetStuffQt(Stuff.Type.Bow) > 0 && !isHereBow)
        {
            GameObject myBow = Instantiate(bow) as GameObject;
            myBow.transform.position = childs[max.myInventory.GetStuffId(Stuff.Type.Bow) /*max.myInventory.bow.index*/].transform.position;
            myBow.transform.SetParent(childs[/*max.myInventory.bow.index*/ max.myInventory.GetStuffId(Stuff.Type.Bow)].transform);
            myBow.GetComponent<bowItem>().max = max;
            isHereBow = true;
        }
        if (/*max.myInventory.torch.number*/ max.myInventory.GetStuffQt(Stuff.Type.Torch) > 0 && !isHereTorch)
        {
            GameObject myTorch = Instantiate(torch) as GameObject;
            myTorch.transform.position = childs[max.myInventory.GetStuffId(Stuff.Type.Torch) /*max.myInventory.torch.index*/].transform.position;
            myTorch.transform.SetParent(childs[/*max.myInventory.torch.index*/ max.myInventory.GetStuffId(Stuff.Type.Torch)].transform);
            myTorch.GetComponent<torchItem>().max = max;
            isHereTorch = true;
        }
    }
}
