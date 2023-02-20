Console.WriteLine("Hello, World!");

LinqQueries queries = new LinqQueries();

PrintValues(queries.AllTheCollection());

void PrintValues(IEnumerable<Book> bookList)
{
    Console.WriteLine("{0,-60} {1,11} {2, 15}\n", "Title", "Pages", "Published Date");
    foreach(var item in bookList)
    {
        Console.WriteLine("{0,-60} {1,11} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}