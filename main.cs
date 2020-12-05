using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Console.Write ("please type hello:");
    string input = Console.ReadLine ();
    if(input == "hello"){
      Console.WriteLine ("Hello World");
      Console.ReadLine ();
    }else{
      while (true){
        Console.WriteLine ("Hello World");
      }
    }
  }
}