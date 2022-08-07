//Corrected by <Patrick Quagge>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_10
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }
        //creating copy constructor to hold copied values
        public Set(Set other)
        {
           this.elements = new List<int>();
            for (int i = 0; i < other.elements.Count; i++)
            {
                elements.Add(other.elements[i]);
            };
        }

        public bool addElement(int val)
         {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }
        private bool containsElement(int val)
        {
            for(int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                else
                    return false;
            }
            return false;
        }
        public override string ToString()
        {
            string str = "";
            foreach(int i in elements)
            {
                str += i + "";
            }
            return str;
        }
        public void clearSet()
        {
            elements.Clear();
        }
        public Set union(Set rhs)
        {
            //the way this method was constructed it was holding the data for A and returning that instead of the new unionized set
            //by using a copy of the original object instead of the object itself we avoid making changes to it over the course of the method
            
            //create a new set to return
            Set finalSet = new Set(this);
            
            for(int i = 0; i < rhs.elements.Count; i++)
            {
                finalSet.addElement(rhs.elements[i]);
            }
            //returning new set that is union only
            //return rhs;
            return finalSet;
        }

        
    }
}
