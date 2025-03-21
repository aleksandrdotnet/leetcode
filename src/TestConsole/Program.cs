using Spectre.Console;

static Table RenderTable(int[] array, int index)
{
    var table = new Table();
        
    // Добавляем столько колонок, сколько элементов в массиве
    foreach (var _ in array)
    {
        table.AddColumn(new TableColumn(""));
    }

    // Формируем строку, выделяя активный элемент
    var row = array.Select((v, i) => i == index ? $"[bold red]→ {v}[/]" : v.ToString()).ToArray();
    table.AddRow(row);

    return table;
}


int[] array = { 1, 2, 3, 4, 5 };
int index = 0;
var random = new Random();

AnsiConsole.Live(RenderTable(array, index))
    .Start(ctx =>
    {
        while (true)
        {
            Thread.Sleep(500);

            // Меняем случайное значение
            array[index] = random.Next(10, 100);

            // Двигаем указатель
            index = (index + 1) % array.Length;

            // Обновляем вывод
            ctx.UpdateTarget(RenderTable(array, index));
        }
    });