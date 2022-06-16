using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Wine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public Wine(int id, string name, int brandId)
        {
            this.Id = id;
            this.Name = name;
            this.BrandId = brandId;
        }
        public Wine(string name, int brandId)
        {
            this.Name = name;
            this.BrandId = brandId;
        }
    }
}
