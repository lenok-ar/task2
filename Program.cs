namespace task3
{
    public class Document
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public List<string> Keyword { get; set; }
        public string Subject { get; set; }
        public string FilePash { get; set; }

        public virtual void ReturnInformation()
        {
            Console.WriteLine($"Название: {Name}\nАвтор: {Author}\nКлючевые слова: {Keyword}\nТематика: {Subject}\nПуть к файлу: {FilePash}");
        }
    }

    public class MsWord : Document
    {
        public string fontName { get; set; }

        public override void ReturnInformation()
        {
            base.ReturnInformation();
            Console.WriteLine($"Шрифт: {fontName}");
        }
    }

    public class PDF : Document
    {
        public int pageCount { get; set; }

        public override void ReturnInformation()
        {
            base.ReturnInformation();
            Console.WriteLine($"Количество страниц: {pageCount}");
        }
    }

    public class MsExcel : Document
    {
        public int cellCount { get; set; }

        public override void ReturnInformation()
        {
            base.ReturnInformation();
            Console.WriteLine($"Количество ячеек: {cellCount}");
        }
    }

    public class TXT : Document
    {
        public int rowsCount { get; set; }

        public override void ReturnInformation()
        {
            base.ReturnInformation();
            Console.WriteLine($"Количество строк: {rowsCount}");
        }
    }

    public class HTML : Document
    {
        public bool isHasImage { get; set; }

        public override void ReturnInformation()
        {
            base.ReturnInformation();
            Console.WriteLine($"Изображение: {isHasImage}");
        }
    }

    internal class Program
    {
        static void Main ()
        {

        }
    }
}
