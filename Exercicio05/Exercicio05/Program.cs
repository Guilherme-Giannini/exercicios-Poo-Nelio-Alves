namespace Exercicio05;

class Program
{
    static void Main(string[] args)
    {
        int[] rooms = new int[10];

        int quantityRoomsRented = int.Parse(Console.ReadLine());
        if (quantityRoomsRented > rooms.Length)
        {
            Console.WriteLine("Quantidade de quartos alugados excede o total disponível.");
            return;
        }

        for (int i = 0; i < quantityRoomsRented; i++)
        {
            string[] rentedRoom = Console.ReadLine().Split(' ');
            int roomNumber = int.Parse(rentedRoom[0]);
            string name = rentedRoom[1];
            string email = rentedRoom[2];
            rooms[roomNumber] = 1;
            Pessoas pessoa = new Pessoas();
            pessoa.Name = name;
            pessoa.Email = email;
            pessoa.Room = roomNumber;
            Console.WriteLine($"Aluguel: {pessoa.Room}, Nome: {pessoa.Name}, Email: {pessoa.Email}");
        }
    }

}
