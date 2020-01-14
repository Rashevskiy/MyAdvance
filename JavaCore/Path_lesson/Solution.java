package Path_lesson;

import java.io.IOException;
import java.nio.file.Path;
import java.nio.file.Paths;

/*
Почитай про все методы класса Path.
Найди такой, который создает относительный путь между текущим и переданным путем.
Реализуй логику метода getDiffBetweenTwoPaths, он должен возвращать относительный путь.
Метод main не участвует в тестировании.

Требования:
•	Класс Solution должен содержать метод Path getDiffBetweenTwoPaths(Path path1, Path path2).
•	Метод Path getDiffBetweenTwoPaths(Path path1, Path path2) должен быть статическим.
•	Метод getDiffBetweenTwoPaths должен возвращать относительный путь между первым аргументом и вторым.
•	Для реализации метода getDiffBetweenTwoPaths используй правильный метод объекта Path.
*/
public class Solution {
    public static void main(String[] args) throws IOException {
//        Path path1 = Paths.get("D:/test/data/firstDir");
//        Path path2 = Paths.get("D:/test/data/secondDir/third");
        Path path1 = Paths.get("F:\\MyProgramm\\");
        Path path2 = Paths.get("F:\\MyProgramm\\JavaRushCore\\src\\");
        Path resultPath = getDiffBetweenTwoPaths(path1, path2);
        System.out.println(resultPath);   //expected output '../secondDir/third' or '..\secondDir\third'
    }

    public static Path getDiffBetweenTwoPaths(Path path1, Path path2) {
            Path diffirentPath = path1.relativize(path2);
        return diffirentPath;
    }
}
