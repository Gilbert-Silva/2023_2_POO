import java.lang.reflect.Array;
import java.util.Arrays;

public class Ex03 {
  public static void main(String[] args) {
    Colecao<String> l = new Colecao(String.class);
    l.pushBack("Teste");
    l.pushBack("1");
    l.pushBack("2");
    l.pushBack("3");
    while (l.size() > 0)
      System.out.println(l.popBack());
  }
}

class Colecao<T> {
  private T[] objs;
  private int k;
  public Colecao(Class<T> classType) {
    objs = (T[]) Array.newInstance(classType, 50);
  }
  public void pushBack(T obj) {
    if (k < 50) objs[k++] = obj;
  }
  public T popBack() {
    if (k > 0) return objs[--k];
    return null;
  }
  public int size() {  
    return k;
  }
}
