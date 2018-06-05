using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PickCtrl : MonoBehaviour {
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

    public void addRocks(int rocks)
    {
        parentPlayer.addRocks(rocks);
    }
}
