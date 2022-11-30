using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace simple_calculate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void add_Click(object sender, EventArgs e)
        {
            int x, y,sum;
            x = Convert.ToInt32(txtx.Text);
            y = Convert.ToInt32(txty.Text);

            sum = x + y;
            txtresult.Text = sum.ToString();
        }
        protected void sub_Click(object sender, EventArgs e)
        {
            int x, y, sum;
            x = Convert.ToInt32(txtx.Text);
            y = Convert.ToInt32(txty.Text);

            sum = x - y;
            txtresult.Text = sum.ToString();
        }
        protected void mul_Click(object sender, EventArgs e)
        {

            int x, y, sum;
            x = Convert.ToInt32(txtx.Text);
            y = Convert.ToInt32(txty.Text);

            sum = x * y;
            txtresult.Text = sum.ToString();
        }
        protected void div_Click(object sender, EventArgs e)
        {
            int x, y, sum;
            x = Convert.ToInt32(txtx.Text);
            y = Convert.ToInt32(txty.Text);

            sum = x / y;
            txtresult.Text = sum.ToString();
        }
        protected void mudol_Click(object sender, EventArgs e)
        {
            int x, y, sum;
            x = Convert.ToInt32(txtx.Text);
            y = Convert.ToInt32(txty.Text);

            sum = x % y;
            txtresult.Text = sum.ToString();
        }
        //protected void exit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
        protected void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtx_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txty_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}