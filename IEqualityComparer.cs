using System.Collections.Generic;
namespace dz_linq_
{
    class UserEqualityComparer_All : IEqualityComparer<User>
    {
        public bool Equals(User b1, User b2)
        {
            if(b1.Pasword != b2.Pasword)
                return false;
            if(b1.Login != b2.Login)
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