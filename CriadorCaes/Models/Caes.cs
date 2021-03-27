using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorCaes.Models
{
    /// <summary>
    /// Dados dos cães
    /// </summary>
    public class Caes
    {
        //Construtor
        public Caes()
        {
            //Inicialização de 'listas'
            ListaDeFotografias = new HashSet<Fotografias>();
            ListaDeCriadores = new HashSet<CriadoresCaes>();
        }

        /// <summary>
        /// Nome do cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// sexo do cão
        /// </summary>
        public string Sexo { get; set; }
        
        /// <summary>
        /// Data de Nascimento
        /// </summary>
        public DateTime DataNasc { get; set; }
       

        /// <summary>
        /// Data de compra
        /// </summary>
        public DateTime DataCompra { get; set; }
        

        /// <summary>
        /// referencia do LOP do cão
        /// Livro de origens portugues
        /// </summary>
        public string LOP { get; set; }
       

        //***********************************************************
        //FK para a Raça (chave estrangeira)
        //***********************************************************

        [ForeignKey(nameof(Raca))]    //[ForeignKey("Raca")]
        public int RacaFK { get; set; }  //FK para Raca no SGBD (SQL)

        public Racas Raca { get; set; }  //FK para Raca no C#



        /* em SQL, a criação desta tabela seria....
         * Create Table Caes(
         * ?????? Primary Key,
         * nome Varchar(30) not null,
         * sexo char(1) not null,
         * ....
         * LOP Varchar(20),
         * raca int not null,
         * Foreign Key (RacaFK) References Racas(ID)
         * )
         * 
         */

        //****************************************************************
        // lista de Fotografias do cão
        //****************************************************************
        public ICollection<Fotografias> ListaDeFotografias { get; set; }
        //****************************************************************

        //****************************************************************
        // lista de Criadores associados ao cão
        //****************************************************************
        public ICollection<CriadoresCaes> ListaDeCriadores { get; set; }
        //****************************************************************
    }
}

