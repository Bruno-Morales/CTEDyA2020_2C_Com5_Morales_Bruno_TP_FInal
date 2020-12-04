using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepSpace
{
    class CuandoEsJugador
    {
		List<Planeta> camino = new List<Planeta>();

		Recorridos recorrido = new Recorridos();

		int team = 2;
		public Movimiento CalcularDelJugador(ArbolGeneral<Planeta> arbol)
		{
			recorrido.ConPreorden(arbol, camino, team);

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

	}
}
