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
    public class ctlVendedor
    {
        public bool Cadastrar(mdlVendedor mdlVendedor)
        {

            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "INSERT INTO Vendedor(razaosocial, nomefantasia, cnpj, email, senha, comissao, endereco) Values (@razaosocial,@nomefantasia,@cnpj,@email,@senha,@comissao, @endereco)";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

                var pmtnome = cmd.CreateParameter();
                pmtnome.ParameterName = "@razaosocial";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.razaosocial;
                cmd.Parameters.Add(pmtnome);

                var pmtnomefantasia = cmd.CreateParameter();
                pmtnome.ParameterName = "@nomefantasia";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlVendedor.nomefantasia;
                cmd.Parameters.Add(pmtnome);

                var pmtcnpj = cmd.CreateParameter();
                pmtnome.ParameterName = "@cnpj";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.cnpj;
                cmd.Parameters.Add(pmtnome);

                var pmtemail = cmd.CreateParameter();
                pmtnome.ParameterName = "@email";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.email;
                cmd.Parameters.Add(pmtnome);

                var pmtsenha = cmd.CreateParameter();
                pmtnome.ParameterName = "@senha";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.senha;
                cmd.Parameters.Add(pmtnome);

                var pmtcomissao = cmd.CreateParameter();
                pmtnome.ParameterName = "@comissao";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.comissao;
                cmd.Parameters.Add(pmtnome);

                var pmtendereco = cmd.CreateParameter();
                pmtnome.ParameterName = "@endereco";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.endereco;
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
        public List<mdlVendedor> BuscarID(ID)
        {
            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "Select * from Vendedor where id = @ID";
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

        public bool Alterar(mdlVendedor mdlVendedor)
        {
            try
            {
                string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
                OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
                conexaobd.Open();

                string query = "UPDATE Vendedor SET nome = @nome, nomefantasia = @nomefantasia , cnpj = @cnpj, email = #email , senha = @senha , comissao = @comissao, endereco = @endereco WHERE id = @ID";
                OleDbCommand cmd = new OleDbCommand(query, conexaobd);

                var pmtnome = cmd.CreateParameter();
                pmtnome.ParameterName = "@nome";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.nome;
                cmd.Parameters.Add(pmtnome);

                var pmtnomefantasia = cmd.CreateParameter();
                pmtnome.ParameterName = "@nomefantasia";
                pmtnome.DbType = System.Data.DbType.Decimal;
                pmtnome.Value = mdlVendedor.nomefantasia;
                cmd.Parameters.Add(pmtnome);

                var pmtcnpj = cmd.CreateParameter();
                pmtnome.ParameterName = "@cnpj";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.cnpj;
                cmd.Parameters.Add(pmtnome);

                var pmtemail = cmd.CreateParameter();
                pmtnome.ParameterName = "@email";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.email;
                cmd.Parameters.Add(pmtnome);

                var pmtsenha = cmd.CreateParameter();
                pmtnome.ParameterName = "@senha";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.senha;
                cmd.Parameters.Add(pmtnome);

                var pmtcomissao = cmd.CreateParameter();
                pmtnome.ParameterName = "@comissao";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.comissao;
                cmd.Parameters.Add(pmtnome);

                var pmtendereco = cmd.CreateParameter();
                pmtnome.ParameterName = "@endereco";
                pmtnome.DbType = System.Data.DbType.String;
                pmtnome.Value = mdlVendedor.endereco;
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
    public bool Delete(mdlVendedor mdlVendedor)
    {
        try
        {
            string ConnectionString3 = ConfigurationManager.ConnectionStrings["ConnectionString3"].ToString();
            OleDbConnection conexaobd = new OleDbConnection(ConnectionString3);
            conexaobd.Open();

            string query = "DELETE Vendedor WHERE id = @ID";
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
