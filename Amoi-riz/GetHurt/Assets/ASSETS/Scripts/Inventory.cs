using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {

    public int woods;
    public int rocks;
    public Bow bow;
    public Spear spear;
    public Torch torch;
    public Inventory()
    {
        woods = 0;
        rocks = 0;
        bow = new Bow(0,1);
        spear = new Spear(0,3);
        torch = new Torch(0,2);
    }
}
public class Bow
{
    public int number;
    public int index;
    public Bow(int number, int index)
    {
        this.number = number;
        this.index = index;
    }
}
public class Spear
{
    public int number;
    public int index;
    public Spear(int number, int index)
    {
        this.number = number;
        this.index = index;
    }
}
public class Torch
{
    public int number;
    public int index;
    public Torch(int number, int index)
    {
        this.number = number;
        this.index = index;
    }
}