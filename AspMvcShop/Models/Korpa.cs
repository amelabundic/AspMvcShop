using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcShop.Models
{
    public class Korpa
    {
        private List<StavkaKorpe> listaStavki = new List<StavkaKorpe>();

        public void DodajStavku(Proizvod p, int kolicina)
        {
            StavkaKorpe st1 = listaStavki
            .SingleOrDefault(st => st.Proizvod.ProizvodId == p.ProizvodId);
            if (st1 == null)
            {
                st1 = new StavkaKorpe
                {
                    Proizvod = p,
                    Kolicina = kolicina
                };
                listaStavki.Add(st1);
            }
            else
            {
                st1.Kolicina += kolicina;
            }
        }

        public virtual void ObrisiStavku(Proizvod p)
        {
            StavkaKorpe st1 = listaStavki.SingleOrDefault(st =>
            st.Proizvod.ProizvodId == p.ProizvodId);
            listaStavki.Remove(st1);
        }

        public void PromeniStavku(Proizvod p, int kolicina)
        {
            StavkaKorpe st1 = listaStavki.SingleOrDefault(st =>
            st.Proizvod.ProizvodId == p.ProizvodId);
            if (st1 != null)
            {
                st1.Kolicina = kolicina;
            }
        }

        public virtual decimal VrednostKorpe()
        {

            return listaStavki.Sum(st => st.Proizvod.Cijena * st.Kolicina);
        }

        public virtual void ObrisiKorpu()
        {
            listaStavki.Clear();
        }

        public IEnumerable<StavkaKorpe> Stavke
        {
            get
            {
                return listaStavki;
            }
        }
    }
}
