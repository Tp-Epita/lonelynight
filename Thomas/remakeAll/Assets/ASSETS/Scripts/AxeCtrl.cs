using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCtrl : MonoBehaviour {
    public charCtrl parentPlayer;
    public BoxCollider boxCollider;

    void Update()
    {
        boxCollider.enabled = !parentPlayer.isplayingAnimation("run");
    }
    public bool isplayingAnimation(string name)
    {
        return parentPlayer.isplayingAnimation(name);
    }

    public void addWoods(int woods)
    {
        parentPlayer.addWood(woods);
    }
}
