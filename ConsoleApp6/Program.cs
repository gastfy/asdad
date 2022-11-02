using System.Diagnostics;
using System.IO;

namespace ConsoleApp6
{
    internal class DopPunkt
    {
        public string Name;
        public string Price;
    }
    internal class Menu
    {
        private int positionMain;
        private string Form;
        private string Size;
        private string TasteOfCakeLayer;
        private string NumOfLayers;
        private string TasteOfDopping;
        private string Decor;


        public int PriceReturn(int pos)
        {
            int price = 0;
            int functionalPos = 2;
            Console.Clear();
            switch (pos)
            {
                case 3:
                    
                    while (true)
                    {
                        if (functionalPos < 2) { functionalPos = 2; }
                        if(functionalPos > 5) { functionalPos = 5; }


                        Console.WriteLine("Выберите одну из форм торта: ");
                        Console.WriteLine("----------------------------------------------");
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine("1. Круглый");
                        Console.SetCursorPosition(2, 3);
                        Console.WriteLine("2. Квадратный");
                        Console.SetCursorPosition(2, 4);
                        Console.WriteLine("3. Прямоугольный");
                        Console.SetCursorPosition(2, 5);
                        Console.WriteLine("4. В виде сердечка.");
                        Console.WriteLine("----------------------------------------------");

                        Console.SetCursorPosition(0, functionalPos);
                        Console.WriteLine("->");
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Escape) { break; }

                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            functionalPos--;
                        }
                        else if (key.Key == ConsoleKey.DownArrow)
                        {
                            functionalPos++;
                        }

                        if(key.Key == ConsoleKey.Enter)
                        {
                            switch (functionalPos)
                            {
                                case 2:
                                    price = 1000;
                                    Form = "Круглая форма";
                                    break;
                                case 3:
                                    price = 900;
                                    Form = "Квадратная форма";
                                    break;
                                case 4:
                                    price = 1300;
                                    Form = "Прямоугольная форма";
                                    break;
                                case 5:
                                    price = 2000;
                                    Form = "Форма в виде сердечка";
                                    break;
                            }
                            break;
                        }
                        Console.Clear();
                    }
                    break;

                    case 4:

