using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KerberosWebAPI.Models
{
    public class PostData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTrue { get; set; }
        public DateTime CreatedOn { get; set; }

        public override string ToString()
        {
            return $"PostData with [Id: {this.Id.ToString()}] - [Name: {this.Name}] - [ITrue: {this.IsTrue.ToString()}] - [CreatedOn: {this.CreatedOn.ToString("dd/MM/yyy")}]";
        }
    }
}