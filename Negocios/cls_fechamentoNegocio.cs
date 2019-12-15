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
    public class cls_fechamentoNegocio
    {
        AcessoMySql acessoMySql = new AcessoMySql();

        public string Inserir(cls_fechamento fechamento)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "INSERT INTO FECHAMENTO(dtfech, valorabertura, valorfechamento) VALUES('" + fechamento.DtFech.Date + "', " + fechamento.ValorAbert.ToString().Replace(",",".") + "," + fechamento.ValorFecham.ToString().Replace(",", ".") + ") RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(cls_fechamento fechamento)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE FECHAMENTO SET  valorabertura = " + fechamento.ValorAbert + ", valorfechamento = " + fechamento.ValorFecham + " WHERE dtfech = '" + fechamento.DtFech.Date  + " RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(cls_fechamento fechamento)
        {
            try
            {
                acessoMySql.ExecutarManipulacao(CommandType.Text, "DELETE FROM FECHAMENTO WHERE dtfech = '" + fechamento.DtFech + "'");
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public cls_fechamentoColecao CarregaDados(DateTime dataFechamento)
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_fechamentoColecao fechamentoColecao = new cls_fechamentoColecao();

                DataTable dataTableFechamento = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT valorabertura, valorfechamento FROM fechamento WHERE dtfech = '" + dataFechamento.Date + "'");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTableFechamento.Rows)
                {
                    //Criar um cliente vazio
                    cls_fechamento fechamento = new cls_fechamento();

                    //Colocar os dados da linha nele     
                    fechamento.ValorAbert = Convert.ToDouble(linha["valorabertura"]);
                    fechamento.ValorFecham = Convert.ToDouble(linha["valorfechamento"]);
                    //Adicionar ele na coleção                                                    
                    fechamentoColecao.Add(fechamento);
                    break;
                }
                return fechamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os itens de Fechamento.\nDetalhes: " + ex.Message);
            }
        }

    }
}
