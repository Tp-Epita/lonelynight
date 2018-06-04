using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCLASS : MonoBehaviour {
    public LootElements.Tree thisTree;
    public AxeCtrl Axe;

    MeshRenderer meshRenderer;
    MeshCollider meshCollider;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshCollider = GetComponent<MeshCollider>();
        thisTree = new LootElements.Tree(meshRenderer,meshCollider);
    }

    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "AXE" && thisTree.isPossible && Axe.isplayingAnimation("punch"))
        {
            thisTree.isPossible = false;
            thisTree.dammages(25);
            Axe.addWoods(8);
            StartCoroutine(WAIT());
        }
    }

    public void setLife(int life)
    {
        thisTree.life = life;
    }
    IEnumerator WAIT()
    {
        yield return new WaitForSeconds(1);
        thisTree.isPossible = true;
    }
}
