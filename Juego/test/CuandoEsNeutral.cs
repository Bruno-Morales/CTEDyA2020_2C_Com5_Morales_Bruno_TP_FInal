using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DeepSpace
{
     class CuandoEsNeutral
    {
		List<Planeta> camino = new List<Planeta>();

		Recorridos recorrido = new Recorridos();

		int team = 2;
		public Movimiento CalculardeNeutral(ArbolGeneral<Planeta> arbol)
		{
			recorrido.ConPreorden(arbol, camino, team);

			if (camino.Count != 0)
			{
				Planeta ori = camino.Last<Planeta>();

				camino.Remove(ori);

				if (camino.Count != 0)
				{

					Planeta dest = camino.Last<Planeta>();

					Movimiento mov = new Movimiento(ori, dest);

					return mov;
				}
			}

			return null;

		}


	}
}
