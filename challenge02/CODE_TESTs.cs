using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CODE_TESTs
{
	class tests
	{
        List<string> mylist = new List<string>();
        string escr = string.Empty;

        public void exe()
		{
            //string leer = "11610497110107115";
            //string leer = "102111114";
            //string leer = "11210897121105110103";
            //string leer = "9911110010110998101114";
            //string leer = "11210810197115101";
            string leer = "11510497114101";

            //solución: thanks for playing codember please share

            while (1 == 1)
            {
                mytests2(leer);
                Console.WriteLine("------------------------------------------------------");
            }
        }

        public void mytests2(string toread)
		{
            Random ran  = new Random();

            int contador = 0;
            int x = 0;

            bool vali = true;

            while (vali == true) 
			{
				try
				{
					x = ran.Next(2, 4); //Numero leatorio (solo toma los valores 2 y 3)

					escr = escr + Convert.ToChar(Convert.ToInt32(toread.Substring(contador, x))); //aqui no grego nada a mylist porque equi solo manejo las substrings.

					contador = contador + x;
					vali = true;
				}
				catch //aqui si agrego contenido a mylist porque aquí valido tódo el código desencriptado a partir de las substrings
				{
					if (contador == toread.Length)
					{						
                        int k = 0;
                        int vali3 = 0;
                        foreach (var cell in mylist)
                        {
                            if (mylist[k] == escr)
                            {
                                vali3++;
                                Console.WriteLine("/////Repeated/////");
                                Console.Write("\n");
                            }
                            else
                            {
                                vali3 = vali3;
                            }
                            k++;
                        }

                        if (vali3 == 0)
                        {
                            mylist.Add(escr); //si el contador concuerda con la longitud del arhumento de la funcion, y si escr no se encuentra en mylist, entonces agrega escr a mylist.
                            vali = false;
                            Console.Write(escr.Replace("\n", "") + "\n\r");
                            Console.Write("\n");
                        }
                    }
					else if (contador < toread.Length)//valido si la suma del número de diviciones de 2 y 3 en la cadena del código encriptado corresponde con la longitud de la cadena original.
					{
                        x = 0;
                        contador = 0;
                        escr = string.Empty;
						vali = true;
                    }
				}
            }
        }
	}
}
