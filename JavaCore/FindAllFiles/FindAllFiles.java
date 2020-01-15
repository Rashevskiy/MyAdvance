package FindAllFiles;
import java.io.File;
import java.io.IOException;
import java.util.*;

/*
Находим все файлы и папки в указанной папке
*/
public class FindAllFiles {
    public static List<String> getFileTree(String root) throws IOException {
        File path = new File(root);
        List<String> result = new ArrayList<>();
        Queue<File> fileQueue = new PriorityQueue<>();

        Collections.addAll(fileQueue, path.listFiles());

        while (!fileQueue.isEmpty()) {
            File currentFile = fileQueue.remove();
            if (currentFile.isDirectory()) {
                Collections.addAll(fileQueue, currentFile.listFiles());
            } else {
                result.add(currentFile.getAbsolutePath());
            }
        }

        return result;
    }

    public static void main(String[] args) throws IOException {
        List<String> myList = getFileTree("D:\\myDirectory\\");
        for(String i : myList){
            System.out.println(i);
        }
    }
}
