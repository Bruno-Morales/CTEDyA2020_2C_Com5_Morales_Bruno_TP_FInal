using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepSpace
{
    class Consultas
    {

		public string cantidadniveles(ArbolGeneral<Planeta> arbol)
		{
			Cola<ArbolGeneral<Planeta>> c = new Cola<ArbolGeneral<Planeta>>();

			ArbolGeneral<Planeta> arbolAux;

			int cantniveles = 0;

			int a = 10;

			int nivel0 = 0;
			int nivel1 = 0;
			int nivel2 = 0;
			int nivel3 = 0;

			if (arbol.getDatoRaiz().population > a)
			{
				nivel0 = 1;
			}

			c.encolar(arbol);

			c.encolar(null);

			while (!c.esVacia())
			{
				arbolAux = c.desencolar();

				if (arbolAux != null)
				{
					if (cantniveles == 1)
					{
						if (arbolAux.getDatoRaiz().population > a)
						{
							nivel1++;
						}
					}
					if (cantniveles == 2)
					{
						if (arbolAux.getDatoRaiz().population > a)
						{
							nivel2++;
						}
					}
					if (cantniveles == 3)
					{
						if (arbolAux.getDatoRaiz().population > a)
						{
							nivel3++;
						}
					}
				}
				if (arbolAux == null)
				{
					cantniveles++;

					if (!c.esVacia())
					{
						c.encolar(null);
					}
				}
				else
				{
					foreach (var hijo in arbolAux.getHijos())
					{
						c.encolar(hijo);
					}
				}
			}

			string me = "nivel 0 =  " + nivel0 + ". Primer nivel =  " + nivel1 + ". Segundo nivel =  " + nivel2 + ". Tercer nivel =  " + nivel3;

			return me;
		}


		public string cantidadniveles1(ArbolGeneral<Planeta> arbol)
		{
			Cola<ArbolGeneral<Planeta>> c = new Cola<ArbolGeneral<Planeta>>();

			ArbolGeneral<Planeta> arbolAux;

			int cantniveles = 0;


			uint nivel0 = arbol.getDatoRaiz().population;
			float nivel1 = 0;
			float nivel2 = 0;
			float nivel3 = 0;


			float sumanivel1 = 0;
			float sumanivel2 = 0;
			float sumanivel3 = 0;


			c.encolar(arbol);

			c.encolar(null);

			while (!c.esVacia())
			{
				arbolAux = c.desencolar();

				if (arbolAux != null)
				{
					if (cantniveles == 1)
					{
						sumanivel1 += arbolAux.getDatoRaiz().population;

						nivel1++;

					}
					if (cantniveles == 2)
					{
						sumanivel2 += arbolAux.getDatoRaiz().population;

						nivel2++;
					}
					if (cantniveles == 3)
					{
						sumanivel3 += arbolAux.getDatoRaiz().population;

						nivel3++;
					}
				}
				if (arbolAux == null)
				{
					cantniveles++;

					if (!c.esVacia())
					{
						c.encolar(null);
					}
				}
				else
				{
					foreach (var hijo in arbolAux.getHijos())
					{
						c.encolar(hijo);
					}
				}
			}

			string me = "nivel 0 =  " + nivel0 + ". Primer nivel =  " + sumanivel1 / nivel1 + ". Segundo nivel =  " + sumanivel2 / nivel2 + ". Tercer nivel =  " + sumanivel3 / nivel3;

			return me;
		}





	}
}
