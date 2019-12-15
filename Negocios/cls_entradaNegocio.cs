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
    public class cls_entradaNegocio
    {
        AcessoMySql acessoMySql = new AcessoMySql();
        public string Inserir(cls_entrada entrada)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "INSERT INTO ENTRADA (dataentrada, datavencimento, qtde, cod_produto, valortotal) VALUES ('" + entrada.DataEntrada + "', '" + entrada.DataVencimento + "'," + entrada.Qtde + "," + entrada.Cod_Produto + "," + entrada.ValorTotal.ToString().Replace(",", ".") + ") RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(cls_entrada entrada)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE ENTRADA SET dataentrada = '" + entrada.DataEntrada.Date + "', datavencimento = '" + entrada.DataVencimento.Date + "', qtde = " + entrada.Qtde + ", cod_produto = " + entrada.Cod_Produto + ", valortotal = " + entrada.ValorTotal + " WHERE codigo = " + entrada.Codigo + " RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(cls_entrada entrada)
        {
            try
            {
                acessoMySql.ExecutarManipulacao(CommandType.Text, "DELETE FROM ENTRADA WHERE codigo = " + entrada.Codigo);
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public cls_entradaColecao EntradaCompleto()
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_entradaColecao entradaColecao = new cls_entradaColecao();
                DataTable dataTableEntrada = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT E.codigo, E.dataentrada, E.datavencimento, E.qtde, E.cod_produto, E.valortotal, P.nome, P.tipounidade FROM entrada E INNER JOIN produto P ON E.cod_produto = P.codigo ORDER BY E.codigo DESC");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTableEntrada.Rows)
                {
                    //Criar um cliente vazio
                    cls_entrada entrada = new cls_entrada();

                    //Colocar os dados da linha nele        
                    entrada.Codigo = Convert.ToInt32(linha["codigo"]);
                    entrada.DataEntrada = Convert.ToDateTime(linha["dataentrada"]);
                    entrada.DataVencimento = Convert.ToDateTime(linha["datavencimento"]);
                    entrada.Qtde = Convert.ToInt32(linha["qtde"]);
                    entrada.Cod_Produto = Convert.ToInt32(linha["cod_produto"]);
                    entrada.ValorTotal = Convert.ToDouble(linha["valortotal"]);
                    entrada.Nome = linha["nome"].ToString();
                    entrada.Tipo = linha["tipounidade"].ToString();
                    //Adicionar ele na coleção                                                    
                    entradaColecao.Add(entrada);
                }

                return entradaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos de Estoque.\nDetalhes: " + ex.Message);
            }
        }

        public cls_entradaColecao HistóricoCadaProduto(int produto)
        {
            try
            {
                cls_entradaColecao entradaColecao = new cls_entradaColecao();
                DataTable dataTableEntrada = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT codigo, dataentrada, datavencimento, qtde, valortotal FROM entrada  WHERE cod_produto = " + produto + " ORDER BY dataentrada DESC");

                foreach (DataRow linha in dataTableEntrada.Rows)
                {
                    cls_entrada entrada = new cls_entrada();

                    entrada.Codigo = Convert.ToInt32(linha["Codigo"]);
                    entrada.DataEntrada = Convert.ToDateTime(linha["DataEntrada"]);
                    entrada.DataVencimento = Convert.ToDateTime(linha["DataVencimento"]);
                    entrada.Qtde = Convert.ToInt32(linha["Qtde"]);
                    entrada.ValorTotal = Convert.ToDouble(linha["ValorTotal"]);
                    entradaColecao.Add(entrada);
                }

                return entradaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Dados cadastrados.\nDetalhes: " + ex.Message);
            }
        }

        public cls_entradaColecao VerificarporData(DateTime dataentrada)
        {
            try
            {
                cls_entradaColecao entradaColecao = new cls_entradaColecao();
                DataTable dataTableEntrada = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT E.codigo, E.dataentrada, E.datavencimento, E.qtde, E.cod_produto, E.valortotal, P.nome, P.tipounidade FROM entrada E INNER JOIN produto P ON E.cod_produto = P.codigo WHERE E.dataentrada = '" + dataentrada + "' ORDER BY E.codigo DESC");

                foreach (DataRow linha in dataTableEntrada.Rows)
                {
                    cls_entrada entrada = new cls_entrada();

                    entrada.Codigo = Convert.ToInt32(linha["codigo"]);
                    entrada.DataEntrada = Convert.ToDateTime(linha["dataentrada"]);
                    entrada.DataVencimento = Convert.ToDateTime(linha["datavencimento"]);
                    entrada.Qtde = Convert.ToInt32(linha["qtde"]);
                    entrada.Cod_Produto = Convert.ToInt32(linha["cod_produto"]);
                    entrada.ValorTotal = Convert.ToDouble(linha["valortotal"]);
                    entrada.Tipo = linha["tipounidade"].ToString();
                    entrada.Nome = linha["nome"].ToString();

                    entradaColecao.Add(entrada);
                }

                return entradaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Dados cadastrados.\nDetalhes: " + ex.Message);
            }
        }
    }
}
