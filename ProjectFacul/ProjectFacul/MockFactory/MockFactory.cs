using ProjectFacul.Models;
using System;
using System.Collections.Generic;

namespace ProjectFacul.MockFactory
{
    public class MockFactory
    {
        public static List<FatoresClimaticosModel> GerarListaProdutos(int quantidadeElementos)
        {
            List<FatoresClimaticosModel> produtos = new List<FatoresClimaticosModel>();

            for(int i = 0; i < quantidadeElementos; i++)
            {
                produtos.Add(new FatoresClimaticosModel()
                {
                   
                });
            }

            return produtos;
        }

        public static List<CategoriaProdutoModel> GerarListaCategoriaProduto(int quantidadeElementos)
        {
            List<CategoriaProdutoModel> categorias = new List<CategoriaProdutoModel>();

            for(int i = 0; i < quantidadeElementos; i++)
            {
                categorias.Add(new CategoriaProdutoModel()
                {
                    Descricao = "Descricao categoria",
                    Id = Guid.NewGuid()
                });
            }

            return categorias;
        }
    }
}
