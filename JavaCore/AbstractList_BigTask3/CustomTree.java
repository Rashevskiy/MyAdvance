package AbstractList_BigTask3;

import java.io.Serializable;
import java.util.AbstractList;
import java.lang.*;
import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

/*
ЗАДАЧА 2
Несмотря на то что наше дерево является потомком класса AbstractList, это не список в привычном понимании.
В частности нам недоступны принимающие в качестве параметра индекс элемента.
Такие методы необходимо переопределить и бросить новое исключение типа UnsupportedOperationException.

Вот их список:
public String get(int index)
public String set(int index, String element)
public void add(int index, String element)
public String remove(int index)
public List<String> subList(int fromIndex, int toIndex)
protected void removeRange(int fromIndex, int toIndex)
public boolean addAll(int index, Collection<? extends String> c)

Требования:
При попытке вызвать метод get(int index) должно возникать исключение типа UnsupportedOperationException.
При попытке вызвать метод set(int index, String element) должно возникать исключение типа UnsupportedOperationException.
При попытке вызвать метод add(int index, String element) должно возникать исключение типа UnsupportedOperationException.
При попытке вызвать метод String remove(int index) должно возникать исключение типа UnsupportedOperationException.
При попытке вызвать метод subList(int fromIndex, int toIndex) должно возникать исключение типа UnsupportedOperationException.
При попытке вызвать метод removeRange(int fromIndex, int toIndex) должно возникать исключение типа UnsupportedOperationException.
При попытке вызвать метод addAll(int index, Collection<? extends String> c) должно возникать исключение типа UnsupportedOperationException.
 */
/*
ЗАДАЧА 3
Класс описывающий дерево мы создали, теперь нужен класс описывающий тип элементов дерева:
1.  В классе CustomTree создай вложенный статический параметризированный класс Entry<T> с модификатором доступа по умолчанию.
2. Обеспечь поддержку этим классом интерфейса Serializable.
3. Создай такие поля (модификатор доступа по умолчанию):
- String elementName;
- boolean availableToAddLeftChildren, availableToAddRightChildren;
- Entry<T> parent, leftChild, rightChild;
- при необходимости, можешь создавать и другие поля;
4. Реализуй публичный конструктор с одним параметром типа String:
- установи поле elementName равным полученному параметру;
- установи поле availableToAddLeftChildren равным true;
- установи поле availableToAddRightChildren равным true;
5. Реализуй публичный метод boolean isAvailableToAddChildren, возвращающий дизъюнкцию полей availableToAddLeftChildren и availableToAddRightChildren.

Требования:
•	Класс CustomTree.Entry должен быть объявлен с модификатором доступа по умолчанию.
•	Класс CustomTree.Entry должен поддерживать интерфейс Serializable.
•	В классе CustomTree.Entry должно существовать поле elementName типа String.
•	В классе CustomTree.Entry должно существовать поле availableToAddLeftChildren типа boolean.
•	В классе CustomTree.Entry должно существовать поле availableToAddRightChildren типа boolean.
•	В классе CustomTree.Entry должно существовать поле parent типа Entry.
•	В классе CustomTree.Entry должно существовать поле leftChild типа Entry.
•	В классе CustomTree.Entry должно существовать поле rightChild типа Entry.
•	В классе CustomTree.Entry должен быть корректно реализован конструктор с одним параметром типа String (смотри условие).
•	В классе CustomTree.Entry должен корректно реализован метод isAvailableToAddChildren (смотри условие).
 */
/*
ЗАДАЧА 4
Любое дерево начинается с корня, поэтому не забудь в класс CustomTree добавить поле root типа Entry<String> c модификатором доступа по умолчанию.

Инициируй его в конструкторе CustomTree, имя (elementName) не важно.

Итак, основа дерева создана, пора тебе поработать немного самому.

Вспомним как должно выглядеть наше дерево.

Элементы дерева должны следовать так как показано на картинке:

Необходимо написать методы, которые бы позволили создать такую структуру дерева и проводить операции над ней.

Тебе необходимо:
1) переопределить метод add(String s) - добавляет элементы дерева, в качестве параметра принимает имя элемента (elementName), искать место для вставки начинаем слева направо.
2) переопределить метод size() - возвращает текущее количество элементов в дереве.
3) реализовать метод getParent(String s) - возвращает имя родителя элемента дерева, имя которого было полученного в качестве параметра.

Если необходимо, можешь вводить дополнительные методы и поля, не указанные в задании.

Требования:
•	В классе CustomTree должно существовать поле root типа Entry.
•	В классе CustomTree должны быть переопределены методы add(String s) и size().
•	После добавления N элементов в дерево с помощью метода add, метод size должен возвращать N.
•	Метод getParent должен возвращать имя родителя для любого элемента дерева.
 */
