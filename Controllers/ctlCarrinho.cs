using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.Configuration;
using System.Data.OleDb;
using Marcketplace.Models;
using System.Data;
using System.Globalization;



namespace Marcketplace.Controllers
{
    public class ctlCarrinho
    {
        public bool Cadastrar(mdlCarrinho mdlCarrinho)
        {

            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "INSERT INTO Carrinho(data, valortotal, statuspedido, cliente) Values (@data,@valototal,@statuspedido ,@cliente)";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

                var pmtnome = cmd.CreateParameter();
                pmtnome.ParameterName = "@data";
                pmtnome.DbType = System.Data.DbType.DateTime;
                pmtnome.Value = mdlCarrinho.data;
                cmd.Parameters.Add(pmtnome);

                var pmtcpf = cmd.CreateParameter();
                pmtnome.ParameterName = "@valortotal";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlCarrinho.valortotal;
                cmd.Parameters.Add(pmtnome);

                var pmtemail = cmd.CreateParameter();
                pmtnome.ParameterName = "@statuspedido";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlCarrinho.statuspedido;
                cmd.Parameters.Add(pmtnome);

                var pmtsenha = cmd.CreateParameter();
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
        public List<mdlCarrinho> BuscarID(ID)
        {
            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "Select * from Carrinho where Carrinho.id = ID";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);


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

        public bool Alterar(mdlCarrinho mdlCarrinho)
        {
            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "UPDATE Carrinho SET data = @data, valortotal = @valortotal , statuspedido = @statuspedido, cliente = #cliente  WHERE Carrinho.id = ID";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

                var pmtnome = cmd.CreateParameter();
                pmtnome.ParameterName = "@data";
                pmtnome.DbType = System.Data.DbType.DateTime;
                pmtnome.Value = mdlCarrinho.data;
                cmd.Parameters.Add(pmtnome);

                var pmtcpf = cmd.CreateParameter();
                pmtnome.ParameterName = "@valortotal";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlCarrinho.valortotal;
                cmd.Parameters.Add(pmtnome);

                var pmtemail = cmd.CreateParameter();
                pmtnome.ParameterName = "@statuspedido";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlCarrinho.statuspedido;
                cmd.Parameters.Add(pmtnome);

                var pmtsenha = cmd.CreateParameter();
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
    public bool Delete(mdlCarrinho mdlCarrinho)
    {
        try
        {
            string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
            OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
            conexaobd.Open();

            string query = "DELETE Carrinho WHERE Carrinho.id = ID";
            OleDbCommand cmd = new OleDbCommand(query, conexaobd);

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
