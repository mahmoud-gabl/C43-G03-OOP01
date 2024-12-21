using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimo_6
{
    #region Ex
    //internal struct point
    //{
    //    public int x;
    //    public int y;
    //    public point()
    //    {
    //        x = 0;
    //        y = 0;
    //    }
    //    public point(int _x, int _y)
    //    {
    //        x = _x;
    //        y = _y;
    //    }
    //    public override string ToString()
    //    {
    //        return $"x={x}:y={y}";
    //    }
    //}
    #endregion
    #region valuables
    internal class point
    {
        #region valuables
        public int id;
        public string name;
        private decimal price;
        #endregion
        #region constracte
        public point(int _id, string _name, decimal _price)
        { 
            id = _id;
            name = _name;   
            price= _price;
        }
        #endregion
        #region method
        public override string ToString()
        {
            return $"id:{id} name:{name} price:{price}";
        }
        #endregion
        #region Ecabsoulation
        //getter
        public string Getname()
        {
            return name ;
        }
        //setter
        public void setname(string value)
        {
            name = value.Length<5?value:value.Substring(0,5) ;
        }

        public decimal Price
        {
            get 
            { 
             return price ;
            }
            set
            { 
             price = value;
            }
        }

        #endregion



    }

    #endregion

}
