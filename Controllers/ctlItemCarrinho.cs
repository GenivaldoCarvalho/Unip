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
    public class ctlitemCarrinho
    {
        public bool Cadastrar(mdlitemCarrinho mdlitemCarrinho)
        {

            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "INSERT INTO itemCarrinho(quantidadte, total) Values (@quantidade,@total)";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

                var pmtquantidade = cmd.CreateParameter();
                pmtnome.ParameterName = "@quantidade";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlitemCarrinho.quantidade;
                cmd.Parameters.Add(pmtnome);

                var pmttotal = cmd.CreateParameter();
                pmtnome.ParameterName = "@total";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlitemCarrinho.total;
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
        public List<mdlitemCarrinho> BuscarID(ID)
        {
            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "Select * from itemCarrinho where itemCarrinho.id = ID";
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

        public bool Alterar(mdlitemCarrinho mdlitemCarrinho)
        {
            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "UPDATE itemCarrinho SET quantidade = @quantidade, total = @total WHERE itemCarrinho.id = ID";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

                var pmtnome = cmd.CreateParameter();
                pmtnome.ParameterName = "@qunatidade";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlitemCarrinho.nome;
                cmd.Parameters.Add(pmtnome);

                var pmtcpf = cmd.CreateParameter();
                pmtnome.ParameterName = "@total";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlitemCarrinho.cpf;
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
    public bool Delete(mdlitemCarrinho mdlitemCarrinho)
    {
        try
        {
            string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
            OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
            conexaobd.Open();

            string query = "DELETE itemCarrinho WHERE itemCarrinho.id = ID";
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
