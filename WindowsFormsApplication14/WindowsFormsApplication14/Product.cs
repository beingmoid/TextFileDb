using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    class Product
    {
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public string prod_qty { get; set; }
        public string prod_price { get; set; }
        public string prod_amt { get; set; }
        public string datetime { get; set; }
        
        public void Calculate(TextBox p_name, TextBox price ,TextBox quantity,TextBox amt, DateTimePicker dt)
        {
            try
            {
                this.prod_name = p_name.Text;
                this.prod_qty = quantity.Text;
                this.prod_price=price.Text;
                this.prod_qty = quantity.Text;
                int qty = int.Parse(prod_qty);
                int amount = qty * int.Parse(price.Text);
                amt.Text = amount.ToString();
                prod_amt = amt.Text;
               
                    string date = dt.Value.ToString();
                    datetime = date;
            
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
           
            

        
        }
    }
}
