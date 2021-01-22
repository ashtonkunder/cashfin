
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System;

using System.Windows.Forms;

using System.Media;
// Ashton kunder
namespace cash
{
    public partial class Form1 : Form
    {
        double burgerscost = 2.75;
        double noburgerscost = 2.25;
        double bigmac = 3.75;
        double chickenburger= 3.00;
        double Sfries = 2.00;
        double Mfries = 2.25;
        double Lfries = 2.75;
        double ELfries = 3.00;
        double icecreamcost = 3.00;
        double friescost = 2.00;
        double drinkscost = 1.00;
        double tax = 0.13;
        int bigMacs = 0;
        int crispyburger = 0;
        int cheeseburgernumber = 0;
        int burgernumber = 0;
        int smallfrie = 0;
        int mefrie = 0;
        int largefrie = 0;
        int exlarge = 0;
        int icecream = 0;
        int drinks = 0;
    
        //SoundPlayer player = new SoundPlayer(Properties.Resources.print);



        //double totalburgers = Convert.ToInt32(burgernumber.Text);
        // double totalfries = Convert.ToInt32(friesnumber.Text);
        // double totaldrinks = Convert.ToInt32(drinksnumber.Text);
        public Form1()
        {
            InitializeComponent();
        }

        private void Sfrie_Click(object sender, EventArgs e)
        {
            
            smallfrie++;
            friestotal.Text = $"{smallfrie}";
            outputlabel2.Text = "Sfries";
            double sfries = (smallfrie * Sfries);
            friesvalue.Text = $"{sfries}";
        }

        private void Mfrie_Click(object sender, EventArgs e)
        {
            mefrie++;
            double mfries = (mefrie * Mfries);
           
            friestotal.Text = $"{mefrie}";
            friesvalue.Text = $"{mfries}";
            outputlabel2.Text = "Mfries";
            
        }

        private void Lfrie_Click(object sender, EventArgs e)
        {
            largefrie++;
            double lfries = (largefrie * Lfries);
            
            friestotal.Text = $"{largefrie}";
            friesvalue.Text = $"{lfries}";
            outputlabel2.Text = "Lfries";
            
        }

        private void ELfrie_Click(object sender, EventArgs e)
        {
            exlarge++;
            double exfries = (exlarge * ELfries);
            
            friestotal.Text = $"{ exlarge}";
            friesvalue.Text = $"{exfries}";
            outputlabel2.Text = "ELfries";
            
        }

        private void cheeseburger_Click(object sender, EventArgs e)
        {
            cheeseburgernumber++;
            outputcheese.Text = $"{cheeseburgernumber}";
            double cheesesburger = (cheeseburgernumber * burgerscost);
            outputcost.Text = $"{cheesesburger}";
        }

        private void bigMac_Click(object sender, EventArgs e)
        {
            bigMacs++;
            double macbig = (bigMacs * bigmac);
            
           outputbigmac.Text = $"{bigMacs}";
            big.Text = $"{macbig}";
       }

        private void crispyChicken_Click(object sender, EventArgs e)
        {
            crispyburger++;
            double chicken = (crispyburger * chickenburger);
              
            crispyburgeroutput.Text = $"{crispyburger}";
            chickenbur.Text = $"{chicken}";
        }

        private void burger_Click(object sender, EventArgs e)
        {
            burgernumber++;
            double burg = (burgernumber * noburgerscost);
               
            nocheeseburgeroutput.Text = $"{ burgernumber}";
            nocheese.Text = $"{burg}";
        }

        private void cola_Click(object sender, EventArgs e)
        {
            drinks++;
            double pop = (drinks * drinkscost);
            drinkss.Text = $"{pop}";
            
            drinksoutput.Text = $"{drinks}";
            outputlabel.Text = "cola";
        }

        private void gingerAle_Click(object sender, EventArgs e)
        {
            drinks++;
            double pop = (drinks * drinkscost);
            drinkss.Text = $"{pop}";
            drinksoutput.Text = $"{drinks}";
            outputlabel.Text = "gingerAle";
        }

