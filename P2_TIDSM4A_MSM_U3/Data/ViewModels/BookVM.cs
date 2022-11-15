using System;

namespace P2_TIDSM4A_MSM_U3.Data.ViewModels
{
    public class BookVM
    {
        public string Titulo { get; set; }

        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int Rate { get; set; }
        public string Genero { get; set; }

        public string Autor { get; set; }

        public string CoverUrl { get; set; }
    }
}
