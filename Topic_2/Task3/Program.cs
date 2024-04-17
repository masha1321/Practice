namespace Task3
{
    using System;
    using System.Collections.Generic;

    public abstract class Документ
    {
        public string Номер { get; set; }
        public DateTime Дата { get; set; }
    }

    public class Квитанция : Документ
    {
        public decimal Сумма { get; set; }
        public string Получатель { get; set; }
    }

    public class Накладная : Документ
    {
        public string Поставщик { get; set; }
        public string Получатель { get; set; }
        public List<string> Товары { get; set; }
    }

    public class Счет : Документ
    {
        public string Плательщик { get; set; }
        public decimal Сумма { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Квитанция квитанция = new Квитанция
            {
                Номер = "123",
                Дата = DateTime.Now,
                Сумма = 1000m,
                Получатель = "Зайко М.А."
            };

            Накладная накладная = new Накладная
            {
                Номер = "456",
                Дата = DateTime.Now,
                Поставщик = "ООО 'Маша и Полина'",
                Получатель = "ООО 'Дертень'",
                Товары = new List<string> { "Товар1", "Товар2", "Товар3" }
            };

            Счет счет = new Счет
            {
                Номер = "789",
                Дата = DateTime.Now,
                Плательщик = "Дершен П.Ю.",
                Сумма = 2000m
            };

            Console.WriteLine($"Квитанция:\nНомер: {квитанция.Номер}\nДата: {квитанция.Дата}\nСумма: {квитанция.Сумма}\nПолучатель: {квитанция.Получатель}");
            Console.WriteLine($"Накладная:\nНомер: {накладная.Номер}\nДата: {накладная.Дата}\nПоставщик: {накладная.Поставщик}\nПолучатель: {накладная.Получатель}\nТовары: {string.Join(", ", накладная.Товары)}");
            Console.WriteLine($"Счет:\nНомер: {счет.Номер}\nДата: {счет.Дата}\nПлательщик: {счет.Плательщик}\nСумма: {счет.Сумма}");
        }
    }
}