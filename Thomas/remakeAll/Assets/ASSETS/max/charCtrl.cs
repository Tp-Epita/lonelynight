using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ASSETS.Scripts;
using UnityEngine;

public class charCtrl : MonoBehaviour {
    public Inventory myInventory;
    public AudioSource audioSource;

    Animation animate;
    new Rigidbody rigidbody;
    private Vector3 JumpSpeed;
    private float walkSpeed = 8;
    private float runSpeed = 20;
    private float turnLspeed = -100;
    private float turnRspeed = 100;
    public bool onCollision = true;

    public float life = 100;
    
    void Start()
    {
        myInventory = new Inventory();
        audioSource = GetComponent<AudioSource>();

        LoadInventory();
        
        
        /*myInventory.AddWeapon(Weapon.TYPE.SPEAR,0);*/
        animate = GetComponent<Animation>();
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.detectCollisions = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F5) && life> 0)
        {            
            life -= 1;
        }
        if (Input.GetKey(KeyCode.F8))
        {
            myInventory = new Inventory();
        }
        if (Input.GetKey(KeyCode.F9))
        {
            myInventory.AddStuff(Stuff.Type.Spear,1);
        }
        if (Input.GetKey(KeyCode.N))
        {
            myInventory.AddStuff(Stuff.Type.Map,1);
        }
        if (Input.GetKey(KeyCode.F11))
        {
            myInventory.AddStuff(Stuff.Type.Torch,1);
        }
        if (Input.GetKey(KeyCode.F12))
        {
            myInventory.AddRessources(Ressource.Type.Wood,5);
            myInventory.AddRessources(Ressource.Type.Rock,5);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            animate.Play("punch");
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, turnLspeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, turnRspeed * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onCollision)
            {
                animate.Play("jump");
                Vector3 v = gameObject.GetComponent<Rigidbody>().velocity;
                v.y = JumpSpeed.y;
                gameObject.GetComponent<Rigidbody>().velocity = JumpSpeed;
            }
        }

        if (Input.GetKey(KeyCode.Z) && !Input.GetKey(KeyCode.LeftShift))
        {
            if (!animate.IsPlaying("jump") && onCollision)
            {
                animate.Play("walk");
            }
                
            JumpSpeed = new Vector3(0, 30, 0);
            transform.Translate(0, 0, walkSpeed * Time.deltaTime);
        }

        else
        {
            if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.LeftShift))
            {
                JumpSpeed = new Vector3(0, 35, 0);
                if (!animate.IsPlaying("jump") && onCollision)
                    animate.Play("run");
                transform.Translate(0, 0, runSpeed * Time.deltaTime);
            }
            else
            {
                JumpSpeed = new Vector3(0, 20, 0);
                if (!animate.IsPlaying("jump") && onCollision && !animate.IsPlaying("punch"))
                    animate.Play("idle");
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        onCollision = true;
    }


    public void OnCollisionExit(Collision collision)
    {
        onCollision = false;
    }

    public void addWood(int woods)
    {
        myInventory.AddRessources(Ressource.Type.Wood,woods);
    }

    public void addRocks(int rocks)
    {
        myInventory.AddRessources(Ressource.Type.Rock,rocks);
    }

    public bool isplayingAnimation(string animation)
    {
        return animate.IsPlaying(animation);
    }

    public float timeAnimation(string animation)
    {
        return animate[animation].time;
    }

    public void SaveInventory()
    {
        BinaryFormatter _form = new BinaryFormatter();
        FileStream str = File.Create(Application.persistentDataPath + "/" + "ntmgrossepute");
        _form.Serialize(str, myInventory);
        str.Close();
    }

    public void LoadInventory()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream str = File.Open(Application.persistentDataPath + "/" + "ntmgrossepute",FileMode.Open);
        Inventory inv = (Inventory) formatter.Deserialize(str);
        str.Close();
        myInventory = inv;
    }
}
