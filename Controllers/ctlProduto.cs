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

                string query = "INSERT INTO Produto(nome, cpf, email, senha, endereco) Values (@Nome,@cpf,@email,@senha,@endereco)";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

                var pmtnome = cmd.CreateParameter();
                pmtnome.ParameterName = "@nome";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.nome;
                cmd.Parameters.Add(pmtnome);

                var pmtcpf = cmd.CreateParameter();
                pmtnome.ParameterName = "@cpf";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlProduto.cpf;
                cmd.Parameters.Add(pmtnome);

                var pmtemail = cmd.CreateParameter();
                pmtnome.ParameterName = "@email";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.email;
                cmd.Parameters.Add(pmtnome);

                var pmtsenha = cmd.CreateParameter();
                pmtnome.ParameterName = "@senha";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.senha;
                cmd.Parameters.Add(pmtnome);

                var pmtendereco = cmd.CreateParameter();
                pmtnome.ParameterName = "@endereco";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.endereco;
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

                string query = "Select * from Produto where Produto.id = ID";
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

                string query = "UPDATE Produto SET nome = @nome, cpf = @cpf , email = @email, senha = #senha , endereco = @endereco WHERE Produto.id = ID";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

                var pmtnome = cmd.CreateParameter();
                pmtnome.ParameterName = "@nome";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.nome;
                cmd.Parameters.Add(pmtnome);

                var pmtcpf = cmd.CreateParameter();
                pmtnome.ParameterName = "@cpf";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlProduto.cpf;
                cmd.Parameters.Add(pmtnome);

                var pmtemail = cmd.CreateParameter();
                pmtnome.ParameterName = "@email";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.email;
                cmd.Parameters.Add(pmtnome);

                var pmtsenha = cmd.CreateParameter();
                pmtnome.ParameterName = "@senha";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.senha;
                cmd.Parameters.Add(pmtnome);

                var pmtendereco = cmd.CreateParameter();
                pmtnome.ParameterName = "@endereco";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlProduto.endereco;
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
