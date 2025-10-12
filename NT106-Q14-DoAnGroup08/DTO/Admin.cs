using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DTOs
{
    class Admin : User
    {
        private string adminId;
        private DateTime createAd;

        public Admin()
        {
        }

        public Admin(string userId, string username, string password, 
                    string fullName, string phone, string email, 
                    string role, bool isActive, string adminId, DateTime createAd)
                    : base(userId, username, password, fullName, phone, email, role, isActive)
        {
            this.adminId = adminId;
            this.createAd = createAd;
        }

        public string AdminId { get => this.adminId; set => this.adminId = value; }

        public DateTime CreateAd { get => this.createAd; set => this.createAd = value; }
    }
}
