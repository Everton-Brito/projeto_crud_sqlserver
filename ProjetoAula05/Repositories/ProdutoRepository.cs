using Dapper;
using ProjetoAula05.Configurations;
using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Repositories
{
    public class ProdutoRepository
    {
        //método para cadastrar um produto no banco de dados
        public void Create(Produto produto)
        {
            //comando SQL para inserir produto no banco de dados
            var sql = @"
                INSERT INTO PRODUTO(
                    IDPRODUTO,
                    NOME,
                    PRECO,
                    QUANTIDADE,
                    DATACADASTRO)
                VALUES(
                    @IdProduto,
                    @Nome,
                    @Preco,
                    @Quantidade,
                    @DataCadastro)
            ";

            //conectar no banco de dados
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                //executando o comando SQL no banco de dados
                connection.Execute(sql, produto);
            }
        }

        //método para atualizar um produto no banco de dados
        public void Update(Produto produto)
        {
            var sql = @"
                UPDATE PRODUTO 
                SET
                    NOME = @Nome,
                    PRECO = @Preco,
                    QUANTIDADE = @Quantidade
                WHERE
                    IDPRODUTO = @IdProduto
            ";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                connection.Execute(sql, produto);
            }
        }

        //método para excluir um produto no banco de dados
        public void Delete(Produto produto)
        {
            var sql = @"
                DELETE FROM PRODUTO
                WHERE IDPRODUTO = @IdProduto
            ";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                connection.Execute(sql, produto);
            }
        }

        //método para retornar uma lista com todos os produtos
        //cadastrados na base de dados
        public List<Produto> GetAll()
        {
            var sql = @"
                SELECT * FROM PRODUTO
                ORDER BY NOME
            ";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                return connection.Query<Produto>(sql).ToList();
            }
        }

        //método para retornar 1 produto baseado no ID
        public Produto GetById(Guid idProduto)
        {
            var sql = @"
                SELECT * FROM PRODUTO
                WHERE IDPRODUTO = @idProduto
            ";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                return connection.Query<Produto>(sql, new { idProduto }).FirstOrDefault();
            }

        }
    }
}



