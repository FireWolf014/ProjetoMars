using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MySqlX.XDevAPI.Common;
using ServiceStack.DataAnnotations;

namespace ProjetoMars

{
    class Conect
    {
        private MySqlConnection objconect = new MySqlConnection();

        private MySqlCommand objComandos = new MySqlCommand();

        private MySqlDataAdapter objDadosEmMemoria;
        
        
        private string msgErro;
        private string strDeConect;
        private int lastId;


        public Conect(string server, string dataBase, string user, string password)
        {
           
            strDeConect = "Persist Security info=false;";
            strDeConect += $"Server='{server}';";
            strDeConect += $"Database='{dataBase}';";
            strDeConect += $"User='{user}';";
            strDeConect += $"Pwd='{password}';";


        }
        public int getLastId()
        {
            return this.lastId;
        }
        private bool conectar()
        {
            try 
            {
                desconectar();
                objconect.ConnectionString = strDeConect;
                objComandos.Connection = objconect;
                objconect.Open();
                return true;
            }
            catch (Exception erro)
            {
                msgErro = erro.Message.ToString();
                return false;
            }
        }

        private bool desconectar()
        {
            try
            {
                if(objconect.State == ConnectionState.Open)
                {
                    objconect.Close();
                }
                return true;
            }
            catch (Exception erro)
            {
                this.msgErro = erro.Message.ToString();
                return false;
            }
        }

        public string getMsgErro()
        {
            return this.msgErro;
        }

        public bool testConect()
        {
            return conectar();
        }

        public bool INSERT(string comandoSql )
        {
            try
            {
                bool blnRetorn = false;
                if (this.conectar())
                {
                    objComandos.CommandText = comandoSql;
                    int result = objComandos.ExecuteNonQuery();
                    if (result > 0) 
                    {
                        blnRetorn = true;
                    }
                    else
                    {
                        msgErro = "Erro na Inclusãode dados\nNenhum dado novo incluido";
                    }

                }
                if (blnRetorn)
                {
                    //this.lastId = Convert.ToInt32(SELECT_1("SELECT LAST_INSERT_ID()")[0, 0]);
                }
                return blnRetorn;
            }
            catch(Exception erro) 
            {
                msgErro = erro.Message.ToString();
                return false;
            }
           
        }

        public bool UPDATE(string comandoSql)
        {
            try
            {
               
                if (conectar())
                {
                    objComandos.CommandText = comandoSql;
                    int result = objComandos.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }

                    msgErro = "Erro na Alterações de dados";

                }
                return false;
            }
            catch (Exception erro) 
            {
            
                msgErro = erro.Message.ToString();
                return false;                                       
            }
        }

        public bool DELETE(string comandoSql)
        {
            try
            {
                
                if (conectar())
                {
                    objComandos.CommandText = comandoSql;
                    int result = objComandos.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    msgErro = "Erro na exclusão de dados";
                }
                return false;
            }
            catch (Exception erro)
            {
                msgErro = erro.Message.ToString();
                return false;
            }
        }

        public DataTable SELECT(string comandoSql)
        {
            try
            {
                if (conectar())
                {
                    objDadosEmMemoria = new MySqlDataAdapter(comandoSql, objconect);
                    DataTable tabelaDeDados = new DataTable();
                    objDadosEmMemoria.Fill(tabelaDeDados);
                    if(tabelaDeDados.Rows.Count > 0)
                    {
                        return tabelaDeDados;
                    }
                }
                return null;
            }
            catch(Exception erro)
            {
                msgErro = erro.Message.ToString();
                return null;
            }
        }

        
    }
}
