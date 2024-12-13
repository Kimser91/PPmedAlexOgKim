namespace PPmedAlexOgKim;

public class Task
{
    //private int Id;
    private string Title;
    private string Description;
    private bool isActive;
    public Task(string title, string description)
    {
        Title = title;
        Description = description;
        //Id = id;
    }

    /*public int getId()
    {
        return Id;
    }*/

    public string getTitle()
    {
        return Title;
    }

    public string getDescription()
    {
        return Description;
    }

    public void setTitle(string title)
    {
        Title = title;
    }

    public void setDescription(string des)
    {
        Description = des;
    }

   /* public void setId(int id)
    {
        Id = id;
    }*/

}