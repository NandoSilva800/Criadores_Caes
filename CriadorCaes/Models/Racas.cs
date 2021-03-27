using System;
using System.Collections.Generic;

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

        public string Designacao { get; set; }

        //************************************************
        //Criar uma lista de cães a que uma Raça está associada
        //************************************************
        public ICollection<Caes> ListaDeCaes { get; set; }
        //************************************************
    }
}