                    while (true)
                    {
                        if (functionalPos < 2) { functionalPos = 2; }
                        if (functionalPos > 5) { functionalPos = 5; }


                        Console.WriteLine("Выберите один из размеров торта: ");
                        Console.WriteLine("----------------------------------------------");
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine("1. Маленький (Диаметр - 16 см.)");
                        Console.SetCursorPosition(2, 3);
                        Console.WriteLine("2. Средний (Диаметр - 18 см.)");
                        Console.SetCursorPosition(2, 4);
                        Console.WriteLine("3. Большой (Диаметр - 20 см.)");
                        Console.SetCursorPosition(2, 5);
                        Console.WriteLine("4. Огромный (Диаметр - 24 см.)");
                        Console.WriteLine("----------------------------------------------");

                        Console.SetCursorPosition(0, functionalPos);
                        Console.WriteLine("->");
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Escape) { break; }

                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            functionalPos--;
                        }
                        else if (key.Key == ConsoleKey.DownArrow)
                        {
                            functionalPos++;
                        }

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (functionalPos)
                            {
                                case 2:
                                    price = 600;
                                    Size = "Маленький размер (16 см в диаметре)";
                                    break;
                                case 3:
                                    price = 900;
                                    Size = "Средний размер (18 см в диаметре)";
                                    break;
                                case 4:
                                    price = 1300;
                                    Size = "Большой размер (20 см в диаметре)";
                                    break;
                                case 5:
                                    price = 2000;
                                    Size = "Огромный размер (24 см в диаметре)";
                                    break;
                            }
                            break;
                        }
                        Console.Clear();
                    }
                    break;
                    case 5:

                    while (true)
                    {
                        if (functionalPos < 2) { functionalPos = 2; }
                        if (functionalPos > 5) { functionalPos = 5; }


                        Console.WriteLine("Выберите один из вкусов коржей торта: ");
                        Console.WriteLine("----------------------------------------------");
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine("1. Клубничный");
                        Console.SetCursorPosition(2, 3);
                        Console.WriteLine("2. Шоколадный");
                        Console.SetCursorPosition(2, 4);
                        Console.WriteLine("3. Ванильный");
                        Console.SetCursorPosition(2, 5);
                        Console.WriteLine("4. Карамельный");
                        Console.WriteLine("----------------------------------------------");

                        Console.SetCursorPosition(0, functionalPos);
                        Console.WriteLine("->");
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Escape) { break; }

                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            functionalPos--;
                        }
                        else if (key.Key == ConsoleKey.DownArrow)
                        {
                            functionalPos++;
                        }

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (functionalPos)
                            {
                                case 2:
                                    price = 1200;
                                    TasteOfCakeLayer = "Клубничный вкус коржей";
                                    break;
                                case 3:
                                    price = 1200;
                                    TasteOfCakeLayer = "Шоколадный вкус коржей";
                                    break;
                                case 4:
                                    price = 1300;
                                    TasteOfCakeLayer = "Ванильный вкус коржей";
                                    break;
                                case 5:
                                    price = 1500;
                                    TasteOfCakeLayer = "Карамельный вкус коржей";
                                    break;

                            }
                            break;
                        }
                        Console.Clear();
                    }
                    break;
                    case 6:
                    while (true)
                    {
                        if (functionalPos < 2) { functionalPos = 2; }
                        if (functionalPos > 5) { functionalPos = 5; }


                        Console.WriteLine("Выберите количество коржей: ");
                        Console.WriteLine("----------------------------------------------");
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine("1. Один");
                        Console.SetCursorPosition(2, 3);
                        Console.WriteLine("2. Два");
                        Console.SetCursorPosition(2, 4);
                        Console.WriteLine("3. Три");
                        Console.SetCursorPosition(2, 5);
                        Console.WriteLine("4. Четыре");
                        Console.WriteLine("----------------------------------------------");

                        Console.SetCursorPosition(0, functionalPos);
                        Console.WriteLine("->");
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Escape) { break; }

                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            functionalPos--;
                        }
                        else if (key.Key == ConsoleKey.DownArrow)
                        {
                            functionalPos++;
                        }

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (functionalPos)
                            {
                                case 2:
                                    price = 300;
                                    NumOfLayers = "Один корж";
                                    break;
                                case 3:
                                    price = 500;
                                    NumOfLayers = "Два коржа";
                                    break;
                                case 4:
                                    price = 600;
                                    NumOfLayers = "Три коржа";
                                    break;
                                case 5:
                                    price = 800;
                                    NumOfLayers = "Четыре коржа";
                                    break;

                            }
                            break;
                        }
                        Console.Clear();
                    }
                    break;
                    case 7:
                    while (true)
                    {
                        if (functionalPos < 2) { functionalPos = 2; }
                        if (functionalPos > 5) { functionalPos = 5; }


                        Console.WriteLine("Выберите глазурь торта: ");
                        Console.WriteLine("----------------------------------------------");
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine("1. Безе");
                        Console.SetCursorPosition(2, 3);
                        Console.WriteLine("2. Шоколад");
                        Console.SetCursorPosition(2, 4);
                        Console.WriteLine("3. Ягоды");
                        Console.SetCursorPosition(2, 5);
                        Console.WriteLine("4. Крем");
                        Console.WriteLine("----------------------------------------------");
                        Console.SetCursorPosition(0, functionalPos);
                        Console.WriteLine("->");
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Escape) { break; }

                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            functionalPos--;
                        }
                        else if (key.Key == ConsoleKey.DownArrow)
                        {
                            functionalPos++;
                        }

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (functionalPos)
                            {
                                case 2:
                                    price = 700;
                                    TasteOfDopping = "Глазурь - Безе";
                                    break;
                                case 3:
                                    price = 800;
                                    TasteOfDopping = "Глазурь - Шоколад";
                                    break;
                                case 4:
                                    price = 800;
                                    TasteOfDopping = "Глазурь - Ягоды";
                                    break;
                                case 5:
                                    price = 700;
                                    TasteOfDopping = "Глазурь - Крем";
                                    break;

                            }
                            break;
                        }
                        Console.Clear();
                    }
                    break;
                    case 8:

                    while (true)
                    {
                        if (functionalPos < 2) { functionalPos = 2; }
                        if (functionalPos > 5) { functionalPos = 5; }


                        Console.WriteLine("Выберите декор торта: ");
                        Console.WriteLine("----------------------------------------------");
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine("1. Шоколадный");
                        Console.SetCursorPosition(2, 3);
                        Console.WriteLine("2. Ягодный");
                        Console.SetCursorPosition(2, 4);
                        Console.WriteLine("3. Кремовый");
                        Console.SetCursorPosition(2, 5);
                        Console.WriteLine("4. Микс (Шоколадный, ягодный и кремовый в одном)");
                        Console.WriteLine("----------------------------------------------");

                        Console.SetCursorPosition(0, functionalPos);
                        Console.WriteLine("->");
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Escape) { break; }

                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            functionalPos--;
                        }
                        else if (key.Key == ConsoleKey.DownArrow)
                        {
                            functionalPos++;
                        }

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (functionalPos)
                            {
                                case 2:
                                    price = 200;
                                    Decor = "Шоколадный декор";
                                    break;
                                case 3:
                                    price = 200;
                                    Decor = "Ягодный декор";
                                    break;
                                case 4:
                                    price = 200;
                                    Decor = "Кремовый декор";
                                    break;
                                case 5:
                                    price = 500;
                                    Decor = "Декор-микс (Шоколадный, ягодный и кремовый в одном)";
                                    break;

                            }
                            break;
                        }
                        Console.Clear();
                    }
                    break;


            }
            return price;
        }
        public List<string> infoPrint()
        {
            List<string> info = new List<string>();
            if(Form != null)
            {
                info.Add(Form);
            }
            if (Size != null)
            {
                info.Add(Size);
            }
            if (TasteOfCakeLayer != null)
            {
                info.Add(TasteOfCakeLayer);
            }
            if (NumOfLayers != null)
            {
                info.Add(NumOfLayers);
            }
            if (TasteOfDopping != null)
            {
                info.Add(TasteOfDopping);
            }
            if (Decor != null)
            {
                info.Add(Decor);
            }
            return info;
        }

        public int isExists(int pos)//Проверка на существующие параметры, возращаем отрицательное значение цены если 1
        {
            int priceless = 0;
            if(Form != null && pos == 3)
            {
                if(Form == "Круглая форма") { priceless += -1000; }
                if (Form == "Квадратная форма") { priceless += -900; }
                if (Form == "Прямоугольная форма") { priceless += -1300; }
                if (Form == "Форма в виде сердечка") { priceless += -2000; }
            }
            if(Size != null && pos == 4)
            {
                if(Size == "Маленький размер (16 см в диаметре)") { priceless += -600; }
                if(Size == "Средний размер (18 см в диаметре)") { priceless += -900; }
                if (Size == "Большой размер (20 см в диаметре)") { priceless += -1300; }
                if (Size == "Огромный размер (24 см в диаметре)") { priceless += -2000; }
            }
            if (TasteOfCakeLayer != null && pos == 5)
            {
                if(TasteOfCakeLayer == "Клубничный вкус коржей") { priceless += -1200; }
                if (TasteOfCakeLayer == "Шоколадный вкус коржей") { priceless += -1200; }
                if (TasteOfCakeLayer == "Ванильный вкус коржей") { priceless += -1300; }
                if (TasteOfCakeLayer == "Карамельный вкус коржей") { priceless += -1500; }
            }
            if (NumOfLayers != null && pos == 6)
            {
                if (NumOfLayers == "Один корж") { priceless += -300; }
                if (NumOfLayers == "Два коржа") { priceless += -500; }
                if (NumOfLayers == "Три коржа") { priceless += -600; }
                if (NumOfLayers == "Четыре коржа") { priceless += -800; }
            }
            if(TasteOfDopping != null && pos == 7)
            {
                if(TasteOfDopping == "Глазурь - Безе") { priceless += -700; }
                if (TasteOfDopping == "Глазурь - Шоколад") { priceless += -800; }
                if (TasteOfDopping == "Глазурь - Ягоды") { priceless += -800; }
                if (TasteOfDopping == "Глазурь - Крем") { priceless += -700; }
            }
            if(Decor != null && pos == 8)
            {
                if(Decor == "Шоколадный декор") { priceless += -200; }
                if (Decor == "Ягодный декор") { priceless += 200; }
                if (Decor == "Кремовый декор") { priceless += -200; }
                if (Decor == "Декор-микс") { priceless += -500; }
            }
            return priceless;
        }
    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            bool mainNoExit = true;
            while (mainNoExit)
            {
                int pos = 3;
                int AllPrice = 0;
                bool noExit = true;
                Menu m = new Menu();
                while (noExit)
                {
                    //Интерфейс.
                    if (pos < 3) { pos = 9; }
                    if (pos > 9) { pos = 3; }
                    Console.WriteLine("Вас приветствует Магазин Мега-Тортики!");
                    Console.WriteLine("Для заказа выберите характеристики торта снизу и нажмите \'Завершить покупку\'.");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.SetCursorPosition(2, 3);
                    Console.WriteLine("1. Выбрать форму торта.");
                    Console.SetCursorPosition(2, 4);
                    Console.WriteLine("2. Выбрать размер торта.");
                    Console.SetCursorPosition(2, 5);
                    Console.WriteLine("3. Выбрать вкус коржей торта.");
                    Console.SetCursorPosition(2, 6);
                    Console.WriteLine("4. Выбрать количество коржей.");
                    Console.SetCursorPosition(2, 7);
                    Console.WriteLine("5. Выбрать глазурь торта.");
                    Console.SetCursorPosition(2, 8);
                    Console.WriteLine("6. Выбрать декор торта.");
                    Console.SetCursorPosition(2, 9);
                    Console.WriteLine("7. Завершить покупку.");
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("Цена вашего торта: " + AllPrice);
                    Console.SetCursorPosition(0, 12);
                    List<string> list = new List<string>();
                    list = m.infoPrint();
                    string str = "";
                    foreach (string i in list)
                    {
                        str += (i + ". ");
                    }

                    Console.WriteLine("Ваш торт: " + str);

                    //Вывод стрелки
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape) { noExit = false; }

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        pos--;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        pos++;
                    }

                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (pos)
                        {
                            case 3:
                                AllPrice += m.isExists(3);
                                AllPrice += m.PriceReturn(pos);
                                break;
                            case 4:
                                AllPrice += m.isExists(4);
                                AllPrice += m.PriceReturn(pos);
                                break;
                            case 5:
                                AllPrice += m.isExists(5);
                                AllPrice += m.PriceReturn(pos);
                                break;
                            case 6:
                                AllPrice += m.isExists(6);
                                AllPrice += m.PriceReturn(pos);
                                break;
                            case 7:
                                AllPrice += m.isExists(7);
                                AllPrice += m.PriceReturn(pos);
                                break;
                            case 8:
                                AllPrice += m.isExists(8);
                                AllPrice += m.PriceReturn(pos);
                                break;
                            case 9:
                                string info = "Заказ от: " + Convert.ToString(DateTime.Now) + '\n' + "\tЗаказ: " + str + '\n' + "\tЦена: " + AllPrice + '.';
                                string path = "D:\\zakaz\\zakaz.txt";
                                if (!File.Exists(path))
                                {
                                    File.Create("D:\\zakaz\\zakaz.txt").Dispose();
                                    File.AppendAllText("D:\\zakaz\\zakaz.txt", info);
                                }
                                else { File.AppendAllText("D:\\zakaz\\zakaz.txt", '\n' + info); }
                                noExit = false;
                                break;
                        }
                    }
                    Console.Clear();
                }
                int position2 = 1;
                while (true)
                {
                    if(position2 < 1) { position2 = 1; }
                    if(position2 > 2) { position2 = 2; }
                    Console.WriteLine("Хотите сделать еще один заказ?");
                    Console.SetCursorPosition(2, 1);
                    Console.WriteLine("1. Да");
                    Console.SetCursorPosition(2, 2);
                    Console.WriteLine("1. Нет");
                    Console.SetCursorPosition(0, position2);
                    Console.WriteLine("->");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position2--;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        position2++;
                    }
                    if(key.Key == ConsoleKey.Enter)
                    {
                        if(position2 == 1) { Console.Clear(); break; }
                        if (position2 == 2) { mainNoExit = false; break; }
                    }
                    Console.Clear();
                }
            }
        }
    }
}