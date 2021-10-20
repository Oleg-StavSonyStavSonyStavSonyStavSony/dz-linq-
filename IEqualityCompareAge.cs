using System.Collections.Generic;
namespace dz_linq_
{
    class UserEqualityComparer_Age : IEqualityComparer<User>
    {
        public bool Equals(User b1, User b2)
        {
            if(b1.Age != b2.Age)
                return false;
            
            return true;
        }

        public int GetHashCode(User bx)
        {
            int hCode = bx.Login.Length + bx.Pasword.Length;
            return hCode.GetHashCode();
        }
    }


}