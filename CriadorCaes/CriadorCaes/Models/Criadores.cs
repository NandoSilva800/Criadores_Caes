using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CriadorCaes.Models {

   /// <summary>
   /// dados dos Criadores dos cães
   /// </summary>
   public class Criadores {

      // construtor
      public Criadores() {
         ListaDeCaes = new HashSet<CriadoresCaes>();
      }

      /// <summary>
      /// PK para o Criador
      /// </summary>
      [Key]
      public int Id { get; set; }


      /// <summary>
      /// Nome do cão
      /// </summary>
      [Required(ErrorMessage = "O Nome é de preenchimento obrigatório...")]
      [StringLength(40, ErrorMessage = "O {0} não deve ser maior que {1} caracteres...")]
      public string Nome { get; set; }

      /// <summary>
      /// sufixo associado ao cão criado pelo criador
      /// </summary>
      [StringLength(20, ErrorMessage = "O {0} não deve ser maior que {1} caracteres...")]
      public string NomeComercial { get; set; }

      /// <summary>
      /// Morada
      /// </summary>
      [Required(ErrorMessage = "A Morada é de preenchimento obrigatório...")]
      [StringLength(60, ErrorMessage = "A {0} não deve ser maior que {1} caracteres...")]
      public string Morada { get; set; }

      /// <summary>
      /// código postal
      /// </summary>
      [Required(ErrorMessage = "O Código Postal é de preenchimento obrigatório...")]
      [StringLength(40, MinimumLength = 8, ErrorMessage = "O {0} deve estar compreendido entre {1} e {2} caracteres...")]
      public string CodPostal { get; set; }

      /// <summary>
      /// email do criador
      /// </summary>
      [StringLength(40, MinimumLength = 6, ErrorMessage = "O {0} deve estar compreendido entre {1} e {2} caracteres...")]
      [RegularExpression("[a-z0-9.]+@ipt.pt", ErrorMessage = "Escreva um email do IPT, por favor.")]
      [EmailAddress(ErrorMessage = "Só são aceites emails do IPT")]
      public string Email { get; set; }

      /// <summary>
      /// telemóvel do Criador
      /// </summary>
      [StringLength(16, MinimumLength = 9, ErrorMessage = "O {0} deve estar compreendido entre {1} e {2} caracteres...")]
      public string Telemovel { get; set; }



      //************************************************************************
      // Lista de Caes associados ao criador
      //************************************************************************
      public ICollection<CriadoresCaes> ListaDeCaes { get; set; }
      //************************************************************************

   }
}