/*
ЗАДАЧА 5
Добавлять в дерево элементы мы можем, теперь займись удалением:

Необходимо реализовать метод remove(Object o), который будет удалять элемент дерева имя которого было полученного в качестве параметра.

Если переданный объект не является строкой, метод должен бросить UnsupportedOperationException.

Если в дереве присутствует несколько элементов с переданным именем - можешь удалить только первый найденный.

Не забывай сверять поведение своего дерева с картинкой:
Что будет если удалить из дерева элементы "3", "4", "5" и "6", а затем попытаемся добавить новый елемент?

В таком случае элементы "1" и "2" должны восстановить возможность иметь потомков (возможно придется внести изменения в метод add()).
Требования:
•	После удаления последнего добавленного элемента из дерева с помощью метода remove, метод size должен возвращать N-1.
•	После удаления второго элемента добавленного в дерево, метод size должен возвращать N/2 + 1 (для случаев где N > 2 и является степенью двойки), N - размер дерева до удаления.
•	Если переданный объект не является строкой, метод remove() должен бросить UnsupportedOperationException.
•	Если ни один элемент не способен иметь потомков, необходимо восстановить такую возможность.
 */
public class CustomTree extends AbstractList<String>
        implements Cloneable, Serializable {

    Entry<String> root;
    private ArrayList<Entry> treeArr = new ArrayList<>();

    static class Entry<T> implements Serializable{
        String elementName;
        boolean availableToAddLeftChildren;
        boolean availableToAddRightChildren;
        Entry<T> parent;
        Entry<T> leftChild;
        Entry<T> rightChild;

        public Entry(String data){
            this.elementName = data;
            this.availableToAddLeftChildren = true;
            this.availableToAddRightChildren = true;
        }
        public boolean isAvailableToAddChildren() {
            return availableToAddLeftChildren || availableToAddRightChildren;
        }
    }

    public CustomTree(){
        root = new Entry<>("0");
        treeArr.add(0, root);
    }

    public boolean remove(Object o) {
        if(!(o instanceof String))
            throw new UnsupportedOperationException();

        String elementName = (String) o;

        //Перебираем лист, пропуская root
        for(int i = 1; i < treeArr.size(); i++) {

            Entry nextEntry = treeArr.get(i);
            //Находим необходимую для удаления запись
            if(nextEntry.elementName.equals(elementName)) {

                //Удаляем найденную запись и ее детей
                removeChilds(nextEntry);
                treeArr.remove(i);

                //восстанавливаем возможность добавить левого или правого ребенка
                Entry parent = nextEntry.parent;

                if(parent.leftChild.elementName == elementName) {
                    parent.availableToAddLeftChildren = true;
                    parent.leftChild = null;
                } else {
                    parent.availableToAddRightChildren = true;
                    parent.rightChild = null;
                }
            }
        }


        return true;
    }

    private void removeChilds(Entry entry) {
        List<Entry> childs = new ArrayList<>();
        for(int i = 0;  i < treeArr.size(); i++) {
            Entry e = treeArr.get(i);
            if(e.elementName == entry.elementName) {
                Entry leftChild = e.leftChild;
                Entry rightChild = e.rightChild;

                if(leftChild != null) {
                    removeChilds(leftChild);
                    childs.add(leftChild);
                }

                if(rightChild != null) {
                    removeChilds(rightChild);
                    childs.add(rightChild);
                }
            }
        }
        treeArr.removeAll(childs);
    }

    @Override
    public String remove(int index) {
        throw new UnsupportedOperationException();
    }

    @Override
    public boolean addAll(int index, Collection<? extends String> c) {
        throw new UnsupportedOperationException();
    }

    @Override
    public List<String> subList(int fromIndex, int toIndex) {
        throw new UnsupportedOperationException();
    }

    @Override
    protected void removeRange(int fromIndex, int toIndex) {
        throw new UnsupportedOperationException();
    }

    @Override
    public boolean add(String element) {
        Entry current;
        Entry newEntry = new Entry(element);
        for(Entry i : treeArr){
            current = i;
            if(current.isAvailableToAddChildren()){
                if(current.leftChild == null){
                    current.leftChild = newEntry;
                    current.availableToAddLeftChildren = false;
                }else {
                    current.rightChild = newEntry;
                    current.availableToAddRightChildren = false;
                }
                newEntry.parent = current;
                treeArr.add(newEntry);
                return true;
            }
        }
        return false;
    }

    public String getParent(String s) {
        for (Entry item : treeArr) {
            if(item.elementName.equals(s))
                return item.parent.elementName;
        }
        return null;
    }

    @Override
    public String get(int index) {
        throw new UnsupportedOperationException();
    }

    @Override
    public String set(int index, String element) {
        return "Пошел на хуй";
    }

    @Override
    public int size() {
        int count=0;
        for(Entry e: this.treeArr) {
            if (e!=null) {
                count++;
            }
        }
        return count-1;
    }
}
