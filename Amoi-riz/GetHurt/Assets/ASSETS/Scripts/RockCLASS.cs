using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCLASS : MonoBehaviour {
    public LootElements.Rock thisRock;
    public PickCtrl Pick;

    MeshRenderer meshRenderer;
    MeshCollider meshCollider;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshCollider = GetComponent<MeshCollider>();
        thisRock = new LootElements.Rock(meshRenderer, meshCollider);
    }

    void Update()
    {

    }
    /*public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PICK" && thisRock.isPossible && Pick.isplayingAnimation("punch"))
        {
            thisRock.isPossible = false;
            thisRock.dammages(25);
            Pick.addRocks(8);
            StartCoroutine(WAIT());
        }
    }*/
    IEnumerator WAIT()
    {
        yield return new WaitForSeconds(1);
        thisRock.isPossible = true;
    }
}
