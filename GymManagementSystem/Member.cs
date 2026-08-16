using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystem
{
    internal class Member
    {
        public int ID;
        public string? Name;
        public int Age;
        public Gender gender;
        public MembershipType membershipType;
       public int MembershipPrice { 
            get {
                if (membershipType == MembershipType.Standard)
                    return 500;
                else if (membershipType == MembershipType.Premium)
                    return  700;

                return 0;
            } 
        }
    }
}
