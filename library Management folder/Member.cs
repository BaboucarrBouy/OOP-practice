using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrayMangingSystem
{
    internal class Member
    {
        public string Name { get; set; }
        public int MemberID { get; set; }

        public int PhoneNumber { get; set; }

        public int BorrowCount {  get; set; }
        public Member(string name, int memberID, int phonenumber) 
        {
            this.Name = name;
            this.MemberID = memberID;
            this.PhoneNumber = phonenumber;
            BorrowCount = 3;
        }

        


    }
}
