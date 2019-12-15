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
    public class cls_saidaNegocio
    {
        AcessoMySql acessoMySql = new AcessoMySql();

        public string Inserir(cls_saida saida)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "INSERT INTO SAIDA (datasaida, qtde, cod_produto) VALUES ('" + saida.DataSaida + "', " + saida.Qtde + "," + saida.Cod_Produto + ") RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(cls_saida saida)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE SAIDA SET datasaida = " + saida.DataSaida + ", qtde = " + saida.Qtde + ", cod_produto = " + saida.Cod_Produto + " WHERE codigo = " + saida.Codigo + " RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(cls_saida saida)
        {
            try
            {
                acessoMySql.ExecutarManipulacao(CommandType.Text, "DELETE FROM SAIDA WHERE codigo = " + saida.Codigo);
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public cls_saidaColecao SaidaColecao()
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_saidaColecao saidaColecao = new cls_saidaColecao();
                DataTable dataTableSaida = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT S.codigo, P.nome, S.datasaida, S.qtde FROM saida S INNER JOIN PRODUTO P ON S.cod_produto = P.codigo ORDER BY S.codigo DESC");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTableSaida.Rows)
                {
                    //Criar um cliente vazio
                    cls_saida saida = new cls_saida();

                    //Colocar os dados da linha nele        
                    saida.Codigo = Convert.ToInt32(linha["codigo"]);
                    saida.Nome = linha["nome"].ToString();
                    saida.DataSaida = Convert.ToDateTime(linha["DataSaida"]);
                    saida.Qtde = Convert.ToInt32(linha["qtde"]);
                    //Adicionar ele na coleção                                                    
                    saidaColecao.Add(saida);
                }

                return saidaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos de Estoque.\nDetalhes: " + ex.Message);
            }
        }

        public cls_saidaColecao HistóricoCadaProduto(int produto)
        {
            try
            {
                cls_saidaColecao saidaColecao = new cls_saidaColecao();
                DataTable dataTableSaida = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT codigo, dataentrada, datavencimento, qtde FROM entrada  WHERE cod_produto = " + produto + " ORDER BY dataentrada DESC");

                foreach (DataRow linha in dataTableSaida.Rows)
                {
                    cls_saida saida = new cls_saida();

                    saida.Codigo = Convert.ToInt32(linha["Codigo"]);
                    saida.DataSaida = Convert.ToDateTime(linha["DataSaida"]);
                    saida.Qtde = Convert.ToInt32(linha["Qtde"]);
                    saida.Cod_Produto = Convert.ToInt32(linha["Cod_Produto"]);

                    saidaColecao.Add(saida);
                }

                return saidaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Dados cadastrados.\nDetalhes: " + ex.Message);
            }
        }
        public cls_saidaColecao SaidaPorData(DateTime dia)
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_saidaColecao saidaColecao = new cls_saidaColecao();
                DataTable dataTableSaida = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT S.codigo, P.nome, S.datasaida, S.qtde FROM saida S INNER JOIN PRODUTO P ON S.cod_produto = P.codigo WHERE S.datasaida = '" + dia + "' ORDER BY S.codigo DESC");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTableSaida.Rows)
                {
                    //Criar um cliente vazio
                    cls_saida saida = new cls_saida();

                    //Colocar os dados da linha nele        
                    saida.Codigo = Convert.ToInt32(linha["codigo"]);
                    saida.Nome = linha["nome"].ToString();
                    saida.DataSaida = Convert.ToDateTime(linha["DataSaida"]);
                    saida.Qtde = Convert.ToInt32(linha["qtde"]);
                    //Adicionar ele na coleção                                                    
                    saidaColecao.Add(saida);
                }

                return saidaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos de Estoque.\nDetalhes: " + ex.Message);
            }
        }
    }
}
