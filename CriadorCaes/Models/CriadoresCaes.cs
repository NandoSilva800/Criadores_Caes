using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorCaes.Models
{
    /// <summary>
    /// Relaciona os objetos da classe Criadores com os objetos da Classe Caes
    /// </summary>
    public class CriadoresCaes
    {
        //*******************************************
        //FK para o Criador
        //*******************************************
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }
        public Criadores Criador { get; set; }
        //*******************************************

        //*******************************************
        //FK para o Cao
        //*******************************************
        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; }
        public Criadores Cao { get; set; }
        //*******************************************

    }
}
