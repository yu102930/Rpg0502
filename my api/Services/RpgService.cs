namespace my_api.Services;

public class RpgService
{

    private static IList<Rpg> database;

    public RpgService()
    {
        database = new List<Rpg>();
        database.Add(item:new Rpg(){id = 0, name ="boss", lv = 200});
        database.Add(item:new Rpg(){id = 1, name ="a", lv = 1});
        database.Add(item:new Rpg(){id = 2, name ="b", lv = 2});
        database.Add(item:new Rpg(){id = 3, name ="c", lv = 3}); 
        database.Add(item:new Rpg(){id = 4, name ="d", lv = 4});
        database.Add(item:new Rpg(){id = 5, name ="e", lv = 5});
        database.Add(item:new Rpg(){id = 6, name ="f", lv = 6});
    }

    public List<Rpg> List()
    {
        List<Rpg> result = null;

        var db = from d in database
            select d;

        if (db.Any())
        {
            result = db.ToList();
        }

        return result;
    }
    
    
    //GET/READ
    public Rpg Get(int id)
    {
        Rpg result = null;

        var db = from d in database
            where d.id == id
            select d;

        if (db.Any())
        {
            result = db.First();
        }
        //result = new Rpg() { id = 0, name = "boss", lv = 200 }; 

        return result;
    }
    
}