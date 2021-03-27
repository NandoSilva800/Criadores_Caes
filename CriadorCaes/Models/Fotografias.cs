using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorCaes.Models
{
    /// <summary>
    /// Fotografias associadas a cada cão
    /// </summary>
    public class Fotografias
    {

        public string Fotografia { get; set; }
            
        public DateTime Data { get; set; }
            
        public string Local { get; set; }

        //***********************************************
        //FK para o cão
        //***********************************************
        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; } //FK para o Cao(SQL)
        public Caes Cao { get; set; } //FK para o Cao(C#)


    }
   
}


