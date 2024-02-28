using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using MathParser;
using org.mariuszgromada.math.mxparser;

namespace Интегралы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Calculate()
        {
            double e, h, a, b;
            Double.TryParse(e_text.Text, out e);
            Double.TryParse(a_text.Text, out a);
            Double.TryParse(b_text.Text, out b);
            h = Math.Pow(e, 0.25);
        
            int n = Convert.ToInt32(Math.Ceiling((b - a) / h));
            while(n % 4 != 0)
            {
                n += 1;
            }
            n_text.Text = n.ToString();
            h = (b - a) / n;
            step_text.Text = h.ToString();
            List<double> xn = new List<double>();
          
            xn.Add(a);
            while(xn.Count != n+1)
            {
                xn.Add(xn[xn.Count - 1] + h);
            }



            double simp1, simp2, rect1, rect2, new_step;
            new_step = h;
            int count = 1;
            simp1 = Simpson(new_step, n, xn);
            simp2 = Simpson(2 * new_step, n, xn);
            simps.Items.Add("Кол-во шагов: " + (n).ToString() + ". Результат: " + simp1.ToString());
            simps.Items.Add("Кол-во шагов: " + (n / 2).ToString() + ". Результат: " + simp2.ToString());
            rect1 = Rectangles(new_step, n, xn);
            rectangles.Items.Add("Кол-во шагов: " + (n).ToString() + ". Результат: " + rect1.ToString());
            while (Math.Abs(simp1 - simp2)/15 > e) 
            {
                simp1 = simp2;
                new_step *= 2;
                count += 1;
                simp2 = Simpson(2 * new_step, n, xn);
                simps.Items.Add("Кол-во шагов: " + (n / Math.Pow(2, count)).ToString() + ". Результат: " + simp2.ToString());
            }
          
            simps.Items.Add("Достигнута заданная точность");
            
        }
        private double Simpson(double h, double n, List<double> xn)
        {
            List<double> y = new List<double>();
            Argument x = new Argument("x");
            while (y.Count != n + 1)
            {
                x.setArgumentValue(xn[y.Count]);

                Expression exp = new Expression(func.Text, x);
                y.Add((double)exp.calculate());
                //MessageBox.Show(string.Join(",", y));
            }
            double even = 0;
            double odd = 0;
            double check = xn[0] + h;


            bool even_or_not = false;
            for(int i = 1; i < n; i++)
            {
  
                if (Math.Round(xn[i],2) == Math.Round(check, 2)) 
                {
                    check += h;
                    if (even_or_not) { even += y[i]; even_or_not = false; continue; }
                    else { odd += y[i]; even_or_not = true; continue; }
                }
                else { continue; }
            }


            return h / 3 * (y[0] + y[(int)n] + (4 * odd) + (2 * even));
            
        }

        private double Rectangles(double h, double n, List<double> x)
        {
            List<double> y = new List<double>();
            List<double> x_rect = new List<double>((int)n);
            for (int i = 0; i < x.Count; i++)
            {
                x[i] = x[i] + h / 2;
            }
            Argument xx = new Argument("x");
            while (y.Count != n)
            {
                xx.setArgumentValue(x[y.Count]);

                Expression exp = new Expression(func.Text, xx);
                y.Add((double)exp.calculate());
                // MessageBox.Show(string.Join(",", y));
            }
            double y_sum = 0;
            for (int i = 0; i < y.Count; i++)
            {
                y_sum += y[i];
            }
            return y_sum * h;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            simps.Items.Clear();
            rectangles.Items.Clear();
            Calculate();
            
        }
    }
  
}

