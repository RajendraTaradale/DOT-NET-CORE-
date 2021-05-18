using System;
using System.Collections.Generic;
using System.Text;

namespace RT.Coding.Interviews
{
   public class RTEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                RTEmployee p = (RTEmployee)obj;
                return (Id == p.Id) && (Name == p.Name) && (Address == p.Address);
            }
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
