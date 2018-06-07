using System;
using System.Collections;
using System.Collections.Generic;
using ASSETS.Scripts;
using NUnit.Framework;
using UnityEngine;


[Serializable]
public class Inventory
{
    public List<Ressource> _ressources;
    public List<Stuff> _stuffs;
    
    public Inventory()
    {
        _ressources = new List<Ressource>();
        _ressources.Add(new Ressource(Ressource.Type.Rock));
        _ressources.Add(new Ressource(Ressource.Type.Wood));
        _stuffs = new List<Stuff>();
        _stuffs.Add(new Stuff(Stuff.Type.Torch,0));
        _stuffs.Add(new Stuff(Stuff.Type.Spear,1));
        _stuffs.Add(new Stuff(Stuff.Type.Map,2));
        _stuffs.Add(new Stuff(Stuff.Type.Bow,3));
        _stuffs.Add(new Stuff(Stuff.Type.Arrow,4));
    }

    public void AddRessources(Ressource.Type _type, int _quantity)
    {
        foreach (var VARIABLE in _ressources)
        {
            if (VARIABLE._type == _type)
            {
                VARIABLE._quantity += _quantity;
            }
        }
    }

    
    
    public int GetGoodQt(Ressource.Type _type)
    {
        foreach (var VARIABLE in _ressources)
        {
            if (_type == VARIABLE._type)
            {
                return VARIABLE._quantity;
            }
        }

        return 0;
    }
    
    public void AddStuff(Stuff.Type _type, int _quant)
    {
        foreach (var VARIABLE in _stuffs)
        {
            if (VARIABLE._Type == _type)
            {
                VARIABLE._quantity += _quant;
            }
        }
    }

    public int GetStuffQt(Stuff.Type _type)
    {
        foreach (var VARIABLE in _stuffs)
        {
            if (VARIABLE._Type == _type)
            {
                return VARIABLE._quantity;
            }
        }

        return 0;
    }
    
    public int GetStuffId(Stuff.Type _type)
    {
        foreach (var VARIABLE in _stuffs)
        {
            if (VARIABLE._Type == _type)
            {
                return VARIABLE._index;
            }
        }

        return 0;
    }
}
