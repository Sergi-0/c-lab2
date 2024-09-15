using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }
    class ProDocumentWorker: DocumentWorker {
            public override void EditDocument()
            {
                Console.WriteLine("Документ отредактирован");
            }
            public override void SaveDocument() {
                Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
            } 
    }

    class ExpertDocumentWorker: ProDocumentWorker {
            public override void SaveDocument() {
                Console.WriteLine("Документ сохранен в новом формате");
            }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker worker = new DocumentWorker();
            Console.WriteLine("Введите ключ доступа(pro или exp), если ключа нет - оставьте поле незаполненным!");
            string key = Console.ReadLine();
            if (key == "pro") worker = new ProDocumentWorker();
            else if (key == "exp") worker = new ExpertDocumentWorker();
            worker.SaveDocument();
            Console.ReadLine();
        }
        
    }
}
