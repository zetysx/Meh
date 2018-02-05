/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sample.TblInfo;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import javax.naming.NamingException;
import sample.Utils.Utils;

/**
 *
 * @author Administrator
 */
public class TblInfoDAO {
    public TblInfoDTO viewWelcome() throws NamingException, SQLException {
        Connection con=null;
        PreparedStatement stm=null;
        ResultSet rs=null;
        TblInfoDTO dto = null;
        String sql="Select * From tblInfo Where page like ? and title like ?";
        try {
           con=Utils.getConnection();
           stm=con.prepareStatement(sql);
           stm.setString(1, "Home");
           stm.setString(2, "Welcome");
           rs=stm.executeQuery();
           while(rs.next()) {
               String title=rs.getString("title");
               String des=rs.getString("description");
               String path=rs.getString("picturePath");
               dto=new TblInfoDTO(title, des, path);
           }
        } finally {
            if(rs!=null)  rs.close();
            if(stm!=null) stm.close();
            if(con!=null) con.close();
        }
        return dto;
    }
    public List<TblInfoDTO> viewHomeEntries() throws NamingException, SQLException {
        Connection con=null;
        PreparedStatement stm=null;
        ResultSet rs=null;
        List<TblInfoDTO> listdto = new ArrayList<>();
        String sql="Select * From tblInfo Where page like ? and not title like ?";
        try {
           con=Utils.getConnection();
           stm=con.prepareStatement(sql);
           stm.setString(1, "Home");
           stm.setString(2, "Welcome");
           rs=stm.executeQuery();
           while(rs.next()) {
               String title=rs.getString("title");
               String des=rs.getString("description");
               String path=rs.getString("picturePath");
               listdto.add(new TblInfoDTO(title, des, path));
           }
        } finally {
            if(rs!=null)  rs.close();
            if(stm!=null) stm.close();
            if(con!=null) con.close();
            
        }
        return listdto;
    }
}
