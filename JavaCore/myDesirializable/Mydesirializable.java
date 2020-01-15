package Deserialization;

import java.io.*;
import java.util.HashMap;
import java.util.Map;

/*
После десериализации объекта класса Mydesirializable обнаружили, что данных в словаре [m] нет :(

Исправить 1 ошибку.

Требования:
•	В классе Mydesirializable не должно быть метода void Mydesirializable без параметров.
•	В классе Mydesirializable должен существовать конструктор без параметров.
•	В классе Mydesirializable должен существовать метод size без параметров.
•	В классе Mydesirializable метод size должен возвращать значение типа int.
*/
public class Mydesirializable implements Serializable {

    public static void main(String args[]) throws Exception {
        FileOutputStream fileOutput = new FileOutputStream("your.file.name");
        ObjectOutputStream outputStream = new ObjectOutputStream(fileOutput);

        Mydesirializable mydesirializable = new Mydesirializable();
        outputStream.writeObject(mydesirializable);

        fileOutput.close();
        outputStream.close();

        //load
        FileInputStream fiStream = new FileInputStream("your.file.name");
        ObjectInputStream objectStream = new ObjectInputStream(fiStream);

        Mydesirializable loadedObject = (Mydesirializable) objectStream.readObject();

        fiStream.close();
        objectStream.close();

        //Attention!!
        System.out.println(loadedObject.size());
    }

    private static Map<String, String> m = new HashMap<>();


    public Map<String, String> getMap() {
        return m;
    }

    static{
        m.put("Mickey", "Mouse");
        m.put("Mickey", "Mantle");
    }

    public int size() {
        return m.size();
    }
}
