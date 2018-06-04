using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_inventory : MonoBehaviour
{

    // Use this for initialization
    public Inventory myInventory;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("inventory_DATA"))
        {
            myInventory = JsonUtility.FromJson<Inventory>(PlayerPrefs.GetString("inventory_DATA"));
            myInventory.bow = JsonUtility.FromJson<Bow>(PlayerPrefs.GetString("inventory_DATA_bow"));
            myInventory.spear = JsonUtility.FromJson<Spear>(PlayerPrefs.GetString("inventory_DATA_spear"));
            myInventory.torch = JsonUtility.FromJson<Torch>(PlayerPrefs.GetString("inventory_DATA_torch"));
        }

        else
            myInventory = new Inventory();

        PlayerPrefs.SetString("inventory_DATA", JsonUtility.ToJson(myInventory));
        PlayerPrefs.SetString("inventory_DATA_spear", JsonUtility.ToJson(myInventory.spear));
        PlayerPrefs.SetString("inventory_DATA_torch", JsonUtility.ToJson(myInventory.torch));
        PlayerPrefs.SetString("inventory_DATA_bow", JsonUtility.ToJson(myInventory.bow));
    }

    public void saveInventory(Inventory inventory)
    {
        PlayerPrefs.SetString("inventory_DATA", JsonUtility.ToJson(myInventory));
        PlayerPrefs.SetString("inventory_DATA_spear", JsonUtility.ToJson(myInventory.spear));
        PlayerPrefs.SetString("inventory_DATA_torch", JsonUtility.ToJson(myInventory.torch));
        PlayerPrefs.SetString("inventory_DATA_bow", JsonUtility.ToJson(myInventory.bow));
    }

    public Inventory getMyInventory()
    {
        return myInventory;
    }
}
