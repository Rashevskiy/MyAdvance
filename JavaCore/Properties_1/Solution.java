package Properties_1;

import java.io.IOException;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Properties;

/*
Реализовать метод getProperties, который должен считывать свойства из переданного файла fileName.
fileName может иметь любое расширение - как xml, так и любое другое, или вообще не иметь.
Нужно обеспечить корректное чтение свойств.
При возникновении ошибок должен возвращаться пустой объект.
Метод main не участвует в тестировании.

Подсказка: возможно тебе понадобится File.separator.

Требования:
•	Класс Solution должен содержать метод Properties getProperties(String fileName).
•	Метод getProperties должен корректно считывать свойства из xml-файла.
•	Метод getProperties должен корректно считывать свойства из любого другого файла с любым расширением.
•	Метод getProperties должен возвращать пустой объект, если во время чтения свойств возникла ошибка.
*/
public class Solution {
    public static void main(String[] args) {
        Solution solution = new Solution();
        Properties properties = solution.getProperties("4.JavaCollections/src/com/javarush/task/task31/task3109/properties.xml");
        properties.list(System.out);

        properties = solution.getProperties("4.JavaCollections/src/com/javarush/task/task31/task3109/properties.txt");
        properties.list(System.out);

        properties = solution.getProperties("4.JavaCollections/src/com/javarush/task/task31/task3109/notExists");
        properties.list(System.out);
    }

    public Properties getProperties(String fileName) {
        Path path1 = Paths.get(fileName);

        Properties prop = new Properties();
        InputStream inputStream = null;

        try {
            prop.loadFromXML(inputStream = Files.newInputStream(path1));
        }
        catch (NullPointerException m) {return prop;}

        catch (IOException e) {

            try {
                prop.load(inputStream = Files.newInputStream(path1));
            }
            catch (Exception ex) {
                return prop;
            }
        }
        return prop;
    }
}
