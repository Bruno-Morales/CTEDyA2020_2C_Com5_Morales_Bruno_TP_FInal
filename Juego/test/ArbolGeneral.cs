using System;
using System.Collections.Generic;

namespace DeepSpace
{
	public class ArbolGeneral<T>
	{

		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

		public ArbolGeneral(T dato)
		{
			this.dato = dato;
		}
		public T getDatoRaiz()
		{
			return this.dato;
		}
		public List<ArbolGeneral<T>> getHijos()
		{
			return hijos;
		}
		public void agregarHijo(ArbolGeneral<T> hijo)
		{
			this.getHijos().Add(hijo);
		}
		public void eliminarHijo(ArbolGeneral<T> hijo)
		{
			this.getHijos().Remove(hijo);
		}
		public bool esHoja()
		{
			return this.getHijos().Count == 0;
		}
        public int altura()
        {
            int altura = 0;
            Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>();
            ArbolGeneral<T> arbolAux;
            c.encolar(this);
            c.encolar(null);
            if (!this.esHoja())
            {
                while (!c.esVacia())
                {
                    arbolAux = c.desencolar();
                    if (arbolAux == null)
                    {
                        altura++;
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
            }
            return altura - 1;
        }
        public void preOrden()
		{
			Console.WriteLine(getDatoRaiz());

			foreach (var hijo in this.getHijos())

				hijo.preOrden();
				
        }

		public void inOrden()
		{
			if (!this.esHoja())
				this.getHijos()[0].inOrden();
			if (this.getHijos().Count > 1)
				for (int i = 1; i < this.getHijos().Count; i++)
					this.getHijos()[i].inOrden();
		}
		public void postOrden()
		{
			foreach (var hijo in this.getHijos())
				hijo.postOrden();
			Console.Write(this.getDatoRaiz() + " ");
		}
        public void porNiveles()
        {
            Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>();

            ArbolGeneral<T> arbolAux;

            c.encolar(this);

            while (!c.esVacia())
            {
                arbolAux = c.desencolar();

                Console.Write(arbolAux.getDatoRaiz() + " ");

                foreach (var hijo in arbolAux.getHijos())
                    
                    c.encolar(hijo);
            }
        }
        public int ancho()
        {
            Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>();
            ArbolGeneral<T> arbolAux;
            int cantnodos = 0;
            int ancho = 0;

            c.encolar(this);
            c.encolar(null);

            while (!c.esVacia())
            {
                arbolAux = c.desencolar();
                if (arbolAux == null)
                {
                    if (cantnodos > ancho)
                        ancho = cantnodos;
                    cantnodos = 0;
                    if (!c.esVacia())
                    {
                        c.encolar(null);
                    }
                }
                else
                {
                    cantnodos++;
                    foreach (var hijo in arbolAux.getHijos())
                    {
                        c.encolar(hijo);
                    }
                }
            }
            return ancho;
        }
        public int cantidadniveles()
        {
            Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>();

            ArbolGeneral<T> arbolAux;

            int cantniveles = 0;

            c.encolar(this);
            c.encolar(null);

            while (!c.esVacia())
            {
                arbolAux = c.desencolar();

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
            return cantniveles;
        }


    }
}
