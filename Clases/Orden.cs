using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_R_OBLIGATORIO.Clases
{
    public class Orden
    {
        public int NumeroOrden {  get; set; }
        public string Cliente {  get; set; }
        public string Tecnico {  get; set; }
        public string Descripcion {  get; set; }
        public DateTime FechaCreacion {  get; set; }
        public string Estado {  get; set; }
        public List<string> Comentarios {  get; set; }

        public Orden()
        {
            Comentarios = new List<string>();
        }

        public void AgregarComentario(string comentario)
        {
            Comentarios.Add(comentario);
        }

        public string ObtenerComentarios()
        {
            return string.Join(Environment.NewLine, Comentarios);
        }
    }
}