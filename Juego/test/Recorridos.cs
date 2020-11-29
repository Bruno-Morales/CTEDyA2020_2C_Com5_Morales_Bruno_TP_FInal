using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepSpace
{
    class Recorridos
    {

		public List<Planeta> ConPreorden(ArbolGeneral<Planeta> arbol, List<Planeta> camino)

		{
			camino.Add(arbol.getDatoRaiz());

			if (arbol.getDatoRaiz().EsPlanetaDeLaIA())
			{
				return camino;
			}
			else
			{
				foreach (var hijo in arbol.getHijos())
				{
					List<Planeta> listaAux = ConPreorden(hijo, camino);

					if (listaAux != null)
					{
						return listaAux;
					}
					camino.RemoveAt(camino.Count - 1);
				}
			}
			return null;
		}

		public List<Planeta> ConPreorden1(ArbolGeneral<Planeta> arbol, List<Planeta> camino)
		{
			camino.Add(arbol.getDatoRaiz());

			if (arbol.getDatoRaiz().EsPlanetaDelJugador())
			{
				return camino;
			}
			else
			{
				foreach (var hijo in arbol.getHijos())
				{
					List<Planeta> listaAux = ConPreorden1(hijo, camino);
					if (listaAux != null)
					{
						return listaAux;
					}
					camino.RemoveAt(camino.Count - 1);
				}
			}
			return null;
		}

		public List<Planeta> ConPreorden2(ArbolGeneral<Planeta> arbol, List<Planeta> camino)
		{
			if (arbol.getDatoRaiz().EsPlanetaDeLaIA())
			{
				camino.Add(arbol.getDatoRaiz());
				foreach (var hijo in arbol.getHijos())
				{
					List<Planeta> listaAux = ConPreorden2(hijo, camino);
					if (listaAux != null)
					{
						return listaAux;
					}
				}
			}
			return null;
		}



	}
}
