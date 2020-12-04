using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DeepSpace

{

	class Estrategia
	{
		
		private List<Planeta> planetas = new List<Planeta>();

		private string consulta1 = "";
		private string consulta2 = "";
		private string consulta3 = "";



		public String Consulta1( ArbolGeneral<Planeta> arbol)
        {
			Recorridos recorrido = new Recorridos();
			int team = 2;
			recorrido.ConPreorden(arbol, planetas, team);
			int me = planetas.Count-1;
			consulta1 = "distancia que existe entre la raíz y el bot =   " + me;
			return consulta1;
        }


		public String Consulta2(ArbolGeneral<Planeta> arbol)
		{
			Consultas consulta = new Consultas();
			consulta2 = consulta.cantidadniveles(arbol);
			return consulta2;
		}
		public String Consulta3( ArbolGeneral<Planeta> arbol)
		{
			Consultas consulta = new Consultas();
			consulta3 = consulta.cantidadniveles_consulta3(arbol);
			return consulta3;
		}
		public Movimiento CalcularMovimiento(ArbolGeneral<Planeta> arbol)
		{
			while (arbol.getDatoRaiz().EsPlanetaNeutral())
			{
				CuandoEsNeutral neutral = new CuandoEsNeutral();
				return neutral.CalculardeNeutral(arbol);
			}
			while (arbol.getDatoRaiz().EsPlanetaDelJugador())
			{
				CuandoEsJugador cuandoEsJugador = new CuandoEsJugador();
				return cuandoEsJugador.CalcularDelJugador(arbol);
			}
			while (arbol.getDatoRaiz().EsPlanetaDeLaIA())
			{
				CuandoEsIA cuandoEsIA = new CuandoEsIA();
				return cuandoEsIA.Jugada2(arbol);
            }
            return null;
		}

	}
}
