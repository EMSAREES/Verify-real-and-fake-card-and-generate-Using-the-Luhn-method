using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;

namespace verify_fake_or_real_card.project
{
    public partial class index : System.Web.UI.Page
    {
        bool isReal = false;
        string numberCard;

        protected void Page_Load(object sender, EventArgs e)
        {
            Verify.Visible = isReal;
        }


        protected void But_Acept_Click1(object sender, EventArgs e)
        {
            numberCard = Tex_Number.Text;
            

            numberCard = Tex_Number.Text.Trim(); 
            if (string.IsNullOrWhiteSpace(numberCard)) 
            {
                Verify.Visible = false;
            }
            else
            {
                varify(); 
            }


        }





        void varify()
        {
            int sumaTotal = 0;

            char[] cardArray = numberCard.ToCharArray();
            Array.Reverse(cardArray);
            //string reversedCard = new string(cardArray);


            for (int i = 0; i < numberCard.Length; i++)
            {
                int val1 = cardArray[i] - '0';

                if (i % 2 != 0)
                {
                    int mult = val1 * 2;

                    if (mult >= 10)
                    {
                        sumaTotal += (mult / 10) + (mult % 10);
                    }
                    else
                    {
                        sumaTotal += mult;
                    }
                }
                else
                {
                    sumaTotal += val1;
                }

                if (sumaTotal % 10 == 0)
                {
                    isReal = true;
                }
                else
                {
                    isReal = false;
                }
            }

            //if (isReal)
            //{
            //    Verify.Visible = isReal;
            //    Verify.Text = "It is card real";
            //}
            //else
            //{
            //    Verify.Visible = true;
            //    Verify.Text = "It isn't card real";
            //}
            isReal = (sumaTotal % 10 == 0); // Validar si la suma es múltiplo de 10

            Verify.Visible = true;
            Verify.Text = isReal ? "It is card real" : "It isn't card real";

        }

        protected void But_Generate_Click(object sender, EventArgs e)
        {
            generate();
        }

        void generate()
        {
            Random random = new Random();
            List<int> ListaGeneradora = new List<int>();
            int sumaTotal = 0;

            for (int generarValor = 0; generarValor < 15; generarValor++)
            {
                int NumberNuevo = random.Next(0, 10);
                ListaGeneradora.Add(NumberNuevo);

                int val;
                if (generarValor % 2 == 0)
                { 
                    val = NumberNuevo * 2;
                    if (val >= 10)
                    {
                        sumaTotal += (val / 10) + (val % 10);
                    }
                    else
                    {
                        sumaTotal += val;
                    }
                }
                else 
                {
                    sumaTotal += NumberNuevo;
                }

                /*int val = (generarValor % 2 == 0) ? NumberNuevo * 2 : NumberNuevo;

                if (val >= 10)
                {
                    sumaTotal += (val / 10) + (val % 10);
                }
                else
                {
                    sumaTotal += val;
                }*/

            }

            int resto = sumaTotal % 10;
            int lastDigit;
            if (resto == 0)
            {
                lastDigit = 0;
            }
            else
            {
                lastDigit = 10 - resto;
            }

            // Calcular el último dígito (dígito de control)
            //int lastDigit = (10 - (sumaTotal % 10)) % 10;


            ListaGeneradora.Add(lastDigit);

            
            Tex_Number.Text = string.Join("", ListaGeneradora);

        }


    }
}