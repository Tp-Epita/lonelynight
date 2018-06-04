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
            myInventory.Cloths = JsonUtility.FromJson<List<Cloth>>(PlayerPrefs.GetString("inventory_DATA_cloths"));
            myInventory.Goods = JsonUtility.FromJson<List<Good>>(PlayerPrefs.GetString("inventory_DATA_goods"));
            myInventory.Weapons = JsonUtility.FromJson<List<Weapon>>(PlayerPrefs.GetString("inventory_DATA_weapons"));
        }

        else
            myInventory = new Inventory();

        PlayerPrefs.SetString("inventory_DATA", JsonUtility.ToJson(myInventory));
        PlayerPrefs.SetString("inventory_DATA_cloths", JsonUtility.ToJson(myInventory.Cloths));
        PlayerPrefs.SetString("inventory_DATA_goods", JsonUtility.ToJson(myInventory.Goods));
        PlayerPrefs.SetString("inventory_DATA_weapons", JsonUtility.ToJson(myInventory.Weapons));
    }

    public void saveInventory(Inventory inventory)
    {
        PlayerPrefs.SetString("inventory_DATA", JsonUtility.ToJson(myInventory));
        PlayerPrefs.SetString("inventory_DATA_cloths", JsonUtility.ToJson(myInventory.Cloths));
        PlayerPrefs.SetString("inventory_DATA_goods", JsonUtility.ToJson(myInventory.Goods));
        PlayerPrefs.SetString("inventory_DATA_weapons", JsonUtility.ToJson(myInventory.Weapons));
    }

    public Inventory getMyInventory()
    {
        return myInventory;
    }
}
