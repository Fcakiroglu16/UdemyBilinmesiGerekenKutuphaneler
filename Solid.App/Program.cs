// See https://aka.ms/new-console-template for more information




using Solid.App.LSPGood;

Console.WriteLine("Hello, World!");

BasePhone phone = new IPhone();

phone.Call();
 ((ITakePhoto)phone).TakePhoto();

phone = new Nokia3310();

phone.Call();


