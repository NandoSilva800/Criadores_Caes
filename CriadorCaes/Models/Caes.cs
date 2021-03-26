using System;
namespace CriadorCaes.Models
{
    public class Caes
    {
        /// <summary>
        /// Dados dos cães
        /// </summary>
        public Caes()
        {

            /// <summary>
            /// Nome do cão
            /// </summary>
            public string Nome
        {
            get;
            set;
        }

        /// <summary>
        /// sexo do cão
        /// </summary>
        public string Sexo
        {
            get;
            set;

        }

        /// <summary>
        /// Data de Nascimento
        /// </summary>
        public DateTime DataNasc
        {
            set;
            get;
        }

        /// <summary>
        /// Data de compra
        /// </summary>
        public DateTime DataCompra
        {
            set;
            get;
        }

        /// <summary>
        /// referencia do LOP do cão
        /// </summary>
        public string LOP
        {
            get;
            set;

        }
    }
    }
}
