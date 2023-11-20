using Marcketplace.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Marcketplace.Controllers
{
    public class ctlCarrinhoRepository
    {
        //Método Adicionar da classe Carrinho Repository
        private void btnAdicionar (object sender, EventArgs e)
        {
            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "INSERT INTO Carrinho(data, valortotal, statuspedido, cliente) Values (@data,@valototal,@statuspedido ,@cliente)";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

               
                var pmtdata = cmd.CreateParameter();
                pmtnome.ParameterName = "@data";
                pmtnome.DbType = System.Data.DbType.DateTime;
                pmtnome.Value = mdlCarrinho.data;
                cmd.Parameters.Add(pmtnome);

                var pmtvalortotal = cmd.CreateParameter();
                pmtnome.ParameterName = "@valortotal";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlCarrinho.valortotal;
                cmd.Parameters.Add(pmtnome);

                var pmtstatuspedido = cmd.CreateParameter();
                pmtnome.ParameterName = "@statuspedido";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlCarrinho.statuspedido;
                cmd.Parameters.Add(pmtnome);

                var pmtcliente = cmd.CreateParameter();
                pmtnome.ParameterName = "@cliente";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlCarrinho.cliente;
                cmd.Parameters.Add(pmtnome);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaobd.Close();
                    return true;
                }
                else
                {
                    conexaobd.Close();
                    return false;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }


        }
    }
}