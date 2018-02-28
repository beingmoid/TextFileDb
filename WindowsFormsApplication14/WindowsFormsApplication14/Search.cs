using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    class Search
    {
        public  string id { get; set; }
    public string name { get; set; }
    private string data;
       
        public void Find(TextBox id,TextBox retailerName, TextBox idd)
        {
            data = File.ReadAllText("c:\\users\\badar\\Documents\\Visual Studio 2013\\Projects\\WindowsFormsApplication14\\WindowsFormsApplication14\\recordd.txt");
            string[] arr = data.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==id.Text)
                {
                    this.id = id.Text;
                    this.name = arr[i + 1];
                    break;
                }
                Show(idd, retailerName);
                
            }
            
        }
        public void Show(TextBox id, TextBox name)
        {
            id.Text = this.id;
            name.Text = this.name;
        }
        
    }
}
