using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class script2_Boar : MonoBehaviour {

    Animation animate;
    public Transform cible;//glisser l'objet player
    private Transform maTransform;
    private NavMeshAgent agent;
    public bool poursuite;
    public float pdv = 10f;
    public bool pause;
    public bool attaque;

    MeshCollider meshCollider;


    void Awake()
    {
        maTransform = transform;
        meshCollider = GetComponent<MeshCollider>();
    }

    // Use this for initialization
    void Start () {

        //Initialisation du script NavMeshAgen qui se trouve sur le même objet que ce script
        agent = GetComponent<NavMeshAgent>();

        animate = GetComponent<Animation>();

        pause = false;
        

    }
	
	// Update is called once per frame
	void Update () {

        if (poursuite)
        {
            animate.Play("run");
            mouvement();
        }

        if (poursuite == false && pause == true)
        {
            miseEnAttente();
        }

    }

    private void mouvement()
    {
        //Si la variable "vieActuelle" est supérieur a 0
        if (pdv > 0)
        {
            Debug.DrawLine(cible.transform.position, maTransform.position, Color.blue);
            Vector3 direction = cible.position - this.transform.position;
            //direction *= -1;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            if (direction.magnitude > 1)
            {
                //if (meshCollider.smoothSphereCollisions)
                //{
                //
                //}
                this.transform.Translate(0, 0, 0.3f);
            }
        }
        else
        {
            animate.Play("death");
            // Add Fourures
            // Add Viande
        }
    }

    //L'ennemi reste a sa position actuelle
    private void miseEnAttente()
    {
        print("NE BOUGE PLUS !!");
        agent.destination = transform.position;
    }


}
