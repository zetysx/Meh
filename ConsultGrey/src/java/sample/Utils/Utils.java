/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sample.Utils;

import java.sql.Connection;
import java.sql.SQLException;
import javax.naming.Context;
import javax.naming.InitialContext;
import javax.naming.NamingException;
import javax.sql.DataSource;

/**
 *
 * @author Administrator
 */
public class Utils {
    public static Connection getConnection() throws NamingException, SQLException {
        Context c=new InitialContext();
        DataSource ds= (DataSource) c.lookup("java:comp/env/MEH");
        Connection con=ds.getConnection();
        return con;
    }
}
