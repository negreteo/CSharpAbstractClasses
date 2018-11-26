namespace DemoLibrary {
  public class SqliteDataAccess : DataAccess {
    public override string LoadConnectionString (string name) {
      string output = base.LoadConnectionString (name);
      output += " (from SQLite)";

      return output;
    }

    public override void LoadData (string sql) {
      System.Console.WriteLine ("Loading SQLite Data");
    }

    public override void SaveData (string sql) {
      System.Console.WriteLine ("Saving data to SQLite");
    }
  }
}
