# ContactManager

A console-based contact management system built with C# and .NET 9. This project demonstrates a clean modular architecture with separate libraries for data models and business logic, providing a simple yet effective way to manage contacts.

## 🚀 Features

- **Add Contacts**: Store contacts with name and phone number
- **Remove Contacts**: Delete contacts by phone number
- **Find Contacts**: Search for specific contacts by phone number
- **List All Contacts**: View all stored contacts
- **Phone Number Indexing**: Uses phone numbers as unique identifiers
- **Input Validation**: Prevents duplicate phone numbers
- **Clean Console Interface**: Easy-to-use menu-driven system

## 🏗️ Project Architecture

The solution follows a modular architecture with three main components:

```
ContactManager/
├── Contact/                    # Data Model Library
│   ├── Contact.cs             # Contact entity class
│   └── Contact.csproj         # Project file
├── ContactBook/               # Business Logic Library
│   ├── ContactBook.cs         # Contact management operations
│   └── ContactBook.csproj     # Project file
├── ContactManager/            # Console Application
│   ├── Program.cs             # Main application entry point
│   └── ContactManager.csproj  # Project file
├── ContactManager.sln         # Visual Studio Solution
└── README.md                  # This file
```

### Component Details

#### 1. Contact Library (`Contact/`)
- **Purpose**: Defines the core data model
- **Main Class**: `Contact`
- **Properties**: 
  - `Name` (string): Contact's name
  - `PhoneNumber` (string): Contact's phone number
- **Methods**:
  - `Contact(string name, string phoneNumber)`: Constructor
  - `PrintContact()`: Returns formatted contact information

#### 2. ContactBook Library (`ContactBook/`)
- **Purpose**: Manages contact collection and operations
- **Main Class**: `ContactBook`
- **Storage**: Uses `Dictionary<string, Contact>` with phone number as key
- **Methods**:
  - `AddContact(Contact contact)`: Adds a new contact
  - `RemoveContact(string phoneNumber)`: Removes contact by phone number
  - `FindContact(string phoneNumber)`: Finds and displays contact
  - `ListAll()`: Displays all contacts

#### 3. ContactManager Application (`ContactManager/`)
- **Purpose**: Provides console user interface
- **Features**: Menu-driven interface with 5 options
- **Dependencies**: References both Contact and ContactBook libraries

## 🛠️ Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- Any text editor or IDE (Visual Studio, VS Code, Rider, etc.)

## 📦 Installation & Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/claudiusayadi/bulb-contact-manager.git
   cd bulb-contact-manager
   ```

2. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

3. **Build the solution**:
   ```bash
   dotnet build
   ```

## 🚀 Running the Application

### Option 1: Run from solution root
```bash
dotnet run --project ContactManager/ContactManager.csproj
```

### Option 2: Run from ContactManager directory
```bash
cd ContactManager
dotnet run
```

### Option 3: Run the compiled executable
```bash
# After building
./ContactManager/bin/Debug/net9.0/ContactManager
```

## 💡 Usage Examples

When you run the application, you'll see the main menu:

```
--- Contact Book Menu ---
1. Add a new contact
2. Remove an existing contact
3. Find a contact by name
4. List all contacts
5. Exit
Enter your choice (1-5):
```

### Adding a Contact
```
Enter your choice (1-5): 1
Enter name: John Doe
Enter phone number: +1234567890
Contact +1234567890 saved successfully!
```

### Finding a Contact
```
Enter your choice (1-5): 3
Enter phone number of contact to find: +1234567890
Contact: Name: John Doe | Phone Number: +1234567890
```

### Listing All Contacts
```
Enter your choice (1-5): 4
Name: John Doe | Phone Number: +1234567890
Name: Jane Smith | Phone Number: +0987654321
```

### Removing a Contact
```
Enter your choice (1-5): 2
Enter phone number of contact to remove: +1234567890
Contact: +1234567890 removed successfully!
```

## 🔧 Development

### Building Individual Projects

```bash
# Build Contact library
dotnet build Contact/Contact.csproj

# Build ContactBook library
dotnet build ContactBook/ContactBook.csproj

# Build ContactManager application
dotnet build ContactManager/ContactManager.csproj
```

### Project Dependencies

- **ContactBook** depends on **Contact**
- **ContactManager** depends on both **Contact** and **ContactBook**

## 📁 Project Structure Details

```
ContactManager/
├── Contact/
│   ├── bin/Debug/net9.0/          # Compiled binaries
│   ├── obj/                       # Build artifacts
│   ├── Contact.cs                 # Main Contact class
│   └── Contact.csproj            # Project configuration
├── ContactBook/
│   ├── bin/Debug/net9.0/          # Compiled binaries
│   ├── obj/                       # Build artifacts
│   ├── ContactBook.cs             # Contact management logic
│   └── ContactBook.csproj        # Project configuration
├── ContactManager/
│   ├── bin/Debug/net9.0/          # Application binaries
│   ├── obj/                       # Build artifacts
│   ├── Program.cs                 # Main application
│   └── ContactManager.csproj     # Project configuration
├── ContactManager.sln             # Solution file
└── README.md                      # Documentation
```

## 🎯 Key Design Decisions

1. **Phone Number as Primary Key**: Ensures uniqueness and provides fast lookup
2. **Dictionary Storage**: O(1) average time complexity for add, remove, and find operations
3. **Modular Architecture**: Separation of concerns with distinct libraries
4. **Console Interface**: Simple, cross-platform user interaction
5. **No Persistence**: In-memory storage for simplicity (data is lost when application exits)

## 🚦 Error Handling

The application includes basic error handling for:
- Duplicate phone numbers when adding contacts
- Non-existent contacts when removing or finding
- Empty contact list when listing all contacts
- Invalid menu choices (falls through to "Invalid choice" message)

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📝 License

This project is open source and available under the [MIT License](LICENSE).

## 🔮 Future Enhancements

Potential improvements that could be added:

- **Data Persistence**: Save contacts to file or database
- **Search by Name**: Add functionality to search contacts by name
- **Edit Contacts**: Allow modification of existing contact information
- **Import/Export**: CSV or JSON import/export functionality
- **Contact Validation**: Email format validation, phone number formatting
- **GUI Interface**: Windows Forms or WPF desktop application
- **Web Interface**: ASP.NET Core web application
- **Unit Tests**: Comprehensive test coverage for all components

## 📞 Support

If you encounter any issues or have questions:

1. Check the [Issues](https://github.com/claudiusayadi/bulb-contact-manager/issues) page
2. Create a new issue if your problem isn't already reported
3. Provide detailed information about your environment and the issue

---

**Built with ❤️ using C# and .NET 9**
