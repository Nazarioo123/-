namespace ПрактичнаНазаріяЛіщинського_ІТ_41
{
    using System;

    public class TextEditor
    {
        // Властивість для збереження тексту 
        public string DocumentText { get; private set; } = "";

        // Метод для додавання тексту
        public void AddText(string txt)
        {
            DocumentText += txt;
        }

        // Метод для друку тексту
        public void Print(IPrinter printer)
        {
            printer.Print(DocumentText);
        }
    }

    // Інтерфейс 
    public interface IPrinter
    {
        void Print(string text);
    }

    // Клас UppercasePrinter друкує текст великими літерами
    public class UppercasePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text.ToUpper());
        }
    }

    
    public class LowercasePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text.ToLower());
        }
    }

    
    class Program
    {
        static void Main()
        {
             
            TextEditor editor = new TextEditor();

            // Додавання тексту
            editor.AddText("Hello, World!");

            // Друк тексту у верхньому регістрі
            UppercasePrinter uppercasePrinter = new UppercasePrinter();
            editor.Print(uppercasePrinter);

            // Друк тексту у нижньому регістрі
            LowercasePrinter lowercasePrinter = new LowercasePrinter();
            editor.Print(lowercasePrinter);
        }
    }

}
