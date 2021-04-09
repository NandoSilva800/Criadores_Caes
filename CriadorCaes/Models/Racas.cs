using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CriadorCaes.Models
{
    /// <summary>
    /// Identifica as raças de um cão
    /// </summary>
    public class Racas
    {

        /// <summary>
        /// construtor da classe Racas
        /// </summary>
        public Racas()
        {
            //aceder à BD, e selecionar todos os caes da raça
            ListaDeCaes = new HashSet<Caes>();


        }

        /// <summary>
        /// Pk racas
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Designacao { get; set; }

        //************************************************
        //Criar uma lista de cães a que uma Raça está associada
        //************************************************
        public ICollection<Caes> ListaDeCaes { get; set; }
        //************************************************
    }
}

