using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DeepSpace

{

	class Estrategia
	{
		
		
		public String Consulta1( ArbolGeneral<Planeta> arbol)
        {
			List<Planeta> planetas = new List<Planeta>();

			Recorridos recorrido = new Recorridos();

			recorrido.ConPreorden(arbol, planetas);

			int me = planetas.Count;

			string a = "distancia que existe entre la raíz y el bot =   " + me;

			return a;
        }


		public String Consulta2(ArbolGeneral<Planeta> arbol)
		{
			Consultas consulta = new Consultas();

			string a = consulta.cantidadniveles(arbol);

			return a;
		}



		public String Consulta3( ArbolGeneral<Planeta> arbol)
		{
			Consultas consulta = new Consultas();

			string la = consulta.cantidadniveles1(arbol);

			return la;
		}



		public Movimiento CalcularMovimiento(ArbolGeneral<Planeta> arbol)
		{


			while (arbol.getDatoRaiz().EsPlanetaNeutral())
			{
				CuandoEsNeutral neutral = new CuandoEsNeutral();

				return neutral.Este(arbol);
			}

			while (arbol.getDatoRaiz().EsPlanetaDelJugador())
			{
				CuandoEsJugador cuandoEsJugador = new CuandoEsJugador();

				Random random = new Random();

				int a = random.Next(2);
				
				switch (a)
				{
					case 0: return cuandoEsJugador.Primereando(arbol);
					case 1: return cuandoEsJugador.Segundeando(arbol);
				}

			}
			while (arbol.getDatoRaiz().EsPlanetaDeLaIA())
			{

				CuandoEsIA cuandoEsIA = new CuandoEsIA();

				Random random = new Random();

				int a = random.Next(3);

                switch (a)
                {
					case 0 : return cuandoEsIA.Jugada2(arbol);
					case 1:  return cuandoEsIA.Delaraizalquesigue(arbol);
					case 2:  return cuandoEsIA.Delaraizalquesigue2(arbol);
				}
            }
            return null;
		}

	}
}
