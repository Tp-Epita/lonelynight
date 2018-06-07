using System;

namespace ASSETS.Scripts
{
    [Serializable]
    public class Stuff
    {
        public enum Type
        {
            Spear,
            Torch,
            Map,
            Bow,
            Arrow
        }


        public int _index;
        public int _quantity;
        public Type _Type;

        public Stuff(Type _type,int _index)
        {
            this._Type = _type;
            _quantity = 0;
            this._index = _index;
        }
    }
}