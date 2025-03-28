namespace task2
{
    public class Document
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Keyword { get; set; }
        public string Subject { get; set; }
        public string FilePash { get; set; }
        
        public virtual void GetInformation()
        {
            Console.Write("Введите название файла: ");
            Name = Console.ReadLine();
            Console.Write("Введите автора: ");
            Author = Console.ReadLine();
            Console.Write("Введите ключевые слова: ");
            Keyword = Console.ReadLine();
            Console.Write("Введите тематику: ");
            Subject = Console.ReadLine();
            Console.Write("Введите путь к файлу: ");
            FilePash = Console.ReadLine();
        }

        public virtual void ReturnInformation()
        {
            Console.WriteLine($"\nНазвание: {Name}\nАвтор: {Author}\nКлючевые слова: {Keyword}\nТематика: {Subject}\nПуть к файлу: {FilePash}");
        }

    }

    public class MsWord : Document
    {
        public string fontName { get; set; }

        public override void GetInformation()
        {
            base.GetInformation();
            Console.Write("Введите шрифт: ");
            fontName = Console.ReadLine();
        }

        public override void ReturnInformation()
        {
            base.ReturnInformation();
            Console.WriteLine($"Шрифт: {fontName}");
        }
    }

    public class PDF : Document
    {
        public int pageCount { get; set; }

        public override void GetInformation()
        {
            base.GetInformation();
            Console.Write("Количество страниц: ");
            pageCount = Convert.ToInt32(Console.ReadLine());
        }

        public override void ReturnInformation()
        {
            base.ReturnInformation();
            Console.WriteLine($"Количество страниц: {pageCount}");
        }
    }

    public class MsExcel : Document
    {
        public int cellCount { get; set; }

        public override void GetInformation()
        {
            base.GetInformation();
            Console.Write("Количество ячеек: ");
            cellCount = Convert.ToInt32(Console.ReadLine());
        }

        public override void ReturnInformation()
        {
            base.ReturnInformation();
            Console.WriteLine($"Количество ячеек: {cellCount}");
        }
    }

    public class TXT : Document
    {
        public int rowsCount { get; set; }

        public override void GetInformation()
        {
            base.GetInformation();
            Console.Write("Количество строк: ");
            rowsCount = Convert.ToInt32(Console.ReadLine());
        }
        
        public override void ReturnInformation()
        {
            base.ReturnInformation();
            Console.WriteLine($"Количество строк: {rowsCount}");
        }
    }

    public class HTML : Document
    {
        public string isHasImage { get; set; }

        public override void GetInformation()
        {
            base.GetInformation();
            Console.Write("Изображение: ");
            isHasImage = Console.ReadLine();
        }

        public override void ReturnInformation()
        {
            base.ReturnInformation();
            Console.WriteLine($"Изображение (да/нет): {isHasImage}");
        }
    }

    internal class Program
    {
        static void Main ()
        {
            while (true)
            {
                string choice;

                Console.WriteLine("\n1 - MS Word\n2 - PDF\n3 - MS Excel\n4 - TXT\n5 - HTML");
                Console.Write("Выберите тип файла: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MsWord word = new MsWord();
                        word.GetInformation();
                        word.ReturnInformation();
                        break;

                    case "2":   
                        PDF pdf = new PDF();
                        pdf.GetInformation();
                        pdf.ReturnInformation();
                        break;

                    case "3":
                        MsExcel excel = new MsExcel();
                        excel.GetInformation();
                        excel.ReturnInformation();
                        break;

                    case "4":
                        TXT txt = new TXT();
                        txt.GetInformation();
                        txt.ReturnInformation();
                        break;

                    case "5":
                        HTML html = new HTML(); 
                        html.GetInformation();
                        html.ReturnInformation();
                        break;

                    default:
                        Console.Write("Введен неизвестный тип файла");
                        break;
                }

            }
        }
    }
}
