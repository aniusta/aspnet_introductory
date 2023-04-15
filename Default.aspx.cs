using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public bool IsDigit(string first, string second)
    {
        bool digitsOnly = first.All(char.IsDigit) && second.All(char.IsDigit);

        return digitsOnly;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        bool x = IsDigit(TextBox1.Text, TextBox2.Text);
        if (x == true)
        {
            int firstnum = Convert.ToInt32(TextBox1.Text);  
            int secondnum = Convert.ToInt32(TextBox2.Text);
            int sum = firstnum + secondnum;
            TextBox3.Text = sum.ToString();
        }
        else
        {
            TextBox3.Text = "Input must be int";
        }

    }

    protected void btnSubtract_Click(object sender, EventArgs e)
    {
        bool x = IsDigit(TextBox1.Text, TextBox2.Text);
        if (x == true)
        {
            int firstnum = Convert.ToInt32(TextBox1.Text);
            int secondnum = Convert.ToInt32(TextBox2.Text);
            int sum = firstnum - secondnum;
            TextBox3.Text = sum.ToString();
        }
        else
        {
            TextBox3.Text = "Input must be int";
        }

    }

    protected void btnDivide_Click(object sender, EventArgs e)
    {
        bool x = IsDigit(TextBox1.Text, TextBox2.Text);
        if (x == true)
        {
            int firstnum = Convert.ToInt32(TextBox1.Text);
            int secondnum = Convert.ToInt32(TextBox2.Text);
            int sum = firstnum / secondnum;
            TextBox3.Text = sum.ToString();
        }
        else
        {
            TextBox3.Text = "Input must be int";
        }

    }

    protected void btnMultiply_Click(object sender, EventArgs e)
    {
        bool x = IsDigit(TextBox1.Text, TextBox2.Text);
        if (x == true)
        {
            int firstnum = Convert.ToInt32(TextBox1.Text);
            int secondnum = Convert.ToInt32(TextBox2.Text);
            int sum = firstnum * secondnum;
            TextBox3.Text = sum.ToString();
        }
        else
        {
            TextBox3.Text = "Input must be int";
        }

    }
}