package FileClassTree;


import java.io.*;
import java.util.ArrayList;
import java.util.Comparator;

public class Solution {
    public static void main(String[] args) throws IOException {

        String path = "D:\\myDirectory"; // "d:/1";
        String resultFile = "D:\\myDirectory\\File1.txt"; // "d:/1.txt";

        ArrayList<File> list = new ArrayList<>();
        allFilesList(new File(path), list);


        Comparator<File> myComparator = new Comparator<File>() {
            @Override
            public int compare(File o1, File o2) {
                return o1.getName().compareTo(o2.getName());
            }
        };


        list.sort(myComparator);

        File resFile = new File(resultFile);
        File newNameFile = new File(resFile.getParent() + "\\" + "allFilesContent.txt");


        if (!FileUtils.isExist(resFile))
            resFile.createNewFile();

        if (FileUtils.isExist(newNameFile))
            newNameFile.delete();

        System.out.println("resFile " + resFile.getAbsolutePath());
        System.out.println("newNameFile " + newNameFile.getAbsolutePath());
        FileUtils.renameFile(resFile, newNameFile);

        resFile = newNameFile;


        FileOutputStream fos = new FileOutputStream(resFile);

        for (File fls : list) {

            FileInputStream fis = new FileInputStream(fls);

            byte[] ar = new byte[fis.available()];

            fis.read(ar);

            fos.write(ar);
            fos.write(10);

            fis.close();
        }


        fos.close();


    }

    public static void allFilesList(File path, ArrayList<File> resultList) throws IOException {


        File[] files = path.listFiles();


        for (File fls : files) {
//            System.out.println(fls.getName());
            if (fls.isDirectory()) {
//                System.out.println("fls.isDirectory");
                allFilesList(fls, resultList);
            }
            else {
                if (fls.getName().endsWith(".txt")) {

                    if (fls.length() <= 50L)
                        resultList.add(fls);

                }
            }


        }


    }
}
