using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorCaes.Models
{
    /// <summary>
    /// Fotografias associadas a cada cão
    /// </summary>
    public class Fotografias
    {

        /// <summary>
        /// PK para as Fotografias
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// nome do ficheiro que contem a fotografia
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// data em que foi tirada a fotografia
        /// </summary>
        public DateTime Data { get; set; }
            
        /// <summary>
        /// local da fotografia
        /// </summary>
        public string Local { get; set; }

        //***********************************************
        //FK para o cão
        //***********************************************
        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; } //FK para o Cao(SQL)
        public Caes Cao { get; set; } //FK para o Cao(C#)


    }
   
}


