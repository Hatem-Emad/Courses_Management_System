using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDay02_DAL.Validators
{
    public class Agefrom27to60 : ValidationAttribute
    {
        public override bool IsValid(object? value)
            => value is int age && age > 27 && age < 60;
        
    }
}
