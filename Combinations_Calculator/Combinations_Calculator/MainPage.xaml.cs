using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Combinations_Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {

            //----------------
            double n = int.Parse(a_1.Text);
            double r = n;

            for (int i = 1; i < n; i++)
            {
                r = r * i;
            }
            //----------------

            double n2 = int.Parse(a_2.Text);
            double r2 = n2;

            for (int i = 1; i < n2; i++)
            {
                r2 = r2 * i;
            }
            //----------------
            double r_a = n - n2;
   
            double r3 = r_a;

            for (int i = 1; i < r_a; i++)
            {
                r3 = r3 * i;
            }
            //----------------
            double s =  r / (r2 * r3);
            double t1 = n;
            double t2 = n2;
            double t3 = n - n2;
            //----------------
            a_3.Text = "C(n,k) = ?";
            a_4.Text = "C(n,k) = C(" + t1 + ", " + t2 + ")";
            a_5.Text = " = "+ t1 + "!" + " / (" + t2 + "! ("+ t1+ " - " + t2 + ")!)" + "  =  " + t1 + "!" + " / (" + t2 + "! x " + t3 + "!)";
            a_6.Text = " =  " +  s.ToString() + "  combinations";

        }
    }
}
