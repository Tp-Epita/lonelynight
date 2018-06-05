using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Inventory {

    /*public int woods;
    public int rocks;
    
    public Bow bow;
    public Spear spear;
    public Torch torch;*/

    private List<Cloth> _cloths;
    private List<Good> _goods;
    private List<Weapon> _weapons;

    #region GetterSetter

    public List<Cloth> Cloths
    {
        get { return _cloths; }
        set { _cloths = value; }
    }

    public List<Good> Goods
    {
        get { return _goods; }
        set { _goods = value; }
    }

    public List<Weapon> Weapons
    {
        get { return _weapons; }
        set { _weapons = value; }
    }

    #endregion

    #region Constructor

    public Inventory()
    {
        _cloths = new List<Cloth>();
        _goods = new List<Good>();
        _weapons = new List<Weapon>();
        Init();
        /*woods = 0;
        rocks = 0;
        bow = new Bow(0,1);
        spear = new Spear(0,3);
        torch = new Torch(0,2);*/
    }

    public void Init()
    {
        Weapon _spear = new Weapon(Weapon.TYPE.SPEAR,1);
        _spear.Index = 0;
        _weapons.Add(_spear);
        Weapon _torch = new Weapon(Weapon.TYPE.TORCH,1);
        _torch.Index = 1;
        _weapons.Add(_torch);
        Weapon _arc = new Weapon(Weapon.TYPE.ARC,1);
        _arc.Index = 2;
        _weapons.Add(_arc);
    }

    #endregion


    #region GetQuantity

    public int GetGoodQt(Good.TYPE _type)
    {
        foreach (Good _good in _goods)
        {
            if (_good.Type == _type)
                return _good.Quantity;
        }
        
        return 0;
    }

    public int GetWeaponQt(Weapon.TYPE _type)
    {
        foreach (Weapon VARIABLE in _weapons)
        {
            if (VARIABLE.Type == _type)
                return VARIABLE.Quantity;
        }

        return 0;
    }
    
    public int GetWeaponId(Weapon.TYPE _type)
    {
        foreach (Weapon VARIABLE in _weapons)
        {
            if (VARIABLE.Type == _type)
                return VARIABLE.Index;
        }

        return -1;
    }

    #endregion

    #region Adder

    public void AddCloth(Cloth.TYPE _type, int _quantity)
    {
        bool _isPresent = false;
        foreach (Cloth clth in _cloths)
        {
            if (clth.Type == _type)
            {
                _isPresent = true;
                clth.Add(_quantity);
                break;
            }            
        }

        if (!_isPresent)
            _cloths.Add(new Cloth(_type,_quantity));
    }

    public void AddGood(Good.TYPE _type, int _quantity)
    {
        bool isPresent = false;
        foreach (Good gd in _goods)
        {
            if (gd.Type == _type)
            {
                isPresent = true;
                gd.Add(_quantity);
                break;
            }
        }
        if(!isPresent)
            _goods.Add(new Good(_type,_quantity));
    }

    public void AddWeapon(Weapon.TYPE _type, int _quantity)
    {
        bool _isPresent = false;
        foreach (Weapon wp in _weapons)
        {
            if (wp.Type == _type)
            {
                _isPresent = true;
                wp.Add(_quantity);
                break;
            }
        }
        Debug.Log(_isPresent);
        if (!_isPresent)
            _weapons.Add(new Weapon(_type,_quantity));
    }

    #endregion
    
    
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


public class Weapon
{
    public enum TYPE
    {
        ARC,
        TORCH,
        SPEAR
    }

    private TYPE _type;
    private int _quantity;
    private int _index;

    #region Getter

    public int Index
    {
        get { return _index; }
        set { _index = value; }
    }
    
    public TYPE Type
    {
        get { return _type; }
    }

    public int Quantity
    {
        get { return _quantity; }
    }

    #endregion

    #region  Constructor

    public Weapon(TYPE _type,int _quantity)
    {
        this._type = _type;
        this._quantity = _quantity;
    }

    #endregion

    public void Add(int _quantity)
    {
        this._quantity += _quantity;
    }
}
public class Good
{
    public enum TYPE
    {
        WOOD,
        ROCK
    }

    private TYPE _type;
    private int _quantity;

    #region Getter

    public TYPE Type
    {
        get { return _type; }
    }

    public int Quantity
    {
        get { return _quantity; }
    }

    #endregion
    
    #region Constructor

    public Good(TYPE _type,int _quantity)
    {
        this._type = _type;
        this._quantity = _quantity;
    }

    #endregion

    public void Add(int _quantity)
    {
        this._quantity += _quantity;
    }
    
}
public class Cloth
{
    public enum TYPE
    {
        JACKECT,
        SHOES
    }

    private TYPE _type;

    public TYPE Type
    {
        get { return _type; }
    }
    private int _quantity;

    public int Quantity
    {
        get { return _quantity; }
    }
    
    public Cloth(TYPE _type, int _quantity)
    {
        this._type = _type;
        this._quantity = _quantity;
    }

    public void Add(int _quantity)
    {
        this._quantity += _quantity;
    }
}