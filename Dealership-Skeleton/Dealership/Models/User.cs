using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Bytes2you.Validation;
using System.Text.RegularExpressions;

namespace Dealership.Models
{
    public class User : IUser
    {
        private string username;
        private string firstname;
        private string lastname;
        private string password;
        private Role role;
        private IList<IVehicle> vehicles;
        Regex r = new Regex("^[a-zA-Z ]+$");
        Regex p = new Regex("^[A-Za-z0-9@*_-]+$");
        public User(string username,string firstname,string lastname,string password,string role)
        {
            Guard.WhenArgument(username.Length, "Username must be between 2 and 20 characters long!").IsGreaterThan(20).IsLessThan(2).Throw();
            Guard.WhenArgument(password.Length, "Password").IsGreaterThan(30).IsLessThan(5).Throw();
            Guard.WhenArgument(firstname.Length, "Firstname").IsGreaterThan(20).IsLessThan(2).Throw();
            Guard.WhenArgument(lastname.Length, "lastname").IsGreaterThan(20).IsLessThan(2).Throw();

            if (!p.IsMatch(password))
            {
                throw new ArgumentException("Password contains invalid Symbols");
            }
            if (!r.IsMatch(username))
            {
                throw new ArgumentException("Username contains Invalid Symbols");
            }
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.role = (Role)Enum.Parse(typeof(Role),role);
            this.vehicles = new List<IVehicle>();
        }
        public string Username { get {return this.username; } }

        public string FirstName { get { return this.firstname; } }

        public string LastName { get { return this.lastname; } }

        public string Password { get { return this.password; } }

        public Role Role { get { return this.role; } private set { this.role = value; } }

        public IList<IVehicle> Vehicles { get {return this.vehicles; } private set { this.vehicles = value; } }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {

            if (commentToAdd==null)
            {
                throw new NullReferenceException("The comment cant be null");
            }

            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.Role==Role.Normal&&Vehicles.Count>=5)
            {
                throw new ArgumentException("You are not VIP and cannot add more than 5 vehicles!");
            }
            if (this.Role==Role.Admin)
            {
                throw new ArgumentException("You are Admin u can't add vehicles");

            }
            Guard.WhenArgument(vehicle, "vehicle").IsNull().Throw();
            this.Vehicles.Add(vehicle);
        }
        public override string ToString()
        {
            return $"Username:{this.Username} ,FullName:{this.FirstName}{this.LastName},Role:{this.Role}";
        }
        public string PrintVehicles()
        {
            var SB = new StringBuilder();
            var counter = 1;
            SB.AppendLine($"--USER {this.Username}--");
            if (this.Vehicles.Count<=0)
            {
                SB.AppendLine("--NO VEHICLES--");
            }
            else 
            {
                foreach (var item in this.Vehicles)
                {
                    SB.AppendLine($"({counter}). {item.ToString()}");
                    counter++;
                }
            }
            return SB.ToString().Trim();

        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (commentToRemove==null)
            {
                throw new ArgumentNullException("Comments cannot be null!");
            }
            if (vehicleToRemoveComment == null)
            {
                throw new ArgumentNullException("Vehicle cannot be null!");
            }
            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            Guard.WhenArgument(vehicle, "Vehicle is null").IsNull().Throw();
            this.Vehicles.Remove(vehicle);
        }
    }
}
