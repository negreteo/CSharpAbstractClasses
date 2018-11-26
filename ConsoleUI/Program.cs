using System;
using System.Collections.Generic;
using DemoLibrary;

namespace ConsoleUI {
  class Program {
    static void Main (string[] args) {
      List<DataAccess> databases = new List<DataAccess> () {
        new SqlDataAccess (),
        new SqliteDataAccess ()
      };

      foreach (var db in databases) {
        System.Console.WriteLine (db.LoadConnectionString ("demo"));
        // db.LoadConnectionString ("demo");
        // db.LoadData ("select * from table");
        // db.SaveData ("insert into table");
        System.Console.WriteLine ();
      }
    }
  }
}
