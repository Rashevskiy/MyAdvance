package NotSerializableException;
import java.io.*;

/*
Запрети сериализацию класса SubSolution используя NotSerializableException.
Сигнатуры классов менять нельзя.

Требования:
•	Класс Solution должен поддерживать интерфейс Serializable.
•	Класс SubSolution должен быть создан внутри класса Solution.
•	Класс SubSolution должен быть потомком класса Solution.
•	При попытке сериализовать объект типа SubSolution должно возникать исключение NotSerializableException.
•	При попытке десериализовать объект типа SubSolution должно возникать исключение NotSerializableException.
*/
public class Solution implements Serializable {




    public static class SubSolution extends Solution {
        SubSolution() throws NotSerializableException {
            throw new NotSerializableException();
        }
        
    }

    public static void main(String[] args) {
        FileOutputStream outputStream;
        ObjectOutputStream objectOutputStream = null;
        {
            try {
                outputStream = new FileOutputStream("C:\\Users\\Катализатор\\Desktop\\file1.txt");
                objectOutputStream = new ObjectOutputStream(outputStream);
                SubSolution subSolution = new SubSolution();
                objectOutputStream.writeObject(subSolution);
            } catch (FileNotFoundException e) {
                e.printStackTrace();
                System.out.println("1");
            } catch (IOException e) {
                e.printStackTrace();
                System.out.println("2");
            }
        }
    }
}
