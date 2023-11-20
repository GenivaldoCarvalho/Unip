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
    public class ctlProduto
    {
        public bool Cadastrar(mdlProduto mdlProduto)
        {

            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "INSERT INTO Produto(descricao, preco, imagem, status, vendedor, categoria) Values (@descricao,@preco,@imagem,@status,@vendedor,@categoria)";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

                var pmtdescricao = cmd.CreateParameter();
                pmtnome.ParameterName = "@descricao";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.descricao;
                cmd.Parameters.Add(pmtnome);

                var pmtpreco = cmd.CreateParameter();
                pmtnome.ParameterName = "@preco";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlProduto.preco;
                cmd.Parameters.Add(pmtnome);

                var pmtimagem = cmd.CreateParameter();
                pmtnome.ParameterName = "@imagem";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.imagem;
                cmd.Parameters.Add(pmtnome);

                var pmtstatus = cmd.CreateParameter();
                pmtnome.ParameterName = "@status";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.status;
                cmd.Parameters.Add(pmtnome);

                var pmtvendedor = cmd.CreateParameter();
                pmtnome.ParameterName = "@vendedor";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.vendedor;
                cmd.Parameters.Add(pmtnome);

                var pmtcategoria = cmd.CreateParameter();
                pmtnome.ParameterName = "@categoria";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.categoria;
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
        public List<mdlProduto> BuscarID(ID)
        {
            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "Select * from Produto where id = @ID";
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

        public bool Alterar(mdlProduto mdlProduto)
        {
            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "UPDATE Produto SET nome = @descricao, preco = @preco , imagem = @imagem, status = #status , vendedor = @vendedor , categoria = @categoria WHERE id = @ID";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

                var pmtdescricao = cmd.CreateParameter();
                pmtnome.ParameterName = "@descricao";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.descricao;
                cmd.Parameters.Add(pmtnome);

                var pmtpreco = cmd.CreateParameter();
                pmtnome.ParameterName = "@preco";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlProduto.preco;
                cmd.Parameters.Add(pmtnome);

                var pmtimagem = cmd.CreateParameter();
                pmtnome.ParameterName = "@imagem";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.imagem;
                cmd.Parameters.Add(pmtnome);

                var pmtstatus = cmd.CreateParameter();
                pmtnome.ParameterName = "@status";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.status;
                cmd.Parameters.Add(pmtnome);

                var pmtvendedor = cmd.CreateParameter();
                pmtnome.ParameterName = "@vendedor";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.vendedor;
                cmd.Parameters.Add(pmtnome);

                var pmtcategoria = cmd.CreateParameter();
                pmtnome.ParameterName = "@categoria";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.categoria;
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
    public bool Delete(mdlProduto mdlProduto)
    {
        try
        {
            string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
            OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
            conexaobd.Open();

            string query = "DELETE Produto WHERE Produto.id = ID";
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
