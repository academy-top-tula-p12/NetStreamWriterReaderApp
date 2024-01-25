// NetStreamWriterReaderApp
using System.IO;
using System.Text;

string fileName = "file01.txt";
string text = "В следующем примере показано, как использовать StreamWriter объект для записи файла со списком каталогов на диске C, а затем использовать StreamReader объект для чтения и отображения каждого имени каталога. Рекомендуется использовать эти объекты в операторе using , чтобы неуправляемые ресурсы были правильно удалены. Инструкция using автоматически вызывает Dispose объект после завершения кода, который ее использует. Конструктор, используемый в этом примере, не поддерживается для использования в приложениях Магазина Windows.";
string textHello = "Hello world";

int number = 10354;
float x = 143.780F;
double y = 23.789423e3;


/*
* Write(string)
* WriteLine(string)
* 
* WriteAsync(string)
* WriteLineAsync(string)
* 
*/

//using (StreamWriter writer = new(fileName))
//{
//    writer.WriteLine(text);
//    writer.WriteLine(number);
//    writer.WriteLine(x);
//    writer.WriteLine(y);
//}

using(StreamReader reader = new StreamReader(fileName))
{
    //var txtRead = reader.ReadToEnd();
    //Console.WriteLine(txtRead);

    while(true)
    {
        //string line = reader.ReadLine();
        //if (line == null)
        //    break;
        //Console.WriteLine(line);
        //Console.WriteLine(new string('-', 20));


        var symbol = reader.Read();
        if (symbol == -1) break;
        Console.WriteLine((char)symbol);

    }
}
    


