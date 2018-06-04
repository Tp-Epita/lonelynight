using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootElements : MonoBehaviour {

    public class Tree
    {
        public bool isPossible;
        public int life = 100;
        MeshRenderer meshR;
        MeshCollider meshC;
        public Tree(MeshRenderer meshR,MeshCollider meshC)
        {
            isPossible = true;
            this.meshR = meshR;
            this.meshC = meshC;
        }

        public void dammages(int deg)
        {
            life -= deg;
            if (life <= 0)
            {
                disable();
            }
        }

        public void disable()
        {
            meshR.enabled = false;
            meshC.enabled = false;
        }

       public void enable()
        {
            meshR.enabled = true;
            meshC.enabled = true;
        }
    }

    public class Rock
    {
        public bool isPossible;
        int life = 150;
        MeshRenderer meshR;
        MeshCollider meshC;
        public Rock(MeshRenderer meshR, MeshCollider meshC)
        {
            isPossible = true;
            this.meshR = meshR;
            this.meshC = meshC;
        }

        public void dammages(int deg)
        {
            life -= deg;
            if (life <= 0)
            {
                meshR.enabled = false;
                meshC.enabled = false;
            }
        }
    }
}
