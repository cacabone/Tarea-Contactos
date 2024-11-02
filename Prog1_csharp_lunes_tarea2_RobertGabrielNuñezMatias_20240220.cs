try
{
    Console.WriteLine("Bienvenido a mi lista de Contactes");

    //names, lastnames, addresses, telephones, emails, ages, bestfriend
    bool runing = true;
    List<int> ids = new List<int>();
    Dictionary<int, string> names = new Dictionary<int, string>();
    Dictionary<int, string> lastnames = new Dictionary<int, string>();
    Dictionary<int, string> addresses = new Dictionary<int, string>();
    Dictionary<int, string> telephones = new Dictionary<int, string>();
    Dictionary<int, string> emails = new Dictionary<int, string>();
    Dictionary<int, int> ages = new Dictionary<int, int>();
    Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();


    while (runing)
    {

        Console.WriteLine("1. Agregar Contacto     \n2. Ver Contactos    \n3. Buscar Contactos     \n4. Modificar Contacto   \n5. Eliminar Contacto    \n6. Salir");
        Console.WriteLine("Digite el número de la opción deseada");

        int typeOption = Convert.ToInt32(Console.ReadLine());

        switch (typeOption)
        {
            case 1: // Add Contact
                {

                    AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);

                }
                break;
            case 2: // List All Contacts
                {
                    ListContacts(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);

                }
                break;
            case 3: // Search Contact
                {
                    SearchContacts(names, lastnames, addresses, telephones, emails, ages, bestFriends);
                }
                break;
            case 4: // Modify Contact
                {
                    ModifyContact(names, lastnames, addresses, telephones, emails, ages, bestFriends);
                }

                break;
            case 5: // Delete
                {
                    DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);

                }
                break;

            case 6: // Exit
                runing = false;
                break;

            default:
                Console.WriteLine("Tu eres o te haces el idiota?");
                break;
        }
    }

    // Adding a new contact method
    static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
    {
        Console.WriteLine("Digite el nombre de la persona");
        string name = Console.ReadLine();
        Console.WriteLine("Digite el apellido de la persona");
        string lastname = Console.ReadLine();
        Console.WriteLine("Digite la dirección");
        string address = Console.ReadLine();
        Console.WriteLine("Digite el telefono de la persona");
        string phone = Console.ReadLine();
        Console.WriteLine("Digite el email de la persona");
        string email = Console.ReadLine();
        Console.WriteLine("Digite la edad de la persona en números");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
        bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

        var id = ids.Count + 1;
        ids.Add(id);
        names.Add(id, name);
        lastnames.Add(id, lastname);
        addresses.Add(id, address);
        telephones.Add(id, phone);
        emails.Add(id, email);
        ages.Add(id, age);
        bestFriends.Add(id, isBestFriend);
    }

    // Listing all contacts method
    static void ListContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
    {
        Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
        Console.WriteLine($"____________________________________________________________________________________________________________________________");
        foreach (var id in ids)
        {
            var isBestFriend = bestFriends[id];
            string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";

            Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
        }
    }

    // Searching a contact method
    static void SearchContacts(Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
    {
        Console.WriteLine("Digita el id de la cuenta que buscas: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var isBestFriend = bestFriends[id];
        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";

        Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
        Console.WriteLine($"____________________________________________________________________________________________________________________________");
        Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
    }

    // Modifying a contact method
    static void ModifyContact(Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
    {
        Console.WriteLine("Digita el id de la cuenta que quieres modificar: ");
        int id = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Escribe el nuevo nombre: ");
        string name = Console.ReadLine();
        names.Remove(id);
        names.Add(id, name);

        Console.WriteLine("Escribe el nuevo apellido: ");
        string lastname = Console.ReadLine();
        lastnames.Remove(id);
        lastnames.Add(id, lastname);

        Console.WriteLine("Escribe la nueva direccion: ");
        string address = Console.ReadLine();
        addresses.Remove(id);
        addresses.Add(id, address);

        Console.WriteLine("Escribe el nuevo telefono: ");
        string phone = Console.ReadLine();
        telephones.Remove(id);
        telephones.Add(id, phone);

        Console.WriteLine("Escribe el nuevo email: ");
        string email = Console.ReadLine();
        emails.Remove(id);
        emails.Add(id, email);

        Console.WriteLine("Escribe la nueva edad de la persona en numeros: ");
        int age = Convert.ToInt32(Console.ReadLine());
        ages.Remove(id);
        ages.Add(id, age);

        Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
        bool isBestFriends = Convert.ToInt32(Console.ReadLine()) == 1;

        bestFriends.Remove(id);
        bestFriends.Add(id, isBestFriends);
    }

    static void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
    {
        Console.WriteLine("Digita el id de la cuenta que quieres borrar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        ids.Remove(id);
        names.Remove(id);
        lastnames.Remove(id);
        addresses.Remove(id);
        telephones.Remove(id);
        emails.Remove(id);
        ages.Remove(id);
        bestFriends.Remove(id);
    }
}
catch (Exception error)
{
    Console.WriteLine("There was an exception");

}

