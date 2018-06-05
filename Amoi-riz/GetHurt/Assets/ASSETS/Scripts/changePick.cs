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

        if (Input.GetKey(spearKeyCode) && max.myInventory.spear.number > 0)
        {
            Axe.SetActive(false);
            Trick.SetActive(false);
            Spear.SetActive(true);
            Torch.SetActive(false);
            axeImage.enabled = false;
            pickImage.enabled = false;
        }
        if (Input.GetKey(torchKeyCode) && max.myInventory.torch.number > 0)
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
        if (max.myInventory.spear.index == 0)
            spearKeyCode = KeyCode.Alpha3;
        if (max.myInventory.spear.index == 1)
            spearKeyCode = KeyCode.Alpha4;
        if (max.myInventory.spear.index == 2)
            spearKeyCode = KeyCode.Alpha5;
        if (max.myInventory.spear.index == 3)
            spearKeyCode = KeyCode.Alpha6;
        if (max.myInventory.spear.index == 4)
            spearKeyCode = KeyCode.Alpha7;
        if (max.myInventory.bow.index == 0)
            bowKeyCode = KeyCode.Alpha3;
        if (max.myInventory.bow.index == 1)
            bowKeyCode = KeyCode.Alpha4;
        if (max.myInventory.bow.index == 2)
            bowKeyCode = KeyCode.Alpha5;
        if (max.myInventory.bow.index == 3)
            bowKeyCode = KeyCode.Alpha6;
        if (max.myInventory.bow.index == 4)
            bowKeyCode = KeyCode.Alpha7;
        if (max.myInventory.torch.index == 0)
            torchKeyCode = KeyCode.Alpha3;
        if (max.myInventory.torch.index == 1)
            torchKeyCode = KeyCode.Alpha4;
        if (max.myInventory.torch.index == 2)
            torchKeyCode = KeyCode.Alpha5;
        if (max.myInventory.torch.index == 3)
            torchKeyCode = KeyCode.Alpha6;
        if (max.myInventory.torch.index == 4)
            torchKeyCode = KeyCode.Alpha7;
    }
}
