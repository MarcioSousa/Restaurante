using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class cls_produtoNegocio
    {
        AcessoMySql acessoMySql = new AcessoMySql();

        public string Inserir(cls_produto produto)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "INSERT INTO PRODUTO(nome, valor, tipounidade, qtde) VALUES('" + produto.Nome + "', " + produto.Valor.ToString().Replace(",",".") + ",'" + produto.TipoUnidade + "'," + produto.QtdeAtual + ") RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(cls_produto produto)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE PRODUTO SET nome = '" + produto.Nome + "', valor = " + produto.Valor.ToString().Replace(",", ".") + ", tipounidade = '" + produto.TipoUnidade + "', qtde = " + produto.QtdeAtual + " WHERE codigo = " + produto.Codigo + " RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string AlterarQtde(cls_produto produto)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE PRODUTO SET qtde = " + produto.QtdeAtual + " WHERE codigo = " + produto.Codigo + " RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(cls_produto produto)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "DELETE FROM PRODUTO WHERE codigo = " + produto.Codigo + " RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public cls_produtoColecao TodosProduto()
        {
            try
            {
                cls_produtoColecao produtoColecao = new cls_produtoColecao();

                DataTable dataTableProduto = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, valor, tipounidade, qtde FROM PRODUTO");

                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    cls_produto produto = new cls_produto();
                                          
                    produto.Codigo = Convert.ToInt32(linha["codigo"]);
                    produto.Nome = Convert.ToString(linha["nome"]);
                    produto.Valor = Convert.ToDouble(linha["valor"]);
                    produto.TipoUnidade = Convert.ToString(linha["tipounidade"]);
                    produto.QtdeAtual = Convert.ToInt32(linha["qtde"]);
                                                
                    produtoColecao.Add(produto);
                }

                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public cls_produtoColecao ConsultarPorCod(int codProduto)
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_produtoColecao produtoColecao = new cls_produtoColecao();

                DataTable dataTableProduto = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, valor, tipounidade, qtde FROM PRODUTO WHERE codigo = " + codProduto);

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //Criar um cliente vazio
                    cls_produto produto = new cls_produto();

                    //Colocar os dados da linha nele                                              
                    produto.Codigo = Convert.ToInt32(linha["codigo"]);
                    produto.Nome = Convert.ToString(linha["nome"]);
                    produto.Valor = Convert.ToDouble(linha["valor"]);
                    produto.TipoUnidade = linha["tipounidade"].ToString();
                    produto.QtdeAtual = Convert.ToInt32( linha["qtde"]);
                    //Adicionar ele na coleção                                                    
                    produtoColecao.Add(produto);
                }

                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public cls_produtoColecao TrazerQuantidade(int codProduto)
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_produtoColecao produtoColecao = new cls_produtoColecao();

                DataTable dataTableProduto = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT qtde FROM PRODUTO WHERE codigo = " + codProduto);

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //Criar um cliente vazio
                    cls_produto produto = new cls_produto();

                    //Colocar os dados da linha nele                                              
                    produto.QtdeAtual = Convert.ToInt32(linha["qtde"]);
                    //Adicionar ele na coleção                                                    
                    produtoColecao.Add(produto);

                    break;
                }

                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public cls_produtoColecao CarregaPorNome(string parteNome)
        {
            try
            {
                cls_produtoColecao produtoColecao = new cls_produtoColecao();

                DataTable dataTableProduto = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, valor, tipounidade, qtde FROM produto WHERE nome LIKE '" + parteNome + "%' ");

                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    cls_produto produto = new cls_produto();

                    produto.Codigo = Convert.ToInt32(linha["codigo"]);
                    produto.Nome = Convert.ToString(linha["nome"]);
                    produto.Valor = Convert.ToDouble(linha["valor"]);
                    produto.TipoUnidade = Convert.ToString(linha["tipounidade"]);
                    produto.QtdeAtual = Convert.ToInt32(linha["qtde"]);

                    produtoColecao.Add(produto);
                }

                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar o Produto.\nDetalhes: " + ex.Message);
            }
        }
    }
}