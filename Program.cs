using balta.BaltaContext;
using System;
using System.Collections.Generic;

namespace balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("artigo de c# basico", "http://bailta.io"));
            articles.Add(new Article("artigo de c# intermediario", "http://bailta.io"));
            articles.Add(new Article("artigo de c# avançado", "http://bailta.io"));


            //foreach(var article in articles)
            //{
            //    Console.WriteLine(article.Id);
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);
            //}


            var courses = new List<Couser>();
            var courseOOP = new Couser("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Couser("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Couser("Fundamentos ASP.NET", "fundamentos-aspnet");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);


            //foreach (var courser in courses)
            //{
            //    Console.WriteLine(courser.Id);
            //    Console.WriteLine(courser.Title);
            //    Console.WriteLine(courser.Url);
            //}


            var carrers = new List<Career>();

            var carrerDotnet = new Career("especialista em c#", "http://balta.io");
            var carrerItem = new CareerItem(1, "curso c# basico","uma descrição aqui", null);
            carrerDotnet.Items.Add(carrerItem);

            carrers.Add(carrerDotnet);

            foreach(var carrer in carrers)
            {
                Console.WriteLine(carrer.Title);
                foreach(var item in carrer.Items)
                {
                    Console.WriteLine($"{item.Order} - {item.Title} - {item.Description} - {item.Couser.Title}");
                }
            }
        }
    }
}
