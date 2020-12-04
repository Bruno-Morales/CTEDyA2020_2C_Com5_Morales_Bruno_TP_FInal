using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepSpace
{
    class CuandoEsIA
    {

       private List<Planeta> camino1 = new List<Planeta>();
       private Recorridos recorrido = new Recorridos();
       private int team = 1;
        public Movimiento Jugada2(ArbolGeneral<Planeta> arbol)
		{
			recorrido.ConPreorden(arbol, camino1, team);
            if (camino1.Count > 1)
            {
                if (!camino1[1].EsPlanetaDeLaIA())
                {
                    Planeta ori = arbol.getDatoRaiz();
                    Planeta dest = camino1[1];
                    Movimiento movim = new Movimiento(ori, dest);
                    return movim;
                }
                if (!camino1[2].EsPlanetaDeLaIA())
                {
                    Planeta ori = camino1[1];
                    Planeta dest = camino1[2];
                    Movimiento movim = new Movimiento(ori, dest);
                    return movim;
                }
                if (!camino1[3].EsPlanetaDeLaIA())
                {
                    Planeta ori = camino1[2];
                    Planeta dest = camino1[3];
                    Movimiento movim = new Movimiento(ori, dest);
                    return movim;
                }
                if (!camino1[4].EsPlanetaDeLaIA())
                {
                    Planeta ori = camino1[3];
                    Planeta dest = camino1[4];
                    Movimiento movim = new Movimiento(ori, dest);
                    return movim;
                }
            }
            return null;
		}
	}
}
