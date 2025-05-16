public interface IXmlParser<T>
{
    T Parse(string data);
    String ConvertToXml(T obj);
}
