namespace DemoLibrary {
  public class SqlDataAccess : DataAccess {
    public override void LoadData (string sql) {
      System.Console.WriteLine ("Loading Microsoft SQL Data");
    }

    public override void SaveData (string sql) {
      System.Console.WriteLine ("Saving data to Microsoft SQL Server");
    }
  }
}
