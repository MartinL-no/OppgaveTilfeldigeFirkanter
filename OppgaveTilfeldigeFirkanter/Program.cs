namespace OppgaveTilfeldigeFirkanter;
public class Program
{
    private static int _width = 40;
    private static int _height = 20;

    static void Main(string[] args)
    {
        var boxes = CreateBoxes();
        Show(boxes);

        while (true)
        {
            foreach (var box in boxes)
            {
                box.Move();
            }
            Show(boxes);
            Thread.Sleep(50);
            Console.Clear();
        }
    }

    private static Box[] CreateBoxes()
    {
        var random = new Random();
        var boxes = new Box[3];
        for (var i = 0; i < boxes.Length; i++)
        {
            boxes[i] = new Box(random, _width, _height, i+1, i+1);
        }
        return boxes;
    }

    private static void Show(Box[] boxes)
    {
        var screen = new VirtualScreen(_width, _height);
        foreach (var box in boxes)
        {
            screen.Add(box);
        }
        screen.Show();
    }
}