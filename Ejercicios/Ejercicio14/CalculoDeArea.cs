﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double area;
            area = Math.Pow(lado, 2);
            return area;
        }
        public static double CalcularTriangulo(double ancho, double altura)
        {
            double area;
            area = (ancho * altura) / 2;
            return area;
        }
        public static double CalcularCirculo(double radio)
        {
            double area;
            area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}
