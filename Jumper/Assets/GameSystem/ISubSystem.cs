public interface ISubSystem
{
    void Initing(ISubSystemConfig config);
    void Updating();
    void Destroying();
}
