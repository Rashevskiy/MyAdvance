package nioFileInfo;
/*
Напиши программу, которая будет считать подробную информацию о папке и выводить ее на консоль.

Первым делом считай путь к папке с консоли.
Если введенный путь не является директорией - выведи "[полный путь] - не папка" и заверши работу.
Затем посчитай и выведи следующую информацию:

Всего папок - [количество папок в директории и поддиректориях]
Всего файлов - [количество файлов в директории и поддиректориях]
Общий размер - [общее количество байт, которое хранится в директории]

Используй только классы и методы из пакета java.nio.

Квадратные скобки [ ] выводить на экран не нужно.

 */


//import java.io.File;
//import java.nio.file.*;
//
//public class Solution {
//    public static String DirectoryPath = "D:\\myDirectory(DELETE)";
//
//
//    public static void main(String[] args) {
////        Path path = Paths.get(DirectoryPath);
//        FileVisitor fileVisitor = new SimpleFileVisitor();
//        File file = new File(DirectoryPath);
//        if(!file.isDirectory()){
//            System.out.println(file.getAbsolutePath());
//        }
//        Path path = Paths.get(DirectoryPath);
//        Files.walkFileTree(path, )
//
//
//    }
//}
