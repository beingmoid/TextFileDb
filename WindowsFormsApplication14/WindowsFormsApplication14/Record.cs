using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    class Record
    {
        StreamWriter sw = new StreamWriter("crecord.txt", true);
        public string r_id { get; set; }
        public string r_name { get; set; }
        public string p_name { get; set; }
        public string p_price { get; set; }
        public string p_qty { get; set; }
        public string p_amount { get; set; }
        public string date { get; set; }
        string[] arr;
        public Record(Product pd,Retailer r)
        {
            this.r_id = r.ID;
            this.r_name = r.Name;
            this.p_name = pd.prod_name;
            this.p_price = pd.prod_price;
            this.p_qty = pd.prod_qty;
            this.p_amount = pd.prod_amt;
            this.date = pd.datetime;
            arr = new string[7] { r_id, r_name, p_name, p_price, p_qty, p_amount, date };
            sw.Close();
            }
        public void Save()
        {
            StreamWriter sw = new StreamWriter("crecord.txt", true);
            
            for (int i = 0; i < arr.Length; i++)
            {
                sw.Write(arr[i]+",");
            }
            sw.WriteLine();
            sw.Close();
        }
        public void Show(DataGridView dgb)
        {
                       string[] a = File.ReadAllLines("crecord.txt");
            
            dgb.Rows.Add(a.Length);
            for (int i = 0; i < a.Length; i++)
            {
                string[] array = a[i].Split(',');
                for (int k = 0; k < 7; k++)
                {
                    dgb[k, i].Value = array[k].ToString();
                }
            }
        }

    }
}
