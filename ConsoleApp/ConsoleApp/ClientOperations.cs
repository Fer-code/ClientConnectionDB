using Azure;
using ConexaoComBDSQL_Teste;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;

public class ClientOperations
{
    Connection dbConnection = new Connection();

    public void Read()
    {
        dbConnection.Open();

        string query = "SELECT * FROM TBcliente";

        DataTable result = dbConnection.ExecuteQuery(query);

        foreach (DataRow row in result.Rows)
        {
            foreach (DataColumn col in result.Columns)
            {
                Console.Write(row[col] + "\t");
            }
            Console.WriteLine();
        }

        dbConnection.Close();

        Console.WriteLine("\n Aperte qualquer tecla para continuar");
        Console.ReadKey();
    }

    public void Write()
    {
        dbConnection.Open();

        Console.WriteLine("Insira o nome do cliente: ");
        string nomeC = Console.ReadLine();
        Console.WriteLine("Insira o email do cliente: ");
        string emailC = Console.ReadLine();

        try
        {
            string query = "INSERT INTO TBcliente (NomeCli, EmailCli) VALUES ('" + nomeC + "','" + emailC + "');";

            dbConnection.ExecuteNonQuery(query);

            Console.WriteLine("Operação realizada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        dbConnection.Close();

    }

    public void Update()
    {
        dbConnection.Open();

        Console.WriteLine("----Atualizar registros de um cliente----");
        Console.WriteLine("1-Atualizar o NOME do cliente");
        Console.WriteLine("2-Atualizar o EMAIL do cliente");
        Console.WriteLine("Insira o código da operacao: ");

        switch (Console.ReadLine())
        {
            case "1":

                try
                {
                    Console.WriteLine(" \n ID do registro que deseja alterar o nome: ");
                    int IDalter = int.Parse(Console.ReadLine());
                    Console.WriteLine("Novo nome para o cliente: ");
                    string novoNome = Console.ReadLine();

                    try
                    {
                        string query = "UPDATE TBcliente SET NomeCli='" + novoNome + "' WHERE IdCli = " + IDalter + ";";
                        dbConnection.ExecuteNonQuery(query);

                        Console.WriteLine(" \n Operação realizada com sucesso");
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                }
                catch (Exception ex) { Console.WriteLine(Console.ReadLine()); }

                break;

            case "2":

                try
                {
                    Console.WriteLine(" \n ID do registro que deseja alterar o email: ");
                    int IDalter = int.Parse(Console.ReadLine());
                    Console.WriteLine("Novo email para o cliente: ");
                    string novoEmail = Console.ReadLine();

                    try
                    {
                        string query = "UPDATE TBcliente SET EmailCli='" + novoEmail + "' WHERE IdCli = " + IDalter + ";";
                        dbConnection.ExecuteNonQuery(query);

                        Console.WriteLine(" \n Operação realizada com sucesso");
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                }
                catch (Exception ex) { Console.WriteLine(Console.ReadLine()); }

                break;
        }

       
        
    }

    public void Delete()
    {
        dbConnection.Open();

        Console.WriteLine("Insira o ID do cliente que será apagado: ");
        string IDcli = Console.ReadLine();

        try
        {
            string query = "DELETE FROM TBcliente WHERE IdCli = " + IDcli;
            dbConnection.ExecuteNonQuery(query);

            Console.WriteLine("Operação realizada com sucesso");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        dbConnection.Close();
    }
}