﻿using System;
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
            if (passed == true)
            {
                Regex re1 = new Regex(@"^(?<x>0x|(-?[1-9][0-9]*x))(?<y>[+-](0y|([1-9][0-9]*y)))(?<c>[+-][1-9][0-9]*)?=(?<eq>-?\d+)$");
                Match matchX = re1.Match(equation1);
                Regex re2 = new Regex(@"^(?<x1>0x|(-?[1-9][0-9]*x))(?<y1>[+-](0y|([1-9][0-9]*y)))(?<c1>[+-][1-9][0-9]*)?=(?<eq1>-?\d+)$");
                Match matchY = re2.Match(equation2);
                int Coefx = 0;
                int Coefx1 = 0;
                int Coefy = 0;
                int Coefy1 = 0;
                int equalss = 0;
                int equalss1 = 0;
                if (matchX.Success)
                {


                    string preXcoefficient = matchX.Groups["x"].Value;
                    string preYcoefficient = matchX.Groups["y"].Value;
                    string constant = matchX.Groups["c"].Value;
                    string equals = matchX.Groups["eq"].Value;


                    for (int i = 0; i <= preXcoefficient.Length; i++)
                    {

                        if (preXcoefficient[i] == 'x')
                        {
                            preXcoefficient = preXcoefficient.Remove(i, 1);
                        }
                        else if (preXcoefficient[i] == '+')
                        {
                            preXcoefficient = preXcoefficient.Remove(i, 1);
                        }
                    }
                    for (int i = 0; i <= preYcoefficient.Length; i++)
                    {
                        if (preYcoefficient[i] == 'y')
                        {
                            preYcoefficient = preYcoefficient.Remove(i, 1);
                        }
                        else if (preYcoefficient[i] == '+')
                        {
                            preYcoefficient = preYcoefficient.Remove(i, 1);
                        }
                    }
                    if (constant != String.Empty)
                    {
                        if (constant.Contains("-"))
                        {
                            constant = constant.Remove(0, 1);


                            equalss = Convert.ToInt32(equals) + Convert.ToInt32(constant);
                        }
                        else
                        {
                            equalss = Convert.ToInt32(equals) - Convert.ToInt32(constant);
                        }
                    }
                    else
                    {
                        equalss = Convert.ToInt32(equals);
                    }

                    
                    Coefx = Convert.ToInt32(preXcoefficient);
                    Coefy = Convert.ToInt32(preYcoefficient);


                }
                if (matchY.Success)
                {


                    string preXcoefficient1 = matchY.Groups["x1"].Value;
                    string preYcoefficient1 = matchY.Groups["y1"].Value;
                    string constant1 = matchY.Groups["c1"].Value;
                    string equals1 = matchY.Groups["eq1"].Value;


                    for (int i = 0; i <= preXcoefficient1.Length; i++)
                    {
                        if (preXcoefficient1[i] == 'x')
                        {
                            preXcoefficient1 = preXcoefficient1.Remove(i, 1);
                        }
                        else if (preXcoefficient1[i] == '+')
                        {
                            preXcoefficient1 = preXcoefficient1.Remove(i, 1);
                        }
                    }
                    for (int i = 0; i <= preYcoefficient1.Length; i++)
                    {
                        if (preYcoefficient1[i] == 'y')
                        {
                            preYcoefficient1 = preYcoefficient1.Remove(i, 1);
                        }
                        else if (preYcoefficient1[i] == '+')
                        {
                            preYcoefficient1 = preYcoefficient1.Remove(i, 1);
                        }
                    }
                    if (constant1 != String.Empty)
                    {
                        if (constant1.Contains("-"))
                        {
                            constant1 = constant1.Remove(0, 1);


                            equalss1 = Convert.ToInt32(equals1) + Convert.ToInt32(constant1);
                        }
                        else
                        {
                            equalss1 = Convert.ToInt32(equals1) - Convert.ToInt32(constant1);
                        }
                    }
                    else
                    {
                        equalss1 = Convert.ToInt32(equals1);
                    }

                   
                    Coefx1 = Convert.ToInt32(preXcoefficient1);
                    Coefy1 = Convert.ToInt32(preYcoefficient1);

                }
                MessageBox.Show($"First Equation: {Coefx} {Coefy} {equalss}\n Second Equation: {Coefx1} {Coefy1} {equalss1}");
                int[,] matrixM = new int[,]
                {
                    {Coefx, Coefy },
                    {Coefx1, Coefy1 }
                };
                double[,] matrixB = new double[,]
                {
                    {equalss },
                    {equalss1 }
                };
                double determinantOfM = GetDetOf2By2Matrix(matrixM);
                double[,] matrixMReversed = Inverse2By2(matrixM, determinantOfM);
                MessageBox.Show($"{matrixMReversed[0,0]} ; {matrixMReversed[0,1]}\n{matrixMReversed[1,0]} ; {matrixMReversed[1,1]}");
                double[,] results = MultiplyTwoMatrices(matrixMReversed, matrixB);
                MessageBox.Show($"Solutions are:\nx = {results[0,0]}\ny = {results[1,0]}");
            }
            



        }
        public static bool PassedVerification(string r, string r1)
        {
            if(Regex.IsMatch(r, @"^(0x|(-?[1-9][0-9]*x))([+-])(0y|([1-9][0-9]*y))([+-][1-9][0-9]*)?=(-?\d+)$") == true)
            {
                if(Regex.IsMatch(r1, @"^(0x|(-?[1-9][0-9]*x))([+-])(0y|([1-9][0-9]*y))([+-][1-9][0-9]*)?=(-?\d+)$") == true)
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
        public static double GetDetOf2By2Matrix(int[,] matM)
        {
            double a = matM[0, 0] * matM[1, 1];
            double b = matM[0, 1] * matM[1, 0];
            double ans = a - b;
            return ans;
        }
        public static double[,] Inverse2By2(int[,] matM, double detM)
        {
            double[,] PrematReturn = new double[,]
            {
                {matM[1,1],-matM[0,1] },
                {- matM[1,0], matM[0,0] }
            };
            for(int i = 0; i <= PrematReturn.GetUpperBound(0); i++)
            {
                for(int x = 0; x <= PrematReturn.GetUpperBound(1); x++)
                {
                    PrematReturn[i, x] *= (1 / detM);
                }
            }
           /* PrematReturn[0, 0] = PrematReturn[0, 0] * (1 / detM);
            PrematReturn[0, 1] = PrematReturn[0, 1] * (1 / detM);
            PrematReturn[1, 0] = PrematReturn[1, 0] * (1 / detM);
            PrematReturn[1, 1] = PrematReturn[1, 1] * (1 / detM);
            */
            return PrematReturn;
        }
        public static double[,] MultiplyTwoMatrices(double[,] MatCoef,double[,] MatAns)
        {
            double x = (MatCoef[0, 0] * MatAns[0, 0]) + (MatCoef[0, 1] * MatAns[1, 0]);
            double y = (MatCoef[1, 0] * MatAns[0, 0]) + (MatCoef[1, 1] * MatAns[1, 0]);
            double[,] ForReturn = new double[,]
            {
                {x },
                {y }
                   
                

            };
            return ForReturn;
        }
        
    }
}
