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
    public class cls_usuarioNegocio
    {
        AcessoMySql acessoMySql = new AcessoMySql();


        public string Inserir(cls_usuario usuario)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "INSERT INTO USUARIO(nome, senha, operacional, administ, menu01, menu02, menu03, menu04, menu05, menu06, menu07, menu08, menu09, dtacri, dtasen) VALUES ('" + usuario.nome + "','" + usuario.senha +"','"+ usuario.operacional+"','" + usuario.administ + "','" + usuario.menu01 + "','" + usuario.menu02 + "','" + usuario.menu03 + "','" + usuario.menu04 + "','" + usuario.menu05 + "','" + usuario.menu06 + "','" + usuario.menu07 + "','" + usuario.menu08 + "','" + usuario.menu09 + "','" + usuario.dtacri + "','" + usuario.dtasen + "') RETURNING codigo").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(cls_usuario usuario)
        {
            try
            {
                return acessoMySql.ExecutarManipulacao(CommandType.Text, "UPDATE USUARIO SET nome = '" + usuario.nome + "', senha = '" + usuario.senha + "', operacional = " + usuario.operacional + ", administ = " + usuario.administ + ", menu01 = '" + usuario.menu01 + "', menu02 = '" + usuario.menu02 + "', menu03 = '" + usuario.menu03 + "', menu04 = '" + usuario.menu04 + "', menu05 = '" + usuario.menu05 + "', menu06 = '" + usuario.menu06 + "', menu07 = '" + usuario.menu07 + "', menu08 = '" + usuario.menu08 + "', menu09 = '" + usuario.menu09 + "', dtacri = '" + usuario.dtacri.ToString() + "', dtasen = '" + usuario.dtasen.ToString() + "' WHERE is_usuario = " + usuario.id + " RETURNING is_usuario").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(cls_usuario usuario)
        {
            try
            {
                acessoMySql.ExecutarManipulacao(CommandType.Text, "DELETE FROM USUARIO WHERE di_usuario = " + usuario.id);
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public cls_usuarioColecao TodosUsuario()
        {
            try
            {
                //Criação de uma coleão nova de clientes (aqui está vazio)
                cls_usuarioColecao usuarioColecao = new cls_usuarioColecao();

                DataTable dataTableUsuario = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT id_usuario, nome, senha, operacional, administ, menu01, menu02, menu03, menu04, menu05, menu06, menu07, menu08, menu09, dtacri, dtasen FROM USUARIO ORDER BY id_usuario");

                //Faz um conjunto de coleção
                foreach (DataRow linha in dataTableUsuario.Rows)
                {
                    //Criar um cliente vazio
                    cls_usuario usuario = new cls_usuario();

                    //Colocar os dados da linha nele           
                    usuario.id = Convert.ToInt32(linha["id_usuario"]);
                    usuario.nome = linha["nome"].ToString();
                    usuario.senha = linha["senha"].ToString();
                    usuario.operacional = Convert.ToBoolean(linha["operacional"]);
                    usuario.administ = Convert.ToBoolean(linha["administ"]);
                    usuario.menu01 = Convert.ToChar(linha["menu01"]);
                    usuario.menu02 = Convert.ToChar(linha["menu02"]);
                    usuario.menu03 = Convert.ToChar(linha["menu03"]);
                    usuario.menu04 = Convert.ToChar(linha["menu04"]);
                    usuario.menu05 = Convert.ToChar(linha["menu05"]);
                    usuario.menu06 = Convert.ToChar(linha["menu06"]);
                    usuario.menu07 = Convert.ToChar(linha["menu07"]);
                    usuario.menu08 = Convert.ToChar(linha["menu08"]);
                    usuario.menu09 = Convert.ToChar(linha["menu09"]);
                    usuario.dtacri = Convert.ToDateTime(linha["dtacri"]);
                    usuario.dtasen = Convert.ToDateTime(linha["dtasen"]);

                    //Adicionar ele na coleção    
                    usuarioColecao.Add(usuario);                                                
                }

                return usuarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Usuarios.\nDetalhes: " + ex.Message);
            }
        }

        //public cls_usuarioColecao nomeUsuario(int codUsuario)
        //{
        //    try
        //    {
        //        //Criação de uma coleão nova de clientes (aqui está vazio)
        //        cls_garconColecao garconColecao = new cls_garconColecao();

        //        DataTable dataTableGarcon = acessoMySql.ExecutarConsulta(CommandType.Text, "SELECT gorgeta FROM GARCON WHERE codigo = " + codGarcon);

        //        //Faz um conjunto de coleção
        //        foreach (DataRow linha in dataTableGarcon.Rows)
        //        {
        //            //Criar um cliente vazio
        //            cls_garcon garcon = new cls_garcon();

        //            //Colocar os dados da linha nele                                              
        //            garcon.Codigo = Convert.ToInt32(linha["codigo"]);
        //            garcon.Nome = Convert.ToString(linha["nome"]);

        //            garcon.Gorgeta = Convert.ToInt32(linha["gorgeta"]);

        //            //Adicionar ele na coleção                                                    
        //            garconColecao.Add(garcon);
        //            break;
        //        }

        //        return garconColecao;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Não foi possível carregar os Garçons.\nDetalhes: " + ex.Message);
        //    }
        //}

    }
}
