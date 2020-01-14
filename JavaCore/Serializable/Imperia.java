package Serializable;

import java.io.Serializable;

public class Imperia implements Serializable {
    private String Name;
    private String[] territoryInfo;
    private String[] incomeInfo;
    private String[] diplomacyInfo;

    public Imperia(String Name,String[] territoryInfo, String[] incomeInfo, String[] diplomacyInfo) {
        this.Name = Name;
        this.territoryInfo = territoryInfo;
        this.incomeInfo = incomeInfo;
        this.diplomacyInfo = diplomacyInfo;
    }

    public void setName(String name) {
        Name = name;
    }

    @Override
    public String toString() {
        String text = "HashCode =  " +  this.hashCode() + "\n";
        text += "ObjectName =  " +  this.Name + "\n";
        text += "ClassName =  " +  this.getClass() + "\n";
        for(String i : territoryInfo){
            text += i + ", ";
        }
        text += "\n";
        for(String i : incomeInfo){
            text += i + ", ";
        }
        text += "\n";
        for(String i : diplomacyInfo){
            text += i + ", ";
        }
        return text;
    }
}
