using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace дээм.Models
{
    public partial class Product
    {
        [NotMapped]
        public string CountUnit
        {
            get
            {
                return $"{Count} {Unit ?? "шт."}";
            }
        }
    }
}