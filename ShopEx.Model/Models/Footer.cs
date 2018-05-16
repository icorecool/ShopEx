using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEx.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        public string ID { set; get; }
    }
}
