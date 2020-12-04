using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepSpace
{
    class Recorridos
    {
		public List<Planeta> ConPreorden(ArbolGeneral<Planeta> arbol, List<Planeta> camino, int team)

		{
			camino.Add(arbol.getDatoRaiz());

			if (arbol.getDatoRaiz().team == team)
			{
				return camino;
			}
			else
			{
				foreach (var hijo in arbol.getHijos())
				{
					List<Planeta> listaAux = ConPreorden(hijo, camino, team);

					if (listaAux != null)
					{
						return listaAux;
					}
					camino.RemoveAt(camino.Count - 1);
				}
			}
			return null;
		}

	}
}
