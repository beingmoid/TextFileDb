using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    class Retailer
    {

        public string Name { get; set; }
        public string ID { get; set; }
      

        public Retailer(TextBox id, TextBox name)
        {
            this.ID = id.Text;
            this.Name = name.Text;
            

        }

    }
}
