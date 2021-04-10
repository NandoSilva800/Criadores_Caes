using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorCaes.Models
{
    /// <summary>
    /// Relaciona os objetos da classe Criadores com os objetos da Classe Caes
    /// </summary>
    public class CriadoresCaes
    {
        [Key]  //PK normal
        public int Id { get; set; }

        //*******************************************
        //FK para o Criador
        //*******************************************
        // [Key Column(Order =1)] //PK com dois atributos Teste
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }
        public Criadores Criador { get; set; }
        //*******************************************

        //*******************************************
        //FK para o Cao
        //*******************************************
        // [Key, Column(Order = 2)] //PK com dois atributos  teste
        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; }
        public Criadores Cao { get; set; }
        //*******************************************

    }
}
