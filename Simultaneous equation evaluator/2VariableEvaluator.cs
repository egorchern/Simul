using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Simultaneous_equation_evaluator
{
    public partial class _2VariableEvaluator : Form
    {
        public _2VariableEvaluator()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            string equation1 = txtEq1.Text;
            string equation2 = txtEq2.Text;
            bool passed = PassedVerification(equation1, equation2);
            MessageBox.Show(Convert.ToString(passed));
            if(passed == true)
            {
                Regex re = new Regex(@"^(?<x>0x|(-?[1-9][0-9]*x))([+-])(0y|([1-9][0-9]*y))([+-]?)([1-9]*)=(-?\d+)$");
                

                Match matchX = re.Match(equation1);

                string preXcoefficient = matchX.Groups["x"].Value;
                for(int i = 0; i <= preXcoefficient.Length; i++)
                {
                    if(preXcoefficient[i] == 'x')
                    {
                        preXcoefficient = preXcoefficient.Remove(i, 1);
                    }
                }
                MessageBox.Show(preXcoefficient);
            }
           
            
        }
        public static bool PassedVerification(string r, string r1)
        {
            if(Regex.IsMatch(r, @"^(0x|(-?[1-9][0-9]*x))([+-])(0y|([1-9][0-9]*y))([+-]?)([1-9]*)=(-?\d+)$") == true)
            {
                if(Regex.IsMatch(r1, @"^(0x|(-?[1-9][0-9]*x))([+-])(0y|([1-9][0-9]*y))([+-]?)([1-9]*)=(-?\d+)$") == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
          
        }
    }
}
