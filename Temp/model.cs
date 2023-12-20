using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

interface IModel {
  int Id { get; set; }
}

class Model<T> where T : IModel {
  protected static List<T> objetos = new List<T>();
  private static string arquivo = typeof(T).ToString() + ".xml";

  public static void ToXML() {
    XmlSerializer xml = new XmlSerializer(typeof(List<T>));
    StreamWriter f = new StreamWriter(arquivo);
    xml.Serialize(f, objetos);
    f.Close();
  }
  public static void FromXML() {
    try {
      XmlSerializer xml = new XmlSerializer(typeof(List<T>));
      StreamReader f = new StreamReader(arquivo);
      objetos = (List<T>) xml.Deserialize(f);
      f.Close();
    }
    catch (FileNotFoundException)
    {
    }
  }
  public static virtual void Inserir(T p) {
    FromXML();
    int id = 0;
    foreach(T obj in objetos) 
      if (obj.Id > id) id = obj.Id;
    p.Id = id + 1;
    objetos.Add(p);
    ToXML();
  }
  public static List<T> Listar() {
    FromXML();
    return objetos;
  }
  public static T Listar(T p) {
    FromXML();
    foreach(T obj in objetos) 
      if (obj.Id == p.Id) return obj;
    return default(T);
  }
  public static void Atualizar(T p) {
    FromXML();
    T obj = Listar(p);
    if (obj != null) {
      objetos.Remove(obj);
      objetos.Add(p);
    }
    ToXML();
  }
  public static void Excluir(T p) {
    FromXML();
    T obj = Listar(p);
    if (obj != null) objetos.Remove(obj);
    ToXML();
  }
}

