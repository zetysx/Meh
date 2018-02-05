/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sample.struts2;

import java.util.List;
import sample.TblInfo.TblInfoDAO;
import sample.TblInfo.TblInfoDTO;

/**
 *
 * @author Administrator
 */
public class ViewHomeAction {
    private TblInfoDTO welcome;
    private List<TblInfoDTO> entries;
    private final String SUCCESS = "success";
    
    public ViewHomeAction() {
    }
    
    public String execute() throws Exception {
        TblInfoDAO dao =new TblInfoDAO();
        welcome=dao.viewWelcome();
        entries=dao.viewHomeEntries();
        return SUCCESS;
    }

    public TblInfoDTO getWelcome() {
        return welcome;
    }

    public void setWelcome(TblInfoDTO welcome) {
        this.welcome = welcome;
    }

    public List<TblInfoDTO> getEntries() {
        return entries;
    }

    public void setEntries(List<TblInfoDTO> entries) {
        this.entries = entries;
    }
    
    
}
