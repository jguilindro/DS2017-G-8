﻿using System;
using System.Collections;
using System.IO;

namespace ABRESPOL
{
    public class LectorPlatillo
    {
        private ArrayList Registros = new ArrayList();

        public LectorPlatillo()
        {
            this.Registros = new ArrayList(); 
        }

        public void ejecutar()
        {
            leer();
        }

        private void leer()
        {
            try 
            {
                //AQUIIIIIIIIII
                string ubicacion = Console.ReadLine(); 
                StreamReader lector = new StreamReader(ubicacion);
               
                String lineas = lector.ReadLine(); 

                while(lineas != null)
                {
                    char[] delimitador = { ',' };
                    string[] palabras = lineas.Split(delimitador);
                    Platillo p = new Platillo();
                    p.Nombre = palabras[0];
                    p.Precio = float.Parse(palabras[1]);
                    p.Descripcion = palabras[2];

                    Registros.Add(p);
                    lineas = lector.ReadLine();
                }
                lector.Close(); 

            }
            catch (Exception e)
            {
                Console.WriteLine("Excepiton" + e.Message); 
            }
            finally
            {
                Console.WriteLine("Lectura Terminada"); 
            }

        }
    }
}
