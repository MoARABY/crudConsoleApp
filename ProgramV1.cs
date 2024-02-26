


// Id - Name - Phone - Age 
///1-Add Friend
///2-Print By Id
///3-Print all
///4-Delete By Id




int selection = 0;
int postion = 0;
Friend[] friends = new Friend[10];

do
{
    Console.WriteLine("""
    1-Add Friend
    2-Print By Id
    3-Print all
    4-Delete By Id 
    """);
    do
    {
        selection = Convert.ToInt32(Console.ReadLine());
        if (selection <= 0 || selection > 4)
	        {
            Console.WriteLine("Invalid selection");
        }
    } while (selection <= 0 || selection > 4);



    switch (selection)
    {
        case 1:
            Friend friend = new Friend();
            do
            {
                Console.WriteLine("Please enter Id");
                friend.id = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < friends.Length; i++)
                {
                    if (friends[i] != null)
                    {
                        if (friends[i].id == friend.id)
                        {
                            friend.id = 0;
                            Console.WriteLine("Id Exists !");
                            break;
                        } 
                    }
                }
            } while (friend.id == 0);

            do
            {
                Console.WriteLine("Please enter Name");
                friend.name = Console.ReadLine();
            } while (friend.name.Length < 3);
          



            Console.WriteLine("Please enter Phone");
            friend.phone =  Console.ReadLine();

            do
            {
                Console.WriteLine("Please enter Age");
                friend.age = Convert.ToByte(Console.ReadLine());

            } while (friend.age <= 0 || friend.age > 100);
           
            friends[postion] = friend;
            postion++;

            break;
        case 2:
            Console.WriteLine("Please enter Id");
             int id = Convert.ToInt32(Console.ReadLine());
            Friend f = null;
            for (int i = 0; i < friends.Length; i++)
            {
                if (friends[i] != null)
                {
                    if(friends[i].id == id)
                    {
                        f = friends[i];
                        break;
                    }
                }

            }

            if(f != null)
            {
                Console.WriteLine($"{f.name} {f.phone} {f.age}");

            }
            else
            {
                Console.WriteLine("Friend not found");
            }
          
            break;
        case 3:
            for (int i = 0; i < friends.Length; i++)
            {
                if (friends[i] != null)
                {
                    Console.WriteLine($"{friends[i].name.PadRight(15)} {friends[i].phone.PadRight(15)} {friends[i].age.ToString().PadRight(5)}");
                }
            }
            break;
        case 4:
            Console.WriteLine("Please enter Id");
            id = Convert.ToInt32(Console.ReadLine());
            f = null;
            int index = 0;
            for (int i = 0; i < friends.Length; i++)
            {
                if (friends[i] != null)
                {
                    if (friends[i].id == id)
                    {
                        f = friends[i];
                        index = i; 
                        break;
                    }
                }

            }

            if (f != null)
            {
                friends[index] = null;
                Console.WriteLine($"{f.name} deleted");
            }
            else
            {
                Console.WriteLine("Friend not found");
            }

            break;
    }

} while (true);




class Friend
{



    public int id;
    public string name;
    public string phone;
    public byte age;
}




