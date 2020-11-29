using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepSpace
{
    class CuandoEsIA
    {
		public Movimiento Jugada2(ArbolGeneral<Planeta> arbol)
		{

			List<Planeta> camino1 = new List<Planeta>();

			Recorridos recorrido = new Recorridos();

			recorrido.ConPreorden1(arbol, camino1);

			return Jugada1(arbol, camino1);

		}

		public Movimiento Jugada1(ArbolGeneral<Planeta> arbol, List<Planeta> camino)
		{
			if (camino.Count > 1)
			{
				if (camino[1].EsPlanetaNeutral())
				{
					Planeta ori = arbol.getDatoRaiz();
					Planeta dest = camino[1];
					Movimiento movim = new Movimiento(ori, dest);
					return movim;
				}
				if (camino[1].EsPlanetaDelJugador())
				{
					Planeta ori = arbol.getDatoRaiz();
					Planeta dest = camino[1];
					Movimiento movim = new Movimiento(ori, dest);
					return movim;
				}
				if (camino[2].EsPlanetaDelJugador())
				{
					Planeta ori = camino[1];
					Planeta dest = camino[2];
					Movimiento movim = new Movimiento(ori, dest);
					return movim;
				}
				if (camino[2].EsPlanetaNeutral())
				{
					Planeta ori = camino[1];
					Planeta dest = camino[2];
					Movimiento movim = new Movimiento(ori, dest);
					return movim;
				}
				if (camino[3].EsPlanetaDelJugador())
				{
					Planeta ori = camino[2];
					Planeta dest = camino[3];
					Movimiento movim = new Movimiento(ori, dest);
					return movim;
				}
				if (camino[3].EsPlanetaNeutral())
				{
					Planeta ori = camino[2];
					Planeta dest = camino[3];
					Movimiento movim = new Movimiento(ori, dest);
					return movim;
				}
				if (camino[4].EsPlanetaDelJugador())
				{
					Planeta ori = camino[3];
					Planeta dest = camino[4];
					Movimiento movim = new Movimiento(ori, dest);
					return movim;
				}
				if (camino[4].EsPlanetaNeutral())
				{
					Planeta ori = camino[3];
					Planeta dest = camino[4];
					Movimiento movim = new Movimiento(ori, dest);
					return movim;
				}
			}
			return null;
		}
		public Movimiento Delaraizalquesigue(ArbolGeneral<Planeta> arbol)
		{
			List<Planeta> camino = new List<Planeta>();

			Recorridos recorrido = new Recorridos();

			recorrido.ConPreorden2(arbol, camino);

			Planeta ori = camino.Last<Planeta>();

			camino.Remove(ori);

			if (camino.Count != 0)

			{

				Planeta ori1 = camino.Last<Planeta>();

				Planeta dest = arbol.getDatoRaiz();

				Movimiento mov = new Movimiento(ori1, dest);

				return mov;
			}
			return null;
		}
		public Movimiento Delaraizalquesigue2(ArbolGeneral<Planeta> arbol)
		{

			List<Planeta> camino = new List<Planeta>();

			Recorridos recorrido = new Recorridos();

			recorrido.ConPreorden2(arbol, camino);

			if (camino.Count > 2)
			{
				Planeta ori = camino.Last<Planeta>();

				camino.Remove(ori);

				Planeta ori1 = camino.Last<Planeta>();

				camino.Remove(ori1);

				Planeta ori2 = camino.Last<Planeta>();

				Planeta dest = arbol.getDatoRaiz();

				Movimiento mov = new Movimiento(ori2, dest);

				return mov;

			}
			return null;

		}





	}
}
