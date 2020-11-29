using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepSpace
{
    class CuandoEsJugador
    {

		public Movimiento Primereando(ArbolGeneral<Planeta> arbol)
		{
			List<Planeta> camino = new List<Planeta>();

			Recorridos recorrido = new Recorridos();

			recorrido.ConPreorden(arbol, camino);

			Planeta ori = camino.Last<Planeta>();

			camino.Remove(ori);

			if (camino.Count != 0)
			{
				Planeta dest = camino.Last<Planeta>();

				Movimiento mov = new Movimiento(ori, dest);

				return mov;
			}
			return null;
		}

		public Movimiento Segundeando(ArbolGeneral<Planeta> arbol)
		{
			List<Planeta> camino = new List<Planeta>();

			Recorridos recorrido = new Recorridos();

			recorrido.ConPreorden2(arbol, camino);

			if (camino.Count > 2)
			{

				Planeta ori = camino.Last<Planeta>();

				camino.Remove(ori);

				Planeta dest = camino.Last<Planeta>();

				camino.Remove(dest);

				Planeta dest1 = camino.Last<Planeta>();

				Movimiento mov = new Movimiento(dest, dest1);

				return mov;
			}

			return null;
		}















	}
}
