using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class User
    {
        public User()
        {
            Deliveries = new HashSet<Delivery>();
            Messages = new HashSet<Message>();
            Payments = new HashSet<Payment>();
            Reviews = new HashSet<Reviews>();
            Testimonials = new HashSet<Testimonial>();
            UserOrders = new HashSet<UserOrder>();
        }

        public decimal Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Image_Path { get; set; }
        public decimal? Salary { get; set; }
        public decimal? DEDUCTION { get; set; }

        public decimal? Height { get; set; }
        public string SkinColor { get; set; }
        public decimal? Weight { get; set; }
        public decimal Gender { get; set; }
        public decimal? Age { get; set; }
        public DateTime DateReg { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal Rol_Id { get; set; }
        public string Lx { get; set; }
        public string Ly { get; set; }

        public virtual Frole Rol { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}
