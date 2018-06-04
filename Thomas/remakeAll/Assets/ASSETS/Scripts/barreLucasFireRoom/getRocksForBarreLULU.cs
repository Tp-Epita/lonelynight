using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getRocksForBarreLULU : MonoBehaviour {
    public GameObject text;
    public GameObject getInv;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<Text>().text = "" + getInv.GetComponent<get_inventory>().myInventory./*rocks*/GetGoodQt(Good.TYPE.ROCK);
    }
}
