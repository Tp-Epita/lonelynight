using System;

namespace ASSETS.Scripts
{
    [Serializable]
    public class Ressource
    {
        public enum Type
        {
            Wood,
            Rock
        }

        public Type _type;
        public int _quantity;
        public Ressource(Type _type)
        {
            _quantity = 0;
            this._type = _type;
        }
    }
}