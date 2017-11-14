using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OutpatientRegistrationSystem
{
    class sqlHelper
    {
        public SqlConnection getcon()
        {
            string sqlstr = "Server=(local); Database=OPRSBase; Integrated Security=sspi";
            // string sqlstr = "server=111.145.10.17; Initial Catalog=OPRSBase; User ID=sa; Password=3150707012";
            SqlConnection myconn = new SqlConnection(sqlstr);
            return myconn;
        }
        public int getcom(string tempstr)
        {
            int rowAffected = 0;
            SqlConnection sqlconn = this.getcon();
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand(tempstr, sqlconn);
            rowAffected = sqlcom.ExecuteNonQuery();
            sqlconn.Close();
            sqlconn.Dispose(); 
            return rowAffected;
        }
        public SqlDataReader getread(string tempstr)
        {
            SqlConnection sqlconn = this.getcon();
            SqlCommand sqlcom = new SqlCommand(tempstr, sqlconn);
            sqlconn.Open();
            SqlDataReader sqlread = sqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            return sqlread;
        }
        public DataSet getds(string tempstr, string temptable)
        {
            SqlConnection mycon = this.getcon();
            SqlDataAdapter myadapter = new SqlDataAdapter(tempstr, mycon);
            DataSet myds = new DataSet();
            myadapter.Fill(myds, temptable);
            return myds;
        }
        public DataSet getys(string tempsqlstr, string tempsqltable)
        {
            SqlConnection myconn = this.getcon();
            SqlDataAdapter da = new SqlDataAdapter(tempsqlstr, myconn);
            DataSet ds = new DataSet();
            da.Fill(ds, tempsqltable);
            return ds;
        }
    }
}
