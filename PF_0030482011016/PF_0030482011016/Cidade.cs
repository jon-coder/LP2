using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace PF_0030482011016
{
    class Cidade
    {
        private int idcidade;
        private string nomecidade;
        private string ufcidade;

        public int Idcidade
        {
            get
            {
                return idcidade;
            }
            set
            {
                idcidade = value;
            }
        }

        public string Nomecidade
        {
            get
            {
                return nomecidade;
            }
            set
            {
                nomecidade = value;
            }
        }

        public string Ufcidade
        {
            get
            {
                return ufcidade;
            }
            set
            {
                ufcidade = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;

            DataTable dtCidade = new DataTable();

            try
            {
                daCidade = new SqlDataAdapter(
                    "SELECT * FROM TB_CIDADE",
                    Form1.conexao
                );
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int numeroRegistros;

                mycommand = new SqlCommand(
                    "INSERT INTO TB_CIDADE VALUES (@nome_cidade, @uf_cidade)",
                    Form1.conexao
                );

                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.Char));

                mycommand.Parameters["@nome_cidade"].Value = nomecidade;
                mycommand.Parameters["@uf_cidade"].Value = ufcidade;

                numeroRegistros = mycommand.ExecuteNonQuery();

                if (numeroRegistros > 0)
                {
                    retorno = numeroRegistros;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                int numeroRegistros = 0;

                mycommand = new SqlCommand(
                    "UPDATE TB_CIDADE SET nome_cidade = @nome_cidade, uf_cidade = @uf_cidade " +
                    "WHERE id_cidade = @id_cidade",
                    Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.Char));

                mycommand.Parameters["@id_cidade"].Value = idcidade;
                mycommand.Parameters["@nome_cidade"].Value = nomecidade;
                mycommand.Parameters["@uf_cidade"].Value = ufcidade;

                numeroRegistros = mycommand.ExecuteNonQuery();

                if (numeroRegistros > 0)
                {
                    retorno = numeroRegistros;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Excluir()
        {
            int numeroRegistros = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand(
                    "DELETE FROM TB_CIDADE WHERE " +
                    "id_cidade = @id_cidade", Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters["@id_cidade"].Value = Convert.ToInt16(idcidade);
                numeroRegistros = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return numeroRegistros;
        }
    }
}
