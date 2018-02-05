/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sample.TblInfo;

/**
 *
 * @author Administrator
 */
public class TblInfoDTO {
    private String title;
    private String description;
    private String imgPath;

    public TblInfoDTO(String title, String description, String imgPath) {
        this.title = title;
        this.description = description;
        this.imgPath = imgPath;
    }

    
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getImgPath() {
        return imgPath;
    }

    public void setImgPath(String imgPath) {
        this.imgPath = imgPath;
    }
    
    
}
