static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach (T obj in collection)
    {

        Console.WriteLine(obj);
    }
    Console.WriteLine();
}


Category c1 = new Category() { ID = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { ID = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { ID = 3, Name = "Electronics", Tier = 1 };

List<Product> products = new List<Product>()
{
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
};


//var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900); //criando coleção, pegando os valores de produtts onde o x.Category.Tier =1  && tal tal tal;
var r1 = from p in products // em p atribui products, cada produto da lista ele chama de p
         where p.Category.Tier == 1 && p.Price < 900.0 // onde categoria for igual a 1 e preço menor que 900.00
         select p; // escolhe o que vai apra nova coleção, quero o produto inteiro

Print("TIER 1 AND PRICE < 900: ", r1);

//var r2 = products.Where(y => y.Category.Name == "Tools").Select(y => y.Name); //to abrindo a lista de products onde o nome da categoria é tools e estou selecionando para a coleção somente pegar nome
//select transforma pra string;

var r2 =
    from p in products
    where p.Category.Name == "Tools"
    select p.Name; // pega somente o name

Print("NAMES OF PRODUCTS FROM TOOLS", r2);

//var r3 = products.Where(p => p.Name[0] == 'C').Select(p=> new {p.Name, p.Price,CategoryName = p.Category.Name});
var r3 =
    from p in products
    where p.Name[0] == 'C'
    select new { p.Name, p.Price, CategoryName = p.Category.Name };

Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

//var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p=>p.Name);
var r4 =
    from p in products
    where p.Category.Tier == 1
    orderby p.Name
    orderby p.Price // tem que ser ao contrario, primeiro ele ta vendo o preço depois o nome
    select p;

Print("TIER 1 ORDER BY PRICE THEN ANONYMOUS OBJECT", r4);

//var r5 = r4.Skip(2).Take(4); // pula dois e pega 4 elementos da lista
var r5 =
    (from p in r4 //pegando o resultado de r4
     select p).Skip(4).Take(4);

Print("SKIP 2 TAKE 4", r5);

var r6 = products.First();    //pega o primeiro elemento da lista
Console.WriteLine("FIRST TEST1 \n" + r6);

var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault(); //pega o primeiro ou nada

Console.WriteLine("\nFIRTS OR DEFAULT");
Console.WriteLine(r7);

var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); //pega somente um elemento ou nada;
Console.WriteLine("\nSINGLE OR DEFAULT TEST 1 \n" + r8);

var r9 = products.Where(p => p.Id == 20).SingleOrDefault(); //pega somente um elemento ou nada;
Console.WriteLine("\nSINGLE OR DEFAULT TEST 1 \n" + r9);

var r10 = products.Max(p => p.Price); // pega o max
Console.WriteLine("MAX PRICE: " + r10);

var r11 = products.Min(p => p.Price); // pega o max
Console.WriteLine("MIN PRICE: " + r11);

var r12 = products.Where(p => p.Category.ID == 1).Sum(p => p.Price); //onde  categoria id for 1, soma p.price
Console.WriteLine("\nCATEGORY 1 SUM PRICES: " + r12);

var r13 = products.Where(p => p.Category.ID == 1).Average(p => p.Price);  //pega a média
Console.WriteLine("\nCATEGORY 1 AVERAGE PRICES: " + r13);

var r14 = products.Where(p => p.Category.ID == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // onde o ID for 5 , pegar o preço, se nao tiver nada estabeleça o valor 0.0;
Console.WriteLine("DEFAULT IF EMPTY: " + r14);

var r15 = products.Where(p => p.Category.ID == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y); //aggregate para acrescentar uma nova função, ela recebe dois parametros x e y e faz a soma deles, 0 ali só para iniciar já com o valor, caso não tenha nada esse valor será atribuido
// x e y são dois objetos diferentes dentro de products, ele percorre toda a lista e faz x e y dai;
Console.WriteLine("\nCATEGORY 1 AGGREGATE SUM: " + r15);
Console.WriteLine();

var r16 = products.GroupBy(p => p.Category);  //separa em grupos com mesma categoria varios produtos( ele pega um elemento de dentro de produtos para ser a chave e dentro de cada chave especifica tem todos os detalhes do produto)
foreach (IGrouping<Category, Product> group in r16) // o grupo tem como cabeça de chave uma categoria e dentro delas, vários produtos que são dessa categoria ;
{
    Console.WriteLine("Category " + group.Key.Name + ":");  //aqui ele faz o foreach pra circular todas as cabeaças de chave, ele printa a que ta no momento

    foreach (Product p in group)
    {

        Console.WriteLine(p); //aqui printa os produtos dentro da cabeça de chave

    }
    Console.WriteLine();

}