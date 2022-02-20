

using MySql.Data.MySqlClient;

var connection = new MySqlConnection("server=db;database=dbexemplo;uid=usuario;pwd=senha");
connection.Open();

Console.WriteLine($"Conectado com sucesso | MySQL version : {connection.ServerVersion}");

connection.Close();
