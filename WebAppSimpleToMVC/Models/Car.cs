using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSimpleToMVC.Models
{
    public class Car
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string ModelName { get; set; }

        public string Color { get; set; }

        public Car(){}  //Zero constructor req. to use our Create view

        public Car(int id, string brand, string name, string color)
        {
            Id = id;
            Brand = brand;
            ModelName = name;
            Color = color;
        }
    }
}
