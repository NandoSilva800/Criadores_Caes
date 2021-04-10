using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CriadorCaes.Models
{
    /// <summary>
    /// dados dos criadores dos cães
    /// </summary>
    public class Criadores
    {

        //construtor
        public Criadores()
        {
            ListaDeCaes = new HashSet<CriadoresCaes>();
        }


        /// <summary>
        /// PK para o criador
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Nome do criador
        /// </summary>
        public string Nome { get; set; }


        /// <summary>
        /// Sufixo associado ao cao criado pelo criador
        /// </summary>
        public string NomeComercial { get; set; }


        /// <summary>
        /// Morada do criador
        /// </summary>
        public string Morada { get; set; }


        /// <summary>
        /// Codigo postal do criador
        /// </summary>
        public string CodPostal { get; set; }


        /// <summary>
        /// Email do criador
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// Telemovel do criador
        /// </summary>
        public string Telemovel { get; set; }


        //*************************************************
        //Lista de Caes associados ao criador
        //*************************************************
        public ICollection<CriadoresCaes> ListaDeCaes { get; set; }
        //*************************************************
    }

}
