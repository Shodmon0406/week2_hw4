Account account1 = new Account(1, 200); 
Account account2 = new Account(2, 400);
Account account3 = new Account(3, 300); 
Account account4 = new Account(4, 500);

System.Console.WriteLine(account1.Balance);
System.Console.WriteLine(account1.Number);
System.Console.WriteLine(account1.ToString());
account1.Credit(100);
account1.Debit(50);
System.Console.WriteLine();

System.Console.WriteLine(account1.ToString());
System.Console.WriteLine(account2.ToString());
System.Console.WriteLine(account3.ToString());
System.Console.WriteLine(account4.ToString());
account1.TransferTo(200, account2);
System.Console.WriteLine();

System.Console.WriteLine(account1.ToString());
System.Console.WriteLine(account2.ToString());
System.Console.WriteLine(account3.ToString());
System.Console.WriteLine(account4.ToString());
System.Console.WriteLine();

account2.TransferTo(300, account3);
System.Console.WriteLine(account1.ToString());
System.Console.WriteLine(account2.ToString());
System.Console.WriteLine(account3.ToString());
System.Console.WriteLine(account4.ToString());
System.Console.WriteLine();
