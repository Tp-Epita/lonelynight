using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changePick : MonoBehaviour {

    public charCtrl max;
    public GameObject Trick;
    public GameObject Axe;
    public GameObject Spear;
    public GameObject Torch;
    public Image axeImage;
    public Image pickImage;


    private KeyCode spearKeyCode;
    private KeyCode bowKeyCode;
    private KeyCode torchKeyCode;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        assignerKeyCode();
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Axe.SetActive(false);
            Trick.SetActive(true);
            Spear.SetActive(false);
            Torch.SetActive(false);
            axeImage.enabled = false;
            pickImage.enabled = true;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Axe.SetActive(true);
            Trick.SetActive(false);
            Spear.SetActive(false);
            Torch.SetActive(false);
            axeImage.enabled = true;
            pickImage.enabled = false;
        }

        if (Input.GetKey(spearKeyCode) && /*max.myInventory.spear.number */ max.myInventory.GetWeaponQt(Weapon.TYPE.SPEAR)> 0)
        {
            Axe.SetActive(false);
            Trick.SetActive(false);
            Spear.SetActive(true);
            Torch.SetActive(false);
            axeImage.enabled = false;
            pickImage.enabled = false;
        }
        if (Input.GetKey(torchKeyCode) && /*max.myInventory.torch.number*/ max.myInventory.GetWeaponQt(Weapon.TYPE.SPEAR) > 0)
        {
            Axe.SetActive(false);
            Trick.SetActive(false);
            Spear.SetActive(false);
            Torch.SetActive(true);
            axeImage.enabled = false;
            pickImage.enabled = false;
        }
    }

    public void assignerKeyCode()
    {
        int SpearID = max.myInventory.GetWeaponId(Weapon.TYPE.SPEAR);
        int BowID = max.myInventory.GetWeaponId(Weapon.TYPE.ARC);
        int TorchID = max.myInventory.GetWeaponId(Weapon.TYPE.SPEAR);
        
        
        if (SpearID == 0)
            spearKeyCode = KeyCode.Alpha3;
        if (SpearID == 1)
            spearKeyCode = KeyCode.Alpha4;
        if (SpearID == 2)
            spearKeyCode = KeyCode.Alpha5;
        if (SpearID == 3)
            spearKeyCode = KeyCode.Alpha6;
        if (SpearID== 4)
            spearKeyCode = KeyCode.Alpha7;
        if (BowID == 0)
            bowKeyCode = KeyCode.Alpha3;
        if (BowID == 1)
            bowKeyCode = KeyCode.Alpha4;
        if (BowID == 2)
            bowKeyCode = KeyCode.Alpha5;
        if (BowID == 3)
            bowKeyCode = KeyCode.Alpha6;
        if (BowID == 4)
            bowKeyCode = KeyCode.Alpha7;
        if (TorchID == 0)
            torchKeyCode = KeyCode.Alpha3;
        if (TorchID == 1)
            torchKeyCode = KeyCode.Alpha4;
        if (TorchID == 2)
            torchKeyCode = KeyCode.Alpha5;
        if (TorchID == 3)
            torchKeyCode = KeyCode.Alpha6;
        if (TorchID == 4)
            torchKeyCode = KeyCode.Alpha7;
    }
}
