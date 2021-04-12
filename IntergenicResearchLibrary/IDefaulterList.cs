namespace IntergenicResearchLibrary
{
    public interface IDefaulterList
    {
        string GetName();
        string GetYear();
        string GetBook();
        Date GetDateIssued();

        Date GetDateReturn();

        string GetDefaulters();         
    }
}