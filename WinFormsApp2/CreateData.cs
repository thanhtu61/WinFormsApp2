//createdata
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Reflection.Emit;

public static class CreateData
{
    public static void InitializeDatabase(string dbPath)
    {
        using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
        {
            connection.Open();

            // Tạo bảng user
            string createUserTable = @"
                CREATE TABLE IF NOT EXISTS user (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Email TEXT NOT NULL
                );";

            // Tạo bảng admin
            string createAdminTable = @"
                CREATE TABLE IF NOT EXISTS admin (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    FOREIGN KEY(UserId) REFERENCES user(Id)
                );";

            // Tạo bảng client
            string createClientTable = @"
                CREATE TABLE IF NOT EXISTS client (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    FOREIGN KEY(UserId) REFERENCES user(Id)
                );";

            // Tạo bảng order
            string createOrderTable = @"
                CREATE TABLE IF NOT EXISTS `order` (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClientId INTEGER,
                    OrderDate DATETIME,
                    FOREIGN KEY(ClientId) REFERENCES client(Id)
                );";

            // Tạo bảng product
            string createProductTable = @"
                CREATE TABLE IF NOT EXISTS product (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Price REAL NOT NULL
                );";

            // Tạo bảng laptopProduct
            string createLaptopProductTable = @"
                CREATE TABLE IF NOT EXISTS laptopProduct (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductId INTEGER,
                    Specs TEXT,
                    FOREIGN KEY(ProductId) REFERENCES product(Id)
                );";

            // Tạo bảng phoneProduct
            string createPhoneProductTable = @"
                CREATE TABLE IF NOT EXISTS phoneProduct (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductId INTEGER,
                    Specs TEXT,
                    FOREIGN KEY(ProductId) REFERENCES product(Id)
                );";

            // Tạo bảng otherProduct
            string createOtherProductTable = @"
                CREATE TABLE IF NOT EXISTS otherProduct (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductId INTEGER,
                    Specs TEXT,
                    FOREIGN KEY(ProductId) REFERENCES product(Id)
                );";

            // Thực thi các lệnh tạo bảng
            ExecuteNonQuery(createUserTable, connection);
            ExecuteNonQuery(createAdminTable, connection);
            ExecuteNonQuery(createClientTable, connection);
            ExecuteNonQuery(createOrderTable, connection);
            ExecuteNonQuery(createProductTable, connection);
            ExecuteNonQuery(createLaptopProductTable, connection);
            ExecuteNonQuery(createPhoneProductTable, connection);
            ExecuteNonQuery(createOtherProductTable, connection);

            Console.WriteLine("Cơ sở dữ liệu và các bảng đã được tạo thành công!");

            // Chèn dữ liệu vào bảng user
            string insertUser = @"
                INSERT INTO user (Username, Password, Email) VALUES 
                ('admin_user', 'admin_pass', 'admin@example.com'),
                ('client_user', 'client_pass', 'client@example.com'),
                ('q', 'q', '@example.com'),
                ('k', 'k', 'client@example.com');";

            ExecuteNonQuery(insertUser, connection);

            // Chèn dữ liệu vào bảng admin
            string insertAdmin = @"
                INSERT INTO admin (UserId) VALUES 
                (1), (3);"; // Giả sử Id 1 là của admin_user

            ExecuteNonQuery(insertAdmin, connection);

            // Chèn dữ liệu vào bảng client
            string insertClient = @"
                INSERT INTO client (UserId) VALUES 
                (2), (4);"; // Giả sử Id 2 là của client_user

            ExecuteNonQuery(insertClient, connection);

            // Chèn dữ liệu vào bảng product
            string insertProduct = @"
                INSERT INTO product (Name, Price) VALUES 
                ('Laptop A', 1000.00),
                ('Phone B', 500.00),
                ('Other Product C', 150.00);";

            ExecuteNonQuery(insertProduct, connection);

            // Chèn dữ liệu vào bảng laptopProduct
            string insertLaptopProduct = @"
                INSERT INTO laptopProduct (ProductId, Specs) VALUES 
                (1, 'Intel i7, 16GB RAM, 512GB SSD');"; // Giả sử ProductId 1 là của Laptop A

            ExecuteNonQuery(insertLaptopProduct, connection);

            // Chèn dữ liệu vào bảng phoneProduct
            string insertPhoneProduct = @"
          
                INSERT INTO phoneProduct(ProductId, Specs) VALUES
                (2, 'Snapdragon 888, 8GB RAM, 128GB Storage'); "; // Giả sử ProductId 2 là của Phone B

            ExecuteNonQuery(insertPhoneProduct, connection);

            // Chèn dữ liệu vào bảng otherProduct
            string insertOtherProduct = @"
                INSERT INTO otherProduct (ProductId, Specs) VALUES 
                (3, 'Generic Specs for Other Product');"; // Giả sử ProductId 3 là của Other Product C

            ExecuteNonQuery(insertOtherProduct, connection);

            // Chèn dữ liệu vào bảng order
            string insertOrder = @"
                INSERT INTO  `order` (ClientId, OrderDate) VALUES 
                (2, datetime('now'));"; // Giả sử ClientId 2 là của client_user

            ExecuteNonQuery(insertOrder, connection);

            Console.WriteLine("Dữ liệu đã được chèn thành công vào các bảng!");
        }
    }

    private static void ExecuteNonQuery(string commandText, SQLiteConnection connection)
    {
        using (var command = new SQLiteCommand(commandText, connection))
        {
            command.ExecuteNonQuery();
        }
    }
}