        private void icetea_Click(object sender, EventArgs e)
        {
            drinks++;
            double pop = (drinks * drinkscost);
            drinkss.Text = $"{pop}";
            drinksoutput.Text = $"{drinks}";

            outputlabel.Text = "icetea";
        }

        private void icecream_Click(object sender, EventArgs e)
        {
            icecream++;
            double ice = (icecream * icecreamcost);
            cream.Text = $"{ice}";
            icecreamoutput.Text = $"{ icecream}";
        }

        private void rec_Click(object sender, EventArgs e)
        {
            reco.Text = "i like to get a Big Mac and fries";
        }

        private void total_Click(object sender, EventArgs e)
        {
            double totalfood = (cheeseburgernumber * burgerscost) +(burgernumber * noburgerscost) +(bigMacs * bigmac) + (crispyburger * chickenburger) * (icecream* icecreamcost) + (smallfrie * Sfries) +  (mefrie * Mfries)+ (largefrie * Lfries) + ( exlarge * ELfries) + (drinks * drinkscost);
            double totaltax = tax * totalfood;
            double totalall = totaltax + totalfood;
            taxtotal.Text = $"{totaltax}";
            totalbox.Text = $"{totalall}";
        }



        // private void Button1_Click_1(object sender, EventArgs e)
        //{// variables 
        //  double burgers = Convert.ToInt32(burgernumber.Text);
        //double fries = Convert.ToInt32(friesnumber.Text);
        //double drinks = Convert.ToInt32(drinksnumber.Text);
      //  double totalfood = (burgers * burgerscost) + (fries * friescost) + (drinks * drinkscost);
        // double totaltax = tax * totalfood;
        //double totalall = totaltax + totalfood;
        //totaltax = totalfood * tax;
        //totalall = totalfood + totaltax;
        // burgernumber.Text = $"{totalfood("$00.00")}";
        // input text
        //subtotal.Text = Convert.ToString(totalfood);
        //taxtotal.Text = Convert.ToString(totaltax);
        ///total.Text = Convert.ToString(totalall);


    }

     //   private void Print_Click(object sender, EventArgs e)
       // {// variables 
         //   double burgers = Convert.ToInt32(burgernumber.Text);
           // double fries = Convert.ToInt32(friesnumber.Text);
            //double drinks = Convert.ToInt32(drinksnumber.Text);
            //double totalfood = (burgers * burgerscost) + (fries * friescost) + (drinks * drinkscost);
            //double totaltax = tax * totalfood;
           // double totalall = totaltax + totalfood;
           /// totaltax = totalfood * tax;
            //totalall = totalfood + totaltax;
            //double burgerstotal = (burgers * burgerscost);
           // double friestotal = (fries * friescost);
           // double drinkstotal = (drinks * drinkscost);
            //text
            //player.Play();
            //label.Text = "big belly burger";

 //           this.Refresh();
   ///         Thread.Sleep(500);
      ///      player.Play();
         ///   ordernumber.Text = "order number 244";
            //this.Refresh();
            ///Thread.Sleep(500);
            //player.Play();
            //date.Text = "dec 21 2020";
            //player.Play();
           /// this.Refresh();
            //Thread.Sleep(500);
          //  player.Play();
            //burgertext.Text = "burgers " + "  " + burgers + "     $" + burgerstotal + "$";
            //this.Refresh();
            //Thread.Sleep(500);
            //player.Play();
            //friestext1.Text = "fries" + "      " + fries + "     $" + friestotal + "$";
           // this.Refresh();
           // Thread.Sleep(500);
            //player.Play();
            //drinkstext1.Text = "drinks" + "    " + drinks + "     $" + drinkstotal + "$";
            //this.Refresh();
            //Thread.Sleep(500);
            //player.Play();
            //subtext.Text = "subtotal" + "         $" + totalfood;
            //this.Refresh();
            //Thread.Sleep(500);
            //player.Play();
            //taxtext.Text = "tax" + "         $" + totaltax;
            //this.Refresh();
            //Thread.Sleep(500);
            //player.Play();
            ///totaltext.Text = "total" + "         $" + totalall;









        }

        //private/// void label4_Click(object sender, EventArgs e)
        //{

        //}//
    //}
//}
