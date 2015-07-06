using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace basedato
{
    public class mysqlbasedato
    {
        public MySqlConnection cn;
        private DataTable dt;
        private Boolean entransaccion = false;
        private MySqlTransaction tr;
        public String errormsg = "";
        public mysqlbasedato(String servidor, String basedato, String usuario, String password)
        {
            MySqlConnectionStringBuilder cnsb = new MySqlConnectionStringBuilder();
            cnsb.Database = basedato;
            cnsb.Password = password;
            cnsb.Server = servidor;
            cnsb.UserID = usuario;
            this.cn = new MySqlConnection(cnsb.ConnectionString);
            this.cn.Open();
        }
        public object getvalor()
        {
            try
            {
                return dt.Rows[0][0];
            }
            catch (Exception ex)
            {
                errormsg = ex.Message;
                return null;
            }
        }
        public DataTable gettabla()
        {
            try
            {
                errormsg = "";
                return dt;
            }
            catch (Exception ex)
            {
                errormsg = ex.Message;
                return null;
            }
        }
        public Int16 ejecutar(String sql)
        {
            try
            {
                MySqlCommand cm = new MySqlCommand(sql, this.cn);
                if (entransaccion == true)
                {
                    cm.Transaction = this.tr;
                    cm.ExecuteNonQuery();
                }
                else
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cm);
                    dt = new DataTable();
                    da.Fill(dt);
                }
                errormsg = "";
                return 1;
            }
            catch (Exception ex)
            {
                errormsg = ex.Message;
                if (entransaccion == true)
                    this.tr.Rollback();
                this.entransaccion = false;
                return 0;
            }
        }
        public Int16 ejecutar(MySqlCommand cm)
        {
            try
            {
                cm.Connection = this.cn;
                if (entransaccion == true)
                {
                    cm.Transaction = this.tr;
                    cm.ExecuteNonQuery();
                }
                else
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cm);
                    dt = new DataTable();
                    da.Fill(dt);
                }
                errormsg = "";
                return 1;
            }
            catch (Exception ex)
            {
                this.errormsg = ex.Message;
                if (entransaccion == true)
                    this.tr.Rollback();
                this.entransaccion = false;
                return 0;
            }
        }
        public Boolean transaccion
        {
            get
            {
                return this.entransaccion;
            }
        }
        public void begin_transaction()
        {
            entransaccion = true;
            this.tr = this.cn.BeginTransaction();
        }
        public void commit_transaction()
        {
            this.tr.Commit();
            this.entransaccion = false;
        }
    }
}
