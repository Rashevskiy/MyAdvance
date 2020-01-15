package NullObjectPattern;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

/*
Требования:
•	Конструктор Solution должен инициализировать поле fileData объектом ConcreteFileData.
•	Если в конструкторе Solution возникла ошибка, нужно инициализировать поле fileData объектом NullFileData.
•	Конструктор Solution должен корректно устанавливать значение поля hidden у объекта ConcreteFileData.
•	Конструктор Solution должен корректно устанавливать значение поля executable у объекта ConcreteFileData.
•	Конструктор Solution должен корректно устанавливать значение поля directory у объекта ConcreteFileData.
•	Конструктор Solution должен корректно устанавливать значение поля writable у объекта ConcreteFileData.
*/
public class Solution {
    private FileData fileData;

    public Solution(String pathToFile) {
        Path path = Paths.get(pathToFile);
        try {
            fileData = new ConcreteFileData(Files.isHidden(path), Files.isExecutable(path), Files.isDirectory(path), Files.isWritable(path));
        } catch (IOException e) {
            fileData = new NullFileData(e);
        }
    }

    public FileData getFileData() {
        return fileData;
    }
}
