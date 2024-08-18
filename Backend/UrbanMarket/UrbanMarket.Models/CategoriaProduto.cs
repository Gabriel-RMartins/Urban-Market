﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanMarket.Models
{
    public class CategoriaProduto
    {
        /// <summary>
        /// Identificador único da categoria do produto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da categoria.
        /// </summary>
        [MaxLength(50)]
        public string Categoria { get; set; }

        // Relação com a tabela Produto (representada por uma coleção de produtos)
        /// <summary>
        /// Coleção de produtos que têm a categoria.
        /// </summary>
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
